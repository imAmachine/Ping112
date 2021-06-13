using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Ping112
{
    public static class Services
    {
        public static bool PingDds(string ipAdress)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    if (ipAdress.Split('.').Length == 4)
                    {
                        if (IPAddress.TryParse(ipAdress, out IPAddress ip))
                        {
                            PingReply reply = ping.Send(ip, Convert.ToInt32(Properties.Settings.Default.PingTimeout));
                            if (reply.Status == IPStatus.Success)
                                return true;
                        }
                    }
                    return false;
                }
            }
            catch { return false; }
        }

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
                    DDS dds = new DDS(line[0], line[1], line[2], line[3], line[4]); //  Создание объекта ДДС
                }
            }
        }

        public static void PingTask(object datagrid)
        {
            DataGridView dataGridView1 = (DataGridView)datagrid;
            //  Получение строк таблицы DataGridView
            List<DataGridViewRow> gridRows = dataGridView1.Rows.Cast<DataGridViewRow>().ToList();

            //  Бесконечный цикл обработки запросов Ping
            while (true)
            {
                //  Параллельная обработка всех строк DataGridView
                gridRows.AsParallel().ForAll(currRow =>
                {
                    //  Получение ячеек текущей строки, содержащих ip адреса
                    List<DataGridViewCell> cells = currRow.Cells.Cast<DataGridViewCell>().ToList();
                    cells = cells.Skip(cells.Count > 1 ? 1 : 0).Take(cells.Count > 1 ? 4 : 1).ToList();//

                    //  параллельная обработка каждой ячейки текущей строки
                    cells.AsParallel().ForAll(cell =>
                    {
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
                Thread.Sleep(Convert.ToInt32(Properties.Settings.Default.PingRetry));    //  Пауза перед следующим "прозвоном" ip адресов
            }
        }
    }
}
