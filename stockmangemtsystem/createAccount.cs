using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace stockmangemtsystem
{
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
            textpasswrd.PasswordChar = '•';
        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createbuton_Click(object sender, EventArgs e)
        {
           
            //SqlConnection acountcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database\Stock.mdf;Integrated Security=True;Connect Timeout=30");

            //string qry = "INSERT INTO login (Name, UserName, NIC, Password) VALUES ('"+textName.Text+"','"+textUsernam.Text+"','"+textNic.Text+"','"+textpasswrd.Text+"')";

            //SqlCommand cmd = new SqlCommand(qry, acountcon);
            //try
            //{
            //    acountcon.Open();
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Inserted");
            //}
            //catch (Exception x)
            //{

            //    MessageBox.Show(x.Message);
            //}

            //Form1 main = new Form1();
            //main.Show();
            //this.Hide();


        }

        private void createAccount_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createbuton_Click_1(object sender, EventArgs e)
        {
            SqlConnection acountcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database\Stock.mdf;Integrated Security=True;Connect Timeout=30");

            string qry = "INSERT INTO login (Name, UserName, NIC, Password) VALUES ('" + textName.Text + "','" + textUsernam.Text + "','" + textNic.Text + "','" + textpasswrd.Text + "')";

            SqlCommand cmd = new SqlCommand(qry, acountcon);
            try
            {
                acountcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

            Login main = new Login();
            main.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void createAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void createAccount_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textUsernam.Focus();
            }
        }

        private void textUsernam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textNic.Focus();
            }
        }

        private void textNic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textpasswrd.Focus();
            }
        }

        private void textpasswrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createbuton.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void createAccount_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
