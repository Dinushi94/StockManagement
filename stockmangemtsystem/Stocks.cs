using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZXing.QrCode.Internal;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
//using System.Data.SqlServer;

namespace stockmangemtsystem
{
    public partial class Stocks : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        int StockId = 0;
        public Stocks()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void submite_Click(object sender, EventArgs e)
        {

        }

        private void barcode_Click(object sender, EventArgs e)
        {

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void Produts_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;

            this.ActiveControl = DateTimePicker1;
            comboBox.SelectedIndex = 0;

            ResetRecord();
            FillDataGridView();

            SqlCommand cmd = new SqlCommand("SELECT ProductName FROM product",sqlCon);
            sqlCon.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollecton mycollection = new AutoCompleteStringCollecton();

            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }
            TextBox2.AutoCompleteCustomSource = mycollection;
            sqlCon.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Produts_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        

        private void Produts_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        
        private void profite_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox1.Focus();
            }
        }
        private void ResetRecord()
        {
            DateTimePicker1.Value = DateTime.Now;
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            btnadd.Text = "Add";
            DateTimePicker1.Focus();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetRecord();
        }

      

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox2.Focus();
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox3.Focus();
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd.Focus();
               
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnadd.Text == "Add")
                {
                    SqlCommand sqlCmd = new SqlCommand("StockAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@StockId", 0);
                    sqlCmd.Parameters.AddWithValue("Barcode", TextBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ProductName", TextBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Quantity", TextBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value.Date);
                    sqlCmd.Parameters.AddWithValue("@Status", comboBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("StockAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@StockId", StockId);
                    sqlCmd.Parameters.AddWithValue("Barcode", TextBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ProductName", TextBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Quantity", TextBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value.Date);
                    sqlCmd.Parameters.AddWithValue("@Status", comboBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                }
                ResetRecord();
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("StockViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvstock.DataSource = dtbl;
            dgvstock.Columns[0].Visible = false;
            sqlCon.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void dgvstock_DoubleClick(object sender, EventArgs e)
        {
            if (dgvstock.CurrentRow.Index != -1)
            {
                StockId = Convert.ToInt32(dgvstock.CurrentRow.Cells[0].Value.ToString());
                TextBox1.Text = dgvstock.CurrentRow.Cells[1].Value.ToString();
                TextBox2.Text = dgvstock.CurrentRow.Cells[2].Value.ToString();
                TextBox3.Text = dgvstock.CurrentRow.Cells[3].Value.ToString();
                DateTimePicker1.Text = dgvstock.CurrentRow.Cells[4].Value.ToString();
                comboBox.Text = dgvstock.CurrentRow.Cells[5].Value.ToString();
                btnadd.Text = "Update";
               
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("StockDeletion", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("StockId", StockId);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                ResetRecord();
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnpSum_Click(object sender, EventArgs e)
        {
            
            label1.Text = dgvstock.Rows.Count.ToString();

        }

        private void btnqSum_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            for (A = 0; A < dgvstock.Rows.Count; A++)
            {
                B += Convert.ToInt32(dgvstock.Rows[A].Cells[3].Value);
            }
            label3.Text = B.ToString();
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
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            if (bitmap != null)
            {
                try
                {
                    BarcodeReader reader = new BarcodeReader();

                    var result = reader.Decode(bitmap);
                    if (result != null)
                    {
                        TextBox1.Invoke(new MethodInvoker(delegate ()
                        {
                            TextBox1.Text = result.ToString();
                        }));
                    }
                    pictureBox.Image = bitmap;
                }
                catch (Exception e)
                {
                    //MessageBox.Show("" + e);
                }

            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void Produts_MouseMove(object sender, MouseEventArgs e)
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
