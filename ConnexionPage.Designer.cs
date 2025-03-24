namespace Systeme_bancaire
{
    partial class ConnexionPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionPage));
            this.Identifiantlabel = new System.Windows.Forms.Label();
            this.Mdplabel = new System.Windows.Forms.Label();
            this.Seconnecterlabel = new System.Windows.Forms.Button();
            this.Oubliélabel = new System.Windows.Forms.Label();
            this.Affichermdp = new System.Windows.Forms.CheckBox();
            this.AfficherMdplabel = new System.Windows.Forms.Label();
            this.IdentifiantInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.MotdepasseInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Identifiantlabel
            // 
            this.Identifiantlabel.AutoSize = true;
            this.Identifiantlabel.BackColor = System.Drawing.Color.Transparent;
            this.Identifiantlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identifiantlabel.ForeColor = System.Drawing.Color.White;
            this.Identifiantlabel.Location = new System.Drawing.Point(81, 103);
            this.Identifiantlabel.Name = "Identifiantlabel";
            this.Identifiantlabel.Size = new System.Drawing.Size(105, 25);
            this.Identifiantlabel.TabIndex = 0;
            this.Identifiantlabel.Text = "Identifiant";
            // 
            // Mdplabel
            // 
            this.Mdplabel.AutoSize = true;
            this.Mdplabel.BackColor = System.Drawing.Color.Transparent;
            this.Mdplabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mdplabel.ForeColor = System.Drawing.Color.White;
            this.Mdplabel.Location = new System.Drawing.Point(80, 176);
            this.Mdplabel.Name = "Mdplabel";
            this.Mdplabel.Size = new System.Drawing.Size(129, 25);
            this.Mdplabel.TabIndex = 1;
            this.Mdplabel.Text = "Mot de passe";
            // 
            // Seconnecterlabel
            // 
            this.Seconnecterlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Seconnecterlabel.FlatAppearance.BorderSize = 0;
            this.Seconnecterlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seconnecterlabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconnecterlabel.ForeColor = System.Drawing.Color.White;
            this.Seconnecterlabel.Location = new System.Drawing.Point(89, 294);
            this.Seconnecterlabel.Name = "Seconnecterlabel";
            this.Seconnecterlabel.Size = new System.Drawing.Size(203, 32);
            this.Seconnecterlabel.TabIndex = 4;
            this.Seconnecterlabel.Text = "SE CONNECTER";
            this.Seconnecterlabel.UseVisualStyleBackColor = false;
            this.Seconnecterlabel.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // Oubliélabel
            // 
            this.Oubliélabel.AutoSize = true;
            this.Oubliélabel.BackColor = System.Drawing.Color.Transparent;
            this.Oubliélabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oubliélabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Oubliélabel.Location = new System.Drawing.Point(122, 343);
            this.Oubliélabel.Name = "Oubliélabel";
            this.Oubliélabel.Size = new System.Drawing.Size(130, 13);
            this.Oubliélabel.TabIndex = 5;
            this.Oubliélabel.Text = "Mot de passe oublié ?";
            // 
            // Affichermdp
            // 
            this.Affichermdp.AutoSize = true;
            this.Affichermdp.BackColor = System.Drawing.Color.Transparent;
            this.Affichermdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Affichermdp.FlatAppearance.BorderSize = 0;
            this.Affichermdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Affichermdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affichermdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Affichermdp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Affichermdp.Location = new System.Drawing.Point(86, 248);
            this.Affichermdp.Name = "Affichermdp";
            this.Affichermdp.Size = new System.Drawing.Size(12, 11);
            this.Affichermdp.TabIndex = 6;
            this.Affichermdp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Affichermdp.UseVisualStyleBackColor = false;
            this.Affichermdp.CheckedChanged += new System.EventHandler(this.Affichermdp_CheckedChanged);
            this.Affichermdp.Click += new System.EventHandler(this.Affichermdp_CheckedChanged);
            // 
            // AfficherMdplabel
            // 
            this.AfficherMdplabel.AutoSize = true;
            this.AfficherMdplabel.BackColor = System.Drawing.Color.Transparent;
            this.AfficherMdplabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficherMdplabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.AfficherMdplabel.Location = new System.Drawing.Point(104, 248);
            this.AfficherMdplabel.Name = "AfficherMdplabel";
            this.AfficherMdplabel.Size = new System.Drawing.Size(146, 13);
            this.AfficherMdplabel.TabIndex = 11;
            this.AfficherMdplabel.Text = "Afficher le mot de passe";
            // 
            // IdentifiantInput
            // 
            this.IdentifiantInput.Animated = true;
            this.IdentifiantInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdentifiantInput.DefaultText = "";
            this.IdentifiantInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdentifiantInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdentifiantInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdentifiantInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdentifiantInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdentifiantInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdentifiantInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdentifiantInput.Location = new System.Drawing.Point(85, 137);
            this.IdentifiantInput.Name = "IdentifiantInput";
            this.IdentifiantInput.PasswordChar = '\0';
            this.IdentifiantInput.PlaceholderText = "Saisissez votre identifiant\r\n";
            this.IdentifiantInput.SelectedText = "";
            this.IdentifiantInput.Size = new System.Drawing.Size(200, 27);
            this.IdentifiantInput.TabIndex = 12;
            // 
            // MotdepasseInput
            // 
            this.MotdepasseInput.Animated = true;
            this.MotdepasseInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MotdepasseInput.DefaultText = "";
            this.MotdepasseInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MotdepasseInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MotdepasseInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MotdepasseInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MotdepasseInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MotdepasseInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MotdepasseInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MotdepasseInput.Location = new System.Drawing.Point(85, 207);
            this.MotdepasseInput.Name = "MotdepasseInput";
            this.MotdepasseInput.PasswordChar = '●';
            this.MotdepasseInput.PlaceholderText = "Saisissez votre mot de passe";
            this.MotdepasseInput.SelectedText = "";
            this.MotdepasseInput.Size = new System.Drawing.Size(200, 27);
            this.MotdepasseInput.TabIndex = 13;
            this.MotdepasseInput.UseSystemPasswordChar = true;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(55, 137);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(24, 27);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 14;
            this.siticonePictureBox1.TabStop = false;
            // 
            // ConnexionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(374, 497);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.MotdepasseInput);
            this.Controls.Add(this.IdentifiantInput);
            this.Controls.Add(this.AfficherMdplabel);
            this.Controls.Add(this.Affichermdp);
            this.Controls.Add(this.Oubliélabel);
            this.Controls.Add(this.Seconnecterlabel);
            this.Controls.Add(this.Mdplabel);
            this.Controls.Add(this.Identifiantlabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnexionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Identifiantlabel;
        private System.Windows.Forms.Label Mdplabel;
        private System.Windows.Forms.Button Seconnecterlabel;
        private System.Windows.Forms.Label Oubliélabel;
        private System.Windows.Forms.CheckBox Affichermdp;
        private System.Windows.Forms.Label AfficherMdplabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox IdentifiantInput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox MotdepasseInput;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}

