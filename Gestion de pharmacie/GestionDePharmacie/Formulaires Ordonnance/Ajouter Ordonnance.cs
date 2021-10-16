using System;
using System.Collections.Generic;
using System.ComponentModel;
using GestionDePharmacie.Entities;
using GestionDePharmacie.Formulaires_Client;
using GestionDePharmacie.Formulaires_Medecin;
using GestionDePharmacie.Formulaires_Vendeur;
using GestionDePharmacie.Formulaires_Medicaments;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie.Formulaires_Ordonnance
{
    public partial class Ajouter_Ordonnance : Form
    {
        public Ajouter_Ordonnance()
        {
            InitializeComponent();
        }
        MYDBC db = new MYDBC();
        private void Ajouter_Ordonnance_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;


            dataGridView1.Columns[0].Name = "Prix";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns[1].Name = "Qantité";
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns[2].Name = "Total";

            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            var r = from m in db.Medicaments select m;
            cb.HeaderText = "Medicament";
            cb.DataSource = r.ToList();
            cb.DisplayMember = "Designation";
            cb.ValueMember = "MedID";

            dataGridView1.Columns.Insert(0, cb);


            //affichage des clients
            var clt = from c in db.Clients select c;
            comboBox1.DataSource = clt.ToList();
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "ClientID";

            //affichage des medecins
            var med = from m in db.Medecins select m;
            comboBox2.DataSource = med.ToList();
            comboBox2.DisplayMember = "Nom";
            comboBox2.ValueMember = "MedID";

        }
        ComboBox cb;
        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            cb = e.Control as ComboBox;

            if (cb != null)
            {


                cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged_1);
            }

        }
        List<int> colID = new List<int>();
        private void cb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue != null)
            {

                string ID = (sender as ComboBox).SelectedValue.ToString();

                if (ID != "GestionDePharmacie.Entities.Medicament")
                {
                    if (int.Parse(ID) > 0)
                    {
                        Medicament m1 = new Medicament();
                        m1.MedID = int.Parse(ID);
                        Medicament m = db.Medicaments.Where(x => x.MedID == m1.MedID).First();
                        dataGridView1.CurrentRow.Cells[1].Value = m.Prix;
                        colID.Add(m1.MedID);

                    }
                }

            }

        }
        int j;
        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            j = e.RowIndex;
        }
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                //dataGridView1.CurrentRow.Cells[3].Value = m.prix * (int)dataGridView1.CurrentRow.Cells[2].Value;
                dataGridView1.CurrentRow.Cells[3].Value = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()) * int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ajouter_Client nouveauClt = new Ajouter_Client();
            nouveauClt.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Ajouter_Medecin nouveaumdc = new Ajouter_Medecin();
            nouveaumdc.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Ordonnance o = new Ordonnance();
            Facture f = new Facture();

            o.DateOrd = dateTimePicker1.Value;

            o.ClientID = int.Parse(comboBox1.SelectedValue.ToString());
            o.MedID = int.Parse(comboBox2.SelectedValue.ToString());
            Medecin md = db.Medecins.Where(x => x.MedID == o.MedID).First();
            md.ordonnances.Add(o);
            o.Matricule = 5;

            float TotalFacture = 0;
            int i = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (i == dataGridView1.Rows.Count - 1) { break; }

                Medicament m1 = new Medicament();


                TotalFacture = TotalFacture + float.Parse(r.Cells[3].Value.ToString());

                m1.MedID = colID[i];
                i++;
                Medicament m = db.Medicaments.Where(x => x.MedID == m1.MedID).First();

                m.ordonnances.Add(o);
                o.medicaments.Add(m);




            }
            f.DateFact = DateTime.Now;
            f.ordonnances.Add(o);
            o.factures.Add(f);
            f.Montant = TotalFacture;

            db.Factures.Add(f);
            db.Ordonnances.Add(o);
            db.SaveChanges();

            MessageBox.Show("Your prescription has been added successfuly");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Medecin m = db.Medecins.First();

            foreach (var o in m.ordonnances) { MessageBox.Show(o.OrdID.ToString()); }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
