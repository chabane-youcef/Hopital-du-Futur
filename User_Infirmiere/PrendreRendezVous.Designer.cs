namespace User_Infirmiere
{
    partial class PrendreRendezVous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrendreRendezVous));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Prendre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNomPatient = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPrenomPatient = new System.Windows.Forms.TextBox();
            this.txtBoxAgePatient = new System.Windows.Forms.TextBox();
            this.ListMedecinsDisponibles = new System.Windows.Forms.ListView();
            this.idMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specialiteMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsulterCreneaux = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsulterCreneaux)).BeginInit();
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
            // Prendre
            // 
            this.Prendre.AutoSize = true;
            this.Prendre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.Prendre.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prendre.ForeColor = System.Drawing.Color.White;
            this.Prendre.Location = new System.Drawing.Point(30, 98);
            this.Prendre.Name = "Prendre";
            this.Prendre.Size = new System.Drawing.Size(199, 58);
            this.Prendre.TabIndex = 1;
            this.Prendre.Text = "Prendre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 32F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendez-vous";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // txtBoxNomPatient
            // 
            this.txtBoxNomPatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNomPatient.Location = new System.Drawing.Point(500, 122);
            this.txtBoxNomPatient.Name = "txtBoxNomPatient";
            this.txtBoxNomPatient.ReadOnly = true;
            this.txtBoxNomPatient.Size = new System.Drawing.Size(250, 27);
            this.txtBoxNomPatient.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(780, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // txtBoxPrenomPatient
            // 
            this.txtBoxPrenomPatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrenomPatient.Location = new System.Drawing.Point(500, 172);
            this.txtBoxPrenomPatient.Name = "txtBoxPrenomPatient";
            this.txtBoxPrenomPatient.ReadOnly = true;
            this.txtBoxPrenomPatient.Size = new System.Drawing.Size(250, 27);
            this.txtBoxPrenomPatient.TabIndex = 3;
            // 
            // txtBoxAgePatient
            // 
            this.txtBoxAgePatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAgePatient.Location = new System.Drawing.Point(500, 222);
            this.txtBoxAgePatient.Name = "txtBoxAgePatient";
            this.txtBoxAgePatient.ReadOnly = true;
            this.txtBoxAgePatient.Size = new System.Drawing.Size(250, 27);
            this.txtBoxAgePatient.TabIndex = 3;
            // 
            // ListMedecinsDisponibles
            // 
            this.ListMedecinsDisponibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMedecin,
            this.nomMedecin,
            this.prenomMedecin,
            this.specialiteMedecin});
            this.ListMedecinsDisponibles.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMedecinsDisponibles.HideSelection = false;
            this.ListMedecinsDisponibles.Location = new System.Drawing.Point(350, 308);
            this.ListMedecinsDisponibles.Name = "ListMedecinsDisponibles";
            this.ListMedecinsDisponibles.Size = new System.Drawing.Size(400, 291);
            this.ListMedecinsDisponibles.TabIndex = 5;
            this.ListMedecinsDisponibles.UseCompatibleStateImageBehavior = false;
            this.ListMedecinsDisponibles.View = System.Windows.Forms.View.Details;
            this.ListMedecinsDisponibles.SelectedIndexChanged += new System.EventHandler(this.ListMedecinsDisponibles_SelectedIndexChanged);
            // 
            // idMedecin
            // 
            this.idMedecin.Text = "ID";
            // 
            // nomMedecin
            // 
            this.nomMedecin.Text = "Nom";
            this.nomMedecin.Width = 100;
            // 
            // prenomMedecin
            // 
            this.prenomMedecin.Text = "Prenom";
            this.prenomMedecin.Width = 100;
            // 
            // specialiteMedecin
            // 
            this.specialiteMedecin.Text = "Specialite";
            this.specialiteMedecin.Width = 140;
            // 
            // btnConsulterCreneaux
            // 
            this.btnConsulterCreneaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulterCreneaux.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulterCreneaux.Image")));
            this.btnConsulterCreneaux.Location = new System.Drawing.Point(550, 625);
            this.btnConsulterCreneaux.Name = "btnConsulterCreneaux";
            this.btnConsulterCreneaux.Size = new System.Drawing.Size(200, 30);
            this.btnConsulterCreneaux.TabIndex = 6;
            this.btnConsulterCreneaux.TabStop = false;
            this.btnConsulterCreneaux.Click += new System.EventHandler(this.btnConsulterCreneaux_Click);
            // 
            // PrendreRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.btnConsulterCreneaux);
            this.Controls.Add(this.ListMedecinsDisponibles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBoxAgePatient);
            this.Controls.Add(this.txtBoxPrenomPatient);
            this.Controls.Add(this.txtBoxNomPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prendre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrendreRendezVous";
            this.Text = "PrendreRendezVous";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsulterCreneaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Prendre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBoxNomPatient;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBoxPrenomPatient;
        public System.Windows.Forms.TextBox txtBoxAgePatient;
        public System.Windows.Forms.ListView ListMedecinsDisponibles;
        private System.Windows.Forms.ColumnHeader idMedecin;
        private System.Windows.Forms.ColumnHeader nomMedecin;
        private System.Windows.Forms.ColumnHeader prenomMedecin;
        private System.Windows.Forms.ColumnHeader specialiteMedecin;
        private System.Windows.Forms.PictureBox btnConsulterCreneaux;
    }
}