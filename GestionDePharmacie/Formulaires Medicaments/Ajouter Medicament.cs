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

namespace GestionDePharmacie
{
    public partial class Form_Medicament : Form
    {
        public Form_Medicament()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        private void Form_Medicament_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creation d'un medicament
            Medicament m = new Medicament();

            m.RefMed = textBox1.Text;
            m.Designation = textBox2.Text;
            m.Prix = float.Parse(textBox3.Text);
            m.QteStock = int.Parse(textBox4.Text);

            db.Medicaments.Add(m);
            db.SaveChanges();

            button2_Click(sender,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
