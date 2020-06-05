using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie.Factures
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        private void Facture_Load(object sender, EventArgs e)
        {
            ListMedi cr = new ListMedi();
            var r = from m in db.Medicaments select m;
            cr.SetDataSource(r.ToList());
            crystalReportViewer1.ReportSource = null; //vider le cr
            crystalReportViewer1.ReportSource = cr; //remplir
            crystalReportViewer1.RefreshReport(); //actualisation du cr
        }
        
    }
}
