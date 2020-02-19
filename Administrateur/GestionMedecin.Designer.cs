namespace Administrateur
{
    partial class GestionMedecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMedecin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LvMedecins = new System.Windows.Forms.ListView();
            this.IdMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenomMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpecialiteMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordMedecin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMedecin = new System.Windows.Forms.PictureBox();
            this.btnDeleteMedecin = new System.Windows.Forms.PictureBox();
            this.btnUpdateMedecin = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1060, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 720);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LvMedecins
            // 
            this.LvMedecins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdMedecin,
            this.NomMedecin,
            this.PrenomMedecin,
            this.EmailMedecin,
            this.SpecialiteMedecin,
            this.passwordMedecin});
            this.LvMedecins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvMedecins.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvMedecins.HideSelection = false;
            this.LvMedecins.Location = new System.Drawing.Point(440, 150);
            this.LvMedecins.Name = "LvMedecins";
            this.LvMedecins.Size = new System.Drawing.Size(600, 558);
            this.LvMedecins.TabIndex = 2;
            this.LvMedecins.UseCompatibleStateImageBehavior = false;
            this.LvMedecins.View = System.Windows.Forms.View.Details;
            this.LvMedecins.SelectedIndexChanged += new System.EventHandler(this.LvMedecins_SelectedIndexChanged);
            // 
            // IdMedecin
            // 
            this.IdMedecin.Text = "ID";
            // 
            // NomMedecin
            // 
            this.NomMedecin.Text = "Nom";
            this.NomMedecin.Width = 130;
            // 
            // PrenomMedecin
            // 
            this.PrenomMedecin.Text = "Prenom";
            this.PrenomMedecin.Width = 130;
            // 
            // EmailMedecin
            // 
            this.EmailMedecin.Text = "Email";
            this.EmailMedecin.Width = 160;
            // 
            // SpecialiteMedecin
            // 
            this.SpecialiteMedecin.Text = "Specialite";
            this.SpecialiteMedecin.Width = 125;
            // 
            // passwordMedecin
            // 
            this.passwordMedecin.Text = "passpword";
            this.passwordMedecin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordMedecin.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medecins";
            // 
            // btnAddMedecin
            // 
            this.btnAddMedecin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedecin.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedecin.Image")));
            this.btnAddMedecin.Location = new System.Drawing.Point(440, 100);
            this.btnAddMedecin.Name = "btnAddMedecin";
            this.btnAddMedecin.Size = new System.Drawing.Size(100, 30);
            this.btnAddMedecin.TabIndex = 4;
            this.btnAddMedecin.TabStop = false;
            this.btnAddMedecin.Click += new System.EventHandler(this.btnAddMedecin_Click);
            // 
            // btnDeleteMedecin
            // 
            this.btnDeleteMedecin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMedecin.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMedecin.Image")));
            this.btnDeleteMedecin.Location = new System.Drawing.Point(940, 100);
            this.btnDeleteMedecin.Name = "btnDeleteMedecin";
            this.btnDeleteMedecin.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteMedecin.TabIndex = 5;
            this.btnDeleteMedecin.TabStop = false;
            this.btnDeleteMedecin.Click += new System.EventHandler(this.btnDeleteMedecin_Click);
            // 
            // btnUpdateMedecin
            // 
            this.btnUpdateMedecin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMedecin.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMedecin.Image")));
            this.btnUpdateMedecin.Location = new System.Drawing.Point(690, 100);
            this.btnUpdateMedecin.Name = "btnUpdateMedecin";
            this.btnUpdateMedecin.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateMedecin.TabIndex = 5;
            this.btnUpdateMedecin.TabStop = false;
            this.btnUpdateMedecin.Click += new System.EventHandler(this.btnUpdateMedecin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(40, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // GestionMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnUpdateMedecin);
            this.Controls.Add(this.btnDeleteMedecin);
            this.Controls.Add(this.btnAddMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LvMedecins);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionMedecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ListView LvMedecins;
        private System.Windows.Forms.ColumnHeader IdMedecin;
        private System.Windows.Forms.ColumnHeader NomMedecin;
        private System.Windows.Forms.ColumnHeader PrenomMedecin;
        private System.Windows.Forms.ColumnHeader EmailMedecin;
        private System.Windows.Forms.ColumnHeader SpecialiteMedecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnAddMedecin;
        private System.Windows.Forms.PictureBox btnDeleteMedecin;
        private System.Windows.Forms.PictureBox btnUpdateMedecin;
        private System.Windows.Forms.ColumnHeader passwordMedecin;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}