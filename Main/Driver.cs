using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Main
{
    public partial class Driver : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=rajje.db.elephantsql.com;Port=5432;User Id=zinzcknb;Password=cgfKp39_0iVh_hl5jMVyWq6XWSxSe73W;Database=zinzcknb");
        List<Drivers_DataBase> drivers_DataBases = new List<Drivers_DataBase>();
        public Driver()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            LoadInfo();
            int i = 0;
            for (int j = 0; j < drivers_DataBases.Count(); j++)
            {
                dataGridView1.Rows.Add();
            }
            foreach(Drivers_DataBase dr in drivers_DataBases)
            {
                dataGridView1.Rows[i].Cells[0].Value = dr.Count;
                dataGridView1.Rows[i].Cells[1].Value = dr.Name;
                dataGridView1.Rows[i].Cells[2].Value = dr.SurName;
                dataGridView1.Rows[i].Cells[3].Value = dr.Experience;
                dataGridView1.Rows[i].Cells[4].Value = dr.ID_drivers;
                i++;
            }
        }

        public void LoadInfo()
        {
            connection.Open();
            NpgsqlCommand query = new NpgsqlCommand("Select * from bridesman", connection);
            NpgsqlDataReader reader = query.ExecuteReader();
            if (reader.HasRows)
            {
                foreach (DbDataRecord record in reader)
                {
                    drivers_DataBases.Add(new Drivers_DataBase
                    {
                        Count = Convert.ToString(record["№"]),
                        Name = Convert.ToString(record["Name"]),
                        SurName = Convert.ToString(record["SurName"]),
                        Experience = Convert.ToInt32(record["Experience"]),
                        ID_drivers = Convert.ToInt32(record["ID drivers"]),
                    });
                }
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Visible == true)
            {
                button1.BackgroundImage = Properties.Resources.plus;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            else
            {
                button4.Visible = true;
                button3.Visible = true;
                button2.Visible = true;
                button1.BackgroundImage = Properties.Resources.close;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand query = new NpgsqlCommand($"INSERT INTO bridesman  VALUES (DEFAULT, '{Convert.ToString(textBox1.Text)}', '{Convert.ToString(textBox2.Text)}', {Convert.ToInt32(textBox3.Text)}, {Convert.ToInt32(textBox4.Text)})", connection);
            query.ExecuteNonQuery();
            connection.Close();
            LoadInfo();
            int i = 0;
            for (int j = 0; j < drivers_DataBases.Count(); j++)
            {
                dataGridView1.Rows.Add();
            }
            foreach (Drivers_DataBase dr in drivers_DataBases)
            {
                dataGridView1.Rows[i].Cells[0].Value = dr.Count;
                dataGridView1.Rows[i].Cells[1].Value = dr.Name;
                dataGridView1.Rows[i].Cells[2].Value = dr.SurName;
                dataGridView1.Rows[i].Cells[3].Value = dr.Experience;
                dataGridView1.Rows[i].Cells[4].Value = dr.ID_drivers;
                i++;
            }
            connection.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            panel3.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel4.BackColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel5.BackColor = Color.White;
            textBox4.ForeColor = Color.White;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            panel2.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel3.BackColor = Color.FromArgb(78, 184, 206); ;
            textBox2.ForeColor = Color.FromArgb(78, 184, 206); ;

            panel4.BackColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel5.BackColor = Color.White;
            textBox4.ForeColor = Color.White;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            panel2.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel4.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            panel5.BackColor = Color.White;
            textBox4.ForeColor = Color.White;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();

            panel2.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel4.BackColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel5.BackColor = Color.FromArgb(78, 184, 206);
            textBox4.ForeColor = Color.FromArgb(78, 184, 206);
        }
    }
}
