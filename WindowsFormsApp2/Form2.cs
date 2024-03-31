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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        int brojac = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 formarezervacije= new Form3();
            formarezervacije.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 formamagacin  = new Form4();
            formamagacin.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranDataSet.Sastav_porudzbine' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'restoranDataSet.Porudzbina' table. You can move, or remove it, as needed.
            this.porudzbinaTableAdapter.Fill(this.restoranDataSet.Porudzbina);
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand command = new OleDbCommand("select ime from hrana where kategorija=1",connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
            }
            OleDbCommand command2 = new OleDbCommand("select ime from hrana where kategorija=2", connection);
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                listView2.Items.Add(dt2.Rows[i][0].ToString());
            }


        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string izabrani = listView1.SelectedItems[0].Text;
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand vratiidhrane = new OleDbCommand($"select id_hrana from hrana where ime='{izabrani}';", connection);
            OleDbDataAdapter adapter3 = new OleDbDataAdapter(vratiidhrane);
            DataTable dt3 = new DataTable();
            adapter3.Fill(dt3);
            int idhrane = int.Parse(dt3.Rows[0][0].ToString());
            OleDbCommand proveri=new OleDbCommand($"select kolicina from Sastav_porudzbine where id_hrane={idhrane};",connection);
            OleDbDataAdapter adapter4 = new OleDbDataAdapter(proveri);
            DataTable dt4 = new DataTable();
            adapter4.Fill(dt4);

            if (dt4.Rows.Count == 0)
            {
                connection.Open();
                OleDbCommand upisi = new OleDbCommand($"insert into Sastav_porudzbine(id_porudzbine,id_hrane,kolicina) values ({numericUpDown1.Value},{idhrane},1)",connection);
                upisi.ExecuteNonQuery();

            }
            else
            {
                connection.Open();
                OleDbCommand dodaj = new OleDbCommand($"update Sastav_porudzbine set kolicina=kolicina+1 where id_hrane={idhrane} and id_porudzbine={numericUpDown1.Value};", connection);
                dodaj.ExecuteNonQuery();
            }
            
            MessageBox.Show(izabrani + " " + idhrane);
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand command = new OleDbCommand($"SELECT Hrana.ime, Sastav_porudzbine.kolicina, [hrana].[cena]*[sastav_porudzbine].[kolicina] AS Cena\r\nFROM Hrana INNER JOIN Sastav_porudzbine ON Hrana.[id_hrana] = Sastav_porudzbine.[id_hrane]\r\nWHERE (((Sastav_porudzbine.id_porudzbine)={numericUpDown1.Value}));", connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            string izabrani = listView2.SelectedItems[0].Text;
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.RestoranConnectionString);
            OleDbCommand vratiidhrane = new OleDbCommand($"select id_hrana from hrana where ime='{izabrani}';", connection);
            OleDbDataAdapter adapter3 = new OleDbDataAdapter(vratiidhrane);
            DataTable dt3 = new DataTable();
            adapter3.Fill(dt3);
            int idhrane = int.Parse(dt3.Rows[0][0].ToString());
            MessageBox.Show(izabrani + " " + idhrane);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brojac++;
            numericUpDown1.Value = brojac;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form5 formarezervacije = new Form5();
            formarezervacije.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //obrisi
            int a = dataGridView1.SelectedCells[0].RowIndex;
            MessageBox.Show(dataGridView1[1,a].Value.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
