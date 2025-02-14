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


        public decimal CalcolaImposta()
        {

            decimal Imposta = 0;
            decimal ImpostaDovuta = Imposta;


            if (RedditoAnnuale == 0)
            {
                return Imposta;
            }
            else if (RedditoAnnuale > 0 && RedditoAnnuale <= 15000)
            {
                Imposta = RedditoAnnuale * 0.23m;
                return ImpostaDovuta;
            }
            else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
            {
                Imposta = 3450 + ((RedditoAnnuale - 15000) * 0.27m);
                return ImpostaDovuta;
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                Imposta = 6960 + ((RedditoAnnuale - 28000) * 0.38m);
                return ImpostaDovuta;
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                Imposta = 17220 + ((RedditoAnnuale - 55000) * 0.41m);
                return ImpostaDovuta;
            }
            else if (RedditoAnnuale > 75000)
            {
                Imposta = 25420 + ((RedditoAnnuale - 75000 * 0.43m));
                return ImpostaDovuta;
            }
        }
    }
}
