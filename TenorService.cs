using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    public class TenorService
    {
        public string Ticket { get; set; }
        public string StartNum { get; set; }
        public string StartUnitLookup { get; set; }
        public string EndNum { get; set; }
        public string EndUnitLookup { get; set;}

        public string FullInfo
        {
            get
            {
                return $"{Ticket},{StartNum},{StartUnitLookup},{EndNum},{EndUnitLookup}";
            }
        }
    }
}
