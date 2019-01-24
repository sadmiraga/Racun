using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    class ValutniRacun:Racun
    {
        //ELEMENTAL DATA
        public List<string> seznamValut = new List<string>();
        public string primarnaValuta { get; set; }

        //CONSTRUCTORS
            
            //constructor (prazan)
            public ValutniRacun()
            {
                primarnaValuta = "";
                limit = 0;
                stanje = 0;
                imeLastnika = "";
            }

            //constructor (stanje, limit, imeLastnika)
            public ValutniRacun (double inputStanje, double inputLimit, string inputImeLastnika)
            {
                stanje = inputStanje;
                limit = inputLimit;
                imeLastnika = inputImeLastnika;
            }

            //constructor (stanje, limit, imeLastnika, primarnaValuta)
            public ValutniRacun(double inputStanje, double inputLimit, string inputImeLastnika, string inputPrimarnaValuta)
            {
                stanje = inputStanje;
                limit = inputLimit;
                imeLastnika = inputImeLastnika;
                primarnaValuta = inputPrimarnaValuta;
            }

        //METHODS
            //zamenjaj valuto
            public void zamenjajValuto (double menjalniTecaj)
            {
                stanje *= menjalniTecaj;
            }


    }
}
