namespace Administrateur
{
    partial class CreaneauxMedecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreaneauxMedecin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dimanche = new System.Windows.Forms.CheckBox();
            this.lundi = new System.Windows.Forms.CheckBox();
            this.mardi = new System.Windows.Forms.CheckBox();
            this.mercredi = new System.Windows.Forms.CheckBox();
            this.jeudi = new System.Windows.Forms.CheckBox();
            this.vendredi = new System.Windows.Forms.CheckBox();
            this.samedi = new System.Windows.Forms.CheckBox();
            this.btnEnregistrerCreneaux = new System.Windows.Forms.PictureBox();
            this.lblNomMedecin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnregistrerCreneaux)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(780, 0);
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
            this.pictureBox2.Size = new System.Drawing.Size(800, 720);
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
            this.label1.Size = new System.Drawing.Size(183, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crenaux";
            // 
            // dimanche
            // 
            this.dimanche.AutoSize = true;
            this.dimanche.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimanche.Location = new System.Drawing.Point(400, 200);
            this.dimanche.Name = "dimanche";
            this.dimanche.Size = new System.Drawing.Size(99, 23);
            this.dimanche.TabIndex = 3;
            this.dimanche.Text = "dimanche";
            this.dimanche.UseVisualStyleBackColor = true;
            this.dimanche.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // lundi
            // 
            this.lundi.AutoSize = true;
            this.lundi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lundi.Location = new System.Drawing.Point(400, 250);
            this.lundi.Name = "lundi";
            this.lundi.Size = new System.Drawing.Size(64, 23);
            this.lundi.TabIndex = 3;
            this.lundi.Text = "lundi";
            this.lundi.UseVisualStyleBackColor = true;
            this.lundi.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // mardi
            // 
            this.mardi.AutoSize = true;
            this.mardi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mardi.Location = new System.Drawing.Point(400, 300);
            this.mardi.Name = "mardi";
            this.mardi.Size = new System.Drawing.Size(71, 23);
            this.mardi.TabIndex = 3;
            this.mardi.Text = "mardi";
            this.mardi.UseVisualStyleBackColor = true;
            this.mardi.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // mercredi
            // 
            this.mercredi.AutoSize = true;
            this.mercredi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercredi.Location = new System.Drawing.Point(400, 350);
            this.mercredi.Name = "mercredi";
            this.mercredi.Size = new System.Drawing.Size(95, 23);
            this.mercredi.TabIndex = 3;
            this.mercredi.Text = "mercredi";
            this.mercredi.UseVisualStyleBackColor = true;
            this.mercredi.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // jeudi
            // 
            this.jeudi.AutoSize = true;
            this.jeudi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jeudi.Location = new System.Drawing.Point(600, 200);
            this.jeudi.Name = "jeudi";
            this.jeudi.Size = new System.Drawing.Size(63, 23);
            this.jeudi.TabIndex = 3;
            this.jeudi.Text = "jeudi";
            this.jeudi.UseVisualStyleBackColor = true;
            this.jeudi.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // vendredi
            // 
            this.vendredi.AutoSize = true;
            this.vendredi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendredi.Location = new System.Drawing.Point(600, 250);
            this.vendredi.Name = "vendredi";
            this.vendredi.Size = new System.Drawing.Size(92, 23);
            this.vendredi.TabIndex = 3;
            this.vendredi.Text = "vendredi";
            this.vendredi.UseVisualStyleBackColor = true;
            this.vendredi.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // samedi
            // 
            this.samedi.AutoSize = true;
            this.samedi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samedi.Location = new System.Drawing.Point(600, 300);
            this.samedi.Name = "samedi";
            this.samedi.Size = new System.Drawing.Size(81, 23);
            this.samedi.TabIndex = 3;
            this.samedi.Text = "samedi";
            this.samedi.UseVisualStyleBackColor = true;
            this.samedi.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // btnEnregistrerCreneaux
            // 
            this.btnEnregistrerCreneaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrerCreneaux.Image = ((System.Drawing.Image)(resources.GetObject("btnEnregistrerCreneaux.Image")));
            this.btnEnregistrerCreneaux.Location = new System.Drawing.Point(450, 550);
            this.btnEnregistrerCreneaux.Name = "btnEnregistrerCreneaux";
            this.btnEnregistrerCreneaux.Size = new System.Drawing.Size(200, 30);
            this.btnEnregistrerCreneaux.TabIndex = 4;
            this.btnEnregistrerCreneaux.TabStop = false;
            this.btnEnregistrerCreneaux.Click += new System.EventHandler(this.btnEnregistrerCreneaux_Click);
            // 
            // lblNomMedecin
            // 
            this.lblNomMedecin.AutoSize = true;
            this.lblNomMedecin.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMedecin.Location = new System.Drawing.Point(389, 80);
            this.lblNomMedecin.Name = "lblNomMedecin";
            this.lblNomMedecin.Size = new System.Drawing.Size(68, 25);
            this.lblNomMedecin.TabIndex = 5;
            this.lblNomMedecin.Text = "label3";
            // 
            // CreaneauxMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.lblNomMedecin);
            this.Controls.Add(this.btnEnregistrerCreneaux);
            this.Controls.Add(this.samedi);
            this.Controls.Add(this.vendredi);
            this.Controls.Add(this.jeudi);
            this.Controls.Add(this.mercredi);
            this.Controls.Add(this.mardi);
            this.Controls.Add(this.lundi);
            this.Controls.Add(this.dimanche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreaneauxMedecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreaneauxMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnregistrerCreneaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox dimanche;
        private System.Windows.Forms.CheckBox lundi;
        private System.Windows.Forms.CheckBox mardi;
        private System.Windows.Forms.CheckBox mercredi;
        private System.Windows.Forms.CheckBox jeudi;
        private System.Windows.Forms.CheckBox vendredi;
        private System.Windows.Forms.CheckBox samedi;
        private System.Windows.Forms.PictureBox btnEnregistrerCreneaux;
        public System.Windows.Forms.Label lblNomMedecin;
    }
}