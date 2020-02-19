namespace User_Medecin
{
    partial class historiqueConsultations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiqueConsultations));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.listPatients = new System.Windows.Forms.ListView();
            this.idConsultation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.agePatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consultationsPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHistorique = new System.Windows.Forms.PictureBox();
            this.idPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistorique)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(248, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patients";
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
            // listPatients
            // 
            this.listPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idConsultation,
            this.idPatient,
            this.nomPatient,
            this.prenomPatient,
            this.agePatient,
            this.consultationsPatient});
            this.listPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listPatients.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPatients.HideSelection = false;
            this.listPatients.Location = new System.Drawing.Point(425, 150);
            this.listPatients.Name = "listPatients";
            this.listPatients.Size = new System.Drawing.Size(600, 450);
            this.listPatients.TabIndex = 3;
            this.listPatients.UseCompatibleStateImageBehavior = false;
            this.listPatients.View = System.Windows.Forms.View.Details;
            this.listPatients.SelectedIndexChanged += new System.EventHandler(this.listPatients_SelectedIndexChanged);
            // 
            // idConsultation
            // 
            this.idConsultation.Text = "ID";
            // 
            // nomPatient
            // 
            this.nomPatient.Text = "Nom";
            this.nomPatient.Width = 120;
            // 
            // prenomPatient
            // 
            this.prenomPatient.Text = "Prenom";
            this.prenomPatient.Width = 120;
            // 
            // agePatient
            // 
            this.agePatient.Text = "Age";
            this.agePatient.Width = 100;
            // 
            // consultationsPatient
            // 
            this.consultationsPatient.Text = "nombre Consultations";
            this.consultationsPatient.Width = 200;
            // 
            // btnHistorique
            // 
            this.btnHistorique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorique.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorique.Image")));
            this.btnHistorique.Location = new System.Drawing.Point(825, 606);
            this.btnHistorique.Name = "btnHistorique";
            this.btnHistorique.Size = new System.Drawing.Size(200, 30);
            this.btnHistorique.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHistorique.TabIndex = 4;
            this.btnHistorique.TabStop = false;
            this.btnHistorique.Click += new System.EventHandler(this.btnHistorique_Click_1);
            // 
            // idPatient
            // 
            this.idPatient.DisplayIndex = 5;
            this.idPatient.Text = "ID Patient";
            this.idPatient.Width = 0;
            // 
            // historiqueConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnHistorique);
            this.Controls.Add(this.listPatients);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "historiqueConsultations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "historiqueConsultations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistorique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        public System.Windows.Forms.ListView listPatients;
        private System.Windows.Forms.ColumnHeader idConsultation;
        private System.Windows.Forms.ColumnHeader nomPatient;
        private System.Windows.Forms.ColumnHeader prenomPatient;
        private System.Windows.Forms.ColumnHeader agePatient;
        private System.Windows.Forms.ColumnHeader consultationsPatient;
        private System.Windows.Forms.PictureBox btnHistorique;
        private System.Windows.Forms.ColumnHeader idPatient;
    }
}