namespace PacMan
{
    partial class Resultat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitreScore = new System.Windows.Forms.Label();
            this.lblVSE = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PacMan.Properties.Resources.Screenshot_2024_04_02_151300_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(221, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 434);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitreScore
            // 
            this.lblTitreScore.AutoSize = true;
            this.lblTitreScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitreScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreScore.Image = ((System.Drawing.Image)(resources.GetObject("lblTitreScore.Image")));
            this.lblTitreScore.Location = new System.Drawing.Point(441, 100);
            this.lblTitreScore.Name = "lblTitreScore";
            this.lblTitreScore.Size = new System.Drawing.Size(62, 24);
            this.lblTitreScore.TabIndex = 4;
            this.lblTitreScore.Text = "Score ";
            // 
            // lblVSE
            // 
            this.lblVSE.AutoSize = true;
            this.lblVSE.BackColor = System.Drawing.Color.Transparent;
            this.lblVSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVSE.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVSE.Image = ((System.Drawing.Image)(resources.GetObject("lblVSE.Image")));
            this.lblVSE.Location = new System.Drawing.Point(290, 280);
            this.lblVSE.Name = "lblVSE";
            this.lblVSE.Size = new System.Drawing.Size(147, 24);
            this.lblVSE.TabIndex = 5;
            this.lblVSE.Text = "Votre score est :";
            this.lblVSE.Click += new System.EventHandler(this.lblPseudo_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblscore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Image = ((System.Drawing.Image)(resources.GetObject("lblscore.Image")));
            this.lblscore.Location = new System.Drawing.Point(455, 280);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(26, 24);
            this.lblscore.TabIndex = 6;
            this.lblscore.Text = "??";
            // 
            // Resultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacMan.Properties.Resources.Screenshot_2024_04_14_151646;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 636);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblVSE);
            this.Controls.Add(this.lblTitreScore);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Resultat";
            this.Text = "Resultat";
            this.Load += new System.EventHandler(this.Resultat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitreScore;
        private System.Windows.Forms.Label lblVSE;
        private System.Windows.Forms.Label lblscore;
    }
}