using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDePharmacie.Entities;

namespace GestionDePharmacie.Formulaires_Medecin
{
    public partial class Ajouter_Medecin : Form
    {
        public Ajouter_Medecin()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        private void Ajouter_Medecin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creation d'un client
            Medecin medecin = new Medecin();

            medecin.Nom = textBox1.Text;
            medecin.Prenom = textBox2.Text;
            medecin.Adresse = textBox3.Text;

            db.Medecins.Add(medecin);
            db.SaveChanges();

            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
