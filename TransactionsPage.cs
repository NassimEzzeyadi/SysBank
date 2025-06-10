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
    public partial class TransactionsPage : Form
    {
        public TransactionsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge les transactions dans le DataGridView.
        /// </summary>
        /// <param name="transactionIdSurlignee">ID de la transaction à surligner (facultatif).</param>
        private void ChargerTransactions(int? transactionIdSurlignee = null)
        {
            // Efface les lignes et colonnes existantes dans le DataGridView
            dgvTransactions.Rows.Clear();
            dgvTransactions.Columns.Clear();

            // 📋 Ajoute les colonnes nécessaires au DataGridView
            dgvTransactions.ColumnCount = 5;
            dgvTransactions.Columns[0].Name = "ID";
            dgvTransactions.Columns[1].Name = "Date";
            dgvTransactions.Columns[2].Name = "Client";
            dgvTransactions.Columns[3].Name = "Type";
            dgvTransactions.Columns[4].Name = "Montant";

            // 🔄 Récupère les 100 dernières transactions depuis la base de données
            var transactions = SQLDataAccess.DernieresTransactions(100);

            foreach (var transac in transactions)
            {
                // Ajoute chaque transaction au DataGridView
                int rowIndex = dgvTransactions.Rows.Add(
                    transac.ID,
                    Convert.ToDateTime(transac.Date).ToString("dd/MM/yyyy HH:mm"),
                    transac.ClientNom,
                    transac.Type,
                    transac.Montant.ToString("C")
                );

                // ✅ Surligne la transaction si elle correspond à l'ID fourni
                if (transactionIdSurlignee != null && transac.ID == transactionIdSurlignee)
                {
                    var row = dgvTransactions.Rows[rowIndex];
                    row.DefaultCellStyle.BackColor = Color.LightGreen; // Surlignement en vert
                    row.Selected = false;

                    // ⏳ Supprime le surlignement après 3 secondes
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

            // ✅ Désélectionne toutes les lignes par défaut
            dgvTransactions.ClearSelection();
        }

        /// <summary>
        /// Recherche des transactions en fonction d'un critère saisi par l'utilisateur.
        /// </summary>
        private void RechercherTransaction()
        {
            // Récupère le texte saisi dans la zone de recherche
            string critere = txtRecherche.Text.Trim().ToLower();

            // Si aucun critère n'est saisi, recharge toutes les transactions
            if (string.IsNullOrEmpty(critere))
            {
                ChargerTransactions();
                return;
            }

            // Efface les lignes existantes dans le DataGridView
            dgvTransactions.Rows.Clear();

            // 🔄 Recherche les transactions correspondant au critère
            var transactions = SQLDataAccess.RechercherTransactions(critere);

            foreach (var transac in transactions)
            {
                // Ajoute chaque transaction trouvée au DataGridView
                dgvTransactions.Rows.Add(
                    transac.ID,
                    Convert.ToDateTime(transac.Date).ToString("dd/MM/yyyy HH:mm"),
                    transac.ClientNom,
                    transac.Type,
                    transac.Montant.ToString("C")
                );
            }

            // ✅ Désélectionne toutes les lignes par défaut
            dgvTransactions.ClearSelection();
        }

        /// <summary>
        /// Événement déclenché lors du chargement de la page.
        /// Charge les transactions initiales.
        /// </summary>
        private void TransactionsPage_Load(object sender, EventArgs e)
        {
            ChargerTransactions();
        }

        /// <summary>
        /// Ouvre le formulaire de dépôt et recharge les transactions après ajout.
        /// </summary>
        private void btnDepot_Click(object sender, EventArgs e)
        {
            DepotForm depotForm = new DepotForm();
            depotForm.TransactionAjoutee += (s, args) =>
            {
                if (args is TransactionEventArgs transacArgs)
                {
                    // Recharge les transactions et surligne la nouvelle transaction
                    ChargerTransactions(transacArgs.TransactionId);
                }
                else
                {
                    ChargerTransactions();
                }
            };

            depotForm.ShowDialog();
        }

        /// <summary>
        /// Ouvre le formulaire de retrait et recharge les transactions après ajout.
        /// </summary>
        private void btnRetrait_Click(object sender, EventArgs e)
        {
            RetraitForm retraitForm = new RetraitForm();
            retraitForm.TransactionAjoutee += (s, args) =>
            {
                if (args is TransactionEventArgs transacArgs)
                {
                    // Recharge les transactions et surligne la nouvelle transaction
                    ChargerTransactions(transacArgs.TransactionId);
                }
                else
                {
                    ChargerTransactions();
                }
            };

            retraitForm.ShowDialog();
        }

        /// <summary>
        /// Ouvre le formulaire de transfert et recharge les transactions après ajout.
        /// </summary>
        private void btnTransfert_Click(object sender, EventArgs e)
        {
            TransfertForm transfertForm = new TransfertForm();
            transfertForm.TransactionAjoutee += (s, args) =>
            {
                if (args is TransactionEventArgs transacArgs)
                {
                    // Recharge les transactions et surligne la nouvelle transaction
                    ChargerTransactions(transacArgs.TransactionId);
                }
                else
                {
                    ChargerTransactions();
                }
            };

            transfertForm.ShowDialog();
        }

        /// <summary>
        /// Événement déclenché lors du clic sur le bouton de recherche.
        /// Effectue une recherche de transactions.
        /// </summary>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            RechercherTransaction();
        }

        /// <summary>
        /// Événement déclenché lorsque le texte de la zone de recherche change.
        /// Effectue une recherche en temps réel.
        /// </summary>
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            RechercherTransaction();
        }
    }
}
