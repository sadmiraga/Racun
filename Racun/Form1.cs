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

        //LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        //OK BUTTON (biranje vrste racuna)
        private void vrstaRacunaSelectedButton_Click(object sender, EventArgs e)
        {
            if(inputVrstaRacuna.SelectedIndex == 0)
            {
                //OSEBNI
                osebni.Visible = true;
                valutni.Visible = false;
                poslovni.Visible = false;
            } else if (inputVrstaRacuna.SelectedIndex == 1)
            {
                //VALUTNI
                valutni.Visible = true;
                osebni.Visible = false;
                poslovni.Visible = false;
            } else if(inputVrstaRacuna.SelectedIndex == 2)
            {
                //POSLOVNI
                poslovni.Visible = true;
                valutni.Visible = false;
                valutni.Visible = false;
            }

        }


        //NAPRAVI RACUN
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
