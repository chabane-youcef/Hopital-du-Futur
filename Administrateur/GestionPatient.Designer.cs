namespace Administrateur
{
    partial class GestionPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPatient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lvPatients = new System.Windows.Forms.ListView();
            this.IdPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenomPatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgePatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaladePatient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAjouterPatient = new System.Windows.Forms.PictureBox();
            this.BtnModifierPatient = new System.Windows.Forms.PictureBox();
            this.BtnSupprimerPatient = new System.Windows.Forms.PictureBox();
            this.BtnProfilPatient = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjouterPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModifierPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSupprimerPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProfilPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patients";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1060, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lvPatients
            // 
            this.lvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPatient,
            this.NomPatient,
            this.PrenomPatient,
            this.AgePatient,
            this.MaladePatient});
            this.lvPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPatients.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPatients.HideSelection = false;
            this.lvPatients.Location = new System.Drawing.Point(360, 150);
            this.lvPatients.Name = "lvPatients";
            this.lvPatients.Size = new System.Drawing.Size(700, 550);
            this.lvPatients.TabIndex = 3;
            this.lvPatients.UseCompatibleStateImageBehavior = false;
            this.lvPatients.View = System.Windows.Forms.View.Details;
            this.lvPatients.SelectedIndexChanged += new System.EventHandler(this.lvPatients_SelectedIndexChanged);
            // 
            // IdPatient
            // 
            this.IdPatient.Text = "ID";
            // 
            // NomPatient
            // 
            this.NomPatient.Text = "Nom";
            this.NomPatient.Width = 150;
            // 
            // PrenomPatient
            // 
            this.PrenomPatient.Text = "Prenom";
            this.PrenomPatient.Width = 150;
            // 
            // AgePatient
            // 
            this.AgePatient.Text = "Age";
            this.AgePatient.Width = 150;
            // 
            // MaladePatient
            // 
            this.MaladePatient.Text = "Type de Malade";
            this.MaladePatient.Width = 200;
            // 
            // BtnAjouterPatient
            // 
            this.BtnAjouterPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAjouterPatient.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouterPatient.Image")));
            this.BtnAjouterPatient.Location = new System.Drawing.Point(360, 100);
            this.BtnAjouterPatient.Name = "BtnAjouterPatient";
            this.BtnAjouterPatient.Size = new System.Drawing.Size(100, 30);
            this.BtnAjouterPatient.TabIndex = 4;
            this.BtnAjouterPatient.TabStop = false;
            this.BtnAjouterPatient.Click += new System.EventHandler(this.BtnAjouterPatient_Click);
            // 
            // BtnModifierPatient
            // 
            this.BtnModifierPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModifierPatient.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifierPatient.Image")));
            this.BtnModifierPatient.Location = new System.Drawing.Point(550, 100);
            this.BtnModifierPatient.Name = "BtnModifierPatient";
            this.BtnModifierPatient.Size = new System.Drawing.Size(100, 30);
            this.BtnModifierPatient.TabIndex = 4;
            this.BtnModifierPatient.TabStop = false;
            this.BtnModifierPatient.Click += new System.EventHandler(this.BtnModifierPatient_Click);
            // 
            // BtnSupprimerPatient
            // 
            this.BtnSupprimerPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSupprimerPatient.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimerPatient.Image")));
            this.BtnSupprimerPatient.Location = new System.Drawing.Point(750, 100);
            this.BtnSupprimerPatient.Name = "BtnSupprimerPatient";
            this.BtnSupprimerPatient.Size = new System.Drawing.Size(100, 30);
            this.BtnSupprimerPatient.TabIndex = 4;
            this.BtnSupprimerPatient.TabStop = false;
            this.BtnSupprimerPatient.Click += new System.EventHandler(this.BtnSupprimerPatient_Click);
            // 
            // BtnProfilPatient
            // 
            this.BtnProfilPatient.Image = ((System.Drawing.Image)(resources.GetObject("BtnProfilPatient.Image")));
            this.BtnProfilPatient.Location = new System.Drawing.Point(960, 100);
            this.BtnProfilPatient.Name = "BtnProfilPatient";
            this.BtnProfilPatient.Size = new System.Drawing.Size(100, 30);
            this.BtnProfilPatient.TabIndex = 4;
            this.BtnProfilPatient.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // GestionPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnProfilPatient);
            this.Controls.Add(this.BtnSupprimerPatient);
            this.Controls.Add(this.BtnModifierPatient);
            this.Controls.Add(this.BtnAjouterPatient);
            this.Controls.Add(this.lvPatients);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionPatient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjouterPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModifierPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSupprimerPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProfilPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ListView lvPatients;
        private System.Windows.Forms.ColumnHeader IdPatient;
        private System.Windows.Forms.ColumnHeader NomPatient;
        private System.Windows.Forms.ColumnHeader PrenomPatient;
        private System.Windows.Forms.ColumnHeader AgePatient;
        private System.Windows.Forms.PictureBox BtnAjouterPatient;
        private System.Windows.Forms.PictureBox BtnModifierPatient;
        private System.Windows.Forms.PictureBox BtnSupprimerPatient;
        private System.Windows.Forms.PictureBox BtnProfilPatient;
        private System.Windows.Forms.ColumnHeader MaladePatient;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}