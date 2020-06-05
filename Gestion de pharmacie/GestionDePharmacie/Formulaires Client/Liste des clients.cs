using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie.Formulaires_Client
{
    public partial class Liste_des_clients : Form
    {
        public Liste_des_clients()
        {
            InitializeComponent();
        }

        private void Liste_des_clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestion_de_pharmacieDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.gestion_de_pharmacieDataSet1.Clients);

        }
    }
}
