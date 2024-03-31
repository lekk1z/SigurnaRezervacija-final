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
    public partial class Form6 : Form
    {
        int id_porudzbine;
        public Form6(int id_porudzbine)
        {
            InitializeComponent();
            this.id_porudzbine = id_porudzbine;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand itemizovano = new OleDbCommand($"SELECT hrana.ime, hrana.cena*Sastav_porudzbine.kolicina AS Expr1\r\nFROM Sastav_porudzbine, hrana\r\nWHERE (((Sastav_porudzbine.[id_porudzbine])={id_porudzbine})) and hrana.id_hrana=Sastav_porudzbine.id_hrane;",connection);
            OleDbCommand command = new OleDbCommand($"SELECT sum( hrana.cena * Sastav_porudzbine.kolicina)\r\nFROM Sastav_porudzbine, hrana\r\nWHERE(((Sastav_porudzbine.[id_porudzbine]) ={ id_porudzbine })) and hrana.id_hrana = Sastav_porudzbine.id_hrane; ",connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(itemizovano);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            DataTable dt2 = new DataTable();
            OleDbDataAdapter adapter2=new OleDbDataAdapter(command);
            adapter2.Fill(dt2);
            label2.Text = dt2.Rows[0][0].ToString();
            label8.Text = label2.Text;
            label5.Text=(double.Parse(label2.Text)*0.2).ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double predcena = double.Parse(label2.Text);
            double ukupno=predcena;
            if (radioButton1.Checked)
            {
                ukupno = predcena;
            }
            else if(radioButton2.Checked)
            {
                ukupno = predcena + predcena * 0.1;
            }
            else if (radioButton3.Checked)
            {
                ukupno = predcena + predcena * 0.15;
            }
            else if (radioButton4.Checked)
            {
                ukupno = predcena + predcena * 0.2;
            }
            label8.Text=ukupno.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nazad = new Form2();
            this.Close();
            nazad.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 nazad = new Form2();
            this.Close();
            nazad.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 nazad = new Form2();
            this.Close();
            nazad.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double predcena = double.Parse(label2.Text);
            double ukupno = predcena;
            if (radioButton1.Checked)
            {
                ukupno = predcena;
            }
            else if (radioButton2.Checked)
            {
                ukupno = predcena + predcena * 0.1;
            }
            else if (radioButton3.Checked)
            {
                ukupno = predcena + predcena * 0.15;
            }
            else if (radioButton4.Checked)
            {
                ukupno = predcena + predcena * 0.2;
            }
            label8.Text = ukupno.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double predcena = double.Parse(label2.Text);
            double ukupno = predcena;
            if (radioButton1.Checked)
            {
                ukupno = predcena;
            }
            else if (radioButton2.Checked)
            {
                ukupno = predcena + predcena * 0.1;
            }
            else if (radioButton3.Checked)
            {
                ukupno = predcena + predcena * 0.15;
            }
            else if (radioButton4.Checked)
            {
                ukupno = predcena + predcena * 0.2;
            }
            label8.Text = ukupno.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double predcena = double.Parse(label2.Text);
            double ukupno = predcena;
            if (radioButton1.Checked)
            {
                ukupno = predcena;
            }
            else if (radioButton2.Checked)
            {
                ukupno = predcena + predcena * 0.1;
            }
            else if (radioButton3.Checked)
            {
                ukupno = predcena + predcena * 0.15;
            }
            else if (radioButton4.Checked)
            {
                ukupno = predcena + predcena * 0.2;
            }
            label8.Text = ukupno.ToString();
        }
    }
}
