namespace Systeme_bancaire
{
    partial class ComptesPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.lblTitrePage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.dgvComptes = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.btnSupprimerCompte = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnModifierCompte = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAjouterCompte = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panelContainer.SuspendLayout();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComptes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.BorderRadius = 10;
            this.panelContainer.Controls.Add(this.siticoneCustomGradientPanel1);
            this.panelContainer.Controls.Add(this.dgvComptes);
            this.panelContainer.Controls.Add(this.btnSupprimerCompte);
            this.panelContainer.Controls.Add(this.btnModifierCompte);
            this.panelContainer.Controls.Add(this.btnAjouterCompte);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(664, 512);
            this.panelContainer.TabIndex = 1;
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.lblTitrePage);
            this.siticoneCustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.siticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.ShadowDecoration.BorderRadius = 0;
            this.siticoneCustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.siticoneCustomGradientPanel1.ShadowDecoration.Depth = 50;
            this.siticoneCustomGradientPanel1.ShadowDecoration.Enabled = true;
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(664, 50);
            this.siticoneCustomGradientPanel1.TabIndex = 9;
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.BackColor = System.Drawing.Color.Transparent;
            this.lblTitrePage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePage.ForeColor = System.Drawing.Color.White;
            this.lblTitrePage.Location = new System.Drawing.Point(20, 15);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(202, 24);
            this.lblTitrePage.TabIndex = 10;
            this.lblTitrePage.Text = "Gestion des Comptes";
            // 
            // dgvComptes
            // 
            this.dgvComptes.AllowUserToAddRows = false;
            this.dgvComptes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvComptes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComptes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComptes.ColumnHeadersHeight = 37;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComptes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComptes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvComptes.Location = new System.Drawing.Point(15, 172);
            this.dgvComptes.Name = "dgvComptes";
            this.dgvComptes.ReadOnly = true;
            this.dgvComptes.RowHeadersVisible = false;
            this.dgvComptes.RowTemplate.Height = 35;
            this.dgvComptes.Size = new System.Drawing.Size(637, 300);
            this.dgvComptes.TabIndex = 6;
            this.dgvComptes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComptes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvComptes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvComptes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvComptes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvComptes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvComptes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvComptes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvComptes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComptes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComptes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvComptes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComptes.ThemeStyle.HeaderStyle.Height = 37;
            this.dgvComptes.ThemeStyle.ReadOnly = true;
            this.dgvComptes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvComptes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvComptes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComptes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvComptes.ThemeStyle.RowsStyle.Height = 35;
            this.dgvComptes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComptes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvComptes.SelectionChanged += new System.EventHandler(this.dgvComptes_SelectionChanged);
            // 
            // btnSupprimerCompte
            // 
            this.btnSupprimerCompte.BorderRadius = 8;
            this.btnSupprimerCompte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimerCompte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimerCompte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupprimerCompte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupprimerCompte.Enabled = false;
            this.btnSupprimerCompte.FillColor = System.Drawing.Color.Red;
            this.btnSupprimerCompte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerCompte.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerCompte.Location = new System.Drawing.Point(489, 84);
            this.btnSupprimerCompte.Name = "btnSupprimerCompte";
            this.btnSupprimerCompte.Size = new System.Drawing.Size(150, 50);
            this.btnSupprimerCompte.TabIndex = 3;
            this.btnSupprimerCompte.Text = "🗑️ Supprimer";
            this.btnSupprimerCompte.Click += new System.EventHandler(this.btnSupprimerCompte_Click);
            // 
            // btnModifierCompte
            // 
            this.btnModifierCompte.BorderRadius = 8;
            this.btnModifierCompte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifierCompte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifierCompte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifierCompte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifierCompte.FillColor = System.Drawing.Color.Orange;
            this.btnModifierCompte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierCompte.ForeColor = System.Drawing.Color.White;
            this.btnModifierCompte.Location = new System.Drawing.Point(258, 84);
            this.btnModifierCompte.Name = "btnModifierCompte";
            this.btnModifierCompte.Size = new System.Drawing.Size(150, 50);
            this.btnModifierCompte.TabIndex = 2;
            this.btnModifierCompte.Text = "✏️ Modifier";
            this.btnModifierCompte.Click += new System.EventHandler(this.btnModifierCompte_Click);
            // 
            // btnAjouterCompte
            // 
            this.btnAjouterCompte.BorderRadius = 8;
            this.btnAjouterCompte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterCompte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterCompte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouterCompte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouterCompte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAjouterCompte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterCompte.ForeColor = System.Drawing.Color.White;
            this.btnAjouterCompte.Location = new System.Drawing.Point(30, 84);
            this.btnAjouterCompte.Name = "btnAjouterCompte";
            this.btnAjouterCompte.Size = new System.Drawing.Size(150, 50);
            this.btnAjouterCompte.TabIndex = 1;
            this.btnAjouterCompte.Text = "➕ Ajouter";
            this.btnAjouterCompte.Click += new System.EventHandler(this.btnAjouterCompte_Click);
            // 
            // ComptesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 512);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComptesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Comptes";
            this.Load += new System.EventHandler(this.ComptesPage_Load);
            this.panelContainer.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComptes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panelContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTitrePage;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvComptes;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSupprimerCompte;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnModifierCompte;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAjouterCompte;
    }
}