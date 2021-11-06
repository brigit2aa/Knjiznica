using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentskiDom_Perkovic;

namespace Studentski_Dom
{
    public partial class StudentiPoSobama : Form
    {  
        public StudentskiDomStudentiPoSobama studentskiDomStudentiPoSobama = new StudentskiDomStudentiPoSobama();
        public BindingSource tablebindingSource3 = new BindingSource();

        public StudentskiDomStudentiPoSobama studentiBezSobe = new StudentskiDomStudentiPoSobama();
        public BindingSource tablebinfingSource4 = new BindingSource();

        Soba soba;

        public StudentiPoSobama(Soba soba)
        {
            this.soba = soba;
            InitializeComponent();
            tablebindingSource3.DataSource = studentskiDomStudentiPoSobama.GetStudentiIzSobe(soba.IdSobe);
            tablebinfingSource4.DataSource = studentiBezSobe.GetStudentiBezSobe();
            
        }


        private void button3SpS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4SpS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void StudentiPoSobama_Load(object sender, EventArgs e)
        {
            dataGridView1StudentiPoSobama.DataSource = tablebindingSource3;
            dataGridView1StudentiPoSobama.AutoGenerateColumns = false;

            dataGridView1BezSoba.DataSource = tablebinfingSource4;
            dataGridView1BezSoba.AutoGenerateColumns = false;
        }

        private void button2SpS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dali ste sigurni da želite obrisati studenta/icu u sobu?", "Obriši studenta iz sobe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string oibStudenta = dataGridView1StudentiPoSobama.CurrentRow.Cells["OIB"].Value.ToString();
                string idSobe = soba.IdSobe;

                studentskiDomStudentiPoSobama.DeleteStudentiPoSobama(oibStudenta, idSobe);
                tablebindingSource3.DataSource = studentskiDomStudentiPoSobama.GetStudentiIzSobe(soba.IdSobe);
            }
            else
            {
                MessageBox.Show("Student/ica nije izbrisana iz sobe!");
            }
        }

        private void button1SpS_Click(object sender, EventArgs e)
        {
          

            if (MessageBox.Show("Želite li dodati studenta/icu u sobu?", "Dodaj studenta u sobu", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                List<Studenti>studentiUSobi = studentskiDomStudentiPoSobama.GetStudentiIzSobe(soba.IdSobe);
                if (studentiUSobi.Count < 2) 
                {
                
                    string oibStudenta = stUs.Text;
                    string idSobe = soba.IdSobe;


                    studentskiDomStudentiPoSobama.CreateStudentiPoSobama(oibStudenta, idSobe);
                    tablebindingSource3.DataSource = studentskiDomStudentiPoSobama.GetStudentiIzSobe(soba.IdSobe);
                    tablebinfingSource4.DataSource = studentiBezSobe.GetStudentiBezSobe();
                    MessageBox.Show("Student/ica je smješten/a u sobu!");
                    stUs.Clear();
                }
               else
               {
                   MessageBox.Show("Soba je popunjena!");
                    stUs.Clear();
                }
            }
           else
            {
                MessageBox.Show("Student/ica nije smješten/a u sobu!");
                stUs.Clear();
            }    
        }

        private void dataGridView1BezSoba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                var oibStudenta = dataGridView1BezSoba.Rows[e.RowIndex].Cells[0].Value.ToString();
                stUs.Text = oibStudenta;
            }
        }
    }
}
