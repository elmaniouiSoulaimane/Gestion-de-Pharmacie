using GestionDePharmacie.Entities;
using GestionDePharmacie.Formulaires_Client;
using GestionDePharmacie.Formulaires_Medecin;
using GestionDePharmacie.Formulaires_Vendeur;
using GestionDePharmacie.Formulaires_Medicaments;
using GestionDePharmacie.Formulaires_Ordonnance;
using GestionDePharmacie.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GestionDePharmacie
{
    public partial class Accueil : Form
    {
        public static Accueil mdiobj;
        public Accueil()
        {
            InitializeComponent();
        }
        Login_Form log = new Login_Form();
        Ajouter_Client aclt = new Ajouter_Client();
        Ajouter_Medecin amdc = new Ajouter_Medecin();
        Ajouter_Medicament amedi = new Ajouter_Medicament();
        Ajouter_Ordonnance ao = new Ajouter_Ordonnance();
        Ajouter_Vendeur av = new Ajouter_Vendeur();
        Modifier_Client mclt = new Modifier_Client();
        Modifier_Medecin mmed = new Modifier_Medecin();
        Modifier_Medicament mmedi = new Modifier_Medicament();
        Modifier_Vendeur mv = new Modifier_Vendeur();
        Supprimer_Client sclt = new Supprimer_Client();
        Supprimer_Medecin smed = new Supprimer_Medecin();
        Supprimer_Medicament smedi = new Supprimer_Medicament();
        Supprimer_Vendeur sv = new Supprimer_Vendeur();
        Factures.Facture facture = new Factures.Facture();
        Factures.Prescriptions prescriptions = new Factures.Prescriptions();
        MYDBC db = new MYDBC();
        private void Form1_Load(object sender, EventArgs e)
        {
            db.Database.CreateIfNotExists();
            menuStrip1.Enabled = false;
            aclt.MdiParent = this;
            amdc.MdiParent = this;
            amedi.MdiParent = this;
            ao.MdiParent = this;
            av.MdiParent = this;
            mclt.MdiParent = this;
            mmed.MdiParent = this;
            mmedi.MdiParent = this;
            mv.MdiParent = this;
            sclt.MdiParent = this;
            smed.MdiParent = this;
            smedi.MdiParent = this;
            sv.MdiParent = this;
            log.MdiParent = this;
            mdiobj = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Client nclt = new Ajouter_Client();
            nclt.Show();
        }

        private void modifierLesInformationsDunClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Client mdclt = new Modifier_Client();
            mdclt.Show();
        }

        private void supprimerUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Client sclt = new Supprimer_Client();
            sclt.Show();
        }

        private void nouveauMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Medecin amdc = new Ajouter_Medecin();
            amdc.Show();
        }

        private void modifierLesInformationsDunMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Medecin mmdc = new Modifier_Medecin();
            mmdc.Show();
        }

        private void supprimerUnMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Medecin smdc = new Supprimer_Medecin();
            smdc.Show();
        }

        private void nouveauVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Vendeur avndr = new Ajouter_Vendeur();
            avndr.Show();
        }

        private void modifierLesInformationsDunVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Vendeur mvndr = new Modifier_Vendeur();
            mvndr.Show();
        }

        private void supprimerUnVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Vendeur svndr = new Supprimer_Vendeur();
            svndr.Show();
        }

        private void nouveauMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Medicament amdc = new Ajouter_Medicament();
            amdc.Show();
        }

        private void modifierLesInfrmationsDunMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Medicament mmdc = new Modifier_Medicament();
            mmdc.Show();
        }

        private void supprimerMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Medicament smdc = new Supprimer_Medicament();
            smdc.Show();
        }

        private void listeDesMedicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facture.Show();
        }

        private void ajouterOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Ordonnance ao = new Ajouter_Ordonnance();
            ao.Show();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_des_clients lclt = new Liste_des_clients();
            lclt.Show();
        }

        private void listeDesMedecinsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_des_medecins lmd = new Liste_des_medecins();
            lmd.Show();
        }

        private void listeDesVendeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_des_vendeurs lv = new Liste_des_vendeurs();
            lv.Show();

        }

        private void listeDesMedicamentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Liste_des_medicaments lm = new Liste_des_medicaments();
            lm.Show();

        }

        private void listeDesOrdonnancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_des_ordonnances lo = new Liste_des_ordonnances();
            lo.Show();
        }

        private void prescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescriptions.Show();
        }
    }
}
