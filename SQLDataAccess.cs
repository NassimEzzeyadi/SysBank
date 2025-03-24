using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Systeme_bancaire
{
    public class SQLDataAccess
    {
        

        public static dynamic VerifierUtilisateur(string identifiant, string motdepasse)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();

                string query = "SELECT Prénom, Nom, Motdepasse FROM Utilisateurs WHERE Identifiant = @Identifiant";
                var utilisateur = conn.QueryFirstOrDefault<dynamic>(query, new { Identifiant = identifiant });

                if (utilisateur != null && utilisateur.Motdepasse == motdepasse)
                {
                    return utilisateur; // ✅ Retourne l'utilisateur complet
                }

                return null;
            }
        }
        public static List<Client> ChargerClients()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "SELECT ID, Prenom, Nom, Adresse, Telephone FROM Clients";
                var clients = conn.Query<Client>(query).ToList();
                return clients;
            }
        }

        public static List<Compte> ChargerComptes()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "SELECT ID, NumeroCompte, ClientID, Solde, Devise FROM Comptes ORDER BY NumeroCompte";
                return conn.Query<Compte>(query).ToList();
            }
        }


        public static int CompterElements(string table)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM {table}";
                return conn.ExecuteScalar<int>(query);
            }
        }

        public static decimal SommeColonne(string table, string colonne)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = $"SELECT IFNULL(SUM({colonne}), 0) FROM {table}";
                return conn.ExecuteScalar<decimal>(query);
            }
        }


        public static List<Transaction> DernieresTransactions(int limite = 10)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = $"SELECT ID, Date, ClientNom, Type, Montant FROM Transactions ORDER BY Date DESC LIMIT @Limite";
                return conn.Query<Transaction>(query, new { Limite = limite }).ToList();
            }
        }
        public static void AjouterCompte(string numeroCompte, decimal solde, string devise, int clientId)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "INSERT INTO Comptes (NumeroCompte, Solde, Devise, ClientID) VALUES (@NumeroCompte, @Solde, @Devise, @ClientID)";
                conn.Execute(query, new { NumeroCompte = numeroCompte, Solde = solde, Devise = devise, ClientID = clientId });
            }
        }



        public static void AjouterClient(string prenom, string nom, string adresse, string telephone)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "INSERT INTO Clients (Prenom, Nom, Adresse, Telephone) VALUES (@Prenom, @Nom, @Adresse, @Telephone)";
                conn.Execute(query, new { Prenom = prenom, Nom = nom, Adresse = adresse, Telephone = telephone });
            }
        }

        public static int AjouterTransaction(int compteId, string type, decimal montant, string clientNom)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();

                // ✅ Insérer la transaction et récupérer l'ID
                string insertQuery = @"
            INSERT INTO Transactions (CompteID, Date, Type, Montant, ClientNom)
            VALUES (@CompteID, @Date, @Type, @Montant, @ClientNom);
            SELECT last_insert_rowid();"; // ⬅️ SQLite retourne l'ID de la dernière insertion

                int transactionId = conn.ExecuteScalar<int>(insertQuery, new
                {
                    CompteID = compteId,
                    Date = DateTime.Now,
                    Type = type,
                    Montant = montant,
                    ClientNom = clientNom
                });

                // 🔄 Mettre à jour le solde du compte
                string updateSoldeQuery = type == "Retrait"
                    ? "UPDATE Comptes SET Solde = Solde - @Montant WHERE ID = @CompteID"
                    : "UPDATE Comptes SET Solde = Solde + @Montant WHERE ID = @CompteID";

                conn.Execute(updateSoldeQuery, new { Montant = montant, CompteID = compteId });

                return transactionId;
            }
        }

        public static void ModifierClient(int id, string nom, string prenom, string adresse, string telephone)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "UPDATE Clients SET Nom = @Nom, Prenom = @Prenom, Adresse = @Adresse, Telephone = @Telephone WHERE ID = @ID";
                conn.Execute(query, new { ID = id, Nom = nom, Prenom = prenom, Adresse = adresse, Telephone = telephone });
            }
        }
        public static void ModifierCompte(int id, string numeroCompte, decimal solde, string devise, int clientId)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "UPDATE Comptes SET NumeroCompte = @NumeroCompte, Solde = @Solde, Devise = @Devise, ClientID = @ClientID WHERE ID = @ID";
                conn.Execute(query, new { ID = id, NumeroCompte = numeroCompte, Solde = solde, Devise = devise, ClientID = clientId });
            }
        }

        public static void SupprimerClient(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "DELETE FROM Clients WHERE ID = @ID";
                conn.Execute(query, new { ID = id });
            }
        }

        public static void SupprimerCompte(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();
                string query = "DELETE FROM Comptes WHERE ID = @ID";
                conn.Execute(query, new { ID = id });
            }
        }

        public static int RetirerArgent(int compteId, decimal montant)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();

                string query = @"
            UPDATE Comptes
            SET Solde = Solde - @Montant
            WHERE ID = @CompteID AND Solde >= @Montant"; // ✅ Vérifie qu'il y a assez d'argent

                conn.Execute(query, new { CompteID = compteId, Montant = montant });

                // ✅ Ajouter une transaction
                string insertTransaction = @"
            INSERT INTO Transactions (CompteID, Date, Type, Montant, ClientNom)
            VALUES (@CompteID, @Date, 'Retrait', @Montant, (SELECT Nom FROM Clients WHERE ID = (SELECT ClientID FROM Comptes WHERE ID = @CompteID)));
            SELECT last_insert_rowid();";

                return conn.ExecuteScalar<int>(insertTransaction, new { CompteID = compteId, Date = DateTime.Now, Montant = montant });
            }
        }

        public static int DeposerArgent(int compteId, decimal montant)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();

                string query = @"
            UPDATE Comptes
            SET Solde = Solde + @Montant
            WHERE ID = @CompteID";

                conn.Execute(query, new { CompteID = compteId, Montant = montant });

                // ✅ Ajouter une transaction
                string insertTransaction = @"
            INSERT INTO Transactions (CompteID, Date, Type, Montant, ClientNom)
            VALUES (@CompteID, @Date, 'Dépôt', @Montant, (SELECT Nom FROM Clients WHERE ID = (SELECT ClientID FROM Comptes WHERE ID = @CompteID)));
            SELECT last_insert_rowid();";

                return conn.ExecuteScalar<int>(insertTransaction, new { CompteID = compteId, Date = DateTime.Now, Montant = montant });
            }
        }
        public static int TransfertArgent(int compteSourceId, int compteDestId, decimal montant)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction()) // ✅ Sécurise l'opération avec une transaction SQL
                {
                    // ✅ Vérifier que le compte source a assez d'argent
                    string checkSolde = "SELECT Solde FROM Comptes WHERE ID = @CompteSourceID";
                    decimal soldeSource = conn.ExecuteScalar<decimal>(checkSolde, new { CompteSourceID = compteSourceId });

                    if (soldeSource < montant)
                    {
                        throw new Exception("Fonds insuffisants pour effectuer le transfert.");
                    }

                    // ✅ Débiter le compte source
                    string debitQuery = "UPDATE Comptes SET Solde = Solde - @Montant WHERE ID = @CompteSourceID";
                    conn.Execute(debitQuery, new { Montant = montant, CompteSourceID = compteSourceId });

                    // ✅ Créditez le compte destinataire
                    string creditQuery = "UPDATE Comptes SET Solde = Solde + @Montant WHERE ID = @CompteDestID";
                    conn.Execute(creditQuery, new { Montant = montant, CompteDestID = compteDestId });

                    // ✅ Ajouter une transaction
                    string insertTransaction = @"
                INSERT INTO Transactions (CompteID, Date, Type, Montant, ClientNom)
                VALUES (@CompteSourceID, @Date, 'Transfert', -@Montant, (SELECT Nom FROM Clients WHERE ID = (SELECT ClientID FROM Comptes WHERE ID = @CompteSourceID)));

                INSERT INTO Transactions (CompteID, Date, Type, Montant, ClientNom)
                VALUES (@CompteDestID, @Date, 'Transfert', @Montant, (SELECT Nom FROM Clients WHERE ID = (SELECT ClientID FROM Comptes WHERE ID = @CompteDestID)));
                SELECT last_insert_rowid();";

                    int transactionId = conn.ExecuteScalar<int>(insertTransaction, new
                    {
                        CompteSourceID = compteSourceId,
                        CompteDestID = compteDestId,
                        Date = DateTime.Now,
                        Montant = montant
                    });

                    transaction.Commit(); // ✅ Confirmer la transaction
                    return transactionId;
                }
            }
        }


        public static List<Transaction> RechercherTransactions(string critere)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\33766\\source\\repos\\Systeme bancaire\\BDD_SB.db"))
            {
                conn.Open();

                string query = @"
            SELECT ID, Date, ClientNom, Type, Montant
            FROM Transactions
            WHERE LOWER(ClientNom) LIKE @Critere
               OR LOWER(Type) LIKE @Critere
               OR CAST(ID AS TEXT) LIKE @Critere
               OR CAST(Montant AS TEXT) LIKE @Critere
            ORDER BY Date DESC";

                return conn.Query<Transaction>(query, new { Critere = "%" + critere + "%" }).ToList();
            }
        }



        // Vérifie si le mot de passe entré correspond au mot de passe stocké
        private static bool VerifierMotDePasse(string motDePasseEntre, string motDePasseStocke)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasseEntre));
                string hashEntre = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                return hashEntre == motDePasseStocke;
            }
        }
    }
}
