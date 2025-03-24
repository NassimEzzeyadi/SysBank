namespace Systeme_bancaire
{
    partial class CalculateurDevisesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateurDevisesForm));
            this.lblTitre = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txtMontant = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cbDevisesDe = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbDevisesVers = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.btnConvertir = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblResultat = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Black;
            this.lblTitre.Location = new System.Drawing.Point(76, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(238, 27);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "$ Convertisseur de Devises";
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
            this.txtMontant.Location = new System.Drawing.Point(50, 70);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.PlaceholderText = "Saisir le montant\r\n\r\n";
            this.txtMontant.SelectedText = "";
            this.txtMontant.Size = new System.Drawing.Size(300, 36);
            this.txtMontant.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.txtMontant.TabIndex = 1;
            // 
            // cbDevisesDe
            // 
            this.cbDevisesDe.AutoRoundedCorners = true;
            this.cbDevisesDe.BackColor = System.Drawing.Color.Transparent;
            this.cbDevisesDe.BorderRadius = 17;
            this.cbDevisesDe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDevisesDe.DropDownHeight = 200;
            this.cbDevisesDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevisesDe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevisesDe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevisesDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbDevisesDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDevisesDe.IntegralHeight = false;
            this.cbDevisesDe.ItemHeight = 30;
            this.cbDevisesDe.Location = new System.Drawing.Point(25, 120);
            this.cbDevisesDe.Name = "cbDevisesDe";
            this.cbDevisesDe.Size = new System.Drawing.Size(140, 36);
            this.cbDevisesDe.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.cbDevisesDe.TabIndex = 2;
            // 
            // cbDevisesVers
            // 
            this.cbDevisesVers.AutoRoundedCorners = true;
            this.cbDevisesVers.BackColor = System.Drawing.Color.Transparent;
            this.cbDevisesVers.BorderRadius = 17;
            this.cbDevisesVers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDevisesVers.DropDownHeight = 200;
            this.cbDevisesVers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevisesVers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevisesVers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevisesVers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbDevisesVers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDevisesVers.IntegralHeight = false;
            this.cbDevisesVers.ItemHeight = 30;
            this.cbDevisesVers.Location = new System.Drawing.Point(220, 120);
            this.cbDevisesVers.Name = "cbDevisesVers";
            this.cbDevisesVers.Size = new System.Drawing.Size(140, 36);
            this.cbDevisesVers.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.cbDevisesVers.TabIndex = 3;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(173, 120);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(40, 36);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 4;
            this.siticonePictureBox1.TabStop = false;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Animated = true;
            this.btnConvertir.AutoRoundedCorners = true;
            this.btnConvertir.BorderRadius = 19;
            this.btnConvertir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvertir.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConvertir.ForeColor = System.Drawing.Color.White;
            this.btnConvertir.Location = new System.Drawing.Point(120, 180);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(160, 40);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "🔄 Convertir";
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.BackColor = System.Drawing.Color.Transparent;
            this.lblResultat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblResultat.Location = new System.Drawing.Point(100, 250);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(86, 23);
            this.lblResultat.TabIndex = 6;
            this.lblResultat.Text = "Résultat : 0";
            // 
            // CalculateurDevisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.cbDevisesVers);
            this.Controls.Add(this.cbDevisesDe);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "CalculateurDevisesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "💱 Calculateur Devises";
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTitre;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMontant;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbDevisesDe;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbDevisesVers;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnConvertir;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblResultat;
    }
} 