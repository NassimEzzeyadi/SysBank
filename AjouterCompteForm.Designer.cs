namespace Systeme_bancaire
{
    partial class AjouterCompteForm
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
            this.btnAnnuler = new Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton();
            this.btnValider = new Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton();
            this.txtSolde = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtNumeroCompte = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cbClients = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbDevisesDe = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txtDevise = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BorderRadius = 10;
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAnnuler.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(241, 315);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(138, 36);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BorderRadius = 10;
            this.btnValider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValider.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(64, 315);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(138, 36);
            this.btnValider.TabIndex = 18;
            this.btnValider.Text = "Ajouter";
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtSolde
            // 
            this.txtSolde.AutoRoundedCorners = true;
            this.txtSolde.BorderRadius = 15;
            this.txtSolde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSolde.DefaultText = "";
            this.txtSolde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSolde.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSolde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSolde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSolde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSolde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSolde.Location = new System.Drawing.Point(96, 103);
            this.txtSolde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.PasswordChar = '\0';
            this.txtSolde.PlaceholderText = "Solde initial\r\n";
            this.txtSolde.SelectedText = "";
            this.txtSolde.Size = new System.Drawing.Size(260, 33);
            this.txtSolde.TabIndex = 12;
            // 
            // txtNumeroCompte
            // 
            this.txtNumeroCompte.AutoRoundedCorners = true;
            this.txtNumeroCompte.BorderRadius = 16;
            this.txtNumeroCompte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroCompte.DefaultText = "";
            this.txtNumeroCompte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroCompte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroCompte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroCompte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroCompte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroCompte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCompte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroCompte.Location = new System.Drawing.Point(96, 52);
            this.txtNumeroCompte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroCompte.Name = "txtNumeroCompte";
            this.txtNumeroCompte.PasswordChar = '\0';
            this.txtNumeroCompte.PlaceholderText = "Numéro de compte";
            this.txtNumeroCompte.SelectedText = "";
            this.txtNumeroCompte.Size = new System.Drawing.Size(260, 35);
            this.txtNumeroCompte.TabIndex = 10;
            // 
            // cbClients
            // 
            this.cbClients.BackColor = System.Drawing.Color.Transparent;
            this.cbClients.BorderRadius = 10;
            this.cbClients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClients.DropDownHeight = 200;
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbClients.IntegralHeight = false;
            this.cbClients.ItemHeight = 30;
            this.cbClients.Location = new System.Drawing.Point(121, 238);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(206, 36);
            this.cbClients.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.cbClients.TabIndex = 20;
            // 
            // cbDevisesDe
            // 
            this.cbDevisesDe.BackColor = System.Drawing.Color.Transparent;
            this.cbDevisesDe.BorderRadius = 10;
            this.cbDevisesDe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDevisesDe.DropDownHeight = 200;
            this.cbDevisesDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevisesDe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevisesDe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevisesDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbDevisesDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDevisesDe.IntegralHeight = false;
            this.cbDevisesDe.ItemHeight = 30;
            this.cbDevisesDe.Location = new System.Drawing.Point(121, 176);
            this.cbDevisesDe.Name = "cbDevisesDe";
            this.cbDevisesDe.Size = new System.Drawing.Size(206, 36);
            this.cbDevisesDe.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.cbDevisesDe.TabIndex = 21;
            // 
            // txtDevise
            // 
            this.txtDevise.BackColor = System.Drawing.SystemColors.Control;
            this.txtDevise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevise.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevise.Location = new System.Drawing.Point(121, 152);
            this.txtDevise.Name = "txtDevise";
            this.txtDevise.Size = new System.Drawing.Size(191, 18);
            this.txtDevise.TabIndex = 22;
            this.txtDevise.Text = "Séléctionner une devise";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 18);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Séléctionner un client";
            // 
            // AjouterCompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 398);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDevise);
            this.Controls.Add(this.cbDevisesDe);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtSolde);
            this.Controls.Add(this.txtNumeroCompte);
            this.Name = "AjouterCompteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un Compte";
            this.Load += new System.EventHandler(this.ChargerClients);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton btnAnnuler;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientTileButton btnValider;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSolde;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNumeroCompte;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbClients;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbDevisesDe;
        private System.Windows.Forms.TextBox txtDevise;
        private System.Windows.Forms.TextBox textBox1;
    }
}