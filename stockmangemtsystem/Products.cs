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
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace stockmangemtsystem
{
    public partial class Products : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database\Stock.mdf;Integrated Security=True;Connect Timeout=30");
        int ProductId = 0;
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void ProductsManager_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void ProductsManager_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("ProductViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name",txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgvproduct.DataSource = dtbl;
            dgvproduct.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvproduct_DoubleClick(object sender, EventArgs e)
        {
            if (dgvproduct.CurrentRow.Index != -1)
            {
                ProductId = Convert.ToInt32(dgvproduct.CurrentRow.Cells[0].Value.ToString());
                richTextBox3.Text = dgvproduct.CurrentRow.Cells[1].Value.ToString();
                richTextBox1.Text = dgvproduct.CurrentRow.Cells[2].Value.ToString();
                comboBox1.Text = dgvproduct.CurrentRow.Cells[3].Value.ToString();
                btnsave.Text = "Update";
                btndelete.Enabled = true;

            }
        }

        void Reset()
        {
            richTextBox3.Text = richTextBox1.Text = comboBox1.Text = "";
            btnsave.Text = "Save";
            ProductId = 0;
            //btndelete.Enabled = false;
        }

        

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        //public Result Value { get; private set; }

        private void ProductsManager_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;
            
            Reset();
            FillDataGridView();
        }

        

       
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            
            if(bitmap != null)
            {
                try
                {
                    BarcodeReader reader = new BarcodeReader();

                    var result = reader.Decode(bitmap);
                    if (result != null)
                    {
                        richTextBox3.Invoke(new MethodInvoker(delegate ()
                        {
                            richTextBox3.Text = result.ToString();
                        }));
                    }
                    pictureBox.Image = bitmap;
                }
                catch(Exception e)
                {
                    //MessageBox.Show("" + e);
                }
                
            }
            
        }

       
        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnsave.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("ProductAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@ProductId", 0);
                    sqlCmd.Parameters.AddWithValue("@Barcode", richTextBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ProductName", richTextBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Status", comboBox1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("ProductAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@ProductId", ProductId);
                    sqlCmd.Parameters.AddWithValue("@Barcode", richTextBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ProductName", richTextBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Status", comboBox1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                }
                Reset();
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

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("ProductDeletion", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@ProductId", ProductId);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Reset();
                FillDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnstart_Click_1(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void btnstop_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
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

        private void ProductsManager_MouseMove(object sender, MouseEventArgs e)
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
