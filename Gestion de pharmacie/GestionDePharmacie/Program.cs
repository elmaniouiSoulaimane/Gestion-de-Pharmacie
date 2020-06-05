using GestionDePharmacie.Formulaires_Client;
using GestionDePharmacie.Formulaires_Medecin;
using GestionDePharmacie.Formulaires_Medicaments;
using GestionDePharmacie.Formulaires_Vendeur;
using GestionDePharmacie.Formulaires_Ordonnance;
using GestionDePharmacie.Factures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Facture());
        }

        private static object Medicament()
        {
            throw new NotImplementedException();
        }
    }
    
}
