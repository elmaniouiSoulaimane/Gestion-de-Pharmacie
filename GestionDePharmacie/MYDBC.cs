using GestionDePharmacie.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDePharmacie
{
    class MYDBC : DbContext
    {
        public MYDBC() : base("Gestion de Pharmacie")
        {

        } 

        public DbSet<Client> Clients { set; get; }
        public DbSet<Vendeur> Vendeurs{ set; get; }
        public DbSet<Medecin> Medecins { set; get; }
        public DbSet<Facture> Factures{ set; get; }
        public DbSet<Medicament> Medicaments { set; get; }
        public DbSet<Ordonnance> Ordonnances { set; get; }
    }
}
