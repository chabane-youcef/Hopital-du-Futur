namespace User_Infirmiere
{
    partial class CreneauxMedecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreneauxMedecin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.lvCreneaux = new System.Windows.Forms.ListView();
            this.idCreneaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jourCreneaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCreneaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heurCreneaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etatCreneaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReserverCreneaux = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReserverCreneaux)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medecin";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(780, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvCreneaux
            // 
            this.lvCreneaux.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCreneaux,
            this.jourCreneaux,
            this.dateCreneaux,
            this.heurCreneaux,
            this.etatCreneaux});
            this.lvCreneaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCreneaux.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCreneaux.HideSelection = false;
            this.lvCreneaux.Location = new System.Drawing.Point(330, 150);
            this.lvCreneaux.Name = "lvCreneaux";
            this.lvCreneaux.Size = new System.Drawing.Size(450, 378);
            this.lvCreneaux.TabIndex = 3;
            this.lvCreneaux.UseCompatibleStateImageBehavior = false;
            this.lvCreneaux.View = System.Windows.Forms.View.Details;
            this.lvCreneaux.SelectedIndexChanged += new System.EventHandler(this.lvCreneaux_SelectedIndexChanged);
            // 
            // idCreneaux
            // 
            this.idCreneaux.Text = "ID";
            this.idCreneaux.Width = 40;
            // 
            // jourCreneaux
            // 
            this.jourCreneaux.Text = "Jour";
            this.jourCreneaux.Width = 100;
            // 
            // dateCreneaux
            // 
            this.dateCreneaux.Text = "Date";
            this.dateCreneaux.Width = 110;
            // 
            // heurCreneaux
            // 
            this.heurCreneaux.Text = "Heure";
            this.heurCreneaux.Width = 110;
            // 
            // etatCreneaux
            // 
            this.etatCreneaux.Text = "etat";
            this.etatCreneaux.Width = 86;
            // 
            // btnReserverCreneaux
            // 
            this.btnReserverCreneaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserverCreneaux.Image = ((System.Drawing.Image)(resources.GetObject("btnReserverCreneaux.Image")));
            this.btnReserverCreneaux.Location = new System.Drawing.Point(475, 581);
            this.btnReserverCreneaux.Name = "btnReserverCreneaux";
            this.btnReserverCreneaux.Size = new System.Drawing.Size(200, 30);
            this.btnReserverCreneaux.TabIndex = 4;
            this.btnReserverCreneaux.TabStop = false;
            this.btnReserverCreneaux.Click += new System.EventHandler(this.btnReserverCreneaux_Click);
            // 
            // CreneauxMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.btnReserverCreneaux);
            this.Controls.Add(this.lvCreneaux);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreneauxMedecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreneauxMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReserverCreneaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        public System.Windows.Forms.ListView lvCreneaux;
        private System.Windows.Forms.ColumnHeader idCreneaux;
        private System.Windows.Forms.ColumnHeader jourCreneaux;
        private System.Windows.Forms.ColumnHeader dateCreneaux;
        private System.Windows.Forms.ColumnHeader heurCreneaux;
        private System.Windows.Forms.ColumnHeader etatCreneaux;
        private System.Windows.Forms.PictureBox btnReserverCreneaux;
    }
}