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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        private void Prescriptions_Load(object sender, EventArgs e)
        {
            CrystalReport1 cr1 = new CrystalReport1();
            var r = from m in db.Ordonnances select m;
            cr1.SetDataSource(r.ToList());
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.RefreshReport();
        }
    }
}
