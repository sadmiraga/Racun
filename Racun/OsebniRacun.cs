using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    class OsebniRacun : Racun
    {
        //elemental data
        public bool varcevalni { get; set; }
        public double obrestnaMera { get; set; }

        //CONSTRUCTORS
            //constructor (prazan)
            public OsebniRacun()
            {
                stanje = 0;
                limit = 0;
                imeLastnika = "";
            }

            //constructor (stanje, limit, imeLasntika)
            public OsebniRacun(double inputDoubleStanje, double inputDoubleLimit, string inputStringImeLastnika)
            {
                stanje = inputDoubleStanje;
                limit = inputDoubleLimit;
                imeLastnika = inputStringImeLastnika;
            }

            //constructor (stanje, limit, imeLasntika, obrestnaMera)
            public OsebniRacun(double inputDoubleStanje, double inputDoubleLimit, string inputStringImeLastnika, double inputDoubleObrestnaMera)
            {
                stanje = inputDoubleStanje;
                limit = inputDoubleLimit;
                imeLastnika = inputStringImeLastnika;
                obrestnaMera = inputDoubleObrestnaMera;
            }


        //METHODS

        //LETNI PRIHRANEK
        public double IzracunajLetniPrihranek ( double inputPovpMesecnoStanje)
        {
            return inputPovpMesecnoStanje * obrestnaMera * 12;
        }

        //NASTAVI OBRESTNO MERO
        public void NastaviObrestnoMero()
        {
            if(varcevalni == true)
            {
                obrestnaMera += 0.5;
            }
        }

    }
}
