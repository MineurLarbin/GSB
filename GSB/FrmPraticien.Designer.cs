
namespace GSB
{
    partial class FrmPraticien
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
            this.lbxMedicamament = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvEchantillons = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBilan = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPraticien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPraticiens = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(1353, 64);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 909);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbxMedicamament);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblMotif);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(462, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 881);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbxMedicamament
            // 
            this.lbxMedicamament.FormattingEnabled = true;
            this.lbxMedicamament.Location = new System.Drawing.Point(50, 785);
            this.lbxMedicamament.Name = "lbxMedicamament";
            this.lbxMedicamament.Size = new System.Drawing.Size(261, 43);
            this.lbxMedicamament.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(633, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Échantillon fournis";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblMotif
            // 
            this.lblMotif.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblMotif.Location = new System.Drawing.Point(113, 318);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(531, 37);
            this.lblMotif.TabIndex = 29;
            this.lblMotif.Text = "Motif";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.Location = new System.Drawing.Point(39, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Motif";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(39, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bilan de la visite";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 725);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Médicament(s) présenté(s)";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.dgvEchantillons);
            this.panel4.Location = new System.Drawing.Point(583, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 490);
            this.panel4.TabIndex = 25;
            // 
            // dgvEchantillons
            // 
            this.dgvEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillons.Location = new System.Drawing.Point(8, 12);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.Size = new System.Drawing.Size(258, 475);
            this.dgvEchantillons.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBilan);
            this.panel3.Location = new System.Drawing.Point(43, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 221);
            this.panel3.TabIndex = 24;
            // 
            // lblBilan
            // 
            this.lblBilan.Location = new System.Drawing.Point(3, 12);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(456, 199);
            this.lblBilan.TabIndex = 0;
            this.lblBilan.Text = "Bilan";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblSpecialite);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lblType);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lblPraticien);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lblEmail);
            this.panel5.Controls.Add(this.lblRue);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.lblTelephone);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(22, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(811, 237);
            this.panel5.TabIndex = 23;
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialite.Location = new System.Drawing.Point(558, 69);
            this.lblSpecialite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(237, 58);
            this.lblSpecialite.TabIndex = 110;
            this.lblSpecialite.Text = "Spécialité";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label11.Location = new System.Drawing.Point(396, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 107;
            this.label11.Text = "Spécialité";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(558, 18);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(238, 20);
            this.lblType.TabIndex = 109;
            this.lblType.Text = "Type";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 100;
            this.label14.Text = "Praticien";
            // 
            // lblPraticien
            // 
            this.lblPraticien.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPraticien.Location = new System.Drawing.Point(128, 13);
            this.lblPraticien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPraticien.Name = "lblPraticien";
            this.lblPraticien.Size = new System.Drawing.Size(216, 20);
            this.lblPraticien.TabIndex = 101;
            this.lblPraticien.Text = "Praticien";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label10.Location = new System.Drawing.Point(403, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 22);
            this.label10.TabIndex = 106;
            this.label10.Text = "Type praticien";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.Location = new System.Drawing.Point(17, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "Rue";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(128, 184);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 18);
            this.lblEmail.TabIndex = 104;
            this.lblEmail.Text = "Email";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(128, 61);
            this.lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(36, 18);
            this.lblRue.TabIndex = 102;
            this.lblRue.Text = "Rue";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label8.Location = new System.Drawing.Point(17, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 97;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblTelephone
            // 
            this.lblTelephone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(128, 132);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(161, 20);
            this.lblTelephone.TabIndex = 103;
            this.lblTelephone.Text = "Téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.Location = new System.Drawing.Point(17, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 99;
            this.label6.Text = "Téléphone";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.dgvPraticiens);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 875);
            this.panel6.TabIndex = 12;
            // 
            // dgvPraticiens
            // 
            this.dgvPraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPraticiens.Location = new System.Drawing.Point(-5, 81);
            this.dgvPraticiens.Name = "dgvPraticiens";
            this.dgvPraticiens.Size = new System.Drawing.Size(422, 716);
            this.dgvPraticiens.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sélectionner le praticien poura afficher ses cooredonnées et les information conc" +
    "ernant sa dernière visite";
            // 
            // FrmPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 996);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPraticien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPraticien_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbxMedicamament;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvEchantillons;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPraticien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvPraticiens;
        private System.Windows.Forms.Label label2;
    }
}