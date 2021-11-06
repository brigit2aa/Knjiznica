using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentskiDom_Perkovic; 

namespace Studentski_Dom
{
    public partial class Studentski_Dom : Form
    {
        public Studentski_Dom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        string sSqlConnectionString = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.Text == "" && textPassword.Text == "")
                {
                    MessageBox.Show("Molim Vas unesite korisničko ime i lozinku");
                }
                else
                {
                    Korisnik korisnik = null;
                    using (DbConnection connection = new SqlConnection(sSqlConnectionString))
                    using (DbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM Perkovic_Korisnici WHERE KorisnickoIme = '" + textName.Text + "'";
                        connection.Open();
                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                korisnik = new Korisnik()
                                {
                                    Ime = (string)reader["Ime"],
                                    Prezime = (string)reader["Prezime"],
                                    KorisnickoIme = (string)reader["KorisnickoIme"],
                                    LozinkaKorisnika = (string)reader["LozinkaKorisnika"]
                                };

                            }
                        }
                        if (korisnik != null)
                        {
                            if (korisnik.LozinkaKorisnika == textPassword.Text)
                            {
                                this.Hide();
                                Izbornik izbornik = new Izbornik(korisnik);
                                izbornik.ShowDialog();
                                this.Visible = true;
                                textName.Clear();
                                textPassword.Clear();

                            }
                            else
                            {
                                MessageBox.Show("Unjeli ste pogrešnu lozinku");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unjeli ste pogrešno korisničko ime");
                        }

                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textPassword.Clear();
            textName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

        private void uReg_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
            this.Hide();
        }

        private void labelS_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
