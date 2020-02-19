namespace User_Infirmiere
{
    partial class MedecinsDiponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedecinsDiponibles));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsulterCreneaux = new System.Windows.Forms.PictureBox();
            this.listViewMedecins = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specialite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(232, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creneaux";
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
            this.label2.TabIndex = 1;
            this.label2.Text = "Medecins";
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
            // comboBoxSearch
            // 
            this.comboBoxSearch.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(830, 150);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(200, 27);
            this.comboBoxSearch.TabIndex = 4;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(701, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specialite :";
            // 
            // btnConsulterCreneaux
            // 
            this.btnConsulterCreneaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulterCreneaux.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulterCreneaux.Image")));
            this.btnConsulterCreneaux.Location = new System.Drawing.Point(830, 620);
            this.btnConsulterCreneaux.Name = "btnConsulterCreneaux";
            this.btnConsulterCreneaux.Size = new System.Drawing.Size(200, 30);
            this.btnConsulterCreneaux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnConsulterCreneaux.TabIndex = 6;
            this.btnConsulterCreneaux.TabStop = false;
            this.btnConsulterCreneaux.Click += new System.EventHandler(this.btnConsulterCreneaux_Click);
            // 
            // listViewMedecins
            // 
            this.listViewMedecins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nom,
            this.prenom,
            this.specialite});
            this.listViewMedecins.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMedecins.HideSelection = false;
            this.listViewMedecins.Location = new System.Drawing.Point(430, 200);
            this.listViewMedecins.Name = "listViewMedecins";
            this.listViewMedecins.Size = new System.Drawing.Size(600, 400);
            this.listViewMedecins.TabIndex = 7;
            this.listViewMedecins.UseCompatibleStateImageBehavior = false;
            this.listViewMedecins.View = System.Windows.Forms.View.Details;
            this.listViewMedecins.SelectedIndexChanged += new System.EventHandler(this.listViewMedecins_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 140;
            // 
            // prenom
            // 
            this.prenom.Text = "Prenom";
            this.prenom.Width = 140;
            // 
            // specialite
            // 
            this.specialite.Text = "Specialite";
            this.specialite.Width = 256;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "List Medecins disponibles";
            // 
            // MedecinsDiponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewMedecins);
            this.Controls.Add(this.btnConsulterCreneaux);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedecinsDiponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedecinsDiponibles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsulterCreneaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        public System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnConsulterCreneaux;
        public System.Windows.Forms.ListView listViewMedecins;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader specialite;
        private System.Windows.Forms.Label label4;
    }
}