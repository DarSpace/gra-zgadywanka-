using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogikaGry;


namespace GraGUI
{
    public partial class buttonNowaGra : Form
    {
        private Gra g;

        
        public buttonNowaGra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonPoddajeSie.Visible = true;

            buttonNowaGra.Enabled = false; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Enabled = false;
            groupBoxPropozycja.Visible = true;

            /* try
             {
                 int a = int.Parse(textBoxZakresMin.Text);
                 int b = int.Parse(textBoxZakresMax.Text);
                 g = new Gra(a, b);
             }
             catch(Exception)
             {
                 textBoxZakresMin.BackColor = Color.Red;

             }

     */
            int a;
            if( !int.TryParse(textBoxZakresMin.Text, out a))
            {
                textBoxZakresMin.BackColor = Color.Red;
                return;
            }

            else
            {
                textBoxZakresMin.BackColor = Color.Green;
            }


            int b;
            if (!int.TryParse(textBoxZakresMax.Text, out b))
            {
                textBoxZakresMin.BackColor = Color.Red;
                return;
            }
            else
            {
                textBoxZakresMax.BackColor = Color.LightGreen;
            }

            g = new Gra(a, b);
            groupBoxLosowanie.Enabled = false;
            groupBoxPropozycja.Visible = true;

            private int wczytajLiczbe(TextBox poleTekstowe)
        {


        }

        private bool danePoprawne( TextBox poleTekstoe)
        {

        }



        private void textBoxPropozycja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
