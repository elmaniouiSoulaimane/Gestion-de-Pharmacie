using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GestionDePharmacie
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"DATA SOURCE=CYBORG\INSTANCE1;Initial Catalog=Gestion de Pharmacie;INTEGRATED SECURITY=TRUE");
            con.Open();

            string log = textBox1.Text;
            string ps = textBox2.Text;

            string query = "select * from Vendeurs where Login=@user and Motdepass=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@user", log));
            cmd.Parameters.Add(new SqlParameter("@pass", ps));


            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                this.Hide();
                MessageBox.Show("Bienvenue "+log);
                Accueil.mdiobj.menuStrip1.Enabled = true;
                Accueil.mdiobj.Height = 376;
                Accueil.mdiobj.Width = 876;
               
            }
            else
            {
                MessageBox.Show("Le login ou le mot de passe n'est pas correct");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }


        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
