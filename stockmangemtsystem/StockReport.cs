using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using stockmangemtsystem.Reports;

namespace stockmangemtsystem
{
    public partial class StockReport : Form
    {
        ReportDocument cry = new ReportDocument();

        public StockReport()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter dr;
        string fromdate;
        string todate;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void StockReport_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void StockReport_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTime.Now;
            DateTimePicker2.Value = DateTime.Now;

            /* cry.Load(@"C:\Users\Sandy\Desktop\Senali\Project\stocksystem - report\stockmangemtsystem\Reports\CrystalReport2.rpt");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database\Stock.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("GetStocks",con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet st = new System.Data.DataSet();
            sda.Fill(st, "stocks");
            cry.SetDataSource(st);
            crystalReportViewer1.ReportSource = cry;*/
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

        private void btnstart_Click(object sender, EventArgs e)
        {
            fromdate = DateTimePicker1.Value.Year + "-" + DateTimePicker1.Value.Month + "-" + DateTimePicker1.Value.Day;
            todate = DateTimePicker2.Value.Year + "-" + DateTimePicker2.Value.Month + "-" + DateTimePicker2.Value.Day;

            con.Open();

            DataTable dt = new DataTable();

            cmd = new SqlCommand("select * from stocks where Date between '" + fromdate + "'and'" + todate+"'", con);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            CrystalReport2 cr = new CrystalReport2();
            cr.Database.Tables["stocks"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;

            con.Close();
        }

        private void StockReport_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
