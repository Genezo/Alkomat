using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alkomat
{
    public partial class Form1 : Form
    {
        string[] messagesText = {"Jesteś trzeźwi!",
                                  "W miare trzeźwy",
                                  "Nie siadaj za kierownicą",
                                    "Idź spać",
                                      "Kończ pić",
                                       "Prawie śmierć",
                                        "Śmierć"};

        string wierszpliku = "";


        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string beer1, string wino, string vodka1, double promile, int nr)
        {
            string nazwaobrazka = "";

            InitializeComponent();

            this.beer.Text += beer1;
            this.wine.Text += wino;
            this.vodka.Text += vodka1;
            this.promil.Text = promile.ToString() + "%%";
            progressBar1.Value = promile>6 ? 6 : Convert.ToUInt16(promile);
            nazwaobrazka = "obrazki\\" + nr.ToString() + ".jpg";
            this.pictureBox1.Load(nazwaobrazka);
            this.linkLabel1.Text = messagesText[nr];

            wierszpliku = System.DateTime.Now.ToString()+";"
                +beer1+";"
                +wino+";"
                +vodka1+";"
                +this.promil.Text;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            // zapis do pliku File.Append
            StreamWriter streamWriter1;
            bool b = false;

            b = File.Exists("Alkomat.csv");
            streamWriter1 = File.AppendText("Alkomat.csv");
            if(!b)
            {
                streamWriter1.WriteLine("Data; Beer; Wine; Vodka; Promile");
            }
            streamWriter1.WriteLine(wierszpliku);
            streamWriter1.Close();
        }
    
    }
}
