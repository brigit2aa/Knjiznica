namespace Studentski_Dom
{
    partial class UKojojJeSobiStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1GdjeJeStudent = new System.Windows.Forms.DataGridView();
            this.textBox1TraziStudenta = new System.Windows.Forms.TextBox();
            this.button1PronaslaSamStudenta = new System.Windows.Forms.Button();
            this.button1TuSuSvi = new System.Windows.Forms.Button();
            this.label1GdjeSi = new System.Windows.Forms.Label();
            this.label1Student2 = new System.Windows.Forms.Label();
            this.button1VratiSeNaSobe = new System.Windows.Forms.Button();
            this.button1IzlazIzApp = new System.Windows.Forms.Button();
            this.obi3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontakt3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeSobe3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1GdjeJeStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.panel1.Controls.Add(this.button1IzlazIzApp);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-1, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 10);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1GdjeJeStudent
            // 
            this.dataGridView1GdjeJeStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1GdjeJeStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1GdjeJeStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obi3,
            this.ime3,
            this.prezime3,
            this.adresa3,
            this.kontakt3,
            this.imeSobe3,
            this.oibStudenta});
            this.dataGridView1GdjeJeStudent.Location = new System.Drawing.Point(58, 186);
            this.dataGridView1GdjeJeStudent.Name = "dataGridView1GdjeJeStudent";
            this.dataGridView1GdjeJeStudent.RowHeadersWidth = 51;
            this.dataGridView1GdjeJeStudent.RowTemplate.Height = 24;
            this.dataGridView1GdjeJeStudent.Size = new System.Drawing.Size(678, 201);
            this.dataGridView1GdjeJeStudent.TabIndex = 2;
            // 
            // textBox1TraziStudenta
            // 
            this.textBox1TraziStudenta.Location = new System.Drawing.Point(58, 141);
            this.textBox1TraziStudenta.Multiline = true;
            this.textBox1TraziStudenta.Name = "textBox1TraziStudenta";
            this.textBox1TraziStudenta.Size = new System.Drawing.Size(286, 39);
            this.textBox1TraziStudenta.TabIndex = 3;
            // 
            // button1PronaslaSamStudenta
            // 
            this.button1PronaslaSamStudenta.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1PronaslaSamStudenta.Location = new System.Drawing.Point(336, 141);
            this.button1PronaslaSamStudenta.Name = "button1PronaslaSamStudenta";
            this.button1PronaslaSamStudenta.Size = new System.Drawing.Size(198, 39);
            this.button1PronaslaSamStudenta.TabIndex = 4;
            this.button1PronaslaSamStudenta.Text = "Pronađi studenta";
            this.button1PronaslaSamStudenta.UseVisualStyleBackColor = true;
            this.button1PronaslaSamStudenta.Click += new System.EventHandler(this.button1PronaslaSamStudenta_Click);
            // 
            // button1TuSuSvi
            // 
            this.button1TuSuSvi.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1TuSuSvi.Location = new System.Drawing.Point(538, 141);
            this.button1TuSuSvi.Name = "button1TuSuSvi";
            this.button1TuSuSvi.Size = new System.Drawing.Size(198, 39);
            this.button1TuSuSvi.TabIndex = 5;
            this.button1TuSuSvi.Text = "Prikaži sve";
            this.button1TuSuSvi.UseVisualStyleBackColor = true;
            this.button1TuSuSvi.Click += new System.EventHandler(this.button1TuSuSvi_Click);
            // 
            // label1GdjeSi
            // 
            this.label1GdjeSi.AutoSize = true;
            this.label1GdjeSi.BackColor = System.Drawing.Color.Transparent;
            this.label1GdjeSi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1GdjeSi.Location = new System.Drawing.Point(270, 66);
            this.label1GdjeSi.Name = "label1GdjeSi";
            this.label1GdjeSi.Size = new System.Drawing.Size(163, 28);
            this.label1GdjeSi.TabIndex = 6;
            this.label1GdjeSi.Text = "U KOJOJ JE SOBI";
            // 
            // label1Student2
            // 
            this.label1Student2.AutoSize = true;
            this.label1Student2.BackColor = System.Drawing.Color.Transparent;
            this.label1Student2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Student2.ForeColor = System.Drawing.Color.White;
            this.label1Student2.Location = new System.Drawing.Point(400, 94);
            this.label1Student2.Name = "label1Student2";
            this.label1Student2.Size = new System.Drawing.Size(134, 25);
            this.label1Student2.TabIndex = 7;
            this.label1Student2.Text = "STUDENT?";
            // 
            // button1VratiSeNaSobe
            // 
            this.button1VratiSeNaSobe.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1VratiSeNaSobe.Location = new System.Drawing.Point(288, 399);
            this.button1VratiSeNaSobe.Name = "button1VratiSeNaSobe";
            this.button1VratiSeNaSobe.Size = new System.Drawing.Size(198, 39);
            this.button1VratiSeNaSobe.TabIndex = 8;
            this.button1VratiSeNaSobe.Text = "Vratite se na sobe";
            this.button1VratiSeNaSobe.UseVisualStyleBackColor = true;
            this.button1VratiSeNaSobe.Click += new System.EventHandler(this.button1VratiSeNaSobe_Click);
            // 
            // button1IzlazIzApp
            // 
            this.button1IzlazIzApp.BackgroundImage = global::Studentski_Dom.Properties.Resources.gumbi;
            this.button1IzlazIzApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1IzlazIzApp.Location = new System.Drawing.Point(762, 3);
            this.button1IzlazIzApp.Name = "button1IzlazIzApp";
            this.button1IzlazIzApp.Size = new System.Drawing.Size(37, 33);
            this.button1IzlazIzApp.TabIndex = 9;
            this.button1IzlazIzApp.Text = "X";
            this.button1IzlazIzApp.UseVisualStyleBackColor = true;
            this.button1IzlazIzApp.Click += new System.EventHandler(this.button1IzlazIzApp_Click);
            // 
            // obi3
            // 
            this.obi3.DataPropertyName = "OIB";
            this.obi3.HeaderText = "OIB";
            this.obi3.MinimumWidth = 6;
            this.obi3.Name = "obi3";
            this.obi3.Width = 125;
            // 
            // ime3
            // 
            this.ime3.DataPropertyName = "ImeStudenta";
            this.ime3.HeaderText = "Ime";
            this.ime3.MinimumWidth = 6;
            this.ime3.Name = "ime3";
            this.ime3.Width = 125;
            // 
            // prezime3
            // 
            this.prezime3.DataPropertyName = "PrezimeStudenta";
            this.prezime3.HeaderText = "Prezime";
            this.prezime3.MinimumWidth = 6;
            this.prezime3.Name = "prezime3";
            this.prezime3.Width = 125;
            // 
            // adresa3
            // 
            this.adresa3.DataPropertyName = "Adresa";
            this.adresa3.HeaderText = "Adresa";
            this.adresa3.MinimumWidth = 6;
            this.adresa3.Name = "adresa3";
            this.adresa3.Width = 125;
            // 
            // kontakt3
            // 
            this.kontakt3.DataPropertyName = "KontaktBroj";
            this.kontakt3.HeaderText = "Kontakt";
            this.kontakt3.MinimumWidth = 6;
            this.kontakt3.Name = "kontakt3";
            this.kontakt3.Width = 125;
            // 
            // imeSobe3
            // 
            this.imeSobe3.DataPropertyName = "IdSobe";
            this.imeSobe3.HeaderText = "Ime sobe";
            this.imeSobe3.MinimumWidth = 6;
            this.imeSobe3.Name = "imeSobe3";
            this.imeSobe3.Width = 125;
            // 
            // oibStudenta
            // 
            this.oibStudenta.DataPropertyName = "OIBStudenta";
            this.oibStudenta.HeaderText = "OIB Studenta";
            this.oibStudenta.MinimumWidth = 6;
            this.oibStudenta.Name = "oibStudenta";
            this.oibStudenta.Visible = false;
            this.oibStudenta.Width = 125;
            // 
            // UKojojJeSobiStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studentski_Dom.Properties.Resources.falcon_eyes_fantasy_cloth_fc_04_3x6m_bor_8718127016454_11;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1VratiSeNaSobe);
            this.Controls.Add(this.label1Student2);
            this.Controls.Add(this.label1GdjeSi);
            this.Controls.Add(this.button1TuSuSvi);
            this.Controls.Add(this.button1PronaslaSamStudenta);
            this.Controls.Add(this.textBox1TraziStudenta);
            this.Controls.Add(this.dataGridView1GdjeJeStudent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UKojojJeSobiStudent";
            this.Text = "UKojojJeSobiStudent";
            this.Load += new System.EventHandler(this.UKojojJeSobiStudent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1GdjeJeStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1GdjeJeStudent;
        private System.Windows.Forms.TextBox textBox1TraziStudenta;
        private System.Windows.Forms.Button button1PronaslaSamStudenta;
        private System.Windows.Forms.Button button1TuSuSvi;
        private System.Windows.Forms.Label label1GdjeSi;
        private System.Windows.Forms.Label label1Student2;
        private System.Windows.Forms.Button button1IzlazIzApp;
        private System.Windows.Forms.Button button1VratiSeNaSobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn obi3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontakt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeSobe3;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibStudenta;
    }
}