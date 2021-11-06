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
    public partial class Sobe : Form
    {
        Soba soba = new Soba();
        public StudentskiDomSobe studentskiDomSobe = new StudentskiDomSobe();
        public BindingSource tablebindingSource2 = new BindingSource();


        public Sobe()
        {
            InitializeComponent();
            tablebindingSource2.DataSource = studentskiDomSobe.GetSobe();
        }


        private void button1Gi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
              
                var IdSobe = dataGridViewSobe.Rows[e.RowIndex].Cells[0].Value.ToString();
                var KapacietniBrojKreveta = dataGridViewSobe.Rows[e.RowIndex].Cells[1].Value.ToString();
                var BojaSobe = dataGridViewSobe.Rows[e.RowIndex].Cells[2].Value.ToString();
                var KatSobe = dataGridViewSobe.Rows[e.RowIndex].Cells[3].Value.ToString();


                var soba = new Soba
                {
                    IdSobe = IdSobe,
                    KapacitetniBrojKreveta = KapacietniBrojKreveta,
                    BojaSobe = BojaSobe,
                    KatSobe = KatSobe
                };
                if (radioButton1PPoSobi.Checked)
                {
                    textBox4.Text = soba.IdSobe;
                    textBox1.Text = soba.KapacitetniBrojKreveta;
                    textBox2.Text = soba.BojaSobe;
                    textBox3.Text = soba.KatSobe;

                }
                if (radioButton1Dodajusobu.Checked)
                {
                    StudentiPoSobama studentiPoSobama2 = new StudentiPoSobama(soba);
                    studentiPoSobama2.ShowDialog();
                }

             

            }
            else
            {
                MessageBox.Show("Greška!");
            }
        }
      
        private void button1DodSob_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite dodati novu sobu?", "Dodaj novu sobu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (textBox4.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                    {
                        MessageBox.Show("Molim Vas unesite podatke o sobi!");
                    }
                    else
                    {
                        soba.IdSobe = textBox4.Text;
                        soba.KapacitetniBrojKreveta = textBox1.Text;
                        soba.BojaSobe = textBox2.Text;
                        soba.KatSobe = textBox3.Text;
                        studentskiDomSobe.CreateSobe(soba);
                        tablebindingSource2.DataSource = studentskiDomSobe.GetSobe();

                        if (soba != null)
                        {
                            if (soba.IdSobe == textBox4.Text)
                            {
                                MessageBox.Show("Podatci o sobi su upisani!");
                                textBox4.Clear();
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Soba već postoji!");
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
                MessageBox.Show("Nova soba nije dodana!");
            }

        }

        private void Sobe_Load(object sender, EventArgs e)
        {
            dataGridViewSobe.DataSource = tablebindingSource2;
            dataGridViewSobe.AutoGenerateColumns = false;
            
        }

        private void button1xx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void TextboxFilter2()
        {
            string connection = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query1 = "SELECT * FROM Perkovic_SOBE WHERE CONCAT(IdSobe, KapacitetniBrojKreveta, BojaSobe, KatSobe) LIKE '%" + trazilicaSobe.Text + "%'";
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(query1, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter2);
            var dataSet2 = new DataSet();
            dataAdapter2.Fill(dataSet2);
            dataGridViewSobe.DataSource = dataSet2.Tables[0];
            con.Close();
        }

        private void button1TzS_Click(object sender, EventArgs e)
        {
            TextboxFilter2();
        }

        private void button1AzSo_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Želite promijeniti podatke o sobi?", "Promjeni podatke o sobi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                soba.IdSobe = textBox4.Text;
                soba.KapacitetniBrojKreveta = textBox1.Text;
                soba.BojaSobe = textBox2.Text;
                soba.KatSobe = textBox3.Text;
                studentskiDomSobe.UpdateSobe(soba);
                tablebindingSource2.DataSource = studentskiDomSobe.GetSobe();

                MessageBox.Show("Podatci o sobi su promjenjeni!");
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                osvjezi_Click(this, null);
                MessageBox.Show("Podatci o sobi nisu promjenjeni!");
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            
        }

        private void osvjezi_Click(object sender, EventArgs e)
        {
            dataGridViewSobe.DataSource = tablebindingSource2;
            dataGridViewSobe.AutoGenerateColumns = false;
            trazilicaSobe.Clear();
        }

        private void button1ObSob_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Želite obrisati sobu", "Obriši sobu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                soba.IdSobe = trazilicaSobe.Text;
                studentskiDomSobe.DeleteSobe(soba);
                tablebindingSource2.DataSource = studentskiDomSobe.GetSobe();
                osvjezi_Click(this, null);
                MessageBox.Show("Soba je obrisana!");
            }
            else
            {
                osvjezi_Click(this, null);
                MessageBox.Show("Soba nije obrisana!");
            }
        }


        private void button1UKojojJeSobiStudent_Click(object sender, EventArgs e)
        {
            UKojojJeSobiStudent gdjeSi = new UKojojJeSobiStudent();
            this.Hide();
            gdjeSi.ShowDialog();
            this.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
