using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeme_bancaire
{
    class UtilisateurSession
    {
        public static string Prenom { get; set; }
        public static string Nom { get; set; }

        public static string NomComplet
        {
            get { return $"{Prenom} {Nom}"; }
        }

        public static void Deconnexion()
        {
            Prenom = null;
            Nom = null;
        }


    }
}
