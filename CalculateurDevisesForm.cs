using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Systeme_bancaire
{
    public partial class CalculateurDevisesForm : Form
    {
        public CalculateurDevisesForm()
        {
            InitializeComponent();
            _ = ChargerDevises();
        }

        private async Task ChargerDevises()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiKey = "ba85b585f8eacb0a5cfaa002"; // Mets ta vraie clé API
                    string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/EUR";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    // ✅ Vérifier si "conversion_rates" existe
                    if (data["conversion_rates"] == null)
                    {
                        MessageBox.Show("Impossible de récupérer les taux de change.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ✅ Récupérer la liste des devises
                    var rates = data["conversion_rates"].ToObject<Dictionary<string, decimal>>();
                    var devises = rates.Keys.ToArray(); // Liste des devises

                    // ✅ Nettoyer les ComboBox avant d'ajouter les nouvelles devises
                    cbDevisesDe.Items.Clear();
                    cbDevisesVers.Items.Clear();

                    // ✅ Ajouter les devises aux ComboBox
                    cbDevisesDe.Items.AddRange(devises);
                    cbDevisesVers.Items.AddRange(devises);

                    // ✅ Sélectionner une valeur par défaut
                    cbDevisesDe.SelectedItem = "EUR";
                    cbDevisesVers.SelectedItem = "USD";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur de connexion à l'API : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtMontant.Text, out decimal montant) || montant <= 0)
            {
                MessageBox.Show("Montant invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string deviseDe = cbDevisesDe.SelectedItem.ToString();
            string deviseVers = cbDevisesVers.SelectedItem.ToString();
            decimal taux = await ObtenirTauxChange(deviseDe, deviseVers);

            if (taux == 0)
            {
                MessageBox.Show($"Erreur de connexion à l'API.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblResultat.Text = $"Résultat : {(montant * taux):F2} {deviseVers}";
        }

        private async Task<decimal> ObtenirTauxChange(string baseDevise, string targetDevise)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiKey = "ba85b585f8eacb0a5cfaa002";
                    string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{baseDevise}";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    if (data["conversion_rates"] != null && data["conversion_rates"][targetDevise] != null)
                    {
                        return data["conversion_rates"][targetDevise].ToObject<decimal>();
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}
