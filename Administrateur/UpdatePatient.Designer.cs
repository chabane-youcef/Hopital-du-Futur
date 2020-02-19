namespace Administrateur
{
    partial class UpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePatient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.AgePatient = new System.Windows.Forms.Label();
            this.btnModifierPatient = new System.Windows.Forms.PictureBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblIdPatient = new System.Windows.Forms.Label();
            this.comboBoxSpecialite = new System.Windows.Forms.ComboBox();
            this.MaladiePatient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifierPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 620);
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
            this.label1.Size = new System.Drawing.Size(200, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modifier";
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
            this.btnExit.Location = new System.Drawing.Point(680, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(350, 160);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(250, 27);
            this.textBoxNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(350, 140);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(43, 19);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(350, 230);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(250, 27);
            this.textBoxPrenom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(350, 210);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(67, 19);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prenom";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(350, 300);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(250, 27);
            this.textBoxAge.TabIndex = 3;
            // 
            // AgePatient
            // 
            this.AgePatient.AutoSize = true;
            this.AgePatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgePatient.Location = new System.Drawing.Point(350, 280);
            this.AgePatient.Name = "AgePatient";
            this.AgePatient.Size = new System.Drawing.Size(37, 19);
            this.AgePatient.TabIndex = 4;
            this.AgePatient.Text = "Age";
            // 
            // btnModifierPatient
            // 
            this.btnModifierPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierPatient.Image")));
            this.btnModifierPatient.Location = new System.Drawing.Point(500, 450);
            this.btnModifierPatient.Name = "btnModifierPatient";
            this.btnModifierPatient.Size = new System.Drawing.Size(100, 30);
            this.btnModifierPatient.TabIndex = 5;
            this.btnModifierPatient.TabStop = false;
            this.btnModifierPatient.Click += new System.EventHandler(this.btnModifierPatient_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(350, 100);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(250, 27);
            this.textBoxId.TabIndex = 3;
            // 
            // lblIdPatient
            // 
            this.lblIdPatient.AutoSize = true;
            this.lblIdPatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPatient.Location = new System.Drawing.Point(350, 80);
            this.lblIdPatient.Name = "lblIdPatient";
            this.lblIdPatient.Size = new System.Drawing.Size(24, 19);
            this.lblIdPatient.TabIndex = 4;
            this.lblIdPatient.Text = "ID";
            // 
            // comboBoxSpecialite
            // 
            this.comboBoxSpecialite.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpecialite.FormattingEnabled = true;
            this.comboBoxSpecialite.Location = new System.Drawing.Point(350, 370);
            this.comboBoxSpecialite.Name = "comboBoxSpecialite";
            this.comboBoxSpecialite.Size = new System.Drawing.Size(250, 27);
            this.comboBoxSpecialite.TabIndex = 6;
            // 
            // MaladiePatient
            // 
            this.MaladiePatient.AutoSize = true;
            this.MaladiePatient.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaladiePatient.Location = new System.Drawing.Point(350, 350);
            this.MaladiePatient.Name = "MaladiePatient";
            this.MaladiePatient.Size = new System.Drawing.Size(125, 19);
            this.MaladiePatient.TabIndex = 4;
            this.MaladiePatient.Text = "Type de Maladie";
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 620);
            this.Controls.Add(this.comboBoxSpecialite);
            this.Controls.Add(this.btnModifierPatient);
            this.Controls.Add(this.MaladiePatient);
            this.Controls.Add(this.AgePatient);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblIdPatient);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePatient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModifierPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        public System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        public System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label AgePatient;
        private System.Windows.Forms.PictureBox btnModifierPatient;
        public System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblIdPatient;
        public System.Windows.Forms.ComboBox comboBoxSpecialite;
        private System.Windows.Forms.Label MaladiePatient;
    }
}