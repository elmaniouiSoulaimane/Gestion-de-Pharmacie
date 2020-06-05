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
    public partial class Ajouter_Client : Form
    {
        public Ajouter_Client()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creation d'un client
            Client clt = new Client();
            
            clt.Nom = textBox1.Text;
            clt.Prenom = textBox2.Text;
            clt.Adresse = textBox3.Text;

            db.Clients.Add(clt);
            db.SaveChanges();

            button2_Click(sender, e);
        }

        private void Ajouter_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
