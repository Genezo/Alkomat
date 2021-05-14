using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alkomat
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }
        
        private void textBoxLiczba_Validation(object sender, CancelEventArgs e)
        {
            try
            {
                int pom = Convert.ToInt16(((TextBox)sender).Text);
            }
            catch
            {
                MessageBox.Show("Podaj liczbę.", "Błąd");
                e.Cancel = true;
            }
        }

        private void policz_Click(object sender, EventArgs e)
        {
            //licz wg wzoru
            int b = Convert.ToInt32(this.beer.Text);
            int w = Convert.ToInt32(this.wine.Text);
            int v = Convert.ToInt32(this.vodka.Text);
            int Kg = Convert.ToInt32(this.mass.Text);
            double K;
            int nr = 0;

            if (this.komieta.Checked)
            {
                K = 0.6;
            }
            else
            {
                K = 0.7;
            }

            // zaokrąglij Math.Round()
            double A = (10 * b) + (10 * w) + (10 * v);
            double Pr = A / (K * Kg);
            Pr = Math.Round(Pr, 2);
            //zbadaj przedział 
            if(Pr == 0)
            {
                nr = 0;
            }
            else if (Pr <= 0.2)
            {
                nr = 1;
            }
            else if(Pr <= 0.5)
            {
                nr = 2;
            }
            else if (Pr <= 0.7)
            {
                nr = 3;
            }
            else if (Pr <= 2.0)
            {
                nr = 4;
            }
            else if (Pr <= 4.0)
            {
                nr = 5;
            }
            else if (Pr > 4.0)
            {
                nr = 6;
            }
            // wyprowadz info
            Form1 f = new Form1(this.beer.Text, this.wine.Text, this.vodka.Text, Pr , nr);
            f.Show();
        }
    }
}
