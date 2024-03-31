namespace WindowsFormsApp2
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.restoranDataSet = new WindowsFormsApp2.RestoranDataSet();
            this.sastavporudzbineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sastav_porudzbineTableAdapter = new WindowsFormsApp2.RestoranDataSetTableAdapters.Sastav_porudzbineTableAdapter();
            this.idporudzbineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhraneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastavporudzbineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idporudzbineDataGridViewTextBoxColumn,
            this.idhraneDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sastavporudzbineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 673);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1187, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 673);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sastavporudzbineBindingSource
            // 
            this.sastavporudzbineBindingSource.DataMember = "Sastav_porudzbine";
            this.sastavporudzbineBindingSource.DataSource = this.restoranDataSet;
            // 
            // sastav_porudzbineTableAdapter
            // 
            this.sastav_porudzbineTableAdapter.ClearBeforeFill = true;
            // 
            // idporudzbineDataGridViewTextBoxColumn
            // 
            this.idporudzbineDataGridViewTextBoxColumn.DataPropertyName = "id_porudzbine";
            this.idporudzbineDataGridViewTextBoxColumn.HeaderText = "id_porudzbine";
            this.idporudzbineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idporudzbineDataGridViewTextBoxColumn.Name = "idporudzbineDataGridViewTextBoxColumn";
            this.idporudzbineDataGridViewTextBoxColumn.Width = 125;
            // 
            // idhraneDataGridViewTextBoxColumn
            // 
            this.idhraneDataGridViewTextBoxColumn.DataPropertyName = "id_hrane";
            this.idhraneDataGridViewTextBoxColumn.HeaderText = "id_hrane";
            this.idhraneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idhraneDataGridViewTextBoxColumn.Name = "idhraneDataGridViewTextBoxColumn";
            this.idhraneDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastavporudzbineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource sastavporudzbineBindingSource;
        private RestoranDataSetTableAdapters.Sastav_porudzbineTableAdapter sastav_porudzbineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idporudzbineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhraneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
    }
}