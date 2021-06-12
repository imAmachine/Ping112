using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ping112
{
    public class DDS
    {
        public string Name { get; set; }
        public string IpVipNet { get; set; }
        public string IpRTK { get; set; }
        public string IpPcs { get; set; }
        public string IpPhones { get; set; }

        public DDS(string name, string ipVipNet, string ipRTK, string ipPcs, string ipPhones)
        {
            Name = name;
            IpVipNet = ipVipNet;
            IpRTK = ipRTK;
            IpPcs = ipPcs;
            IpPhones = ipPhones;
            ListDds.AllDds.Add(this);
        }
    }
}
