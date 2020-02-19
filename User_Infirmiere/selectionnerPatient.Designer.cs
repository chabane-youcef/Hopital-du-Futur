namespace User_Infirmiere
{
    partial class selectionnerPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectionnerPatient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJourCreneaux = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDateCreneaux = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHeureCreneaux = new System.Windows.Forms.TextBox();
            this.lvPatients = new System.Windows.Forms.ListView();
            this.idPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.agepatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.btnReserver = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReserver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jour";
            // 
            // textBoxJourCreneaux
            // 
            this.textBoxJourCreneaux.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJourCreneaux.Location = new System.Drawing.Point(500, 100);
            this.textBoxJourCreneaux.Name = "textBoxJourCreneaux";
            this.textBoxJourCreneaux.ReadOnly = true;
            this.textBoxJourCreneaux.Size = new System.Drawing.Size(200, 27);
            this.textBoxJourCreneaux.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // textBoxDateCreneaux
            // 
            this.textBoxDateCreneaux.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateCreneaux.Location = new System.Drawing.Point(500, 150);
            this.textBoxDateCreneaux.Name = "textBoxDateCreneaux";
            this.textBoxDateCreneaux.ReadOnly = true;
            this.textBoxDateCreneaux.Size = new System.Drawing.Size(200, 27);
            this.textBoxDateCreneaux.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Heure";
            // 
            // textBoxHeureCreneaux
            // 
            this.textBoxHeureCreneaux.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeureCreneaux.Location = new System.Drawing.Point(500, 200);
            this.textBoxHeureCreneaux.Name = "textBoxHeureCreneaux";
            this.textBoxHeureCreneaux.ReadOnly = true;
            this.textBoxHeureCreneaux.Size = new System.Drawing.Size(200, 27);
            this.textBoxHeureCreneaux.TabIndex = 3;
            // 
            // lvPatients
            // 
            this.lvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPatient,
            this.nomPatient,
            this.prenomPatient,
            this.agepatient});
            this.lvPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPatients.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPatients.HideSelection = false;
            this.lvPatients.Location = new System.Drawing.Point(338, 309);
            this.lvPatients.Name = "lvPatients";
            this.lvPatients.Size = new System.Drawing.Size(450, 300);
            this.lvPatients.TabIndex = 4;
            this.lvPatients.UseCompatibleStateImageBehavior = false;
            this.lvPatients.View = System.Windows.Forms.View.Details;
            this.lvPatients.SelectedIndexChanged += new System.EventHandler(this.lvPatients_SelectedIndexChanged);
            // 
            // idPatient
            // 
            this.idPatient.Text = "ID";
            // 
            // nomPatient
            // 
            this.nomPatient.Text = "Nom";
            this.nomPatient.Width = 150;
            // 
            // prenomPatient
            // 
            this.prenomPatient.Text = "Prenom";
            this.prenomPatient.Width = 150;
            // 
            // agepatient
            // 
            this.agepatient.Text = "Age";
            this.agepatient.Width = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "selectionner Patient";
            // 
            // btnReserver
            // 
            this.btnReserver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserver.Image = ((System.Drawing.Image)(resources.GetObject("btnReserver.Image")));
            this.btnReserver.Location = new System.Drawing.Point(588, 630);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(200, 30);
            this.btnReserver.TabIndex = 5;
            this.btnReserver.TabStop = false;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(780, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // selectionnerPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.lvPatients);
            this.Controls.Add(this.textBoxHeureCreneaux);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDateCreneaux);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxJourCreneaux);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectionnerPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "selectionnerMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReserver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxJourCreneaux;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxDateCreneaux;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxHeureCreneaux;
        public System.Windows.Forms.ListView lvPatients;
        private System.Windows.Forms.ColumnHeader idPatient;
        private System.Windows.Forms.ColumnHeader nomPatient;
        private System.Windows.Forms.ColumnHeader prenomPatient;
        private System.Windows.Forms.ColumnHeader agepatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnReserver;
        private System.Windows.Forms.PictureBox btnExit;
    }
}