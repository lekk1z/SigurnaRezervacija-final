using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet.Sto' table. You can move, or remove it, as needed.
            this.stoTableAdapter.Fill(this.restoranDataSet.Sto);
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand command = new OleDbCommand("SELECT Sto.id_stola, Kupac.ime, Kupac.telefon, Kupac.rezervacija FROM Kupac INNER JOIN Sto ON Kupac.[id_kupac] = Sto.[id_kupca] WHERE (((Sto.rezervisan)=True));\r\n", connection);
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
