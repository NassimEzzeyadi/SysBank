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
    public partial class TransactionsPage: Form
    {
        public TransactionsPage()
        {
            InitializeComponent();
        }

       

        private void ChargerTransactions(int? transactionIdSurlignee = null)
        {
            dgvTransactions.Rows.Clear();
            dgvTransactions.Columns.Clear();

            // 📋 Ajouter les colonnes
            dgvTransactions.ColumnCount = 5;
            dgvTransactions.Columns[0].Name = "ID";
            dgvTransactions.Columns[1].Name = "Date";
            dgvTransactions.Columns[2].Name = "Client";
            dgvTransactions.Columns[3].Name = "Type";
            dgvTransactions.Columns[4].Name = "Montant";

            // 🔄 Récupérer les transactions
            var transactions = SQLDataAccess.DernieresTransactions(100); // ✅ Charge les 100 dernières transactions

            foreach (var transac in transactions)
            {
                int rowIndex = dgvTransactions.Rows.Add(
                    transac.ID,
                    Convert.ToDateTime(transac.Date).ToString("dd/MM/yyyy HH:mm"),
                    transac.ClientNom,
                    transac.Type,
                    transac.Montant.ToString("C")
                );

                // ✅ Surligner la transaction si elle vient d’être ajoutée
                if (transactionIdSurlignee != null && transac.ID == transactionIdSurlignee)
                {
                    var row = dgvTransactions.Rows[rowIndex];
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.Selected = false;

                    // ⏳ Supprimer le surlignement après 3 secondes
                    var timer = new Timer();
                    timer.Interval = 3000;
                    timer.Tick += (s, e) =>
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        timer.Stop();
                    };
                    timer.Start();
                }
            }

            dgvTransactions.ClearSelection(); // ✅ Évite la sélection automatique
        }



        private void RechercherTransaction()
        {
            string critere = txtRecherche.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(critere))
            {
                ChargerTransactions(); // 🔄 Recharge toutes les transactions si vide
                return;
            }

            dgvTransactions.Rows.Clear();

            var transactions = SQLDataAccess.RechercherTransactions(critere); // ✅ Recherche les transactions selon critere = Nom,Type,montant et ID de transaction //



            foreach (var transac in transactions)
            {
                dgvTransactions.Rows.Add(
                    transac.ID,
                    Convert.ToDateTime(transac.Date).ToString("dd/MM/yyyy HH:mm"),
                    transac.ClientNom,
                    transac.Type,
                    transac.Montant.ToString("C")
                );
            }

            dgvTransactions.ClearSelection();
        }


        private void TransactionsPage_Load(object sender, EventArgs e)
        {
            ChargerTransactions();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            DepotForm depotForm = new DepotForm();
            depotForm.TransactionAjoutee += (s, args) =>
            {
                if (args is TransactionEventArgs transacArgs)
                {
                    ChargerTransactions(transacArgs.TransactionId);
                }
                else
                {
                    ChargerTransactions();
                }
            };

            depotForm.ShowDialog();
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            RetraitForm retraitForm = new RetraitForm();
            retraitForm.TransactionAjoutee += (s, args) =>
            {
                if (args is TransactionEventArgs transacArgs)
                {
                    ChargerTransactions(transacArgs.TransactionId);
                }
                else
                {
                    ChargerTransactions();
                }
            };

            retraitForm.ShowDialog();
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {
            TransfertForm transfertForm = new TransfertForm();
            transfertForm.TransactionAjoutee += (s, args) =>
            {
                if (args is TransactionEventArgs transacArgs)
                {
                    ChargerTransactions(transacArgs.TransactionId);
                }
                else
                {
                    ChargerTransactions();
                }
            };

            transfertForm.ShowDialog();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            RechercherTransaction();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            RechercherTransaction();
        }
    }
}
