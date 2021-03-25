
namespace GSB
{
    partial class FrmMedicament
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblContreIndic = new System.Windows.Forms.Label();
            this.lblEffet = new System.Windows.Forms.Label();
            this.lblComposition = new System.Windows.Forms.Label();
            this.lblFamille = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brnValider = new System.Windows.Forms.Button();
            this.lbxMedicaments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(1353, 64);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.brnValider);
            this.panel1.Controls.Add(this.lbxMedicaments);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 805);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblContreIndic);
            this.panel3.Controls.Add(this.lblEffet);
            this.panel3.Controls.Add(this.lblComposition);
            this.panel3.Controls.Add(this.lblFamille);
            this.panel3.Location = new System.Drawing.Point(275, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 754);
            this.panel3.TabIndex = 4;
            // 
            // lblContreIndic
            // 
            this.lblContreIndic.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContreIndic.Location = new System.Drawing.Point(21, 613);
            this.lblContreIndic.Name = "lblContreIndic";
            this.lblContreIndic.Size = new System.Drawing.Size(959, 94);
            this.lblContreIndic.TabIndex = 3;
            this.lblContreIndic.Text = "Contre Indication";
            // 
            // lblEffet
            // 
            this.lblEffet.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblEffet.Location = new System.Drawing.Point(21, 358);
            this.lblEffet.Name = "lblEffet";
            this.lblEffet.Size = new System.Drawing.Size(966, 181);
            this.lblEffet.TabIndex = 2;
            this.lblEffet.Text = "Effet";
            // 
            // lblComposition
            // 
            this.lblComposition.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblComposition.Location = new System.Drawing.Point(21, 191);
            this.lblComposition.Name = "lblComposition";
            this.lblComposition.Size = new System.Drawing.Size(979, 183);
            this.lblComposition.TabIndex = 1;
            this.lblComposition.Text = "composition";
            // 
            // lblFamille
            // 
            this.lblFamille.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblFamille.Location = new System.Drawing.Point(21, 30);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(750, 71);
            this.lblFamille.TabIndex = 0;
            this.lblFamille.Text = "Famille";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(8, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 754);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contre indication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Effet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Composition";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Famille";
            // 
            // brnValider
            // 
            this.brnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(193)))), ((int)(((byte)(28)))));
            this.brnValider.Font = new System.Drawing.Font("Arial", 12F);
            this.brnValider.Location = new System.Drawing.Point(406, 3);
            this.brnValider.Name = "brnValider";
            this.brnValider.Size = new System.Drawing.Size(110, 31);
            this.brnValider.TabIndex = 2;
            this.brnValider.Text = "Rechercher";
            this.brnValider.UseVisualStyleBackColor = false;
            // 
            // lbxMedicaments
            // 
            this.lbxMedicaments.FormattingEnabled = true;
            this.lbxMedicaments.Location = new System.Drawing.Point(159, 4);
            this.lbxMedicaments.Name = "lbxMedicaments";
            this.lbxMedicaments.Size = new System.Drawing.Size(212, 30);
            this.lbxMedicaments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médicament";
            // 
            // FrmMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 996);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMedicament";
            this.Text = "frmMedicament";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brnValider;
        private System.Windows.Forms.ListBox lbxMedicaments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblContreIndic;
        private System.Windows.Forms.Label lblEffet;
        private System.Windows.Forms.Label lblComposition;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}