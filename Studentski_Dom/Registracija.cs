using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentski_Dom
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void registracijaLogin_Click(object sender, EventArgs e)
        {
            Studentski_Dom logInButton = new Studentski_Dom();
            logInButton.Show();
            this.Hide();
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            string connection = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "INSERT INTO Perkovic_Korisnici(Ime, Prezime, KorisnickoIme, LozinkaKorisnika) VALUES ('" + imeRegistracija.Text + "', '" + prezimeRegistracija.Text + "', '" + korisnickoRegistracija.Text + "', '" + lozinkaRegistracija.Text + "')";
                SqlDataAdapter data = new SqlDataAdapter(query, con);
                con.Open();
                data.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Uspješno ste se registrirali");
                ClearData();
            }
            catch
            {
                MessageBox.Show("Pojavila se pogreška pri registraciji!");
            }
            finally
            {
                con.Close();
            }
        }
        private void ClearData()
        {
            imeRegistracija.Text = "";
            prezimeRegistracija.Text = "";
            korisnickoRegistracija.Text = "";
            lozinkaRegistracija.Text = "";
        }

        private void lozinkaRegistracija_TextChanged(object sender, EventArgs e)
        {
            lozinkaRegistracija.PasswordChar = '*';
        }

        private void gasiReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }
    }
}
