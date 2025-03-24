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
    public partial class ModifierCompteForm : Form
    {
        public event EventHandler CompteModifie;
        private int idCompte;

        public ModifierCompteForm(int id, string numeroCompte, decimal solde, string devise, int clientId)
        {
            InitializeComponent();
            idCompte = id; // ✅ Stocke l'ID du compte
            txtNumeroCompte.Text = numeroCompte;
            txtSolde.Text = solde.ToString();
            cbDevisesDe.SelectedItem = devise;
            ChargerClients();
            cbClients.SelectedItem = cbClients.Items.Cast<string>().FirstOrDefault(c => c.StartsWith(clientId.ToString()));
            cbDevisesDe.Items.AddRange(new string[] { "EUR", "USD", "GBP", "MAD", "CAD" }); // 💰 Ajout des devises

        }

        private void ChargerClients()
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

            // ✅ Modifier en base
            SQLDataAccess.ModifierCompte(idCompte, txtNumeroCompte.Text, solde, cbDevisesDe.SelectedItem.ToString(), clientId);

            MessageBox.Show("Compte modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ Déclencher l'événement
            CompteModifie?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
    
}
