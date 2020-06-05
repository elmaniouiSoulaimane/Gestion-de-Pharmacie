namespace GestionDePharmacie.Formulaires_Ordonnance
{
    partial class Liste_des_ordonnances
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
            this.gestion_de_pharmacieDataSet4 = new GestionDePharmacie.Gestion_de_pharmacieDataSet4();
            this.ordonnancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordonnancesTableAdapter = new GestionDePharmacie.Gestion_de_pharmacieDataSet4TableAdapters.OrdonnancesTableAdapter();
            this.ordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordIDDataGridViewTextBoxColumn,
            this.dateOrdDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.medIDDataGridViewTextBoxColumn,
            this.matriculeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordonnancesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestion_de_pharmacieDataSet4
            // 
            this.gestion_de_pharmacieDataSet4.DataSetName = "Gestion_de_pharmacieDataSet4";
            this.gestion_de_pharmacieDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordonnancesBindingSource
            // 
            this.ordonnancesBindingSource.DataMember = "Ordonnances";
            this.ordonnancesBindingSource.DataSource = this.gestion_de_pharmacieDataSet4;
            // 
            // ordonnancesTableAdapter
            // 
            this.ordonnancesTableAdapter.ClearBeforeFill = true;
            // 
            // ordIDDataGridViewTextBoxColumn
            // 
            this.ordIDDataGridViewTextBoxColumn.DataPropertyName = "OrdID";
            this.ordIDDataGridViewTextBoxColumn.HeaderText = "OrdID";
            this.ordIDDataGridViewTextBoxColumn.Name = "ordIDDataGridViewTextBoxColumn";
            this.ordIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrdDataGridViewTextBoxColumn
            // 
            this.dateOrdDataGridViewTextBoxColumn.DataPropertyName = "DateOrd";
            this.dateOrdDataGridViewTextBoxColumn.HeaderText = "DateOrd";
            this.dateOrdDataGridViewTextBoxColumn.Name = "dateOrdDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // medIDDataGridViewTextBoxColumn
            // 
            this.medIDDataGridViewTextBoxColumn.DataPropertyName = "MedID";
            this.medIDDataGridViewTextBoxColumn.HeaderText = "MedID";
            this.medIDDataGridViewTextBoxColumn.Name = "medIDDataGridViewTextBoxColumn";
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            // 
            // Liste_des_ordonnances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 271);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Liste_des_ordonnances";
            this.Text = "Liste_des_ordonnances";
            this.Load += new System.EventHandler(this.Liste_des_ordonnances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Gestion_de_pharmacieDataSet4 gestion_de_pharmacieDataSet4;
        private System.Windows.Forms.BindingSource ordonnancesBindingSource;
        private Gestion_de_pharmacieDataSet4TableAdapters.OrdonnancesTableAdapter ordonnancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
    }
}