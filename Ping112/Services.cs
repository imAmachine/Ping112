using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Ping112
{
    public static class Services
    {
        public static ManualResetEvent mre = new ManualResetEvent(true);
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

        public static void FilterDgvCollection(object dataGridView, string search, List<KeyValuePair<bool, string>> filters, bool isFiltering)
        {
            mre.Reset();

            DataGridView dgv = dataGridView as DataGridView;
            List<DDS> ddses = new List<DDS>();
            List<DDS> result = new List<DDS>();

            if (isFiltering && filters.Count > 0)
            {
                var primary = filters.Where(f => f.Key).ToList();
                var secondary = filters.Where(f => !f.Key).ToList();

                primary.ForEach(f => ddses = ListDds.AllDds.Where(dds => dds.Name.ToLower().Contains(f.Value.ToLower())).ToList());
                secondary.ForEach(f => result.AddRange(ddses.Where(dds => dds.Name.ToLower().Contains(f.Value.ToLower())).ToList()));
            }

            if (search.Length > 0)
                result = result.Where(dds => dds.Name.ToLower().Contains(search.ToLower())).ToList();
            else
                result = ListDds.AllDds;

            dgv.DataSource = result;
            dgv.ClearSelection();

            mre.Set();
        }

        public static void PingTask(object datagrid)
        {
            DataGridView dataGridView1 = (DataGridView)datagrid;

            //  Бесконечный цикл обработки запросов Ping
            while (true)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    //  Получение строк таблицы DataGridView
                    List<DataGridViewRow> gridRows = dataGridView1.Rows.Cast<DataGridViewRow>().ToList();
                    //  Параллельная обработка всех строк DataGridView
                    gridRows.AsParallel().ForAll(currRow =>
                    {
                        if (!mre.WaitOne())
                            return;

                    //  Получение ячеек текущей строки, содержащих ip адреса
                    List<DataGridViewCell> cells = currRow.Cells.Cast<DataGridViewCell>().ToList();

                        cells = cells.Skip(cells.Count > 1 ? 1 : 0).Take(cells.Count > 1 ? 4 : 1).ToList();

                    //  параллельная обработка каждой ячейки текущей строки
                    cells.AsParallel().ForAll(cell =>
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
                                        List<bool> notConnected = replyes.Where(r => r == false).ToList();  //  ответы с отключенными ip адресами

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
                    //Thread.Sleep(Convert.ToInt32(Properties.Settings.Default.PingRetry));    //  Пауза перед следующим "прозвоном" ip адресов
                }
            }
        }
    }
}
