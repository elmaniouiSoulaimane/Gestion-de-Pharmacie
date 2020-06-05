using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie.Formulaires_Vendeur
{
    public partial class Liste_des_vendeurs : Form
    {
        public Liste_des_vendeurs()
        {
            InitializeComponent();
        }

        private void Liste_des_vendeurs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_de_pharmacieDataSet.Vendeurs' table. You can move, or remove it, as needed.
            this.vendeursTableAdapter.Fill(this.gestion_de_pharmacieDataSet.Vendeurs);

        }
    }
}
