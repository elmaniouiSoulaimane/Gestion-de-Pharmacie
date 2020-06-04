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

namespace GestionDePharmacie.Formulaires_Vendeur
{
    public partial class Modifier_Vendeur : Form
    {
        public Modifier_Vendeur()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        Vendeur res;
        Boolean b = true;
        private void Modifier_Vendeur_Load(object sender, EventArgs e)
        {
            //affichage des valeures du 1er combobox
            var r1 = from v in db.Vendeurs select v;
            comboBox1.DataSource = r1.ToList();
            b = true;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "Matricule";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cherche d'objet selectionner
            Vendeur v1 = new Vendeur();

            if (b == true)
            {
                v1 = (Vendeur)comboBox1.SelectedValue;//recuperation d'objet selectionner

            }
            else
            {
                v1.Matricule = (int)comboBox1.SelectedValue;
            }


            res = db.Vendeurs.Where(x => x.Matricule == v1.Matricule).First();

            textBox1.Text = res.Nom;
            textBox2.Text = res.Prenom;
            textBox3.Text = res.Login;
            textBox4.Text = res.Motdepass;
            dateTimePicker1.Value = res.Dernierecon;


            b = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res.Nom = textBox1.Text;
            res.Prenom = textBox2.Text;
            res.Login = textBox3.Text;
            res.Motdepass = textBox4.Text;
            res.Dernierecon = dateTimePicker1.Value;

            //valider le changement
            db.SaveChanges();

            //affichage des valeures du 1er combobox
            var r = from v in db.Vendeurs select v;
            comboBox1.DataSource = r.ToList();
            b = true;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "Matricule";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
