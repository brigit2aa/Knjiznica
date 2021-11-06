using StudentskiDom_Perkovic;
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
    public partial class UKojojJeSobiStudent : Form
    {
        public StudentskiDomStudenti gdjeJeStudentSmjesten = new StudentskiDomStudenti();
        public BindingSource tablebindingSource5 = new BindingSource();
        public UKojojJeSobiStudent()
        {
            InitializeComponent();
            tablebindingSource5.DataSource = gdjeJeStudentSmjesten.GetGdjeJeStudent();
        }

        private void button1VratiSeNaSobe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1IzlazIzApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UKojojJeSobiStudent_Load(object sender, EventArgs e)
        {
            dataGridView1GdjeJeStudent.DataSource = tablebindingSource5;
            dataGridView1GdjeJeStudent.AutoGenerateColumns = false;
        }

        public void TextboxFilter3()
        {
            string connection = "Server=193.198.57.183; Database= STUDENTI_PIN; Initial Catalog=StudentskiDom_Perkovic; User Id=pin; Password=Vsmti1234!;";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query1 = "SELECT * from Perkovic_STUDENTI LEFT JOIN Perkovic_STUDENT_SOBA ON Perkovic_STUDENTI.OIB = Perkovic_STUDENT_SOBA.OIBStudenta  WHERE CONCAT (OIBStudenta, IdSobe, PrezimeStudenta, ImeStudenta) LIKE  '%" + textBox1TraziStudenta.Text + "%'";
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(query1, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter2);
            var dataSet3 = new DataSet();
            dataAdapter2.Fill(dataSet3);
            dataGridView1GdjeJeStudent.DataSource = dataSet3.Tables[0];
            con.Close();
        }

        private void button1PronaslaSamStudenta_Click(object sender, EventArgs e)
        {
            TextboxFilter3();
        }

        private void button1TuSuSvi_Click(object sender, EventArgs e)
        {
            dataGridView1GdjeJeStudent.DataSource = tablebindingSource5;
            dataGridView1GdjeJeStudent.AutoGenerateColumns = false;
        }
    }
}
