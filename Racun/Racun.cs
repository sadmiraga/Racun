using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    class Racun
    {
        //elemental data
        public double stanje { get; set; }
        public double limit { get; set; }
        public string imeLastnika { get; set; }



        //CONSTRUCTORS

            //constructor (prazan)
            public Racun()
            {
                stanje = 0;
                limit = 0;
                imeLastnika = "";
            }

            // constructor (stanje)
            public Racun(double inputDoubleStanje)
                {
                    stanje = inputDoubleStanje;
                }

            //constructor (stanje, limit)
            public Racun(double inputDoubleStanje, double inputDoubleLimit)
            {
                stanje = inputDoubleStanje;
                limit = inputDoubleLimit;
            }

            //constructor (stanje, limit, imeLasntika)
            public Racun(double inputDoubleStanje, double inputDoubleLimit, string inputStringImeLastnika)
            {
                stanje = inputDoubleStanje;
                limit = inputDoubleLimit;
                imeLastnika = inputStringImeLastnika;
            }

        //METHODS

            //dvig
            public bool dvig (double iznosZaPodignuti)
            {
                //provjeriti da li je uopste moguce podginuti novac
                if(iznosZaPodignuti > stanje)
                {
                    return false;
                } else
                {
                    stanje -= iznosZaPodignuti;
                    return true;
                }
            }

            //polog
            public void polog (double iznosZaDodati)
            {
                stanje += iznosZaDodati;
            }



    }
}
