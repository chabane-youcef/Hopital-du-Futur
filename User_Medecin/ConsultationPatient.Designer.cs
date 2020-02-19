namespace User_Medecin
{
    partial class ConsultationPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationPatient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBoxTraitement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnregistrementEtat = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaladie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnregistrementEtat)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(177, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(550, 123);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(400, 27);
            this.textBoxNom.TabIndex = 4;
            // 
            // comboBoxTraitement
            // 
            this.comboBoxTraitement.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTraitement.FormattingEnabled = true;
            this.comboBoxTraitement.Location = new System.Drawing.Point(550, 323);
            this.comboBoxTraitement.Name = "comboBoxTraitement";
            this.comboBoxTraitement.Size = new System.Drawing.Size(400, 27);
            this.comboBoxTraitement.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(550, 173);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.ReadOnly = true;
            this.textBoxPrenom.Size = new System.Drawing.Size(400, 27);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Traitement";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNote.Location = new System.Drawing.Point(550, 373);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(400, 150);
            this.textBoxNote.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Note";
            // 
            // btnEnregistrementEtat
            // 
            this.btnEnregistrementEtat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrementEtat.Image = ((System.Drawing.Image)(resources.GetObject("btnEnregistrementEtat.Image")));
            this.btnEnregistrementEtat.Location = new System.Drawing.Point(750, 575);
            this.btnEnregistrementEtat.Name = "btnEnregistrementEtat";
            this.btnEnregistrementEtat.Size = new System.Drawing.Size(200, 30);
            this.btnEnregistrementEtat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEnregistrementEtat.TabIndex = 7;
            this.btnEnregistrementEtat.TabStop = false;
            this.btnEnregistrementEtat.Click += new System.EventHandler(this.btnEnregistrementEtat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Maladie";
            // 
            // textBoxMaladie
            // 
            this.textBoxMaladie.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaladie.Location = new System.Drawing.Point(550, 273);
            this.textBoxMaladie.Name = "textBoxMaladie";
            this.textBoxMaladie.Size = new System.Drawing.Size(400, 27);
            this.textBoxMaladie.TabIndex = 4;
            // 
            // ConsultationPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnEnregistrementEtat);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.comboBoxTraitement);
            this.Controls.Add(this.textBoxMaladie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultationPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultationPatient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnregistrementEtat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxNom;
        public System.Windows.Forms.ComboBox comboBoxTraitement;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnEnregistrementEtat;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxMaladie;
    }
}