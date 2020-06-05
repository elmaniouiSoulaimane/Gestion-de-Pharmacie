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

namespace GestionDePharmacie.Formulaires_Medicaments
{
    public partial class Supprimer_Medicament : Form
    {
        public Supprimer_Medicament()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        Medicament res;
        Boolean b = true;
        private void Supprimer_Medicament_Load(object sender, EventArgs e)
        {
            //affichage des valeures du 1er combobox
            var r1 = from m in db.Medicaments select m;
            comboBox1.DataSource = r1.ToList();
            b = true;
            comboBox1.DisplayMember = "RefMed";
            comboBox1.ValueMember = "MedID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cherche d'objet selectionner
            Medicament m1 = new Medicament();

            if (b == true)
            {
                m1 = (Medicament)comboBox1.SelectedValue;//recuperation d'objet selectionner

            }
            else
            {
                m1.MedID = (int)comboBox1.SelectedValue;
            }


            res = db.Medicaments.Where(x => x.MedID == m1.MedID).First();

            textBox1.Text = res.RefMed;
            textBox2.Text = res.Designation;
            textBox3.Text = res.Prix.ToString();
            textBox4.Text = res.QteStock.ToString();

            b = false;
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
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Medicaments.Remove(res);

            db.SaveChanges();

            MessageBox.Show("Le medicament "+res.Designation + "a etait supprimer avec succees");
            //affichage des valeures du 1er combobox
            var r1 = from m in db.Medicaments select m;
            comboBox1.DataSource = r1.ToList();
            comboBox1.DisplayMember = "RefMed";
            comboBox1.ValueMember = "MedID";
        }
    }
}
