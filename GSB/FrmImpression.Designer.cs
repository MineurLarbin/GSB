
namespace GSB
{
    partial class FrmImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpression));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgApercu = new System.Windows.Forms.PictureBox();
            this.imgImprimer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printRDV = new System.Windows.Forms.PrintDialog();
            this.apercuRDV = new System.Windows.Forms.PrintPreviewDialog();
            this.choixImprimante = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgApercu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(1353, 64);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgApercu);
            this.panel1.Controls.Add(this.imgImprimer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 834);
            this.panel1.TabIndex = 0;
            // 
            // imgApercu
            // 
            this.imgApercu.BackgroundImage = global::GSB.Properties.Resources.apercu;
            this.imgApercu.Location = new System.Drawing.Point(486, 169);
            this.imgApercu.Name = "imgApercu";
            this.imgApercu.Size = new System.Drawing.Size(192, 267);
            this.imgApercu.TabIndex = 6;
            this.imgApercu.TabStop = false;
            // 
            // imgImprimer
            // 
            this.imgImprimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgImprimer.BackgroundImage = global::GSB.Properties.Resources.imprimer;
            this.imgImprimer.InitialImage = global::GSB.Properties.Resources.imprimer;
            this.imgImprimer.Location = new System.Drawing.Point(733, 169);
            this.imgImprimer.Name = "imgImprimer";
            this.imgImprimer.Size = new System.Drawing.Size(144, 138);
            this.imgImprimer.TabIndex = 5;
            this.imgImprimer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(504, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Au";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(503, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Du";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(551, 113);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printRDV
            // 
            this.printRDV.UseEXDialog = true;
            // 
            // apercuRDV
            // 
            this.apercuRDV.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.apercuRDV.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.apercuRDV.ClientSize = new System.Drawing.Size(400, 300);
            this.apercuRDV.Enabled = true;
            this.apercuRDV.Icon = ((System.Drawing.Icon)(resources.GetObject("apercuRDV.Icon")));
            this.apercuRDV.Name = "apercuRDV";
            this.apercuRDV.Visible = false;
            // 
            // choixImprimante
            // 
            this.choixImprimante.UseEXDialog = true;
            // 
            // FrmImpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 996);
            this.Controls.Add(this.panel1);
            this.Name = "FrmImpression";
            this.Text = "FrmImpression";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgApercu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgImprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgApercu;
        private System.Windows.Forms.PrintDialog printRDV;
        private System.Windows.Forms.PrintPreviewDialog apercuRDV;
        private System.Windows.Forms.PrintDialog choixImprimante;
    }
}