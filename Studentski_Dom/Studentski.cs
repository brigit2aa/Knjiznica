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
using StudentskiDom_Perkovic;

namespace Studentski_Dom
{
    public partial class Studentski : Form
    {
        public StudentskiDomStudenti studentskiDomStudenti = new StudentskiDomStudenti();
        public BindingSource tablebindingSource = new BindingSource();
        Studenti studenti = new Studenti();
        public Studentski()
        {
            InitializeComponent();
            tablebindingSource.DataSource = studentskiDomStudenti.GetStudent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Studentski_Load(object sender, EventArgs e)
        {
            dataGridViewStudenti.DataSource = tablebindingSource;
            dataGridViewStudenti.AutoGenerateColumns = false;
        }
      
        private void DodatiStudenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite dodati novog studenta?", "Dodaj novog studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (textBox1O.Text == "" && textBox2I.Text == "" && textBox3P.Text == "" && textBox4A.Text == "" && textBox5K.Text == "")
                    {
                        MessageBox.Show("Molim Vas unesite podatke o studentu!");
                    }
                    else
                    {
                        studenti.OIB = textBox1O.Text;
                        studenti.ImeStudenta = textBox2I.Text;
                        studenti.PrezimeStudenta = textBox3P.Text;
                        studenti.Adresa = textBox4A.Text;
                        studenti.KontaktBroj = textBox5K.Text;
                        studentskiDomStudenti.CreateStudent(studenti);
                        tablebindingSource.DataSource = studentskiDomStudenti.GetStudent();

                        if (studenti != null)
                        {
                            if (studenti.OIB == textBox1O.Text)
                            {
                                MessageBox.Show("Podatci o studentu su upisani!");
                                textBox1O.Clear();
                                textBox2I.Clear();
                                textBox3P.Clear();
                                textBox4A.Clear();
                                textBox5K.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Student već postoji!");
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            else
            {
                MessageBox.Show("Novi student nije dodan!");
            }

        }
       public void TextboxFilter()
        {
            string connection = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = "SELECT * FROM Perkovic_STUDENTI WHERE CONCAT (OIB, PrezimeStudenta) LIKE '%" + trazilicaStudent.Text + "%'";
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter1);
            var dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);
            dataGridViewStudenti.DataSource = dataSet1.Tables[0];
            con.Close();
        }
      
        private void searchStudent_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

   
        private void dataGridViewStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.RowIndex != -1)
                {

                    var OIB = dataGridViewStudenti.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var ImeStudenta = dataGridViewStudenti.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var PrezimeStudenta = dataGridViewStudenti.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var Adresa = dataGridViewStudenti.Rows[e.RowIndex].Cells[3].Value.ToString();
                    var KontaktBroje = dataGridViewStudenti.Rows[e.RowIndex].Cells[4].Value.ToString();

                    var studenti = new Studenti
                    {
                        OIB = OIB,
                        ImeStudenta = ImeStudenta,
                        PrezimeStudenta = PrezimeStudenta,
                        Adresa = Adresa,
                        KontaktBroj = KontaktBroje

                    };
                    textBox1O.Text = studenti.OIB;
                    textBox2I.Text = studenti.ImeStudenta;
                    textBox3P.Text = studenti.PrezimeStudenta;
                    textBox4A.Text = studenti.Adresa;
                    textBox5K.Text = studenti.KontaktBroj;
                }
            
        }

        private void BrisanjeStudenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Obriši studenta?", "Obriši studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                studenti.OIB = trazilicaStudent.Text;
                studentskiDomStudenti.DeleteStudent(studenti);
                tablebindingSource.DataSource = studentskiDomStudenti.GetStudent();
                osvjeziStudente_Click(this, null);
                MessageBox.Show("Student je obrisan!");

            }
            else
            {
                osvjeziStudente_Click(this, null);
                MessageBox.Show("Student nije obrisan!");
            }
        }

        private void povratakNaIzbornik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3D_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1Oibb_Click(object sender, EventArgs e)
        {

        }


        private void osvjeziStudente_Click(object sender, EventArgs e)
        {
            dataGridViewStudenti.DataSource = tablebindingSource;
            dataGridViewStudenti.AutoGenerateColumns = false;
            trazilicaStudent.Clear();
        }

        private void azurirajStudente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li promjeniti podatke o studenta?", "Promjeni podatke o studentu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //dataGridView1_CellContentClick(this, null);
                studenti.OIB = textBox1O.Text;
                studenti.ImeStudenta = textBox2I.Text;
                studenti.PrezimeStudenta = textBox3P.Text;
                studenti.Adresa = textBox4A.Text;
                studenti.KontaktBroj = textBox5K.Text;
                studentskiDomStudenti.UpdateStudent(studenti);
                tablebindingSource.DataSource = studentskiDomStudenti.GetStudent();
                MessageBox.Show("Podatci o studentu su promjenjeni!");
                textBox1O.Clear();
                textBox2I.Clear();
                textBox3P.Clear();
                textBox4A.Clear();
                textBox5K.Clear();
            }
            else
            {
                osvjeziStudente_Click(this, null);
                MessageBox.Show("Podatci o studentu nisu promjenjeni!");
                textBox1O.Clear();
                textBox2I.Clear();
                textBox3P.Clear();
                textBox4A.Clear();
                textBox5K.Clear();
            }
        }
    }
}



        
    

