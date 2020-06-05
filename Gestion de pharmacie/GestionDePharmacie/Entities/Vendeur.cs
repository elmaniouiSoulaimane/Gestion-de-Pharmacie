using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePharmacie.Entities
{
    class Vendeur
    {
        public Vendeur()
        {
            this.ordonnances = new HashSet<Ordonnance>();

        }


        [Key]
        public int Matricule { set; get; }
        public string Nom { set; get; }
        public string Prenom { set; get; }
        public string Login { set; get; }
        public string Motdepass { set; get; }
        public int nbCon { set; get; }
        public DateTime Dernierecon { set; get; }

        public virtual ICollection<Ordonnance> ordonnances { set; get; }
    }
}
