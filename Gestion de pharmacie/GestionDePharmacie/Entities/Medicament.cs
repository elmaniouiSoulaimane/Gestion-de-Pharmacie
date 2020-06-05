using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePharmacie.Entities
{
    class Medicament
    {
        public Medicament()
        {
            this.ordonnances = new HashSet<Ordonnance>();

        }
        [Key]
        public int MedID { set; get; }
        public string RefMed { set; get; }
        public string Designation { set; get; }
        public float Prix { set; get; }
        public int QteStock { set; get; }

        public virtual ICollection<Ordonnance> ordonnances { set; get; }
    }
}
