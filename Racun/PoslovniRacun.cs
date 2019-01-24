using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    class PoslovniRacun:Racun
    {
        //ELEMENTAL DATA 
        public string nazivPodjetja { get; set; }
        public string tipPodjetja { get; set; }

        //CONSTRUCTORS

            //constructor (prazan)
            public PoslovniRacun()
            {
                limit = 0;
                stanje = 0;
                imeLastnika = "";
            }

            //constructor (stanje, limit, imeLastnika)
            public PoslovniRacun(double inputStanje, double inputLimit, string inputImeLastnika)
            {
                stanje = inputStanje;
                limit = inputLimit;
                imeLastnika = inputImeLastnika;
            }

            //constructor (stanje, limit, imeLastnika, nazivPodjetja, tipPodjetja)
            public PoslovniRacun(double inputStanje, double inputLimit, string inputImeLastnika, string inputNazivPodjetja, string inputTipPodjetja)
            {
                stanje = inputStanje;
                limit = inputLimit;
                imeLastnika = inputImeLastnika;
                nazivPodjetja = inputNazivPodjetja;
                tipPodjetja = inputTipPodjetja;
            }

        //METHODS
            //likvidno()
            public bool Likvidno()
            {
                if(stanje > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }




    }
}
