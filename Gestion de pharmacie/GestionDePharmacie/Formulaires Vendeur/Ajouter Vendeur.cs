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
    public partial class Ajouter_Vendeur : Form
    {
        public Ajouter_Vendeur()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        private void button1_Click(object sender, EventArgs e)
        {
            //creation d'un vendeur
            Vendeur v = new Vendeur();

            v.Nom = textBox1.Text;
            v.Prenom = textBox2.Text;
            v.Login = textBox3.Text;
            v.Motdepass = textBox4.Text;
            v.Dernierecon = dateTimePicker1.Value;

            db.Vendeurs.Add(v);
            db.SaveChanges();

            MessageBox.Show("Le vendeur "+v.Nom + "a etait ajouter avec succees");
            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Vendeur_Load(object sender, EventArgs e)
        {

        }
    }
}
