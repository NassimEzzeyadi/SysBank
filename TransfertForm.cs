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
    public partial class TransfertForm : Form
    {
        public event EventHandler TransactionAjoutee;

        public TransfertForm()
        {
            InitializeComponent();
            ChargerComptes();
        }

        private void ChargerComptes()
        {
            var comptes = SQLDataAccess.ChargerComptes();
            cbCompteSource.Items.Clear();
            cbCompteDest.Items.Clear();

            foreach (var compte in comptes)
            {
                cbCompteSource.Items.Add($"{compte.ID} - {compte.NumeroCompte} (Solde: {compte.Solde} {compte.Devise})");
                cbCompteDest.Items.Add($"{compte.ID} - {compte.NumeroCompte} (Solde: {compte.Solde} {compte.Devise})");
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbCompteSource.SelectedItem == null || cbCompteDest.SelectedItem == null || string.IsNullOrWhiteSpace(txtMontant.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sourceSelection = cbCompteSource.SelectedItem.ToString();
            int compteSourceId = int.Parse(sourceSelection.Split('-')[0].Trim());

            string destSelection = cbCompteDest.SelectedItem.ToString();
            int compteDestId = int.Parse(destSelection.Split('-')[0].Trim());

            if (compteSourceId == compteDestId)
            {
                MessageBox.Show("Le compte source et le compte destinataire doivent être différents.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMontant.Text, out decimal montant) || montant <= 0)
            {
                MessageBox.Show("Montant invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Effectuer le transfert en base de données
            int transactionId = SQLDataAccess.TransfertArgent(compteSourceId, compteDestId, montant);

            MessageBox.Show("Transfert effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
