using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePharmacie.Entities
{
    class Ordonnance
    {
        [Key]
        public int OrdID { set; get; }
        public DateTime DateOrd { set; get; }


        //cles etrangers
        public int ClientID { set; get; }
        public int MedID { set; get; }
        public int Matricule { set; get; }


        [ForeignKey("ClientID")]
        public virtual Client client { set; get; }
        
        [ForeignKey("MedID")]
        public virtual Medecin medecin { set; get; }

        [ForeignKey("Matricule")]
        public virtual Vendeur vendeur { set; get; }

        public virtual ICollection<Medicament> medicaments { set; get; }
        public virtual ICollection<Facture> factures { set; get; }
    }
}
