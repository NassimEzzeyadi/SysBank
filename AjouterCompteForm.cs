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
    public partial class AjouterCompteForm: Form
    {

        public event EventHandler CompteAjoute;

        public AjouterCompteForm()
        {
            InitializeComponent();
            cbDevisesDe.Items.AddRange(new string[] { "EUR", "USD", "GBP", "MAD", "CAD" }); // 💰 Ajout des devises
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbClients.SelectedItem == null || string.IsNullOrWhiteSpace(txtNumeroCompte.Text) || string.IsNullOrWhiteSpace(txtSolde.Text) || cbDevisesDe.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSolde.Text, out decimal solde) || solde < 0)
            {
                MessageBox.Show("Solde invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Récupérer le ClientID sélectionné
            string clientSelectionne = cbClients.SelectedItem.ToString();
            int clientId = int.Parse(clientSelectionne.Split('-')[0].Trim());

            // ✅ Ajouter en base
            // Remplacer la ligne suivante
            // SQLDataAccess.AjouterCompte(txtNumeroCompte.Text, solde, cbDevisesDe.SelectedItem.ToString(), clientId);
            // Par cette ligne
            SQLDataAccess.AjouterCompte(txtNumeroCompte.Text, solde, cbDevisesDe.SelectedItem.ToString(), clientId);

            MessageBox.Show("Compte ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CompteAjoute?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChargerClients(object sender, EventArgs e)
        {
            var clients = SQLDataAccess.ChargerClients();
            cbClients.Items.Clear();

            foreach (var client in clients)
            {
                cbClients.Items.Add($"{client.ID} - {client.Prenom} {client.Nom}");
            }

            if (cbClients.Items.Count > 0)
                cbClients.SelectedIndex = 0; // ✅ Sélectionner le premier client par défaut
        }
    }

}
