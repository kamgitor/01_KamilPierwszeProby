using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kamil_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void baton_Click(object sender, EventArgs e)
        {
/*
            Pracownik P1 = new Pracownik("Kamil", 1000);
            Pracownik.ilosc = 0;
*/

            MojaKlasa p1 = new MojaKlasa();
            p1.Dana = 5;
            MojaKlasa p2;
            MojaKlasa p3 = new MojaKlasa();
            p3 = p1;        // 
            p1.Dana = 10;
        }



        public class MojaKlasa
        {
            public int Dana { get; set; }
        }


/*
        public class Pracownik
        {
            public static int ilosc;
            public string nazwisko;
            private double zarobki;
            public Pracownik(string n, double z) // konstruktor
            {
                nazwisko = n;
                zarobki = z;
            }
            public void PokazPracownika() // metoda
            {
                // Console.WriteLine("{0,-15} {1,10}", nazwisko, zarobki);
            }
        }
*/

    }
}
