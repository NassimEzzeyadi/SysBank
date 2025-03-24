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
    public partial class ModifierClientForm: Form
    {


        private int clientId;

        public ModifierClientForm(int id, string nom, string prenom, string adresse, string telephone)
        {
            InitializeComponent();
            clientId = id;
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtAdresse.Text = adresse;
            txtTelephone.Text = telephone;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string nouveauNom = txtNom.Text.Trim();
            string nouveauPrenom = txtPrenom.Text.Trim();
            string nouvelleAdresse = txtAdresse.Text.Trim();
            string nouveauTelephone = txtTelephone.Text.Trim();

            if (string.IsNullOrWhiteSpace(nouveauNom) || string.IsNullOrWhiteSpace(nouveauPrenom))
            {
                MessageBox.Show("Le nom et le prénom sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Mettre à jour en base
            SQLDataAccess.ModifierClient(clientId, nouveauNom, nouveauPrenom, nouvelleAdresse, nouveauTelephone);

            MessageBox.Show("Client modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
