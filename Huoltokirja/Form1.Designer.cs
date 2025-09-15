namespace Huoltokirja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnValitse = new Button();
            cmbAjoneuvot = new ComboBox();
            tabPage2 = new TabPage();
            btnVieCSV = new Button();
            dgvOpettaja = new DataGridView();
            dgvOpiskelija = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOpettaja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOpiskelija).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvOpiskelija);
            tabPage1.Controls.Add(btnValitse);
            tabPage1.Controls.Add(cmbAjoneuvot);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Opiskelija";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnValitse
            // 
            btnValitse.Location = new Point(26, 310);
            btnValitse.Name = "btnValitse";
            btnValitse.Size = new Size(144, 38);
            btnValitse.TabIndex = 2;
            btnValitse.Text = "Valitse ajoneuvo";
            btnValitse.UseVisualStyleBackColor = true;
            btnValitse.Click += btnValitse_Click;
            // 
            // cmbAjoneuvot
            // 
            cmbAjoneuvot.FormattingEnabled = true;
            cmbAjoneuvot.Location = new Point(17, 24);
            cmbAjoneuvot.Name = "cmbAjoneuvot";
            cmbAjoneuvot.Size = new Size(672, 23);
            cmbAjoneuvot.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnVieCSV);
            tabPage2.Controls.Add(dgvOpettaja);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Opettaja";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVieCSV
            // 
            btnVieCSV.Location = new Point(23, 320);
            btnVieCSV.Name = "btnVieCSV";
            btnVieCSV.Size = new Size(168, 40);
            btnVieCSV.TabIndex = 1;
            btnVieCSV.Text = "Vie CSV-tiedostoon";
            btnVieCSV.UseVisualStyleBackColor = true;
            btnVieCSV.Click += btnVieCSV_Click;
            // 
            // dgvOpettaja
            // 
            dgvOpettaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOpettaja.Location = new Point(23, 77);
            dgvOpettaja.Name = "dgvOpettaja";
            dgvOpettaja.Size = new Size(664, 213);
            dgvOpettaja.TabIndex = 0;
            // 
            // dgvOpiskelija
            // 
            dgvOpiskelija.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dgvOpiskelija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOpiskelija.Location = new Point(17, 53);
            dgvOpiskelija.Name = "dgvOpiskelija";
            dgvOpiskelija.Size = new Size(672, 231);
            dgvOpiskelija.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOpettaja).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOpiskelija).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cmbAjoneuvot;
        private Button btnValitse;
        private Button btnVieCSV;
        private DataGridView dgvOpettaja;
        private DataGridView dgvOpiskelija;
    }
}
