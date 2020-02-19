namespace User_Medecin
{
    partial class ConsulterRendezVous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterRendezVous));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.listRendezvous = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supprimerRendezvousBtn = new System.Windows.Forms.PictureBox();
            this.consulterPatientBtn = new System.Windows.Forms.PictureBox();
            this.idPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimerRendezvousBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulterPatientBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendez-vous";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1060, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listRendezvous
            // 
            this.listRendezvous.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.idPatient,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listRendezvous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listRendezvous.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRendezvous.HideSelection = false;
            this.listRendezvous.Location = new System.Drawing.Point(446, 130);
            this.listRendezvous.Name = "listRendezvous";
            this.listRendezvous.Size = new System.Drawing.Size(600, 470);
            this.listRendezvous.TabIndex = 3;
            this.listRendezvous.UseCompatibleStateImageBehavior = false;
            this.listRendezvous.View = System.Windows.Forms.View.Details;
            this.listRendezvous.SelectedIndexChanged += new System.EventHandler(this.listRendezvous_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jour";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Heure";
            this.columnHeader6.Width = 140;
            // 
            // supprimerRendezvousBtn
            // 
            this.supprimerRendezvousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimerRendezvousBtn.Image = ((System.Drawing.Image)(resources.GetObject("supprimerRendezvousBtn.Image")));
            this.supprimerRendezvousBtn.Location = new System.Drawing.Point(624, 606);
            this.supprimerRendezvousBtn.Name = "supprimerRendezvousBtn";
            this.supprimerRendezvousBtn.Size = new System.Drawing.Size(200, 30);
            this.supprimerRendezvousBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.supprimerRendezvousBtn.TabIndex = 4;
            this.supprimerRendezvousBtn.TabStop = false;
            this.supprimerRendezvousBtn.Click += new System.EventHandler(this.supprimerRendezvousBtn_Click);
            // 
            // consulterPatientBtn
            // 
            this.consulterPatientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consulterPatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("consulterPatientBtn.Image")));
            this.consulterPatientBtn.Location = new System.Drawing.Point(846, 606);
            this.consulterPatientBtn.Name = "consulterPatientBtn";
            this.consulterPatientBtn.Size = new System.Drawing.Size(200, 30);
            this.consulterPatientBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.consulterPatientBtn.TabIndex = 5;
            this.consulterPatientBtn.TabStop = false;
            this.consulterPatientBtn.Click += new System.EventHandler(this.consulterPatientBtn_Click);
            // 
            // idPatient
            // 
            this.idPatient.Text = "idPatient";
            this.idPatient.Width = 0;
            // 
            // ConsulterRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.consulterPatientBtn);
            this.Controls.Add(this.supprimerRendezvousBtn);
            this.Controls.Add(this.listRendezvous);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsulterRendezVous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsulterRendezVous";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimerRendezvousBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulterPatientBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        public System.Windows.Forms.ListView listRendezvous;
        private System.Windows.Forms.PictureBox supprimerRendezvousBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox consulterPatientBtn;
        private System.Windows.Forms.ColumnHeader idPatient;
    }
}