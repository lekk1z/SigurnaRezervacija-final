namespace WindowsFormsApp2
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkupcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervisanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new WindowsFormsApp2.RestoranDataSet();
            this.stoTableAdapter = new WindowsFormsApp2.RestoranDataSetTableAdapters.StoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstolaDataGridViewTextBoxColumn,
            this.idkupcaDataGridViewTextBoxColumn,
            this.rezervisanDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.stoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 649);
            this.dataGridView1.TabIndex = 0;
            // 
            // idstolaDataGridViewTextBoxColumn
            // 
            this.idstolaDataGridViewTextBoxColumn.DataPropertyName = "id_stola";
            this.idstolaDataGridViewTextBoxColumn.HeaderText = "id_stola";
            this.idstolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstolaDataGridViewTextBoxColumn.Name = "idstolaDataGridViewTextBoxColumn";
            this.idstolaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idkupcaDataGridViewTextBoxColumn
            // 
            this.idkupcaDataGridViewTextBoxColumn.DataPropertyName = "id_kupca";
            this.idkupcaDataGridViewTextBoxColumn.HeaderText = "id_kupca";
            this.idkupcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkupcaDataGridViewTextBoxColumn.Name = "idkupcaDataGridViewTextBoxColumn";
            this.idkupcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // rezervisanDataGridViewCheckBoxColumn
            // 
            this.rezervisanDataGridViewCheckBoxColumn.DataPropertyName = "rezervisan";
            this.rezervisanDataGridViewCheckBoxColumn.HeaderText = "rezervisan";
            this.rezervisanDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rezervisanDataGridViewCheckBoxColumn.Name = "rezervisanDataGridViewCheckBoxColumn";
            this.rezervisanDataGridViewCheckBoxColumn.Width = 125;
            // 
            // stoBindingSource
            // 
            this.stoBindingSource.DataMember = "Sto";
            this.stoBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stoTableAdapter
            // 
            this.stoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1197, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 673);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource stoBindingSource;
        private RestoranDataSetTableAdapters.StoTableAdapter stoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkupcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rezervisanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}