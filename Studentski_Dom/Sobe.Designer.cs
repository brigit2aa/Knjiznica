namespace Studentski_Dom
{
    partial class Sobe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1xx = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1Sobe = new System.Windows.Forms.PictureBox();
            this.label1Sobe = new System.Windows.Forms.Label();
            this.label1SobD = new System.Windows.Forms.Label();
            this.dataGridViewSobe = new System.Windows.Forms.DataGridView();
            this.imeSobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaSobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1DodSob = new System.Windows.Forms.Button();
            this.button1ObSob = new System.Windows.Forms.Button();
            this.button1AzSo = new System.Windows.Forms.Button();
            this.button1Gi = new System.Windows.Forms.Button();
            this.trazilicaSobe = new System.Windows.Forms.TextBox();
            this.button1TzS = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1Dodajusobu = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton1PPoSobi = new System.Windows.Forms.RadioButton();
            this.label1ImSobe = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3Kat = new System.Windows.Forms.Label();
            this.label2Boja = new System.Windows.Forms.Label();
            this.label1Broj = new System.Windows.Forms.Label();
            this.osvjezi = new System.Windows.Forms.Button();
            this.poruka = new System.Windows.Forms.Label();
            this.button1UKojojJeSobiStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Sobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSobe)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.panel1.Controls.Add(this.button1xx);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1xx
            // 
            this.button1xx.BackColor = System.Drawing.Color.White;
            this.button1xx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1xx.Location = new System.Drawing.Point(1117, 3);
            this.button1xx.Name = "button1xx";
            this.button1xx.Size = new System.Drawing.Size(30, 30);
            this.button1xx.TabIndex = 12;
            this.button1xx.Text = "X";
            this.button1xx.UseVisualStyleBackColor = false;
            this.button1xx.Click += new System.EventHandler(this.button1xx_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(-7, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 10);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1Sobe
            // 
            this.pictureBox1Sobe.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Sobe.Image = global::Studentski_Dom.Properties.Resources.iconfinder_Macau_paul_cathedral_building_landmark_3691807;
            this.pictureBox1Sobe.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1Sobe.Name = "pictureBox1Sobe";
            this.pictureBox1Sobe.Size = new System.Drawing.Size(87, 93);
            this.pictureBox1Sobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1Sobe.TabIndex = 2;
            this.pictureBox1Sobe.TabStop = false;
            // 
            // label1Sobe
            // 
            this.label1Sobe.AutoSize = true;
            this.label1Sobe.BackColor = System.Drawing.Color.Transparent;
            this.label1Sobe.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Sobe.Location = new System.Drawing.Point(7, 39);
            this.label1Sobe.Name = "label1Sobe";
            this.label1Sobe.Size = new System.Drawing.Size(134, 27);
            this.label1Sobe.TabIndex = 3;
            this.label1Sobe.Text = "STUDENTSKI";
            // 
            // label1SobD
            // 
            this.label1SobD.AutoSize = true;
            this.label1SobD.BackColor = System.Drawing.Color.Transparent;
            this.label1SobD.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1SobD.ForeColor = System.Drawing.Color.White;
            this.label1SobD.Location = new System.Drawing.Point(94, 66);
            this.label1SobD.Name = "label1SobD";
            this.label1SobD.Size = new System.Drawing.Size(78, 30);
            this.label1SobD.TabIndex = 4;
            this.label1SobD.Text = "DOM";
            // 
            // dataGridViewSobe
            // 
            this.dataGridViewSobe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeSobe,
            this.kapacitet,
            this.bojaSobe,
            this.kat});
            this.dataGridViewSobe.Location = new System.Drawing.Point(516, 216);
            this.dataGridViewSobe.Name = "dataGridViewSobe";
            this.dataGridViewSobe.RowHeadersWidth = 51;
            this.dataGridViewSobe.RowTemplate.Height = 24;
            this.dataGridViewSobe.Size = new System.Drawing.Size(573, 309);
            this.dataGridViewSobe.TabIndex = 5;
            this.dataGridViewSobe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imeSobe
            // 
            this.imeSobe.DataPropertyName = "IdSobe";
            this.imeSobe.HeaderText = "Ime sobe";
            this.imeSobe.MinimumWidth = 6;
            this.imeSobe.Name = "imeSobe";
            this.imeSobe.Width = 178;
            // 
            // kapacitet
            // 
            this.kapacitet.DataPropertyName = "KapacitetniBrojKreveta";
            this.kapacitet.HeaderText = "Broj kreveta";
            this.kapacitet.MinimumWidth = 6;
            this.kapacitet.Name = "kapacitet";
            this.kapacitet.Width = 179;
            // 
            // bojaSobe
            // 
            this.bojaSobe.DataPropertyName = "BojaSobe";
            this.bojaSobe.HeaderText = "Boja sobe";
            this.bojaSobe.MinimumWidth = 6;
            this.bojaSobe.Name = "bojaSobe";
            this.bojaSobe.Width = 178;
            // 
            // kat
            // 
            this.kat.DataPropertyName = "KatSobe";
            this.kat.HeaderText = "Kat";
            this.kat.MinimumWidth = 6;
            this.kat.Name = "kat";
            this.kat.Width = 178;
            // 
            // button1DodSob
            // 
            this.button1DodSob.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1DodSob.Location = new System.Drawing.Point(53, 485);
            this.button1DodSob.Name = "button1DodSob";
            this.button1DodSob.Size = new System.Drawing.Size(202, 40);
            this.button1DodSob.TabIndex = 6;
            this.button1DodSob.Text = "Dodaj novu sobu";
            this.button1DodSob.UseVisualStyleBackColor = true;
            this.button1DodSob.Click += new System.EventHandler(this.button1DodSob_Click);
            // 
            // button1ObSob
            // 
            this.button1ObSob.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1ObSob.Location = new System.Drawing.Point(53, 531);
            this.button1ObSob.Name = "button1ObSob";
            this.button1ObSob.Size = new System.Drawing.Size(202, 40);
            this.button1ObSob.TabIndex = 7;
            this.button1ObSob.Text = "Obriši sobu";
            this.button1ObSob.UseVisualStyleBackColor = true;
            this.button1ObSob.Click += new System.EventHandler(this.button1ObSob_Click);
            // 
            // button1AzSo
            // 
            this.button1AzSo.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1AzSo.Location = new System.Drawing.Point(261, 485);
            this.button1AzSo.Name = "button1AzSo";
            this.button1AzSo.Size = new System.Drawing.Size(202, 40);
            this.button1AzSo.TabIndex = 8;
            this.button1AzSo.Text = "Promjeni podatke o sobi";
            this.button1AzSo.UseVisualStyleBackColor = true;
            this.button1AzSo.Click += new System.EventHandler(this.button1AzSo_Click);
            // 
            // button1Gi
            // 
            this.button1Gi.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1Gi.Location = new System.Drawing.Point(261, 531);
            this.button1Gi.Name = "button1Gi";
            this.button1Gi.Size = new System.Drawing.Size(202, 40);
            this.button1Gi.TabIndex = 9;
            this.button1Gi.Text = "Glavni izbornik";
            this.button1Gi.UseVisualStyleBackColor = true;
            this.button1Gi.Click += new System.EventHandler(this.button1Gi_Click);
            // 
            // trazilicaSobe
            // 
            this.trazilicaSobe.Location = new System.Drawing.Point(516, 170);
            this.trazilicaSobe.Multiline = true;
            this.trazilicaSobe.Name = "trazilicaSobe";
            this.trazilicaSobe.Size = new System.Drawing.Size(223, 40);
            this.trazilicaSobe.TabIndex = 10;
            // 
            // button1TzS
            // 
            this.button1TzS.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1TzS.Location = new System.Drawing.Point(736, 170);
            this.button1TzS.Name = "button1TzS";
            this.button1TzS.Size = new System.Drawing.Size(187, 40);
            this.button1TzS.TabIndex = 11;
            this.button1TzS.Text = "Tražilica za sobe";
            this.button1TzS.UseVisualStyleBackColor = true;
            this.button1TzS.Click += new System.EventHandler(this.button1TzS_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.radioButton1Dodajusobu);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.radioButton1PPoSobi);
            this.panel3.Controls.Add(this.label1ImSobe);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3Kat);
            this.panel3.Controls.Add(this.label2Boja);
            this.panel3.Controls.Add(this.label1Broj);
            this.panel3.Location = new System.Drawing.Point(22, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 278);
            this.panel3.TabIndex = 12;
            // 
            // radioButton1Dodajusobu
            // 
            this.radioButton1Dodajusobu.AutoSize = true;
            this.radioButton1Dodajusobu.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1Dodajusobu.Location = new System.Drawing.Point(231, 257);
            this.radioButton1Dodajusobu.Name = "radioButton1Dodajusobu";
            this.radioButton1Dodajusobu.Size = new System.Drawing.Size(211, 21);
            this.radioButton1Dodajusobu.TabIndex = 21;
            this.radioButton1Dodajusobu.TabStop = true;
            this.radioButton1Dodajusobu.Text = "Dodavanje studenata u sobu";
            this.radioButton1Dodajusobu.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 41);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(284, 40);
            this.textBox4.TabIndex = 17;
            // 
            // radioButton1PPoSobi
            // 
            this.radioButton1PPoSobi.AutoSize = true;
            this.radioButton1PPoSobi.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1PPoSobi.Location = new System.Drawing.Point(31, 257);
            this.radioButton1PPoSobi.Name = "radioButton1PPoSobi";
            this.radioButton1PPoSobi.Size = new System.Drawing.Size(194, 21);
            this.radioButton1PPoSobi.TabIndex = 20;
            this.radioButton1PPoSobi.TabStop = true;
            this.radioButton1PPoSobi.Text = "Promjena podataka o sobi";
            this.radioButton1PPoSobi.UseVisualStyleBackColor = false;
            // 
            // label1ImSobe
            // 
            this.label1ImSobe.AutoSize = true;
            this.label1ImSobe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1ImSobe.Location = new System.Drawing.Point(26, 53);
            this.label1ImSobe.Name = "label1ImSobe";
            this.label1ImSobe.Size = new System.Drawing.Size(102, 28);
            this.label1ImSobe.TabIndex = 16;
            this.label1ImSobe.Text = "Ime sobe:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 197);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 40);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 146);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 40);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 40);
            this.textBox1.TabIndex = 13;
            // 
            // label3Kat
            // 
            this.label3Kat.AutoSize = true;
            this.label3Kat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3Kat.Location = new System.Drawing.Point(26, 209);
            this.label3Kat.Name = "label3Kat";
            this.label3Kat.Size = new System.Drawing.Size(96, 28);
            this.label3Kat.TabIndex = 2;
            this.label3Kat.Text = "Kat sobe:";
            // 
            // label2Boja
            // 
            this.label2Boja.AutoSize = true;
            this.label2Boja.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2Boja.Location = new System.Drawing.Point(26, 158);
            this.label2Boja.Name = "label2Boja";
            this.label2Boja.Size = new System.Drawing.Size(106, 28);
            this.label2Boja.TabIndex = 1;
            this.label2Boja.Text = "Boja sobe:";
            // 
            // label1Broj
            // 
            this.label1Broj.AutoSize = true;
            this.label1Broj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Broj.Location = new System.Drawing.Point(26, 105);
            this.label1Broj.Name = "label1Broj";
            this.label1Broj.Size = new System.Drawing.Size(126, 28);
            this.label1Broj.TabIndex = 0;
            this.label1Broj.Text = "Broj kreveta:";
            // 
            // osvjezi
            // 
            this.osvjezi.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.osvjezi.Location = new System.Drawing.Point(928, 170);
            this.osvjezi.Name = "osvjezi";
            this.osvjezi.Size = new System.Drawing.Size(161, 40);
            this.osvjezi.TabIndex = 13;
            this.osvjezi.Text = "Prikaži sve sobe";
            this.osvjezi.UseVisualStyleBackColor = true;
            this.osvjezi.Click += new System.EventHandler(this.osvjezi_Click);
            // 
            // poruka
            // 
            this.poruka.AutoSize = true;
            this.poruka.BackColor = System.Drawing.Color.Transparent;
            this.poruka.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poruka.Location = new System.Drawing.Point(79, 464);
            this.poruka.Name = "poruka";
            this.poruka.Size = new System.Drawing.Size(0, 28);
            this.poruka.TabIndex = 18;
            // 
            // button1UKojojJeSobiStudent
            // 
            this.button1UKojojJeSobiStudent.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1UKojojJeSobiStudent.Location = new System.Drawing.Point(717, 531);
            this.button1UKojojJeSobiStudent.Name = "button1UKojojJeSobiStudent";
            this.button1UKojojJeSobiStudent.Size = new System.Drawing.Size(192, 40);
            this.button1UKojojJeSobiStudent.TabIndex = 20;
            this.button1UKojojJeSobiStudent.Text = "U kojoj je sobi student?";
            this.button1UKojojJeSobiStudent.UseVisualStyleBackColor = true;
            this.button1UKojojJeSobiStudent.Click += new System.EventHandler(this.button1UKojojJeSobiStudent_Click);
            // 
            // Sobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studentski_Dom.Properties.Resources.falcon_eyes_fantasy_cloth_fc_04_3x6m_bor_8718127016454_1;
            this.ClientSize = new System.Drawing.Size(1156, 612);
            this.Controls.Add(this.button1UKojojJeSobiStudent);
            this.Controls.Add(this.poruka);
            this.Controls.Add(this.osvjezi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1TzS);
            this.Controls.Add(this.trazilicaSobe);
            this.Controls.Add(this.button1Gi);
            this.Controls.Add(this.button1AzSo);
            this.Controls.Add(this.button1ObSob);
            this.Controls.Add(this.button1DodSob);
            this.Controls.Add(this.dataGridViewSobe);
            this.Controls.Add(this.label1SobD);
            this.Controls.Add(this.label1Sobe);
            this.Controls.Add(this.pictureBox1Sobe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sobe";
            this.Text = "Sobe";
            this.Load += new System.EventHandler(this.Sobe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Sobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSobe)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1Sobe;
        private System.Windows.Forms.Label label1Sobe;
        private System.Windows.Forms.Label label1SobD;
        private System.Windows.Forms.DataGridView dataGridViewSobe;
        private System.Windows.Forms.Button button1DodSob;
        private System.Windows.Forms.Button button1ObSob;
        private System.Windows.Forms.Button button1AzSo;
        private System.Windows.Forms.Button button1Gi;
        private System.Windows.Forms.TextBox trazilicaSobe;
        private System.Windows.Forms.Button button1TzS;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeSobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaSobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat;
        private System.Windows.Forms.Button button1xx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3Kat;
        private System.Windows.Forms.Label label2Boja;
        private System.Windows.Forms.Label label1Broj;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1ImSobe;
        private System.Windows.Forms.Button osvjezi;
        private System.Windows.Forms.Label poruka;
        private System.Windows.Forms.RadioButton radioButton1PPoSobi;
        private System.Windows.Forms.RadioButton radioButton1Dodajusobu;
        private System.Windows.Forms.Button button1UKojojJeSobiStudent;
    }
}