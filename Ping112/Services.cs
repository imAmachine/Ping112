using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping112
{
    public static class Services
    {
        public static ManualResetEvent mre = new ManualResetEvent(true);

        /// <summary>
        /// Метод, необходимый для чтения данных из CSV файла (используется для импорта CSV таблицы)
        /// </summary>
        /// <param name="path">Путь к импортируемому файлу</param>
        public static void ReadCsv(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                ListDds.AllDds.Clear(); //  Очистка списка ДДС
                sr.ReadLine(); //   Пропуск заголовков в CSV таблице

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');   //  Построчное чтение CSV
                    ListDds.AllDds.Add(new DDS(line[0], line[1], line[2], line[3], line[4])); //  Создание объекта ДДС
                }
            }
        }

        /// <summary>
        /// Метод для фильтрации коллекции DataGridView
        /// </summary>
        /// <param name="dataGridView">Обрабатываемый DataGridView</param>
        /// <param name="search">Значение для проведения поиска по отфильтрованной коллекции</param>
        /// <param name="filters">Коллекция первичного и вторичных фильтров</param>
        /// <param name="isFiltering">Булевый параметр для определения нужно фильтровать коллекцию или не нужно</param>
        public static void FilterDgvCollection(object dataGridView, string search, List<KeyValuePair<bool, string>> filters, bool isFiltering)
        {
            mre.Reset();

            DataGridView dgv = dataGridView as DataGridView;
            List<DDS> ddses = ListDds.AllDds;
            List<DDS> result = new List<DDS>();

            if (isFiltering && filters.Count > 0)
            {
                var primaryFilter = filters.Where(f => f.Key); //  Получение первичного фильтра
                var secondary = filters.Where(f => !f.Key).ToList();    //  Получения коллекции вторичных фильтров

                //  Фильтрация основного списка по первичному фильтру
                if (primaryFilter.Count() > 0)
                    ddses = ddses.Where(dds => dds.Name.ToLower().Contains(primaryFilter.First().Value)).ToList();

                //  Добавление групп в вывод по вторичным фильтрам
                if (secondary.Count > 0)
                    secondary.ForEach(sec => result.AddRange(ddses.Where(dds => dds.Name.ToLower().Contains(sec.Value.ToLower()))));
            }

            //  Реализация функции поиска
            Func<DDS, bool> predicate = new Func<DDS, bool>(dds => dds.Name.ToLower().Contains(search.ToLower().Trim()));
            result = result.Count == 0 ? ddses.Where(predicate).ToList() : result.Where(predicate).ToList();

            dgv.DataSource = result;
            dgv.ClearSelection();

            mre.Set();
        }

        /// <summary>
        /// Метод, для вызова в потоке, позволяющий бесконечно пинговать все адреса из коллекции всех передаваемых DataGridView
        /// </summary>
        /// <param name="dgvs">Коллекция обрабатываемых DataGridView</param>
        public static void PingThread(object dgvs)
        {
            List<DataGridView> dgvsLst = (dgvs as object[]).Cast<DataGridView>().ToList();
            while (true)
            {
                Parallel.ForEach(dgvsLst, dgv => PingMethod(dgv));
                Thread.Sleep(Convert.ToInt32(Properties.Settings.Default.PingRetry));    //  Пауза перед следующим "прозвоном" ip адресов
            }
        }

        public static bool IpV4IsMatch(string ips)
        {
            return Regex.IsMatch(ips.ToString(), @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
        }

        /// <summary>
        /// Метод для однократной проверки всех адресов из DataGridView на доступность
        /// </summary>
        /// <param name="datagrid">Обрабатываемый DataGridView</param>
        private static void PingMethod(object datagrid)
        {
            DataGridView dataGridView1 = (DataGridView)datagrid;

            if (dataGridView1.Rows.Count > 0)
            {
                //  Получение строк таблицы DataGridView
                List<DataGridViewRow> gridRows = dataGridView1.Rows.Cast<DataGridViewRow>().ToList();

                //  Параллельная обработка всех строк DataGridView
                Parallel.ForEach(gridRows, currRow =>
                {
                    if (!mre.WaitOne())
                        return;

                    //  Получение ячеек текущей строки, содержащих ip адреса
                    List<DataGridViewCell> cells = currRow.Cells.Cast<DataGridViewCell>().Where(cell => IpV4IsMatch(cell.Value.ToString())).ToList();

                    //  параллельная обработка каждой ячейки текущей строки
                    Parallel.ForEach(cells, cell =>
                    {
                        if (!mre.WaitOne())
                            return;
                        try
                        {
                            if (cell.Value != null)
                            {
                                //  получение списка ip адресов из ячейки
                                string[] ip = cell.Value.ToString()
                                        .Split(',')
                                        .Select(c => c.Trim())
                                        .ToArray();

                                //  Получение ответов на запрос Ping для каждого ip адреса по порядку
                                bool[] replyes = PingDds(ip);                              //  Все ответы
                                List<bool> notConnected = replyes.Where(r => !r).ToList();  //  ответы с отключенными ip адресами

                                /*  
                                *  1. Если все ip в сети - отметить ячейку зелёным цветом
                                *  2. Если часть ip адресов не в сети - пометить ячейку жёлтым цветом
                                *  3. Если все ip адреса не в сети - пометить ячейку красным цветом
                                */
                                if (notConnected.Count == 0)                    //  1
                                    cell.Style.BackColor = Color.Green;
                                else if (notConnected.Count < replyes.Length)   //  2
                                    cell.Style.BackColor = Color.Yellow;
                                else                                            //  3
                                    cell.Style.BackColor = Color.Red;
                            }
                        }
                        catch { }
                    });
                });
            }
        }

        /// <summary>
        /// Метод для отправки Ping запроса на коллекцию IP адресов
        /// </summary>
        /// <param name="ipAdresses">Коллекция пингуемых адресов</param>
        /// <returns></returns>
        public static bool[] PingDds(string[] ipAdresses)
        {
            bool[] replyes = new bool[ipAdresses.Length];
            using (Ping ping = new Ping())
            {
                for (int i = 0; i < ipAdresses.Length; i++)
                {
                    replyes[i] = false; //  Начальная инициализация
                    if (ipAdresses[i].Split('.').Length == 4)   //  проверка корректности ip адреса
                    {
                        if (IPAddress.TryParse(ipAdresses[i], out IPAddress ip))    //  преобразование ip адреса к типу IPAdress
                        {
                            PingReply reply = ping.Send(ip, Convert.ToInt32(Properties.Settings.Default.PingTimeout));   //  попытка отправки ping запроса
                            if (reply.Status == IPStatus.Success)
                                replyes[i] = true;
                        }
                    }
                }
            }
            return replyes;
        }
    }
}
