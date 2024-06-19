﻿namespace Jeu_pacman
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            fondmenu = new PictureBox();
            bntQuitter = new Button();
            btnParametres = new Button();
            btnContinuer = new Button();
            btnNouvellePartie = new Button();
            lblMeilleurepartie = new Label();
            lblScore = new Label();
            lblNiveau = new Label();
            ((System.ComponentModel.ISupportInitialize)fondmenu).BeginInit();
            SuspendLayout();
            // 
            // fondmenu
            // 
            fondmenu.Image = (Image)resources.GetObject("fondmenu.Image");
            fondmenu.ImageLocation = "";
            fondmenu.Location = new Point(0, -3);
            fondmenu.Name = "fondmenu";
            fondmenu.Size = new Size(1853, 1149);
            fondmenu.TabIndex = 0;
            fondmenu.TabStop = false;
            fondmenu.Click += pictureBox1_Click;
            // 
            // bntQuitter
            // 
            bntQuitter.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntQuitter.ForeColor = Color.FromArgb(255, 224, 192);
            bntQuitter.Image = (Image)resources.GetObject("bntQuitter.Image");
            bntQuitter.Location = new Point(100, 638);
            bntQuitter.Name = "bntQuitter";
            bntQuitter.Size = new Size(334, 92);
            bntQuitter.TabIndex = 9;
            bntQuitter.Text = "Quitter";
            bntQuitter.UseVisualStyleBackColor = true;
            bntQuitter.Click += button4_Click;
            // 
            // btnParametres
            // 
            btnParametres.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnParametres.ForeColor = Color.FromArgb(255, 224, 192);
            btnParametres.Image = (Image)resources.GetObject("btnParametres.Image");
            btnParametres.Location = new Point(100, 512);
            btnParametres.Name = "btnParametres";
            btnParametres.Size = new Size(334, 92);
            btnParametres.TabIndex = 8;
            btnParametres.Text = "Paramètres";
            btnParametres.UseVisualStyleBackColor = true;
            btnParametres.Click += button3_Click;
            // 
            // btnContinuer
            // 
            btnContinuer.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinuer.ForeColor = Color.FromArgb(255, 224, 192);
            btnContinuer.Image = (Image)resources.GetObject("btnContinuer.Image");
            btnContinuer.Location = new Point(100, 397);
            btnContinuer.Name = "btnContinuer";
            btnContinuer.Size = new Size(334, 92);
            btnContinuer.TabIndex = 7;
            btnContinuer.Text = "Continuer";
            btnContinuer.UseVisualStyleBackColor = true;
            btnContinuer.Click += button2_Click;
            // 
            // btnNouvellePartie
            // 
            btnNouvellePartie.BackColor = Color.FromArgb(192, 64, 0);
            btnNouvellePartie.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNouvellePartie.ForeColor = Color.FromArgb(255, 224, 192);
            btnNouvellePartie.Image = (Image)resources.GetObject("btnNouvellePartie.Image");
            btnNouvellePartie.Location = new Point(100, 279);
            btnNouvellePartie.Name = "btnNouvellePartie";
            btnNouvellePartie.Size = new Size(334, 91);
            btnNouvellePartie.TabIndex = 6;
            btnNouvellePartie.Text = "Nouvelle Partie";
            btnNouvellePartie.UseVisualStyleBackColor = false;
            btnNouvellePartie.Click += button1_Click;
            // 
            // lblMeilleurepartie
            // 
            lblMeilleurepartie.AutoSize = true;
            lblMeilleurepartie.BackColor = Color.Transparent;
            lblMeilleurepartie.Font = new Font("Microsoft Sans Serif", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeilleurepartie.ForeColor = Color.FromArgb(255, 255, 192);
            lblMeilleurepartie.Image = (Image)resources.GetObject("lblMeilleurepartie.Image");
            lblMeilleurepartie.ImageAlign = ContentAlignment.TopCenter;
            lblMeilleurepartie.Location = new Point(1100, 55);
            lblMeilleurepartie.Name = "lblMeilleurepartie";
            lblMeilleurepartie.Size = new Size(477, 73);
            lblMeilleurepartie.TabIndex = 10;
            lblMeilleurepartie.Text = "Meilleure Partie";
            lblMeilleurepartie.Click += label1_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Sienna;
            lblScore.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.FromArgb(255, 255, 192);
            lblScore.Image = (Image)resources.GetObject("lblScore.Image");
            lblScore.Location = new Point(1342, 140);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(103, 32);
            lblScore.TabIndex = 11;
            lblScore.Text = "Score :";
            lblScore.Click += label2_Click;
            // 
            // lblNiveau
            // 
            lblNiveau.AutoSize = true;
            lblNiveau.BackColor = Color.Sienna;
            lblNiveau.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNiveau.ForeColor = Color.FromArgb(255, 255, 192);
            lblNiveau.Image = (Image)resources.GetObject("lblNiveau.Image");
            lblNiveau.Location = new Point(1342, 210);
            lblNiveau.Name = "lblNiveau";
            lblNiveau.Size = new Size(118, 32);
            lblNiveau.TabIndex = 12;
            lblNiveau.Text = "Niveau :";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1797, 1055);
            Controls.Add(lblNiveau);
            Controls.Add(lblScore);
            Controls.Add(lblMeilleurepartie);
            Controls.Add(bntQuitter);
            Controls.Add(btnParametres);
            Controls.Add(btnContinuer);
            Controls.Add(btnNouvellePartie);
            Controls.Add(fondmenu);
            Name = "Main";
            Text = "MainMenu";
            FormClosed += Main_FormClosed;
            ((System.ComponentModel.ISupportInitialize)fondmenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fondmenu;
        private Button bntQuitter;
        private Button btnParametres;
        private Button btnContinuer;
        private Button btnNouvellePartie;
        private Label lblMeilleurepartie;
        private Label lblScore;
        private Label lblNiveau;
    }
}
