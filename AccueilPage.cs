using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systeme_bancaire
{
    public partial class AccueilPage: Form
    {
       

        public AccueilPage()
        {
            InitializeComponent();
            ChargerStatistiques();
           ChargerDernieresTransactions();
        }


        private void ChargerStatistiques()
        {
            // Récupère les stats depuis SQLDataAccess
            int totalClients = SQLDataAccess.CompterElements("Clients");
            int totalComptes = SQLDataAccess.CompterElements("Comptes");
            decimal totalFonds = SQLDataAccess.SommeColonne("Comptes", "Solde");

            // Met à jour les labels
            lblTotalClients.Text = "Total Clients : " + totalClients;
            lblTotalComptes.Text = "Total Comptes : " + totalComptes;
            lblTotalFonds.Text = "Total Fonds : " + totalFonds.ToString("C");
        }

        private void ChargerDernieresTransactions(int? transactionIdSurlignee = null)
        {

            lvDernieresTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            lvDernieresTransactions.RowTemplate.Height = 22; // ✅ Hauteur fixe des lignes
            lvDernieresTransactions.ScrollBars = ScrollBars.None; // ✅ Retire la scrollbar si pas nécessaire


            // Clear pour éviter les doublons
            lvDernieresTransactions.Rows.Clear();
            lvDernieresTransactions.Columns.Clear();

            // 📋 Ajouter les colonnes
            lvDernieresTransactions.ColumnCount = 4;
            lvDernieresTransactions.Columns[0].Name = "Date";
            lvDernieresTransactions.Columns[1].Name = "Client";
            lvDernieresTransactions.Columns[2].Name = "Type";
            lvDernieresTransactions.Columns[3].Name = "Montant";

            // Ajustement des tailles de colonnes
            lvDernieresTransactions.Columns[0].Width = 120; // Date
            lvDernieresTransactions.Columns[1].Width = 200; // Client
            lvDernieresTransactions.Columns[2].Width = 150; // Type
            lvDernieresTransactions.Columns[3].Width = 150; // Montant

            // 🔄 Récupérer les dernières transactions
            var transactions = SQLDataAccess.DernieresTransactions(10);

            foreach (var transac in transactions)
            {
                    int rowIndex = lvDernieresTransactions.Rows.Add(
                    Convert.ToDateTime(transac.Date).ToString("dd/MM/yyyy HH:mm"),
                    transac.ClientNom,
                    transac.Type,
                    transac.Montant.ToString("C")
                );

                // ✅ Surligner la transaction si elle correspond
                if (transactionIdSurlignee != null && transac.ID == transactionIdSurlignee)
                {
                    var row = lvDernieresTransactions.Rows[rowIndex];
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.Selected = false; // Assurer que la ligne n'est pas sélectionnée
                    
                    // ⏳ Supprimer le surlignement après 3 secondes
                    var timer = new Timer();
                    timer.Interval = 3000; // 2000 ms = 3 secondes
                    timer.Tick += (s, e) =>
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        timer.Stop();
                    };
                    timer.Start();


                }

                // Désélectionner toute sélection une fois le chargement terminé
                lvDernieresTransactions.CurrentCell = null;
                lvDernieresTransactions.ClearSelection();

            }
        }

        private void AccueilPage_Load(object sender, EventArgs e)
        {
            
            lvDernieresTransactions.ClearSelection();

            // Style général du DataGridView
            lvDernieresTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            lvDernieresTransactions.EnableHeadersVisualStyles = false;
            lvDernieresTransactions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 117, 214);
            lvDernieresTransactions.DefaultCellStyle.SelectionForeColor = Color.White;
            lvDernieresTransactions.RowTemplate.Height = 35;
            lvDernieresTransactions.AllowUserToAddRows = false; // Empêche l'ajout manuel de lignes


            SiticoneButton[] boutons = { btnAjouterClient, btnNouvelleTransaction, btnCalculateurDevises };

            foreach (var btn in boutons)
            {
                btn.ForeColor = Color.White;
                btn.BorderColor = Color.White;
                btn.BorderThickness = 1;
                btn.HoverState.FillColor = Color.White;
                btn.HoverState.ForeColor = Color.Black;
            }

           
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            AjouterClientForm ajouterClientForm = new AjouterClientForm();

            ajouterClientForm.ShowDialog();
        }

        private void btnNouvelleTransaction_Click(object sender, EventArgs e)
        {

            NouvelleTransactionForm transactionForm = new NouvelleTransactionForm();

            // ✅ Rafraîchir et surligner la ligne de la nouvelle transaction
            transactionForm.TransactionAjoutee += (s, args) =>
            {
                if (args is TransactionEventArgs transacArgs)
                {
                    ChargerDernieresTransactions(transacArgs.TransactionId);
                }
                else
                {
                    ChargerDernieresTransactions();
                }
            };

            transactionForm.ShowDialog();
        }

        private void btnCalculateurDevises_Click(object sender, EventArgs e)
        {
            CalculateurDevisesForm convertisseur = new CalculateurDevisesForm();
            new CalculateurDevisesForm().ShowDialog();
        }
    }
}
