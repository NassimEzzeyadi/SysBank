using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace Systeme_bancaire
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
           

        }
        private void LoadPage(Form page)
        {
            mainPanel.Controls.Clear();  // Vide le panel
            page.TopLevel = false;       // Intègre le formulaire dans le panel
            page.Dock = DockStyle.Fill;  // La page prend tout l'espace du panel
            mainPanel.Controls.Add(page);// Ajoute la page au panel
            page.Show();                 // Affiche la page
        }


        private void EcranPrincipal_Load(object sender, EventArgs e)
        {
            LoadPage(new AccueilPage());
            ActiverOnglet(btnAccueil); // ✅ L'onglet Accueil est actif au lancement

            lblNomUtilisateur.Text = $"{UtilisateurSession.Prenom} {UtilisateurSession.Nom}";

            // Style des boutons
            SiticoneButton[] boutons = { btnAccueil, btnClients, btnTransactions, btnComptes, btnDevises, btnParametres, btnDeconnexion };

            foreach (var btn in boutons)
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.White;
                btn.BorderColor = Color.White;
                btn.BorderThickness = 1;
                btn.HoverState.FillColor = Color.White;
                btn.HoverState.ForeColor = Color.Black;
            }
        }
        private void ActiverOnglet(SiticoneButton boutonActif)
        {
            // ✅ Déplacer la barre à côté du bouton actif
            activeIndicator.Top = boutonActif.Top;

            // ✅ Met à jour le style des boutons
            foreach (Control ctrl in menuPanel.Controls)
            {
                if (ctrl is SiticoneButton btn)
                {
                    if (btn == boutonActif)
                    {
                        // Bouton actif : texte blanc et fond bleu clair
                        btn.FillColor = Color.FromArgb(0, 150, 255);
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        // Boutons inactifs : fond transparent et texte blanc
                        btn.FillColor = Color.Transparent;
                        btn.ForeColor = Color.White;
                    }
                }
            }
        }


        private void btnAccueil_Click(object sender, EventArgs e)
        {
            LoadPage(new AccueilPage());
            ActiverOnglet(btnAccueil);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            LoadPage(new ClientsPage());
            ActiverOnglet(btnClients);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            LoadPage(new TransactionsPage());
            ActiverOnglet(btnTransactions);
        }

        private void btnComptes_Click(object sender, EventArgs e)
        {
            LoadPage(new ComptesPage());
            ActiverOnglet(btnComptes);
        }
    }


    
}
