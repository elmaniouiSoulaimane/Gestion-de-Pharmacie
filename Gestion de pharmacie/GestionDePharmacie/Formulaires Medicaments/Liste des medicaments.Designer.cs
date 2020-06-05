namespace GestionDePharmacie.Formulaires_Medicaments
{
    partial class Liste_des_medicaments
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
            this.gestion_de_pharmacieDataSet3 = new GestionDePharmacie.Gestion_de_pharmacieDataSet3();
            this.medicamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentsTableAdapter = new GestionDePharmacie.Gestion_de_pharmacieDataSet3TableAdapters.MedicamentsTableAdapter();
            this.medIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medIDDataGridViewTextBoxColumn,
            this.refMedDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.qteStockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestion_de_pharmacieDataSet3
            // 
            this.gestion_de_pharmacieDataSet3.DataSetName = "Gestion_de_pharmacieDataSet3";
            this.gestion_de_pharmacieDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentsBindingSource
            // 
            this.medicamentsBindingSource.DataMember = "Medicaments";
            this.medicamentsBindingSource.DataSource = this.gestion_de_pharmacieDataSet3;
            // 
            // medicamentsTableAdapter
            // 
            this.medicamentsTableAdapter.ClearBeforeFill = true;
            // 
            // medIDDataGridViewTextBoxColumn
            // 
            this.medIDDataGridViewTextBoxColumn.DataPropertyName = "MedID";
            this.medIDDataGridViewTextBoxColumn.HeaderText = "MedID";
            this.medIDDataGridViewTextBoxColumn.Name = "medIDDataGridViewTextBoxColumn";
            this.medIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refMedDataGridViewTextBoxColumn
            // 
            this.refMedDataGridViewTextBoxColumn.DataPropertyName = "RefMed";
            this.refMedDataGridViewTextBoxColumn.HeaderText = "RefMed";
            this.refMedDataGridViewTextBoxColumn.Name = "refMedDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // qteStockDataGridViewTextBoxColumn
            // 
            this.qteStockDataGridViewTextBoxColumn.DataPropertyName = "QteStock";
            this.qteStockDataGridViewTextBoxColumn.HeaderText = "QteStock";
            this.qteStockDataGridViewTextBoxColumn.Name = "qteStockDataGridViewTextBoxColumn";
            // 
            // Liste_des_medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 295);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Liste_des_medicaments";
            this.Text = "Liste_des_medicaments";
            this.Load += new System.EventHandler(this.Liste_des_medicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Gestion_de_pharmacieDataSet3 gestion_de_pharmacieDataSet3;
        private System.Windows.Forms.BindingSource medicamentsBindingSource;
        private Gestion_de_pharmacieDataSet3TableAdapters.MedicamentsTableAdapter medicamentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockDataGridViewTextBoxColumn;
    }
}