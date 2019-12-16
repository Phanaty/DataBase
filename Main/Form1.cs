using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://translate.google.by");
            request.Timeout = 5000;
            request.Credentials = CredentialCache.DefaultNetworkCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(
                    "Отсутствует интернет соединение",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox1.BackgroundImage = Properties.Resources.driver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
            pictureBox1.BackgroundImage = Properties.Resources.driver1;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox2.BackgroundImage = Properties.Resources.car;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.ButtonFace;
            pictureBox2.BackgroundImage = Properties.Resources.car2;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox3.BackgroundImage = Properties.Resources.warehouse;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.ButtonFace;
            pictureBox3.BackgroundImage = Properties.Resources.warehouse1;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox4.BackgroundImage = Properties.Resources.cargo1;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ButtonFace;
            pictureBox4.BackgroundImage = Properties.Resources.cargo;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox6.BackgroundImage = Properties.Resources.shipping1;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = SystemColors.ButtonFace;
            pictureBox6.BackgroundImage = Properties.Resources.shipping;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox5.BackgroundImage = Properties.Resources.price1;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = SystemColors.ButtonFace;
            pictureBox5.BackgroundImage = Properties.Resources.price;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox7.BackgroundImage = Properties.Resources.settings1;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = SystemColors.ButtonFace;
            pictureBox7.BackgroundImage = Properties.Resources.settings;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(78, 184, 206);
            pictureBox8.BackgroundImage = Properties.Resources.table1;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = SystemColors.ButtonFace;
            pictureBox8.BackgroundImage = Properties.Resources.table;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.Show();
        }
    }
}
