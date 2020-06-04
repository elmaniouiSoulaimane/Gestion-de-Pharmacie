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
    public partial class Supprimer_Medecin : Form
    {
        public Supprimer_Medecin()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        Boolean b = true;
        Medecin medecinres;
        private void Supprimer_Medecin_Load(object sender, EventArgs e)
        {
            //affichage des valeures du 1er combobox
            var m1 = from medecin in db.Medecins select medecin;
            comboBox1.DataSource = m1.ToList();
            b = true;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "MedID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Medecins.Remove(medecinres);

            db.SaveChanges();

            //affichage des valeures du 1er combobox
            var r1 = from medecin in db.Medecins select medecin;
            comboBox1.DataSource = r1.ToList();
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "MedID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cherche d'objet selectionner
            Medecin medecin1 = new Medecin();

            if (b == true)
            {
                medecin1 = (Medecin)comboBox1.SelectedValue;//recuperation d'objet selectionner

            }
            else
            {
                medecin1.MedID = (int)comboBox1.SelectedValue;
            }


            medecinres = db.Medecins.Where(x => x.MedID == medecin1.MedID).First();

            textBox1.Text = medecinres.Nom;
            textBox2.Text = medecinres.Prenom;
            textBox3.Text = medecinres.Adresse;

            b = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
