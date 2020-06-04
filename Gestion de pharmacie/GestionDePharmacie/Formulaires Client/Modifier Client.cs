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

namespace GestionDePharmacie.Formulaires_Client
{
    public partial class Modifier_Client : Form
    {
        public Modifier_Client()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        Boolean b = true;
        Client cltres;
        private void Modifier_Client_Load(object sender, EventArgs e)
        {
            //affichage des valeures du 1er combobox
            var c1 = from client in db.Clients select client;
            comboBox1.DataSource = c1.ToList();
            b = true;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "ClientID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cherche d'objet selectionner
            Client clt1 = new Client();

            if (b == true)
            {
                clt1 = (Client)comboBox1.SelectedValue;//recuperation d'objet selectionner

            }
            else
            {
                clt1.ClientID = (int)comboBox1.SelectedValue;
      
            }


            cltres = db.Clients.Where(x => x.ClientID == clt1.ClientID).First();

            textBox1.Text = cltres.Nom;
            textBox2.Text = cltres.Prenom;
            textBox3.Text = cltres.Adresse;

            b = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cltres.Nom = textBox1.Text;
            cltres.Prenom = textBox2.Text;
            cltres.Adresse = textBox3.Text;

            //valider le changement
            db.SaveChanges();

            //affichage des valeures du 1er combobox
            var r = from clt in db.Clients select clt;
            comboBox1.DataSource = r.ToList();
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "ClientID";
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
            this.Close();
        }
    }
}
