namespace Systeme_bancaire
{
    partial class EcranPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipal));
            this.menuPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.activeIndicator = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblNomUtilisateur = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.btnDevises = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnComptes = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnParametres = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDeconnexion = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnTransactions = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnClients = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAccueil = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.titleLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.logoBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.mainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.menuPanel.Controls.Add(this.activeIndicator);
            this.menuPanel.Controls.Add(this.siticonePictureBox1);
            this.menuPanel.Controls.Add(this.lblNomUtilisateur);
            this.menuPanel.Controls.Add(this.btnDevises);
            this.menuPanel.Controls.Add(this.btnComptes);
            this.menuPanel.Controls.Add(this.btnParametres);
            this.menuPanel.Controls.Add(this.btnDeconnexion);
            this.menuPanel.Controls.Add(this.btnTransactions);
            this.menuPanel.Controls.Add(this.btnClients);
            this.menuPanel.Controls.Add(this.btnAccueil);
            this.menuPanel.Controls.Add(this.titleLabel);
            this.menuPanel.Controls.Add(this.logoBox);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(220, 614);
            this.menuPanel.TabIndex = 1;
            // 
            // activeIndicator
            // 
            this.activeIndicator.BackColor = System.Drawing.Color.White;
            this.activeIndicator.Location = new System.Drawing.Point(20, 160);
            this.activeIndicator.Name = "activeIndicator";
            this.activeIndicator.Size = new System.Drawing.Size(5, 40);
            this.activeIndicator.TabIndex = 11;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(7, 572);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(36, 28);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 10;
            this.siticonePictureBox1.TabStop = false;
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = false;
            this.lblNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUtilisateur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.ForeColor = System.Drawing.Color.White;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(46, 577);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(158, 18);
            this.lblNomUtilisateur.TabIndex = 9;
            this.lblNomUtilisateur.Text = null;
            this.lblNomUtilisateur.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDevises
            // 
            this.btnDevises.Animated = true;
            this.btnDevises.BackColor = System.Drawing.Color.Transparent;
            this.btnDevises.BorderColor = System.Drawing.Color.White;
            this.btnDevises.BorderRadius = 4;
            this.btnDevises.BorderThickness = 1;
            this.btnDevises.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDevises.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDevises.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDevises.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDevises.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDevises.ForeColor = System.Drawing.Color.White;
            this.btnDevises.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDevises.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDevises.Location = new System.Drawing.Point(20, 360);
            this.btnDevises.Name = "btnDevises";
            this.btnDevises.Size = new System.Drawing.Size(180, 40);
            this.btnDevises.TabIndex = 8;
            this.btnDevises.Text = "Devises";
            this.btnDevises.Click += new System.EventHandler(this.btnDevises_Click);
            // 
            // btnComptes
            // 
            this.btnComptes.Animated = true;
            this.btnComptes.BackColor = System.Drawing.Color.Transparent;
            this.btnComptes.BorderColor = System.Drawing.Color.White;
            this.btnComptes.BorderRadius = 4;
            this.btnComptes.BorderThickness = 1;
            this.btnComptes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComptes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComptes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComptes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComptes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnComptes.ForeColor = System.Drawing.Color.White;
            this.btnComptes.HoverState.FillColor = System.Drawing.Color.White;
            this.btnComptes.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnComptes.Location = new System.Drawing.Point(20, 310);
            this.btnComptes.Name = "btnComptes";
            this.btnComptes.Size = new System.Drawing.Size(180, 40);
            this.btnComptes.TabIndex = 7;
            this.btnComptes.Text = "Comptes";
            this.btnComptes.Click += new System.EventHandler(this.btnComptes_Click);
            // 
            // btnParametres
            // 
            this.btnParametres.Animated = true;
            this.btnParametres.BackColor = System.Drawing.Color.Transparent;
            this.btnParametres.BorderColor = System.Drawing.Color.White;
            this.btnParametres.BorderRadius = 4;
            this.btnParametres.BorderThickness = 1;
            this.btnParametres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParametres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParametres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParametres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParametres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnParametres.ForeColor = System.Drawing.Color.White;
            this.btnParametres.HoverState.FillColor = System.Drawing.Color.White;
            this.btnParametres.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnParametres.Location = new System.Drawing.Point(20, 410);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(180, 40);
            this.btnParametres.TabIndex = 6;
            this.btnParametres.Text = "Parametres  ⚙️";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Animated = true;
            this.btnDeconnexion.BackColor = System.Drawing.Color.Transparent;
            this.btnDeconnexion.BorderColor = System.Drawing.Color.White;
            this.btnDeconnexion.BorderRadius = 4;
            this.btnDeconnexion.BorderThickness = 1;
            this.btnDeconnexion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeconnexion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeconnexion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeconnexion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeconnexion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeconnexion.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDeconnexion.Location = new System.Drawing.Point(20, 466);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(180, 40);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "Déconnexion";
            // 
            // btnTransactions
            // 
            this.btnTransactions.Animated = true;
            this.btnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.BorderColor = System.Drawing.Color.White;
            this.btnTransactions.BorderRadius = 4;
            this.btnTransactions.BorderThickness = 1;
            this.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTransactions.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnTransactions.Location = new System.Drawing.Point(20, 260);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(180, 40);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnClients
            // 
            this.btnClients.Animated = true;
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.BorderColor = System.Drawing.Color.White;
            this.btnClients.BorderRadius = 4;
            this.btnClients.BorderThickness = 1;
            this.btnClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClients.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClients.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClients.Location = new System.Drawing.Point(20, 210);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(180, 40);
            this.btnClients.TabIndex = 3;
            this.btnClients.Text = "Clients";
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAccueil
            // 
            this.btnAccueil.Animated = true;
            this.btnAccueil.BackColor = System.Drawing.Color.Transparent;
            this.btnAccueil.BorderColor = System.Drawing.Color.White;
            this.btnAccueil.BorderRadius = 4;
            this.btnAccueil.BorderThickness = 1;
            this.btnAccueil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccueil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccueil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccueil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccueil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAccueil.ForeColor = System.Drawing.Color.White;
            this.btnAccueil.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAccueil.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAccueil.Location = new System.Drawing.Point(20, 160);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(180, 40);
            this.btnAccueil.TabIndex = 2;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(68, 106);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(86, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "SysBank";
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.FillColor = System.Drawing.Color.Transparent;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.ImageRotate = 0F;
            this.logoBox.Location = new System.Drawing.Point(60, 10);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(100, 100);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.logoBox.UseTransparentBackground = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(220, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(696, 614);
            this.mainPanel.TabIndex = 2;
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 614);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "EcranPrincipal";
            this.Text = "EcranPrincipal";
            this.Load += new System.EventHandler(this.EcranPrincipal_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel menuPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAccueil;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel titleLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox logoBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClients;
        private Siticone.Desktop.UI.WinForms.SiticonePanel mainPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDevises;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnComptes;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnParametres;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDeconnexion;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTransactions;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblNomUtilisateur;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel activeIndicator;
    }
}