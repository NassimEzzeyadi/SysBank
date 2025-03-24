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
    public partial class AjouterClientForm: Form
    {
        public AjouterClientForm()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string prenom = txtPrenom.Text.Trim();
            string nom = txtNom.Text.Trim();
            string adresse = txtAdresse.Text.Trim();
            string telephone = txtTelephone.Text.Trim();

            // Vérifie que les champs obligatoires sont remplis
            if (string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Prénom et Nom sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Appelle la méthode pour insérer le client dans la BDD
            try
            {
                SQLDataAccess.AjouterClient(prenom, nom, adresse, telephone);
                MessageBox.Show("Client ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Ferme le pop-up après succès
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
