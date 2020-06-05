using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie.Formulaires_Medecin
{
    public partial class Liste_des_medecins : Form
    {
        public Liste_des_medecins()
        {
            InitializeComponent();
        }

        private void Liste_des_medecins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_de_pharmacieDataSet2.Medecins' table. You can move, or remove it, as needed.
            this.medecinsTableAdapter.Fill(this.gestion_de_pharmacieDataSet2.Medecins);

        }
    }
}
