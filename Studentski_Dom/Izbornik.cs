using StudentskiDom_Perkovic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentski_Dom
{
    public partial class Izbornik : Form
    {
        Korisnik prijavljeniKorisnik;
       
        public Izbornik(Korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
            label1.Text = prijavljeniKorisnik.Ime;
        }

        private void studentiIzbornik_Click(object sender, EventArgs e)
        {
            Studentski novaForma = new Studentski();
            this.Hide();
            novaForma.ShowDialog();
            this.Visible = true;
            
        }

        private void sobeIzbornik_Click(object sender, EventArgs e)
        {
            Sobe novaSoba = new Sobe();
            this.Hide();
            novaSoba.ShowDialog();
            this.Visible = true;
        }

        private void button1IzlazIzbornik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1Odjava_Click(object sender, EventArgs e)
        {
            this.Close(); 
            
        }

        private void labelIzbornik_Click(object sender, EventArgs e)
        {

        }

        private void Izbornik_Load(object sender, EventArgs e)
        {

        }
    }
}
