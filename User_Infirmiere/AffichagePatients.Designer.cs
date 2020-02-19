namespace User_Infirmiere
{
    partial class AffichagePatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichagePatients));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewPatients = new System.Windows.Forms.ListView();
            this.idPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.agePatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConsulterRendezVous = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsulterRendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(780, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patients";
            // 
            // listViewPatients
            // 
            this.listViewPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPatient,
            this.nomPatient,
            this.prenomPatient,
            this.agePatient});
            this.listViewPatients.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPatients.HideSelection = false;
            this.listViewPatients.Location = new System.Drawing.Point(325, 100);
            this.listViewPatients.Name = "listViewPatients";
            this.listViewPatients.Size = new System.Drawing.Size(450, 450);
            this.listViewPatients.TabIndex = 3;
            this.listViewPatients.UseCompatibleStateImageBehavior = false;
            this.listViewPatients.View = System.Windows.Forms.View.Details;
            this.listViewPatients.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idPatient
            // 
            this.idPatient.Text = "ID";
            // 
            // nomPatient
            // 
            this.nomPatient.Text = "Nom";
            this.nomPatient.Width = 160;
            // 
            // prenomPatient
            // 
            this.prenomPatient.Text = "Prenom";
            this.prenomPatient.Width = 160;
            // 
            // agePatient
            // 
            this.agePatient.Text = "Age";
            this.agePatient.Width = 66;
            // 
            // ConsulterRendezVous
            // 
            this.ConsulterRendezVous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsulterRendezVous.Image = ((System.Drawing.Image)(resources.GetObject("ConsulterRendezVous.Image")));
            this.ConsulterRendezVous.Location = new System.Drawing.Point(575, 591);
            this.ConsulterRendezVous.Name = "ConsulterRendezVous";
            this.ConsulterRendezVous.Size = new System.Drawing.Size(200, 30);
            this.ConsulterRendezVous.TabIndex = 4;
            this.ConsulterRendezVous.TabStop = false;
            this.ConsulterRendezVous.Click += new System.EventHandler(this.ConsulterRendezVous_Click);
            // 
            // AffichagePatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.ConsulterRendezVous);
            this.Controls.Add(this.listViewPatients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AffichagePatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AffichagePatients";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsulterRendezVous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView listViewPatients;
        private System.Windows.Forms.ColumnHeader idPatient;
        private System.Windows.Forms.ColumnHeader nomPatient;
        private System.Windows.Forms.ColumnHeader prenomPatient;
        private System.Windows.Forms.ColumnHeader agePatient;
        private System.Windows.Forms.PictureBox ConsulterRendezVous;
    }
}