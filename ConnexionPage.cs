using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systeme_bancaire
{
    public partial class ConnexionPage : Form
    {
        public ConnexionPage()
        {
            InitializeComponent();
        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            string identifiant = IdentifiantInput.Text;
            string motDePasse = MotdepasseInput.Text;

            var utilisateur = SQLDataAccess.VerifierUtilisateur(identifiant, motDePasse);

            if (utilisateur != null)
            {
                // ✅ Stocker les infos utilisateur dans UtilisateurSession
                UtilisateurSession.Prenom = utilisateur.Prénom;
                UtilisateurSession.Nom = utilisateur.Nom;

                // Ouvrir EcranPrincipal
                this.Hide();
                EcranPrincipal ecran = new EcranPrincipal();
                ecran.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Affichermdp_CheckedChanged(object sender, EventArgs e)
        {

            MotdepasseInput.UseSystemPasswordChar = false;

            // Afficher ou masquer le mot de passe
            if (Affichermdp.Checked)
                MotdepasseInput.PasswordChar = '\0'; // ✅ Affiche le mot de passe
            else
                MotdepasseInput.PasswordChar = '●'; // ✅ Cache le mot de passe avec un point noir
           
        }

       
    }
}
