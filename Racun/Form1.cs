using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int vrstaRacuna;

         //RACUNI
             //OSEBNI RACUN
             OsebniRacun osebniRacun = new OsebniRacun();
            //VALUTNI RACUN
            ValutniRacun valutniRacun = new ValutniRacun();
            //POSLOVNI RACUN 
            PoslovniRacun poslovniRacun = new PoslovniRacun();

        //vnesite pravo vrednost
        public void inputError()
        {
            MessageBox.Show("Vnesite pravilno vrednost");
        }

        //DA li je ispunjena forma funckiaj 
        public bool popunjeno()
        {
            decimal number;
            if( (decimal.TryParse(inputStanje.Text,out number)) && (decimal.TryParse(inputLimit.Text,out number)) && (inputName.Text != ""))
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        //SAKRIJ FUNCKIJA
        public void sakrij()
        {
            groupBox1.Visible = false;
        }

        //LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        //OK BUTTON (biranje vrste racuna)
        private void vrstaRacunaSelectedButton_Click(object sender, EventArgs e)
        {



            //Izabrat kooji je tip racuna
                  if(inputVrstaRacuna.SelectedIndex == 0)
                 {
                    //OSEBNI
                    osebni.Visible = true;
                    valutni.Visible = false;
                    poslovni.Visible = false;
                    vrstaRacuna = 0;
                    
                    //Prikazat ustvari button
                    ustvariButton.Visible = true;

            } else if (inputVrstaRacuna.SelectedIndex == 1)
                {
                    //VALUTNI
                    valutni.Visible = true;
                    osebni.Visible = false;
                    poslovni.Visible = false;
                    vrstaRacuna = 1;

                    //Prikazat ustvari button
                    ustvariButton.Visible = true;

            } else if(inputVrstaRacuna.SelectedIndex == 2)
                {
                    //POSLOVNI
                    poslovni.Visible = true;
                    valutni.Visible = false;
                    osebni.Visible = false;
                    vrstaRacuna = 2;
                    
                    //Prikazat ustvari button
                    ustvariButton.Visible = true;
            } else
            {
                MessageBox.Show("Izberi tip racuna");
            }

        }


        //NAPRAVI RACUN
        private void button2_Click(object sender, EventArgs e)
        {

           
            // provjeriti koji tip racuna je potrebno napraviti 
            if(vrstaRacuna == 0)
            {
                //OSEBNI RACUN
                //OGRANICIT DA JE SAMO DOUBLE

                //provjeriti da li je korisnik unio pravilne vrijednosti 
                decimal number;
                
                //provjeriti da li su unesene prave vrijednosti
                if( (decimal.TryParse(inputStanje.Text,out number)) && (decimal.TryParse(inputLimit.Text, out number)) && (decimal.TryParse(inputObrestnaMera.Text, out number)) && (inputObrestnaMera.Text!="") && (inputName.Text != ""))
                {
                    //pokupti vrijednost iz textboxova
                    string ime = inputName.Text;
                    string stanjeTest = inputStanje.Text;
                    string limitTest = inputLimit.Text;
                    string obrestnaMeraTest = inputObrestnaMera.Text;

                    //CONVERTING VALUES
                    double stanje = Convert.ToDouble(stanjeTest);
                    double limit = Convert.ToDouble(limitTest);
                    double obrestnaMera = Convert.ToDouble(obrestnaMeraTest);


                    //NEW RACUN

                    //PROVJERITI DA LI JE VARCEVALNI 
                    bool varcevalniInput;
                    if (varcevalniCheckBox.Checked == true)
                    {
                        varcevalniInput = true;
                    }
                    else
                    {
                        varcevalniInput = false;
                    }

                    //POMOCU CONSTRUCTORA
                    //OsebniRacun user = new OsebniRacun(stanje, limit, ime, varcevalniInput, obrestnaMera);

                    //GETTING DATA INTO OBJECT
                    osebniRacun.stanje = stanje;
                    osebniRacun.limit = limit;
                    osebniRacun.imeLastnika = ime;
                    osebniRacun.varcevalni = varcevalniInput;
                    osebniRacun.obrestnaMera = obrestnaMera;
                    
                    

                    //sakrit prikaz pravljenja racuna 
                    sakrij();



                    //PRIKAZAT FUNCKIJE 
                    pologGroupBox.Visible = true;
                    dvigGroupBox.Visible = true;
                    osebniFunctionsGroupBox.Visible = true;

                    //prikazat stanje 
                    stanjeLabel.Text = "Stanje: " + osebniRacun.stanje.ToString();

                } else
                {
                    inputError();
                }
                
            }
            else if(vrstaRacuna == 1)
            {
                //VALUTNI
                    
                    //provjeriti da li su unesene prave vrijednosti 
                    if(popunjeno() == true)
                    {
                        //provjerit da li je odabrana primarna valuta 
                        if(inputPrimarnaValuta.Text == "")
                        {
                            inputError();
                        } else
                        {
                        //EXECUTE (everything alright)
                            //pokupit vrijednosti iz textboxova
                            string inputIme = inputName.Text;
                            double stanje = Convert.ToDouble(inputStanje.Text);
                            double limit = Convert.ToDouble(inputLimit.Text);
                            string primarnaValuta = inputPrimarnaValuta.Text;

                         //CONSTRUCTOR
                            //ValutniRacun user = new  ValutniRacun(stanje,limit,inputIme,primarnaValuta);

                            //GETTING DATA INTO OBJECT
                            valutniRacun.stanje = stanje;
                            valutniRacun.limit = limit;
                            valutniRacun.imeLastnika = inputIme;
                            valutniRacun.primarnaValuta = primarnaValuta;
                         
                            
                            
                            //prikazat funkcije za Valutni racun
                            groupBox1.Visible = false;
                            valutniFunctionsGroupBox.Visible = true;
                            dvigGroupBox.Visible = true;
                            pologGroupBox.Visible = true;

                            //prikaz stanja
                            stanjeLabel.Text = "Stanje: "+ valutniRacun.stanje.ToString() + " "+valutniRacun.primarnaValuta;



                    }

                    } else
                    {
                        inputError();
                    }
               
                   
                    



            } else if(vrstaRacuna == 2)
            {
                //POSLOVNI
                //provjeriti da su unesene sve informacije 
                if (popunjeno() == true)
                {
                    // da li je uneseno ime i tip poduzeca
                    if((inputNazivPodjetja.Text != "") || (inputTipPodjetja.Text != ""))
                    {
                        //pokupit vrijednosti iz textboxa 
                        string imeLastnika = inputName.Text;
                        double stanje = Convert.ToDouble(inputStanje.Text);
                        double limit = Convert.ToDouble(inputLimit.Text);
                        string imePodjetja = inputNazivPodjetja.Text;
                        string typePodjetja = inputTipPodjetja.Text;

                        //PREKO CONSTRUCTORA 
                        //PoslovniRacun user = new PoslovniRacun(stanje,limit,imeLastnika,imePodjetja,typePodjetja);

                        //GETTING DATA INTO OBJECT
                        poslovniRacun.stanje = stanje;
                        poslovniRacun.limit = limit;
                        poslovniRacun.imeLastnika = imeLastnika;
                        poslovniRacun.nazivPodjetja = imePodjetja;
                        poslovniRacun.tipPodjetja = typePodjetja;


                        //prikazat stanje
                        stanjeLabel.Text = "Stanje: " + poslovniRacun.stanje.ToString();

                        //prikazat funckije moguce 
                        dvigGroupBox.Visible = true;
                        pologGroupBox.Visible = true;
                        poslovniFunctionsGroupBox.Visible = true;


                    }
                    else
                    {
                        inputError();
                    }
                } else
                {
                    inputError();
                }

            }
        }


        //DODAJ VALUTU
        private void addValutaButton_Click(object sender, EventArgs e)
        {
            //DODAJ U LISTUBOX
            if(inputValuta.Text == "")
            {
                MessageBox.Show("Unesite pravilne vrijednosti");
            } else
            {
                string valuta = inputValuta.Text;
                seznamValutList.Items.Add(valuta);
                inputPrimarnaValuta.Items.Add(valuta);
            }

           

        }


        //DVIG FUNCTION
        private void dvigButton_Click(object sender, EventArgs e)
        {
            //prvo vidjet koji je tip racuna 
            if(vrstaRacuna == 0)
            {
                //osebni dvig
                int svota = Convert.ToInt32(inputDvig.Text);

                if(osebniRacun.dvig(svota) == true)
                {
                    //prikazat novo stanje racuna 
                    stanjeLabel.Text = "Stanje: "+ osebniRacun.stanje.ToString();
                } else
                {
                    MessageBox.Show("Ni mozno dvignuti denar");
                }
                

            } else if(vrstaRacuna == 1)
            {
                //valutni dvig
                int svota = Convert.ToInt32(inputDvig.Text);

                if (valutniRacun.dvig(svota) == true)
                {
                    //prikazat novo stanje racuna 
                    stanjeLabel.Text = "Stanje: "+ valutniRacun.stanje.ToString();
                }
                else
                {
                    MessageBox.Show("Ni mozno dvignuti denar");
                }

            } else if(vrstaRacuna == 2)
            {
                //poslovni dvig
                int svota = Convert.ToInt32(inputDvig.Text);

                if (poslovniRacun.dvig(svota) == true)
                {
                    //prikazat novo stanje racuna 
                    stanjeLabel.Text = "Stanje: "+ poslovniRacun.stanje.ToString();
                }
                else
                {
                    MessageBox.Show("Ni mozno dvignuti denar");
                }
            }
        }

        //POLOG
        private void pologButton_Click(object sender, EventArgs e)
        {
            //provjeriti koji je racun u pitanju 
            if(vrstaRacuna == 0)
            {   //OSEBNI
                //pokupit vrijednosti
                int iznos = Convert.ToInt32(inputPolog.Text);

                //pozivanje funkcije
                osebniRacun.polog(iznos);

                //prikaz novog stanja
                stanjeLabel.Text = "Stanje: "+ osebniRacun.stanje.ToString();

            } else if(vrstaRacuna == 1)
            {   //VALUTNI
                //pokupit vrijednosti
                int iznos = Convert.ToInt32(inputPolog.Text);

                //pozivanje funkcije
                valutniRacun.polog(iznos);

                //prikaz novog stanja
                stanjeLabel.Text = "Stanje: " + valutniRacun.stanje.ToString() + valutniRacun.primarnaValuta.ToString();

            } else if(vrstaRacuna == 2)
            {   //POSLOVNI
                //pokupit vrijednosti
                int iznos = Convert.ToInt32(inputPolog.Text);

                //pozivanje funkcije
                poslovniRacun.polog(iznos);

                //prikaz novog stanja
                stanjeLabel.Text = "Stanje: " + poslovniRacun.stanje.ToString();
            }
        }
        
        //LIKVIDNO PODJETJE
        private void likvidnoButton_Click(object sender, EventArgs e)
        {
            if (poslovniRacun.Likvidno() == true)
            {
                MessageBox.Show("Podjetje je likvidno");
            } else
            {
                MessageBox.Show("Podjetje NI likvidno");
            }
        }
            
        //ZAMENJAJ VALUTO
        private void zamenjajValutoButton_Click(object sender, EventArgs e)
        {
            //get data from textbox
            double tecaj = Convert.ToDouble(inputTecaj.Text);

            //call function
            valutniRacun.zamenjajValuto(tecaj);

            //new data display 
            stanjeLabel.Text = valutniRacun.stanje.ToString();
        }

        //PRIHRANEK
        private void prihranekButton_Click(object sender, EventArgs e)
        {
            //pokupit vrijednost iz textboxa
            double povprecnoMesecnoStanje = Convert.ToDouble(inputPrihranek.Text);

            //funkcija
            double prihranek = osebniRacun.IzracunajLetniPrihranek(povprecnoMesecnoStanje);

            //ispis
            MessageBox.Show(prihranek.ToString());
            

        }

        //NASTAVI OBRESTNO MERO
        private void povecajObrestnoMeroButton_Click(object sender, EventArgs e)
        {
            osebniRacun.NastaviObrestnoMero();
        }
    }
}
