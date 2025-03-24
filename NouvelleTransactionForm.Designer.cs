namespace Systeme_bancaire
{
    partial class NouvelleTransactionForm
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
            this.lblClient = new System.Windows.Forms.Label();
            this.cbClients = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lblTypeTransaction = new System.Windows.Forms.Label();
            this.cbTypeTransaction = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtMontant = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnValider = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAnnuler = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(20, 30);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(170, 16);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "📋 Sélectionner un client :";
            // 
            // cbClients
            // 
            this.cbClients.AutoRoundedCorners = true;
            this.cbClients.BackColor = System.Drawing.Color.Transparent;
            this.cbClients.BorderRadius = 17;
            this.cbClients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbClients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbClients.ItemHeight = 30;
            this.cbClients.Location = new System.Drawing.Point(20, 55);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(300, 36);
            this.cbClients.TabIndex = 1;
            // 
            // lblTypeTransaction
            // 
            this.lblTypeTransaction.AutoSize = true;
            this.lblTypeTransaction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeTransaction.Location = new System.Drawing.Point(20, 100);
            this.lblTypeTransaction.Name = "lblTypeTransaction";
            this.lblTypeTransaction.Size = new System.Drawing.Size(156, 16);
            this.lblTypeTransaction.TabIndex = 2;
            this.lblTypeTransaction.Text = "📂 Type de transaction :";
            // 
            // cbTypeTransaction
            // 
            this.cbTypeTransaction.AutoRoundedCorners = true;
            this.cbTypeTransaction.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeTransaction.BorderRadius = 17;
            this.cbTypeTransaction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeTransaction.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeTransaction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeTransaction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeTransaction.ItemHeight = 30;
            this.cbTypeTransaction.Items.AddRange(new object[] {
            "Dépôt",
            "Retrait",
            "Transfert"});
            this.cbTypeTransaction.Location = new System.Drawing.Point(20, 125);
            this.cbTypeTransaction.Name = "cbTypeTransaction";
            this.cbTypeTransaction.Size = new System.Drawing.Size(300, 36);
            this.cbTypeTransaction.TabIndex = 3;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(20, 170);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(100, 16);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "💰 Montant (€) :";
            // 
            // txtMontant
            // 
            this.txtMontant.AutoRoundedCorners = true;
            this.txtMontant.BorderRadius = 14;
            this.txtMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontant.DefaultText = "";
            this.txtMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.Location = new System.Drawing.Point(20, 195);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.PlaceholderText = "0.00 ";
            this.txtMontant.SelectedText = "";
            this.txtMontant.Size = new System.Drawing.Size(300, 30);
            this.txtMontant.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.BorderRadius = 10;
            this.btnValider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnValider.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(50, 250);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 35);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "✅ Valider";
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BorderRadius = 10;
            this.btnAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnnuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(200, 250);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 35);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "❌ Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // NouvelleTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.cbTypeTransaction);
            this.Controls.Add(this.lblTypeTransaction);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.lblClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NouvelleTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbClients;
        private System.Windows.Forms.Label lblTypeTransaction;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbTypeTransaction;
        private System.Windows.Forms.Label lblMontant;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMontant;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnValider;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAnnuler;
    }
}