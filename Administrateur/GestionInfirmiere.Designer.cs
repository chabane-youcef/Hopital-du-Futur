namespace Administrateur
{
    partial class GestionInfirmiere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionInfirmiere));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LvInfirmiere = new System.Windows.Forms.ListView();
            this.IdInfirmiere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomInfirmiere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenomInfirmiere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailInfirmiere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAjouter = new System.Windows.Forms.PictureBox();
            this.BtnModifier = new System.Windows.Forms.PictureBox();
            this.BtnSupprimer = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSupprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 58);
            this.label1.TabIndex = 2;
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
            this.label2.Size = new System.Drawing.Size(263, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Infirmieres";
            // 
            // LvInfirmiere
            // 
            this.LvInfirmiere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdInfirmiere,
            this.NomInfirmiere,
            this.PrenomInfirmiere,
            this.EmailInfirmiere});
            this.LvInfirmiere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvInfirmiere.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvInfirmiere.HideSelection = false;
            this.LvInfirmiere.Location = new System.Drawing.Point(440, 150);
            this.LvInfirmiere.Name = "LvInfirmiere";
            this.LvInfirmiere.Size = new System.Drawing.Size(600, 558);
            this.LvInfirmiere.TabIndex = 3;
            this.LvInfirmiere.UseCompatibleStateImageBehavior = false;
            this.LvInfirmiere.View = System.Windows.Forms.View.Details;
            this.LvInfirmiere.SelectedIndexChanged += new System.EventHandler(this.LvInfirmiere_SelectedIndexChanged);
            // 
            // IdInfirmiere
            // 
            this.IdInfirmiere.Text = "ID";
            // 
            // NomInfirmiere
            // 
            this.NomInfirmiere.Text = "Nom";
            this.NomInfirmiere.Width = 170;
            // 
            // PrenomInfirmiere
            // 
            this.PrenomInfirmiere.Text = "Prenom";
            this.PrenomInfirmiere.Width = 170;
            // 
            // EmailInfirmiere
            // 
            this.EmailInfirmiere.Text = "Email";
            this.EmailInfirmiere.Width = 195;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouter.Image")));
            this.BtnAjouter.Location = new System.Drawing.Point(440, 94);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(100, 30);
            this.BtnAjouter.TabIndex = 4;
            this.BtnAjouter.TabStop = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.Location = new System.Drawing.Point(690, 94);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(100, 30);
            this.BtnModifier.TabIndex = 5;
            this.BtnModifier.TabStop = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.Location = new System.Drawing.Point(940, 94);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(100, 30);
            this.BtnSupprimer.TabIndex = 5;
            this.BtnSupprimer.TabStop = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(40, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 30);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 6;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // GestionInfirmiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.LvInfirmiere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionInfirmiere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionInfirmiere";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAjouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSupprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView LvInfirmiere;
        private System.Windows.Forms.ColumnHeader IdInfirmiere;
        private System.Windows.Forms.ColumnHeader NomInfirmiere;
        private System.Windows.Forms.ColumnHeader PrenomInfirmiere;
        private System.Windows.Forms.ColumnHeader EmailInfirmiere;
        private System.Windows.Forms.PictureBox BtnAjouter;
        private System.Windows.Forms.PictureBox BtnModifier;
        private System.Windows.Forms.PictureBox BtnSupprimer;
        private System.Windows.Forms.PictureBox btnHome;
    }
}