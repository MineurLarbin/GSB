
namespace GSB
{
    partial class FrmVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisite));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbx2NdMedicament = new System.Windows.Forms.ComboBox();
            this.cbx1erMedicament = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBilan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEchantillonAjouté = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nbMedicamentDist = new System.Windows.Forms.NumericUpDown();
            this.cbxEchantillonDist = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTypePraticien = new System.Windows.Forms.Label();
            this.lblPraticien = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gsbDataSet = new GSB.gsbDataSet();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillonAjouté)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMedicamentDist)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(1353, 64);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 898);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbx2NdMedicament);
            this.panel5.Controls.Add(this.cbx1erMedicament);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(438, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 486);
            this.panel5.TabIndex = 4;
            // 
            // cbx2NdMedicament
            // 
            this.cbx2NdMedicament.FormattingEnabled = true;
            this.cbx2NdMedicament.Location = new System.Drawing.Point(18, 342);
            this.cbx2NdMedicament.Name = "cbx2NdMedicament";
            this.cbx2NdMedicament.Size = new System.Drawing.Size(222, 21);
            this.cbx2NdMedicament.TabIndex = 9;
            // 
            // cbx1erMedicament
            // 
            this.cbx1erMedicament.FormattingEnabled = true;
            this.cbx1erMedicament.Location = new System.Drawing.Point(18, 128);
            this.cbx1erMedicament.Name = "cbx1erMedicament";
            this.cbx1erMedicament.Size = new System.Drawing.Size(222, 21);
            this.cbx1erMedicament.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(15, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Premier médicament présenté :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(15, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Second médicament présenté :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(15, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Informations à renseigner après la visite :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblBilan);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(31, 514);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 312);
            this.panel4.TabIndex = 2;
            // 
            // lblBilan
            // 
            this.lblBilan.Font = new System.Drawing.Font("Arial", 12F);
            this.lblBilan.Location = new System.Drawing.Point(17, 72);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(719, 198);
            this.lblBilan.TabIndex = 6;
            this.lblBilan.Text = "Bilan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(9, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bilan de la visite";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvEchantillonAjouté);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.nbMedicamentDist);
            this.panel3.Controls.Add(this.cbxEchantillonDist);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(827, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 823);
            this.panel3.TabIndex = 1;
            // 
            // dgvEchantillonAjouté
            // 
            this.dgvEchantillonAjouté.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillonAjouté.Location = new System.Drawing.Point(27, 182);
            this.dgvEchantillonAjouté.Name = "dgvEchantillonAjouté";
            this.dgvEchantillonAjouté.Size = new System.Drawing.Size(425, 612);
            this.dgvEchantillonAjouté.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.Location = new System.Drawing.Point(378, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nbMedicamentDist
            // 
            this.nbMedicamentDist.Location = new System.Drawing.Point(263, 128);
            this.nbMedicamentDist.Name = "nbMedicamentDist";
            this.nbMedicamentDist.Size = new System.Drawing.Size(63, 20);
            this.nbMedicamentDist.TabIndex = 10;
            // 
            // cbxEchantillonDist
            // 
            this.cbxEchantillonDist.FormattingEnabled = true;
            this.cbxEchantillonDist.Location = new System.Drawing.Point(22, 128);
            this.cbxEchantillonDist.Name = "cbxEchantillonDist";
            this.cbxEchantillonDist.Size = new System.Drawing.Size(222, 21);
            this.cbxEchantillonDist.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F);
            this.label13.Location = new System.Drawing.Point(260, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "Quantité";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F);
            this.label12.Location = new System.Drawing.Point(19, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Médicament";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.Location = new System.Drawing.Point(19, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Échantillons distribués";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTypePraticien);
            this.panel2.Controls.Add(this.lblPraticien);
            this.panel2.Controls.Add(this.lblMotif);
            this.panel2.Controls.Add(this.lblLieu);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 487);
            this.panel2.TabIndex = 0;
            // 
            // lblTypePraticien
            // 
            this.lblTypePraticien.AutoSize = true;
            this.lblTypePraticien.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTypePraticien.Location = new System.Drawing.Point(158, 406);
            this.lblTypePraticien.Name = "lblTypePraticien";
            this.lblTypePraticien.Size = new System.Drawing.Size(103, 18);
            this.lblTypePraticien.TabIndex = 9;
            this.lblTypePraticien.Text = "Type Practien";
            // 
            // lblPraticien
            // 
            this.lblPraticien.AutoSize = true;
            this.lblPraticien.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPraticien.Location = new System.Drawing.Point(158, 296);
            this.lblPraticien.Name = "lblPraticien";
            this.lblPraticien.Size = new System.Drawing.Size(70, 18);
            this.lblPraticien.TabIndex = 8;
            this.lblPraticien.Text = "Praticien";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMotif.Location = new System.Drawing.Point(158, 182);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(42, 18);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLieu.Location = new System.Drawing.Point(158, 88);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(38, 18);
            this.lblLieu.TabIndex = 6;
            this.lblLieu.Text = "Lieu";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDate.Location = new System.Drawing.Point(158, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 18);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(14, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type praticien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(14, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Praticien consulté";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(14, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Motif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lieu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // gsbDataSet
            // 
            this.gsbDataSet.DataSetName = "gsbDataSet";
            this.gsbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 996);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVisite";
            this.Text = "Visite";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillonAjouté)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMedicamentDist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx2NdMedicament;
        private System.Windows.Forms.ComboBox cbx1erMedicament;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nbMedicamentDist;
        private System.Windows.Forms.ComboBox cbxEchantillonDist;
        private System.Windows.Forms.Label lblTypePraticien;
        private System.Windows.Forms.Label lblPraticien;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblDate;
        private gsbDataSet gsbDataSet;
        private System.Windows.Forms.DataGridView dgvEchantillonAjouté;
    }
}