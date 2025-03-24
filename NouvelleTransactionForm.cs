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
    public partial class NouvelleTransactionForm: Form
    {

        public event EventHandler TransactionAjoutee;
        public NouvelleTransactionForm()
        {
            InitializeComponent();
            ChargerClients(); // ✅ Charge les clients dans la ComboBox
            
        }


        private void ChargerClients()
        {
            var clients = SQLDataAccess.ChargerClients(); // Méthode qui retourne la liste des clients
            cbClients.Items.Clear();

            foreach (var client in clients)
            {
                cbClients.Items.Add($"{client.ID} - {client.Prenom} {client.Nom}");
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbClients.SelectedItem == null || cbTypeTransaction.SelectedItem == null || string.IsNullOrWhiteSpace(txtMontant.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔄 Récupère l'élément sélectionné dans la ComboBox
            string clientSelectionne = cbClients.SelectedItem.ToString();
            string[] split = clientSelectionne.Split('-');

            int compteId = int.Parse(split[0].Trim());               // ✅ Récupère le CompteID
            string clientNom = split[1].Trim();                      // ✅ Récupère uniquement le Prénom et le Nom
            string typeTransaction = cbTypeTransaction.SelectedItem.ToString();
            decimal montant;

            if (!decimal.TryParse(txtMontant.Text, out montant) || montant <= 0)
            {
                MessageBox.Show("Veuillez entrer un montant valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                // ✅ Récupérer l'ID de la transaction ajoutée
                int transactionId = SQLDataAccess.AjouterTransaction(compteId, typeTransaction, montant, clientNom);

                // ✅ Déclencher l'événement et passer l'ID
                TransactionAjoutee?.Invoke(this, new TransactionEventArgs(transactionId));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la transaction : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
