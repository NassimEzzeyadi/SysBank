namespace Systeme_bancaire
{
    partial class AccueilPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTotalClients = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.iconClients = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblTotalClients = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panelTotalFonds = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.iconFonds = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblTotalFonds = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panelTotalComptes = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.icnoComptes = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblTotalComptes = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lvDernieresTransactions = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.shortcutsPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnCalculateurDevises = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAjouterClient = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnNouvelleTransaction = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lblTitrePage = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panelTotalClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClients)).BeginInit();
            this.panelTotalFonds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFonds)).BeginInit();
            this.panelTotalComptes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnoComptes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvDernieresTransactions)).BeginInit();
            this.shortcutsPanel.SuspendLayout();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotalClients
            // 
            this.panelTotalClients.AutoRoundedCorners = true;
            this.panelTotalClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panelTotalClients.BorderColor = System.Drawing.Color.Transparent;
            this.panelTotalClients.BorderRadius = 49;
            this.panelTotalClients.Controls.Add(this.iconClients);
            this.panelTotalClients.Controls.Add(this.lblTotalClients);
            this.panelTotalClients.Location = new System.Drawing.Point(19, 78);
            this.panelTotalClients.Name = "panelTotalClients";
            this.panelTotalClients.Size = new System.Drawing.Size(200, 100);
            this.panelTotalClients.TabIndex = 4;
            // 
            // iconClients
            // 
            this.iconClients.BackColor = System.Drawing.Color.Transparent;
            this.iconClients.FillColor = System.Drawing.Color.Transparent;
            this.iconClients.Image = ((System.Drawing.Image)(resources.GetObject("iconClients.Image")));
            this.iconClients.ImageRotate = 0F;
            this.iconClients.Location = new System.Drawing.Point(10, 27);
            this.iconClients.Name = "iconClients";
            this.iconClients.Size = new System.Drawing.Size(40, 40);
            this.iconClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClients.TabIndex = 1;
            this.iconClients.TabStop = false;
            this.iconClients.UseTransparentBackground = true;
            // 
            // lblTotalClients
            // 
            this.lblTotalClients.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalClients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClients.ForeColor = System.Drawing.Color.White;
            this.lblTotalClients.Location = new System.Drawing.Point(55, 40);
            this.lblTotalClients.Name = "lblTotalClients";
            this.lblTotalClients.Size = new System.Drawing.Size(121, 21);
            this.lblTotalClients.TabIndex = 0;
            this.lblTotalClients.Text = "Total Clients : 0";
            // 
            // panelTotalFonds
            // 
            this.panelTotalFonds.AutoSize = true;
            this.panelTotalFonds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panelTotalFonds.BorderColor = System.Drawing.Color.Transparent;
            this.panelTotalFonds.Controls.Add(this.iconFonds);
            this.panelTotalFonds.Controls.Add(this.lblTotalFonds);
            this.panelTotalFonds.Location = new System.Drawing.Point(459, 78);
            this.panelTotalFonds.Name = "panelTotalFonds";
            this.panelTotalFonds.Size = new System.Drawing.Size(200, 100);
            this.panelTotalFonds.TabIndex = 5;
            // 
            // iconFonds
            // 
            this.iconFonds.BackColor = System.Drawing.Color.Transparent;
            this.iconFonds.FillColor = System.Drawing.Color.Transparent;
            this.iconFonds.Image = ((System.Drawing.Image)(resources.GetObject("iconFonds.Image")));
            this.iconFonds.ImageRotate = 0F;
            this.iconFonds.Location = new System.Drawing.Point(7, 27);
            this.iconFonds.Name = "iconFonds";
            this.iconFonds.Size = new System.Drawing.Size(40, 40);
            this.iconFonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFonds.TabIndex = 1;
            this.iconFonds.TabStop = false;
            this.iconFonds.UseTransparentBackground = true;
            // 
            // lblTotalFonds
            // 
            this.lblTotalFonds.AutoSize = false;
            this.lblTotalFonds.AutoSizeHeightOnly = true;
            this.lblTotalFonds.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFonds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFonds.ForeColor = System.Drawing.Color.White;
            this.lblTotalFonds.Location = new System.Drawing.Point(49, 40);
            this.lblTotalFonds.Name = "lblTotalFonds";
            this.lblTotalFonds.Size = new System.Drawing.Size(130, 20);
            this.lblTotalFonds.TabIndex = 0;
            this.lblTotalFonds.Text = "Total Fonds : 0 €";
            // 
            // panelTotalComptes
            // 
            this.panelTotalComptes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelTotalComptes.BorderColor = System.Drawing.Color.Transparent;
            this.panelTotalComptes.BorderRadius = 15;
            this.panelTotalComptes.Controls.Add(this.icnoComptes);
            this.panelTotalComptes.Controls.Add(this.lblTotalComptes);
            this.panelTotalComptes.Location = new System.Drawing.Point(239, 78);
            this.panelTotalComptes.Name = "panelTotalComptes";
            this.panelTotalComptes.Size = new System.Drawing.Size(200, 100);
            this.panelTotalComptes.TabIndex = 5;
            // 
            // icnoComptes
            // 
            this.icnoComptes.BackColor = System.Drawing.Color.Transparent;
            this.icnoComptes.FillColor = System.Drawing.Color.Transparent;
            this.icnoComptes.Image = ((System.Drawing.Image)(resources.GetObject("icnoComptes.Image")));
            this.icnoComptes.ImageRotate = 0F;
            this.icnoComptes.Location = new System.Drawing.Point(10, 27);
            this.icnoComptes.Name = "icnoComptes";
            this.icnoComptes.Size = new System.Drawing.Size(40, 40);
            this.icnoComptes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnoComptes.TabIndex = 1;
            this.icnoComptes.TabStop = false;
            this.icnoComptes.UseTransparentBackground = true;
            // 
            // lblTotalComptes
            // 
            this.lblTotalComptes.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalComptes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComptes.ForeColor = System.Drawing.Color.White;
            this.lblTotalComptes.Location = new System.Drawing.Point(53, 40);
            this.lblTotalComptes.Name = "lblTotalComptes";
            this.lblTotalComptes.Size = new System.Drawing.Size(137, 21);
            this.lblTotalComptes.TabIndex = 0;
            this.lblTotalComptes.Text = "Total Comptes : 0";
            // 
            // lvDernieresTransactions
            // 
            this.lvDernieresTransactions.AllowUserToAddRows = false;
            this.lvDernieresTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.lvDernieresTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lvDernieresTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lvDernieresTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.lvDernieresTransactions.Enabled = false;
            this.lvDernieresTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvDernieresTransactions.Location = new System.Drawing.Point(19, 205);
            this.lvDernieresTransactions.Name = "lvDernieresTransactions";
            this.lvDernieresTransactions.ReadOnly = true;
            this.lvDernieresTransactions.RowHeadersVisible = false;
            this.lvDernieresTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lvDernieresTransactions.Size = new System.Drawing.Size(640, 241);
            this.lvDernieresTransactions.TabIndex = 6;
            this.lvDernieresTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.lvDernieresTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.lvDernieresTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.lvDernieresTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.lvDernieresTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.lvDernieresTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.lvDernieresTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvDernieresTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lvDernieresTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.lvDernieresTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDernieresTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.lvDernieresTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lvDernieresTransactions.ThemeStyle.HeaderStyle.Height = 23;
            this.lvDernieresTransactions.ThemeStyle.ReadOnly = true;
            this.lvDernieresTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.lvDernieresTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.lvDernieresTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDernieresTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lvDernieresTransactions.ThemeStyle.RowsStyle.Height = 22;
            this.lvDernieresTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lvDernieresTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // shortcutsPanel
            // 
            this.shortcutsPanel.BackColor = System.Drawing.Color.White;
            this.shortcutsPanel.BorderRadius = 5;
            this.shortcutsPanel.Controls.Add(this.btnCalculateurDevises);
            this.shortcutsPanel.Controls.Add(this.btnAjouterClient);
            this.shortcutsPanel.Controls.Add(this.btnNouvelleTransaction);
            this.shortcutsPanel.Location = new System.Drawing.Point(19, 475);
            this.shortcutsPanel.Name = "shortcutsPanel";
            this.shortcutsPanel.Size = new System.Drawing.Size(640, 80);
            this.shortcutsPanel.TabIndex = 7;
            // 
            // btnCalculateurDevises
            // 
            this.btnCalculateurDevises.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculateurDevises.BorderRadius = 5;
            this.btnCalculateurDevises.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateurDevises.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateurDevises.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculateurDevises.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculateurDevises.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnCalculateurDevises.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateurDevises.ForeColor = System.Drawing.Color.White;
            this.btnCalculateurDevises.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculateurDevises.Image")));
            this.btnCalculateurDevises.Location = new System.Drawing.Point(440, 20);
            this.btnCalculateurDevises.Name = "btnCalculateurDevises";
            this.btnCalculateurDevises.Size = new System.Drawing.Size(180, 45);
            this.btnCalculateurDevises.TabIndex = 2;
            this.btnCalculateurDevises.Text = "Calculateur Devises";
            this.btnCalculateurDevises.Click += new System.EventHandler(this.btnCalculateurDevises_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouterClient.BorderRadius = 5;
            this.btnAjouterClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouterClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouterClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAjouterClient.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouterClient.ForeColor = System.Drawing.Color.White;
            this.btnAjouterClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterClient.Image")));
            this.btnAjouterClient.Location = new System.Drawing.Point(20, 20);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(180, 45);
            this.btnAjouterClient.TabIndex = 1;
            this.btnAjouterClient.Text = "Ajouter Client";
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnNouvelleTransaction
            // 
            this.btnNouvelleTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnNouvelleTransaction.BorderRadius = 5;
            this.btnNouvelleTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNouvelleTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNouvelleTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNouvelleTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNouvelleTransaction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNouvelleTransaction.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNouvelleTransaction.ForeColor = System.Drawing.Color.White;
            this.btnNouvelleTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnNouvelleTransaction.Image")));
            this.btnNouvelleTransaction.Location = new System.Drawing.Point(230, 20);
            this.btnNouvelleTransaction.Name = "btnNouvelleTransaction";
            this.btnNouvelleTransaction.Size = new System.Drawing.Size(180, 45);
            this.btnNouvelleTransaction.TabIndex = 0;
            this.btnNouvelleTransaction.Text = "Nouvelle Transaction";
            this.btnNouvelleTransaction.Click += new System.EventHandler(this.btnNouvelleTransaction_Click);
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.siticonePictureBox1);
            this.siticoneCustomGradientPanel1.Controls.Add(this.lblTitrePage);
            this.siticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneCustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.siticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.ShadowDecoration.BorderRadius = 0;
            this.siticoneCustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.siticoneCustomGradientPanel1.ShadowDecoration.Depth = 50;
            this.siticoneCustomGradientPanel1.ShadowDecoration.Enabled = true;
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(696, 50);
            this.siticoneCustomGradientPanel1.TabIndex = 8;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(14, 8);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(26, 30);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 11;
            this.siticonePictureBox1.TabStop = false;
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.BackColor = System.Drawing.Color.Transparent;
            this.lblTitrePage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePage.ForeColor = System.Drawing.Color.White;
            this.lblTitrePage.Location = new System.Drawing.Point(43, 14);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(71, 24);
            this.lblTitrePage.TabIndex = 10;
            this.lblTitrePage.Text = "Accueil";
            // 
            // AccueilPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(696, 590);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.Controls.Add(this.shortcutsPanel);
            this.Controls.Add(this.lvDernieresTransactions);
            this.Controls.Add(this.panelTotalFonds);
            this.Controls.Add(this.panelTotalComptes);
            this.Controls.Add(this.panelTotalClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccueilPage";
            this.Text = "AccueilPage";
            this.Load += new System.EventHandler(this.AccueilPage_Load);
            this.panelTotalClients.ResumeLayout(false);
            this.panelTotalClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClients)).EndInit();
            this.panelTotalFonds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFonds)).EndInit();
            this.panelTotalComptes.ResumeLayout(false);
            this.panelTotalComptes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnoComptes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvDernieresTransactions)).EndInit();
            this.shortcutsPanel.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panelTotalClients;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox iconClients;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTotalClients;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panelTotalFonds;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox iconFonds;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTotalFonds;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panelTotalComptes;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox icnoComptes;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTotalComptes;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView lvDernieresTransactions;
        private Siticone.Desktop.UI.WinForms.SiticonePanel shortcutsPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnCalculateurDevises;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAjouterClient;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNouvelleTransaction;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lblTitrePage;
    }
}