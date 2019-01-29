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


                    OsebniRacun user = new OsebniRacun(stanje, limit, ime, varcevalniInput, obrestnaMera);

                    //sakrit prikaz pravljenja racuna 
                    sakrij();



                    //PRIKAZAT FUNCKIJE 
                    pologGroupBox.Visible = true;
                    dvigGroupBox.Visible = true;
                    osebniFunctionsGroupBox.Visible = true;

                    //prikazat stanje 
                    stanjeLabel.Text = "Stanje: " + user.stanje.ToString();

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

                            //kreirat racun
                            ValutniRacun user = new  ValutniRacun(stanje,limit,inputIme,primarnaValuta);
                            
                            //prikazat funkcije za Valutni racun
                            groupBox1.Visible = false;
                            valutniFunctionsGroupBox.Visible = true;
                            dvigGroupBox.Visible = true;
                            pologGroupBox.Visible = true;

                            //prikaz stanja
                            stanjeLabel.Text = "Stanje: "+ user.stanje.ToString() + " "+user.primarnaValuta;



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

                        //napravi novi user 
                        PoslovniRacun user = new PoslovniRacun(stanje,limit,imeLastnika,imePodjetja,typePodjetja);

                        //prikazat stanje
                        stanjeLabel.Text = "Stanje: " + user.stanje.ToString();

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
           //dvig function
        }
    }
}
