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
    public partial class ComptesPage: Form
    {
        public ComptesPage()
        {
            InitializeComponent();
        }
        private void ComptesPage_Load(object sender, EventArgs e)
        {
            ChargerComptes();
        }
       

        private void ChargerComptes()
        {
            dgvComptes.Rows.Clear();
            dgvComptes.Columns.Clear();

            // 📋 Ajouter les colonnes
            dgvComptes.ColumnCount = 5;
            dgvComptes.Columns[0].Name = "ID";
            dgvComptes.Columns[1].Name = "Numéro de Compte";
            dgvComptes.Columns[2].Name = "Solde";
            dgvComptes.Columns[3].Name = "Devise";
            dgvComptes.Columns[4].Name = "ClientID"; // Add this line


            // 🔄 Récupérer les comptes depuis la base de données
            var comptes = SQLDataAccess.ChargerComptes();

            foreach (var compte in comptes)
            {
                dgvComptes.Rows.Add(compte.ID, compte.NumeroCompte, compte.Solde.ToString("C"), compte.Devise, compte.ClientID);
            }

            dgvComptes.ClearSelection(); // ✅ Évite la sélection automatique
        }

        private void btnAjouterCompte_Click(object sender, EventArgs e)
        {
            AjouterCompteForm ajouterForm = new AjouterCompteForm();
            ajouterForm.CompteAjoute += (s, args) => ChargerComptes(); // 🔄 Rafraîchir après ajout
            ajouterForm.ShowDialog();
        }

        private void btnModifierCompte_Click(object sender, EventArgs e)
        {
            if (dgvComptes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez un compte à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvComptes.SelectedRows[0];
            int id = (int)row.Cells["ID"].Value;
            string numero = row.Cells["Numéro de Compte"].Value.ToString();
            decimal solde = decimal.Parse(row.Cells["Solde"].Value.ToString().Replace("€", "").Trim());
            string devise = row.Cells["Devise"].Value.ToString();
            int clientId = (int)row.Cells["ClientID"].Value;

            ModifierCompteForm modifForm = new ModifierCompteForm(id, numero, solde, devise, clientId);
            modifForm.CompteModifie += (s, args) => ChargerComptes();
            modifForm.ShowDialog();
        }

        private void dgvComptes_SelectionChanged(object sender, EventArgs e)
        {
            btnModifierCompte.Enabled = dgvComptes.SelectedRows.Count > 0;
            btnSupprimerCompte.Enabled = dgvComptes.SelectedRows.Count > 0;
        }

        private void btnSupprimerCompte_Click(object sender, EventArgs e)
        {
            if (dgvComptes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez un compte à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvComptes.SelectedRows[0];
            int id = (int)row.Cells["ID"].Value;

            var confirmation = MessageBox.Show("Voulez-vous vraiment supprimer ce compte ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                SQLDataAccess.SupprimerCompte(id);
                ChargerComptes(); // 🔄 Rafraîchir après suppression
            }
        }
    }
}
