using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet.Hrana' table. You can move, or remove it, as needed.
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand command = new OleDbCommand("SELECT Hrana.ime, Hrana.cena, Hrana.kolicina FROM Hrana;", connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 konobar = new Form2();
            this.Close();
            konobar.Visible = true;
        }
    }
}
