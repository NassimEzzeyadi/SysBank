using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeme_bancaire
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string ClientNom { get; set; }
        public string Type { get; set; }
        public decimal Montant { get; set; }
    }
}
