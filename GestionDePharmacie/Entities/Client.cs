using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePharmacie.Entities
{
    class Client
    {
        [Key]
        public int ClientID { set; get;}
        public string Nom { set; get; }
        public string Prenom { set; get; }
        public string Adresse { set; get; }

        public virtual ICollection<Ordonnance> Ordonnances { set; get; }
    }
}
