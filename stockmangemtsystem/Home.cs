using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockmangemtsystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void supplesbutton_Click(object sender, EventArgs e)
        {
            //when clikc the button user goin to supler forum
            ProReport supl = new ProReport();
            supl.Show();
        }

        

        private void produtsbutton_Click(object sender, EventArgs e)
        {
            //when click the button user goin to products fornm
            Stocks produts = new Stocks();
            produts.Show();

        }

        private void productMangeButton_Click(object sender, EventArgs e)
        {
            //when the buton click user goes to produts manaegmt forum
            Products promage = new Products();
            promage.Show();

        }
        private void StockReport_Click(object sender, EventArgs e)
        {
            //when the buton click user goes to produts manaegmt forum
            StockReport strpt = new StockReport();
            strpt.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}
