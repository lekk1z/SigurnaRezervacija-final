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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 formakonobar = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection=new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand command = new OleDbCommand($"select lozinka from radnik where ID={int.Parse(txbID.Text)}", connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Ovaj korisnik nije u bazi podataka");
            }
            else
            {
                if (dt.Rows[0][0].ToString() == txbPassword.Text)
                {
                    this.Visible = false;
                    formakonobar.Show();
                }
                else
                {
                    MessageBox.Show("Lozinka netacna");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet.Radnik' table. You can move, or remove it, as needed.
            this.radnikTableAdapter.Fill(this.restoranDataSet.Radnik);

        }
    }
}
