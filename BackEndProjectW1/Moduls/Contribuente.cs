using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjectW1.Moduls
{
    public class Contribuente
    {
        public string Nome { get; set; } = "";
        public string Cognome { get; set; } = "";
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; } = "";
        public string Sesso { get; set; } = "";
        public string ComuneResidenza { get; set; } = "";
        public int RedditoAnnuale { get; set; } = 0;


        public  static decimal CalcolaImposta( int RedditoAnnuale) 
        {
            {
                decimal ImpostaDovuta = 0;

                if (RedditoAnnuale == 0)
                {
                    return ImpostaDovuta;
                }
                else if (RedditoAnnuale > 0 && RedditoAnnuale <= 15000)
                {
                    ImpostaDovuta += RedditoAnnuale * 0.23m;
                }
                else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
                {
                    ImpostaDovuta += 3450 + ((RedditoAnnuale - 15000) * 0.27m);
                }
                else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
                {
                    ImpostaDovuta += 6960 + ((RedditoAnnuale - 28000) * 0.38m);
                }
                else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
                {
                    ImpostaDovuta += 17220 + ((RedditoAnnuale - 55000) * 0.41m);
                }
                else if (RedditoAnnuale > 75000)
                {
                    ImpostaDovuta += 25420 + ((RedditoAnnuale - 75000) * 0.43m);
                }

                return ImpostaDovuta;
            }
        }

       
    }
}
