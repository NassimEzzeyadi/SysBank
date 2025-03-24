using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeme_bancaire
{
    public class Compte
    {
        public int ID { get; set; }
        public string NumeroCompte { get; set; }
        public int ClientID { get; set; }
        public decimal Solde { get; set; }
        public string Devise { get; set; }
    }
}
