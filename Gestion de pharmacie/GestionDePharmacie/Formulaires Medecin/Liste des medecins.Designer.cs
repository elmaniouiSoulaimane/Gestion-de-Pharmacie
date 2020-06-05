namespace GestionDePharmacie.Formulaires_Medecin
{
    partial class Liste_des_medecins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestion_de_pharmacieDataSet2 = new GestionDePharmacie.Gestion_de_pharmacieDataSet2();
            this.medecinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinsTableAdapter = new GestionDePharmacie.Gestion_de_pharmacieDataSet2TableAdapters.MedecinsTableAdapter();
            this.medIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medIDDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medecinsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestion_de_pharmacieDataSet2
            // 
            this.gestion_de_pharmacieDataSet2.DataSetName = "Gestion_de_pharmacieDataSet2";
            this.gestion_de_pharmacieDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinsBindingSource
            // 
            this.medecinsBindingSource.DataMember = "Medecins";
            this.medecinsBindingSource.DataSource = this.gestion_de_pharmacieDataSet2;
            // 
            // medecinsTableAdapter
            // 
            this.medecinsTableAdapter.ClearBeforeFill = true;
            // 
            // medIDDataGridViewTextBoxColumn
            // 
            this.medIDDataGridViewTextBoxColumn.DataPropertyName = "MedID";
            this.medIDDataGridViewTextBoxColumn.HeaderText = "MedID";
            this.medIDDataGridViewTextBoxColumn.Name = "medIDDataGridViewTextBoxColumn";
            this.medIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // Liste_des_medecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 304);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Liste_des_medecins";
            this.Text = "Liste_des_medecins";
            this.Load += new System.EventHandler(this.Liste_des_medecins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Gestion_de_pharmacieDataSet2 gestion_de_pharmacieDataSet2;
        private System.Windows.Forms.BindingSource medecinsBindingSource;
        private Gestion_de_pharmacieDataSet2TableAdapters.MedecinsTableAdapter medecinsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
    }
}