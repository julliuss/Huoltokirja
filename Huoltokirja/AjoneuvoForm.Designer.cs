namespace Huoltokirja
{
    partial class AjoneuvoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblOtsikko = new System.Windows.Forms.Label();
            this.dgvMerkinnat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUusiMittari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbToimenpide = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKuvaus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkVikailmoitus = new System.Windows.Forms.CheckBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerkinnat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // lblOtsikko

            this.lblOtsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtsikko.Location = new System.Drawing.Point(12, 9);
            this.lblOtsikko.Name = "lblOtsikko";
            this.lblOtsikko.Size = new System.Drawing.Size(560, 30);
            this.lblOtsikko.TabIndex = 0;
            this.lblOtsikko.Text = "Ajoneuvo (ID)";
            this.lblOtsikko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvMerkinnat

            this.dgvMerkinnat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMerkinnat.Location = new System.Drawing.Point(12, 42);
            this.dgvMerkinnat.Name = "dgvMerkinnat";
            this.dgvMerkinnat.Size = new System.Drawing.Size(560, 200);
            this.dgvMerkinnat.TabIndex = 1;

            // groupBox1

            this.groupBox1.Controls.Add(this.btnTallenna);
            this.groupBox1.Controls.Add(this.chkVikailmoitus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKuvaus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbToimenpide);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUusiMittari);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uusi merkintä";

            // txtUusiMittari

            this.txtUusiMittari.Location = new System.Drawing.Point(100, 25);
            this.txtUusiMittari.Name = "txtUusiMittari";
            this.txtUusiMittari.Size = new System.Drawing.Size(100, 20);
            this.txtUusiMittari.TabIndex = 0;
  
            // label1

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mittarilukema:";

            // cmbToimenpide

            this.cmbToimenpide.FormattingEnabled = true;
            this.cmbToimenpide.Location = new System.Drawing.Point(100, 55);
            this.cmbToimenpide.Name = "cmbToimenpide";
            this.cmbToimenpide.Size = new System.Drawing.Size(150, 21);
            this.cmbToimenpide.TabIndex = 2;

            // label2

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toimenpide:";

            // txtKuvaus

            this.txtKuvaus.Location = new System.Drawing.Point(100, 85);
            this.txtKuvaus.Multiline = true;
            this.txtKuvaus.Name = "txtKuvaus";
            this.txtKuvaus.Size = new System.Drawing.Size(400, 60);
            this.txtKuvaus.TabIndex = 4;

            // label3

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kuvaus:";

            // chkVikailmoitus

            this.chkVikailmoitus.AutoSize = true;
            this.chkVikailmoitus.Location = new System.Drawing.Point(280, 57);
            this.chkVikailmoitus.Name = "chkVikailmoitus";
            this.chkVikailmoitus.Size = new System.Drawing.Size(83, 17);
            this.chkVikailmoitus.TabIndex = 6;
            this.chkVikailmoitus.Text = "Vikailmoitus";
            this.chkVikailmoitus.UseVisualStyleBackColor = true;

            // btnTallenna

            this.btnTallenna.Location = new System.Drawing.Point(430, 160);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(120, 30);
            this.btnTallenna.TabIndex = 7;
            this.btnTallenna.Text = "Tallenna merkintä";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);

            // AjoneuvoForm

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMerkinnat);
            this.Controls.Add(this.lblOtsikko);
            this.Name = "AjoneuvoForm";
            this.Text = "Ajoneuvo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerkinnat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOtsikko;
        private System.Windows.Forms.DataGridView dgvMerkinnat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.CheckBox chkVikailmoitus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKuvaus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbToimenpide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUusiMittari;
    }
}