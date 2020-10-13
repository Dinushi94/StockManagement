using System;

namespace stockmangemtsystem
{
    partial class Stocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.submite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.RichTextBox();
            this.dgvstock = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.btnpSum = new System.Windows.Forms.Button();
            this.btnqSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet11 = new stockmangemtsystem.Datas.DataSet1();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimePicker1.CheckedState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.FillColor = System.Drawing.Color.Blue;
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker1.HoverState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Location = new System.Drawing.Point(67, 32);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.ShadowDecoration.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.DateTimePicker1.TabIndex = 0;
            this.DateTimePicker1.Value = new System.DateTime(2020, 7, 11, 12, 49, 40, 272);
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            this.DateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateTimePicker1_KeyDown);
            // 
            // submite
            // 
            this.submite.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submite.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submite.Location = new System.Drawing.Point(1506, 136);
            this.submite.Name = "submite";
            this.submite.Size = new System.Drawing.Size(157, 44);
            this.submite.TabIndex = 40;
            this.submite.Text = "Submite";
            this.submite.UseVisualStyleBackColor = false;
            this.submite.Click += new System.EventHandler(this.submite_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(1191, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 65;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.close.Location = new System.Drawing.Point(1265, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 35);
            this.close.TabIndex = 64;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btnstop
            // 
            this.btnstop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnstop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnstop.Location = new System.Drawing.Point(395, 306);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(114, 44);
            this.btnstop.TabIndex = 96;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(227, 407);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(282, 30);
            this.TextBox1.TabIndex = 95;
            this.TextBox1.Text = "";
            this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(55, 185);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(324, 165);
            this.pictureBox.TabIndex = 94;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Camera";
            // 
            // btnreset
            // 
            this.btnreset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnreset.Location = new System.Drawing.Point(395, 592);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(114, 44);
            this.btnreset.TabIndex = 89;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btndelete.Location = new System.Drawing.Point(239, 592);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(114, 44);
            this.btndelete.TabIndex = 88;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadd.Location = new System.Drawing.Point(67, 592);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 44);
            this.btnadd.TabIndex = 85;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cboCamera
            // 
            this.cboCamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(239, 124);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(270, 21);
            this.cboCamera.TabIndex = 92;
            // 
            // btnstart
            // 
            this.btnstart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnstart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnstart.Location = new System.Drawing.Point(395, 243);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(114, 44);
            this.btnstart.TabIndex = 91;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Quantity
            // 
            this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Quantity.Location = new System.Drawing.Point(51, 514);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(92, 25);
            this.Quantity.TabIndex = 87;
            this.Quantity.Text = "Quantity";
            // 
            // ProductName
            // 
            this.ProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductName.Location = new System.Drawing.Point(50, 461);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(148, 25);
            this.ProductName.TabIndex = 84;
            this.ProductName.Text = "Product Name";
            // 
            // barcode
            // 
            this.barcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcode.AutoSize = true;
            this.barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.barcode.Location = new System.Drawing.Point(51, 412);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(92, 25);
            this.barcode.TabIndex = 83;
            this.barcode.Text = "Barcode";
            // 
            // TextBox3
            // 
            this.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(227, 515);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(282, 30);
            this.TextBox3.TabIndex = 97;
            this.TextBox3.Text = "";
            this.TextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox3_KeyDown);
            // 
            // dgvstock
            // 
            this.dgvstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstock.Location = new System.Drawing.Point(699, 275);
            this.dgvstock.Name = "dgvstock";
            this.dgvstock.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvstock.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvstock.Size = new System.Drawing.Size(545, 322);
            this.dgvstock.TabIndex = 98;
            this.dgvstock.DoubleClick += new System.EventHandler(this.dgvstock_DoubleClick);
            // 
            // Status
            // 
            this.Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Status.Location = new System.Drawing.Point(705, 128);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(73, 25);
            this.Status.TabIndex = 104;
            this.Status.Text = "Status";
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.IntegralHeight = false;
            this.comboBox.Items.AddRange(new object[] {
            "Active"});
            this.comboBox.Location = new System.Drawing.Point(836, 124);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(282, 29);
            this.comboBox.TabIndex = 103;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(699, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 44);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(836, 220);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 25);
            this.txtSearch.TabIndex = 105;
            this.txtSearch.Text = "";
            // 
            // btnpSum
            // 
            this.btnpSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpSum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpSum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnpSum.Location = new System.Drawing.Point(721, 606);
            this.btnpSum.Name = "btnpSum";
            this.btnpSum.Size = new System.Drawing.Size(105, 34);
            this.btnpSum.TabIndex = 107;
            this.btnpSum.Text = "Total Products";
            this.btnpSum.UseVisualStyleBackColor = false;
            this.btnpSum.Click += new System.EventHandler(this.btnpSum_Click);
            // 
            // btnqSum
            // 
            this.btnqSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnqSum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnqSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqSum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnqSum.Location = new System.Drawing.Point(950, 606);
            this.btnqSum.Name = "btnqSum";
            this.btnqSum.Size = new System.Drawing.Size(109, 34);
            this.btnqSum.TabIndex = 108;
            this.btnqSum.Text = "Total Quantities";
            this.btnqSum.UseVisualStyleBackColor = false;
            this.btnqSum.Click += new System.EventHandler(this.btnqSum_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(832, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 109;
            this.label1.Text = "        ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1065, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 110;
            this.label3.Text = "        ";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(1228, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 111;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(1237, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 20);
            this.button3.TabIndex = 112;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(227, 461);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(282, 27);
            this.TextBox2.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(588, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 114;
            this.label4.Text = "Stocks";
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1308, 691);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnqSum);
            this.Controls.Add(this.btnpSum);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dgvstock);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.submite);
            this.Controls.Add(this.DateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Produts_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Produts_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Produts_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Produts_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Button submite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label Quantity;
        private new System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.RichTextBox TextBox3;
        private System.Windows.Forms.DataGridView dgvstock;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.Button btnpSum;
        private System.Windows.Forms.Button btnqSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private Datas.DataSet1 dataSet11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Label label4;
    }
}