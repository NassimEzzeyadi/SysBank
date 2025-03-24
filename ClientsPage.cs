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
    public partial class ClientsPage : Form
    {
        public ClientsPage()
        {
            InitializeComponent();
        }

        private void ClientsPage_Load(object sender, EventArgs e)
        {
            ChargerClients();
        }

        private void ChargerClients()
        {

            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvClients.RowTemplate.Height = 30; // ✅ Hauteur fixe des lignes
            dgvClients.ScrollBars = ScrollBars.None; // ✅ Retire la scrollbar si pas nécessaire


            // Clear pour éviter les doublons
            dgvClients.Rows.Clear();
            dgvClients.Columns.Clear();

            // Ajouter les colonnes
            dgvClients.ColumnCount = 5;
            dgvClients.Columns[0].Name = "ID";
            dgvClients.Columns[1].Name = "Nom";
            dgvClients.Columns[2].Name = "Prénom";
            dgvClients.Columns[3].Name = "Adresse";
            dgvClients.Columns[4].Name = "Téléphone";

            // 🔄 Charger les données depuis la base
            var clients = SQLDataAccess.ChargerClients();

            if (clients.Count == 0)
            {
                MessageBox.Show("Aucun client trouvé en base de données !", "Info");
            }

            foreach (var client in clients)
            {
                dgvClients.Rows.Add(client.ID, client.Nom, client.Prenom, client.Adresse, client.Telephone);

            }

            dgvClients.ClearSelection(); // ✅ Évite la sélection automatique de la première ligne
            dgvClients.CurrentCell = null;
           
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            AjouterClientForm ajouterClientForm = new AjouterClientForm();

            // ✅ Rafraîchir la liste après ajout
            ajouterClientForm.FormClosed += (s, args) => ChargerClients();

            ajouterClientForm.ShowDialog();
        }

        // activer "Modifier" uniquement si une ligne est sélectionnée
        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            btnModifierClient.Enabled = dgvClients.SelectedRows.Count > 0;
            btnSupprimerClient.Enabled = dgvClients.SelectedRows.Count > 0;
        }
       

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔄 Récupérer les infos du client sélectionné
            int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells[0].Value);
            string nom = dgvClients.SelectedRows[0].Cells[1].Value.ToString();
            string prenom = dgvClients.SelectedRows[0].Cells[2].Value.ToString();
            string adresse = dgvClients.SelectedRows[0].Cells[3].Value.ToString();
            string telephone = dgvClients.SelectedRows[0].Cells[4].Value.ToString();

            // 📝 Ouvrir le formulaire de modification
            ModifierClientForm modifierForm = new ModifierClientForm(clientId, nom, prenom, adresse, telephone);

            // ✅ Rafraîchir après modification
            modifierForm.FormClosed += (s, args) => ChargerClients();

            modifierForm.ShowDialog();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔄 Récupérer l'ID du client sélectionné
            int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells[0].Value);
            string clientNom = dgvClients.SelectedRows[0].Cells[1].Value.ToString() + " " + dgvClients.SelectedRows[0].Cells[2].Value.ToString();

            // ⚠ Confirmation avant suppression
            DialogResult result = MessageBox.Show($"Voulez-vous vraiment supprimer {clientNom} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // 🔥 Suppression du client
                SQLDataAccess.SupprimerClient(clientId);

                // ✅ Rafraîchir la liste après suppression
                ChargerClients();
            }
        }
    }
}
