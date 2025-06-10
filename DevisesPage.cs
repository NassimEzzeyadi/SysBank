using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systeme_bancaire
{
    public partial class DevisesPage : Form
    {
        public DevisesPage()
        {
            InitializeComponent();
            // Appelle la méthode pour charger les devises dès l'ouverture de la page
            _ = ChargerDevises();
        }

        /// <summary>
        /// Charge les devises et leurs taux de change depuis une API externe.
        /// </summary>
        private async Task ChargerDevises()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // URL de l'API pour récupérer les taux de change avec une clé API
                    string apiKey = "ba85b585f8eacb0a5cfaa002"; // Remplacez par votre clé API valide
                    string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/EUR";

                    // Envoie une requête GET à l'API
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Vérifie que la requête a réussi

                    // Lit la réponse JSON de l'API
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    // Vérifie si la clé "conversion_rates" existe dans la réponse
                    if (data["conversion_rates"] == null)
                    {
                        MessageBox.Show("Impossible de récupérer les taux de change.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Récupère les taux de change sous forme de dictionnaire
                    var rates = data["conversion_rates"].ToObject<Dictionary<string, decimal>>();
                    var devises = rates.Keys.ToArray(); // Liste des devises disponibles

                    // Nettoie les ComboBox avant d'ajouter les nouvelles devises
                    cbDevisesDe.Items.Clear();
                    cbDevisesVers.Items.Clear();

                    // Ajoute les devises aux ComboBox
                    cbDevisesDe.Items.AddRange(devises);
                    cbDevisesVers.Items.AddRange(devises);

                    // Définit des valeurs par défaut pour les ComboBox
                    cbDevisesDe.SelectedItem = "EUR"; // Devise de base
                    cbDevisesVers.SelectedItem = "USD"; // Devise cible

                    // Remplit le DataGridView avec les taux de change
                    dgvTaux.Rows.Clear();
                    foreach (var rate in rates)
                    {
                        dgvTaux.Rows.Add(rate.Key, rate.Value); // Ajoute chaque devise et son taux
                    }
                }
                catch (Exception ex)
                {
                    // Affiche un message d'erreur en cas de problème avec l'API
                    MessageBox.Show($"Erreur de connexion à l'API : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Convertit un montant d'une devise à une autre en utilisant les taux de change.
        /// </summary>
        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            // Vérifie si le montant saisi est valide
            if (!decimal.TryParse(txtMontant.Text, out decimal montant) || montant <= 0)
            {
                MessageBox.Show("Montant invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupère les devises sélectionnées dans les ComboBox
            string deviseDe = cbDevisesDe.SelectedItem.ToString();
            string deviseVers = cbDevisesVers.SelectedItem.ToString();

            // Obtient le taux de change entre les deux devises
            decimal taux = await ObtenirTauxChange(deviseDe, deviseVers);

            // Vérifie si le taux est valide
            if (taux == 0)
            {
                MessageBox.Show($"Erreur de connexion à l'API.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Affiche le résultat de la conversion
            lblResultat.Text = $"Résultat : {(montant * taux):F2} {deviseVers}";
        }

        /// <summary>
        /// Récupère le taux de change entre deux devises depuis l'API.
        /// </summary>
        /// <param name="baseDevise">La devise de base (ex. EUR).</param>
        /// <param name="targetDevise">La devise cible (ex. USD).</param>
        /// <returns>Le taux de change ou 0 en cas d'erreur.</returns>
        private async Task<decimal> ObtenirTauxChange(string baseDevise, string targetDevise)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // URL de l'API pour récupérer les taux de change pour une devise spécifique
                    string apiKey = "ba85b585f8eacb0a5cfaa002";
                    string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{baseDevise}";

                    // Envoie une requête GET à l'API
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Vérifie que la requête a réussi

                    // Lit la réponse JSON de l'API
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    // Vérifie si le taux de change pour la devise cible existe
                    if (data["conversion_rates"] != null && data["conversion_rates"][targetDevise] != null)
                    {
                        return data["conversion_rates"][targetDevise].ToObject<decimal>();
                    }
                    else
                    {
                        return 0; // Retourne 0 si le taux n'est pas trouvé
                    }
                }
                catch
                {
                    // Retourne 0 en cas d'erreur (ex. problème de connexion)
                    return 0;
                }
            }
        }
    }
}
