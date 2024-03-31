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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new WindowsFormsApp2.RestoranDataSet();
            this.stoTableAdapter = new WindowsFormsApp2.RestoranDataSetTableAdapters.StoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.stoPorudzbinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porudzbinaTableAdapter = new WindowsFormsApp2.RestoranDataSetTableAdapters.PorudzbinaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoPorudzbinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 649);
            this.dataGridView1.TabIndex = 0;
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
            // stoPorudzbinaBindingSource
            // 
            this.stoPorudzbinaBindingSource.DataMember = "StoPorudzbina";
            this.stoPorudzbinaBindingSource.DataSource = this.stoBindingSource;
            // 
            // porudzbinaTableAdapter
            // 
            this.porudzbinaTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.stoPorudzbinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource stoBindingSource;
        private RestoranDataSetTableAdapters.StoTableAdapter stoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource stoPorudzbinaBindingSource;
        private RestoranDataSetTableAdapters.PorudzbinaTableAdapter porudzbinaTableAdapter;
    }
}