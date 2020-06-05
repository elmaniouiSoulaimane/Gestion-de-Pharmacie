namespace GestionDePharmacie.Formulaires_Vendeur
{
    partial class Liste_des_vendeurs
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
            this.gestion_de_pharmacieDataSet = new GestionDePharmacie.Gestion_de_pharmacieDataSet();
            this.vendeursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendeursTableAdapter = new GestionDePharmacie.Gestion_de_pharmacieDataSetTableAdapters.VendeursTableAdapter();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motdepassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbConDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derniereconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.motdepassDataGridViewTextBoxColumn,
            this.nbConDataGridViewTextBoxColumn,
            this.derniereconDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendeursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestion_de_pharmacieDataSet
            // 
            this.gestion_de_pharmacieDataSet.DataSetName = "Gestion_de_pharmacieDataSet";
            this.gestion_de_pharmacieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendeursBindingSource
            // 
            this.vendeursBindingSource.DataMember = "Vendeurs";
            this.vendeursBindingSource.DataSource = this.gestion_de_pharmacieDataSet;
            // 
            // vendeursTableAdapter
            // 
            this.vendeursTableAdapter.ClearBeforeFill = true;
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            this.matriculeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // motdepassDataGridViewTextBoxColumn
            // 
            this.motdepassDataGridViewTextBoxColumn.DataPropertyName = "Motdepass";
            this.motdepassDataGridViewTextBoxColumn.HeaderText = "Motdepass";
            this.motdepassDataGridViewTextBoxColumn.Name = "motdepassDataGridViewTextBoxColumn";
            // 
            // nbConDataGridViewTextBoxColumn
            // 
            this.nbConDataGridViewTextBoxColumn.DataPropertyName = "nbCon";
            this.nbConDataGridViewTextBoxColumn.HeaderText = "nbCon";
            this.nbConDataGridViewTextBoxColumn.Name = "nbConDataGridViewTextBoxColumn";
            // 
            // derniereconDataGridViewTextBoxColumn
            // 
            this.derniereconDataGridViewTextBoxColumn.DataPropertyName = "Dernierecon";
            this.derniereconDataGridViewTextBoxColumn.HeaderText = "Dernierecon";
            this.derniereconDataGridViewTextBoxColumn.Name = "derniereconDataGridViewTextBoxColumn";
            // 
            // Liste_des_vendeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 301);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Liste_des_vendeurs";
            this.Text = "Liste_des_vendeurs";
            this.Load += new System.EventHandler(this.Liste_des_vendeurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_pharmacieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendeursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Gestion_de_pharmacieDataSet gestion_de_pharmacieDataSet;
        private System.Windows.Forms.BindingSource vendeursBindingSource;
        private Gestion_de_pharmacieDataSetTableAdapters.VendeursTableAdapter vendeursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motdepassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbConDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derniereconDataGridViewTextBoxColumn;
    }
}