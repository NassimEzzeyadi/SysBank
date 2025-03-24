namespace Systeme_bancaire
{
    partial class TransfertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransfertForm));
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.cbCompteDest = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbCompteSource = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txtMontant = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnAnnuler = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnValider = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 90F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(173, 70);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(46, 36);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 8;
            this.siticonePictureBox1.TabStop = false;
            // 
            // cbCompteDest
            // 
            this.cbCompteDest.AutoRoundedCorners = true;
            this.cbCompteDest.BackColor = System.Drawing.Color.Transparent;
            this.cbCompteDest.BorderRadius = 17;
            this.cbCompteDest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCompteDest.DropDownHeight = 200;
            this.cbCompteDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompteDest.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCompteDest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCompteDest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbCompteDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCompteDest.IntegralHeight = false;
            this.cbCompteDest.ItemHeight = 30;
            this.cbCompteDest.Location = new System.Drawing.Point(52, 112);
            this.cbCompteDest.Name = "cbCompteDest";
            this.cbCompteDest.Size = new System.Drawing.Size(300, 36);
            this.cbCompteDest.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.cbCompteDest.TabIndex = 7;
            // 
            // cbCompteSource
            // 
            this.cbCompteSource.BackColor = System.Drawing.Color.Transparent;
            this.cbCompteSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCompteSource.DropDownHeight = 200;
            this.cbCompteSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompteSource.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCompteSource.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCompteSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbCompteSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCompteSource.IntegralHeight = false;
            this.cbCompteSource.ItemHeight = 30;
            this.cbCompteSource.Location = new System.Drawing.Point(52, 28);
            this.cbCompteSource.Name = "cbCompteSource";
            this.cbCompteSource.Size = new System.Drawing.Size(300, 36);
            this.cbCompteSource.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.cbCompteSource.TabIndex = 6;
            // 
            // txtMontant
            // 
            this.txtMontant.AutoRoundedCorners = true;
            this.txtMontant.BorderRadius = 17;
            this.txtMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontant.DefaultText = "";
            this.txtMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Location = new System.Drawing.Point(52, 191);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.PlaceholderText = "Saisir le montant\r\n\r\n";
            this.txtMontant.SelectedText = "";
            this.txtMontant.Size = new System.Drawing.Size(300, 36);
            this.txtMontant.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtMontant.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BorderRadius = 10;
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(218, 257);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 45);
            this.btnAnnuler.TabIndex = 23;
            this.btnAnnuler.Text = "❌ Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BorderRadius = 10;
            this.btnValider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(68, 257);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(128, 45);
            this.btnValider.TabIndex = 22;
            this.btnValider.Text = "\t✔ Transférer";
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // TransfertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 351);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.cbCompteDest);
            this.Controls.Add(this.cbCompteSource);
            this.Controls.Add(this.txtMontant);
            this.Name = "TransfertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transférer de l\'argent";
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCompteDest;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCompteSource;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMontant;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAnnuler;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnValider;
    }
}