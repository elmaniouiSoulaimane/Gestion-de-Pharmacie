using GestionDePharmacie.Entities;
using GestionDePharmacie.Formulaires_Client;
using GestionDePharmacie.Formulaires_Medecin;
using GestionDePharmacie.Formulaires_Vendeur;
using GestionDePharmacie.Formulaires_Medicaments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie.Formulaires_Ordonnance
{
    public partial class Ajouter_Ordonnance : Form
    {
        public Ajouter_Ordonnance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Client nouveauClt = new Ajouter_Client();
            nouveauClt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajouter_Medecin nouveaumdc = new Ajouter_Medecin();
            nouveaumdc.Show();
        }
    }
}
