using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

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
                            PingReply reply = ping.Send(ip, Properties.Settings.Default.PingTimeout);
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
                            PingReply reply = ping.Send(ip, Properties.Settings.Default.PingTimeout);   //  попытка отправки ping запроса
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
    }
}
