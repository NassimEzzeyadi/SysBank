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
    public partial class RetraitForm : Form
    {
        public event EventHandler TransactionAjoutee;

        public RetraitForm()
        {
            InitializeComponent();
            ChargerComptes();
        }

        private void ChargerComptes()
        {
            var comptes = SQLDataAccess.ChargerComptes();
            cbComptes.Items.Clear();
            foreach (var compte in comptes)
            {
                cbComptes.Items.Add($"{compte.ID} - {compte.NumeroCompte}");
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbComptes.SelectedItem == null || string.IsNullOrWhiteSpace(txtMontant.Text))
            {
                MessageBox.Show("Veuillez sélectionner un compte et entrer un montant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string compteSelectionne = cbComptes.SelectedItem.ToString();
            int compteId = int.Parse(compteSelectionne.Split('-')[0].Trim());

            if (!decimal.TryParse(txtMontant.Text, out decimal montant) || montant <= 0)
            {
                MessageBox.Show("Montant invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // ✅ Effectuer le retrait en base de données
            int transactionId = SQLDataAccess.RetirerArgent(compteId, montant);

            MessageBox.Show("Retrait effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ Rafraîchir l’écran Transactions
            TransactionAjoutee?.Invoke(this, new TransactionEventArgs(transactionId));
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
