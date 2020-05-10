using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePharmacie.Entities
{
    class Facture
    {
        [Key]
        public int FactureID { set; get; }
        public DateTime DateFact { set; get; }
        public float Montant { set; get; }

        public virtual ICollection<Ordonnance> ordonnances { set; get; }
    }
}
