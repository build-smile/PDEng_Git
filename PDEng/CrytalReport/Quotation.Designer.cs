namespace PDEng
{
    partial class Quotation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quotation));
            this.gridQTDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtQtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalesName = new System.Windows.Forms.TextBox();
            this.dtValidity = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFetchCustomer = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.spnUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.spnQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.Customer = new System.Windows.Forms.TabPage();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSave = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.Details = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridViewQT = new System.Windows.Forms.DataGridView();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.AddDetail = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridQTDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuantity)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.General.SuspendLayout();
            this.Customer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.Details.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQT)).BeginInit();
            this.tabControl4.SuspendLayout();
            this.AddDetail.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridQTDetail
            // 
            this.gridQTDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridQTDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridQTDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridQTDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridQTDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.gridQTDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQTDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Qty,
            this.UnitPrice,
            this.TotalAmount,
            this.Delete});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridQTDetail.DefaultCellStyle = dataGridViewCellStyle29;
            this.gridQTDetail.Location = new System.Drawing.Point(3, 20);
            this.gridQTDetail.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.gridQTDetail.Name = "gridQTDetail";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridQTDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.gridQTDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridQTDetail.RowTemplate.Height = 28;
            this.gridQTDetail.Size = new System.Drawing.Size(840, 141);
            this.gridQTDetail.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Description";
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomer.Location = new System.Drawing.Point(88, 21);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtCustomer.Multiline = true;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(228, 32);
            this.txtCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // dtQtDate
            // 
            this.dtQtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtQtDate.CustomFormat = "dd/MM/yyyy";
            this.dtQtDate.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtQtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtQtDate.Location = new System.Drawing.Point(119, 21);
            this.dtQtDate.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.dtQtDate.Name = "dtQtDate";
            this.dtQtDate.Size = new System.Drawing.Size(231, 39);
            this.dtQtDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(88, 140);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtCustomerPhone.Multiline = true;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(228, 31);
            this.txtCustomerPhone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sales Name";
            // 
            // txtSalesName
            // 
            this.txtSalesName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalesName.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSalesName.Location = new System.Drawing.Point(119, 126);
            this.txtSalesName.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtSalesName.Multiline = true;
            this.txtSalesName.Name = "txtSalesName";
            this.txtSalesName.Size = new System.Drawing.Size(231, 38);
            this.txtSalesName.TabIndex = 12;
            // 
            // dtValidity
            // 
            this.dtValidity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtValidity.CustomFormat = "dd/MM/yyyy";
            this.dtValidity.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtValidity.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtValidity.Location = new System.Drawing.Point(119, 77);
            this.dtValidity.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.dtValidity.Name = "dtValidity";
            this.dtValidity.Size = new System.Drawing.Size(231, 39);
            this.dtValidity.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Validity";
            // 
            // btnFetchCustomer
            // 
            this.btnFetchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetchCustomer.Location = new System.Drawing.Point(328, 20);
            this.btnFetchCustomer.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.btnFetchCustomer.Name = "btnFetchCustomer";
            this.btnFetchCustomer.Size = new System.Drawing.Size(45, 32);
            this.btnFetchCustomer.TabIndex = 15;
            this.btnFetchCustomer.Text = "...";
            this.btnFetchCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddDetail.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddDetail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddDetail.Location = new System.Drawing.Point(3, 170);
            this.btnAddDetail.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(430, 38);
            this.btnAddDetail.TabIndex = 17;
            this.btnAddDetail.Text = "ADD";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "UnitPrice";
            // 
            // spnUnitPrice
            // 
            this.spnUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnUnitPrice.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.spnUnitPrice.Location = new System.Drawing.Point(110, 71);
            this.spnUnitPrice.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.spnUnitPrice.Name = "spnUnitPrice";
            this.spnUnitPrice.Size = new System.Drawing.Size(138, 39);
            this.spnUnitPrice.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quantity";
            // 
            // spnQuantity
            // 
            this.spnQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spnQuantity.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.spnQuantity.Location = new System.Drawing.Point(110, 14);
            this.spnQuantity.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.spnQuantity.Name = "spnQuantity";
            this.spnQuantity.Size = new System.Drawing.Size(138, 39);
            this.spnQuantity.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDescription.Location = new System.Drawing.Point(116, 58);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(281, 84);
            this.txtDescription.TabIndex = 11;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.AutoScroll = true;
            this.HeaderPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.HeaderPanel.Controls.Add(this.tabControl4);
            this.HeaderPanel.Controls.Add(this.tabControl2);
            this.HeaderPanel.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.HeaderPanel.Location = new System.Drawing.Point(4, 68);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(851, 261);
            this.HeaderPanel.TabIndex = 18;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.General);
            this.tabControl2.Controls.Add(this.Customer);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(399, 261);
            this.tabControl2.TabIndex = 17;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.General.Controls.Add(this.dtQtDate);
            this.General.Controls.Add(this.label3);
            this.General.Controls.Add(this.label6);
            this.General.Controls.Add(this.txtSalesName);
            this.General.Controls.Add(this.label5);
            this.General.Controls.Add(this.dtValidity);
            this.General.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.General.Location = new System.Drawing.Point(4, 46);
            this.General.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.General.Size = new System.Drawing.Size(391, 207);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Customer.Controls.Add(this.btnFetchCustomer);
            this.Customer.Controls.Add(this.txtCustomerAddress);
            this.Customer.Controls.Add(this.label1);
            this.Customer.Controls.Add(this.label2);
            this.Customer.Controls.Add(this.label4);
            this.Customer.Controls.Add(this.txtCustomer);
            this.Customer.Controls.Add(this.txtCustomerPhone);
            this.Customer.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Customer.Location = new System.Drawing.Point(4, 46);
            this.Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Customer.Size = new System.Drawing.Size(391, 211);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(88, 62);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(228, 70);
            this.txtCustomerAddress.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave});
            this.toolStrip1.Location = new System.Drawing.Point(4, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(851, 31);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuSave
            // 
            this.menuSave.BackColor = System.Drawing.Color.Transparent;
            this.menuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuSave.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(28, 28);
            this.menuSave.Text = "SAVE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(9, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 644);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.HeaderPanel);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabPage1.ForeColor = System.Drawing.Color.Chocolate;
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.tabPage1.Size = new System.Drawing.Size(859, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quotation";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.Details);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl3.Location = new System.Drawing.Point(4, 371);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(851, 214);
            this.tabControl3.TabIndex = 19;
            // 
            // Details
            // 
            this.Details.BackColor = System.Drawing.Color.White;
            this.Details.Controls.Add(this.gridQTDetail);
            this.Details.Location = new System.Drawing.Point(4, 29);
            this.Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Details.Size = new System.Drawing.Size(843, 181);
            this.Details.TabIndex = 0;
            this.Details.Text = "Details";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridViewQT);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.tabPage2.Size = new System.Drawing.Size(859, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridViewQT
            // 
            this.gridViewQT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewQT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewQT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridViewQT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridViewQT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewQT.Location = new System.Drawing.Point(12, 38);
            this.gridViewQT.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.gridViewQT.Name = "gridViewQT";
            this.gridViewQT.RowTemplate.Height = 28;
            this.gridViewQT.Size = new System.Drawing.Size(838, 240);
            this.gridViewQT.TabIndex = 0;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.AddDetail);
            this.tabControl4.Controls.Add(this.tabPage3);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl4.Location = new System.Drawing.Point(407, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(444, 261);
            this.tabControl4.TabIndex = 18;
            // 
            // AddDetail
            // 
            this.AddDetail.Controls.Add(this.txtItemName);
            this.AddDetail.Controls.Add(this.label8);
            this.AddDetail.Controls.Add(this.txtDescription);
            this.AddDetail.Controls.Add(this.label7);
            this.AddDetail.Controls.Add(this.btnAddDetail);
            this.AddDetail.Location = new System.Drawing.Point(4, 46);
            this.AddDetail.Name = "AddDetail";
            this.AddDetail.Padding = new System.Windows.Forms.Padding(3);
            this.AddDetail.Size = new System.Drawing.Size(436, 211);
            this.AddDetail.TabIndex = 0;
            this.AddDetail.Text = "Add Detail";
            this.AddDetail.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.spnQuantity);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.spnUnitPrice);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(436, 211);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "detail2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Location = new System.Drawing.Point(116, 13);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(281, 32);
            this.txtItemName.TabIndex = 19;
            // 
            // Quotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(885, 672);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quotation";
            this.Padding = new System.Windows.Forms.Padding(9, 14, 9, 14);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridQTDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuantity)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.Details.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQT)).EndInit();
            this.tabControl4.ResumeLayout(false);
            this.AddDetail.ResumeLayout(false);
            this.AddDetail.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridQTDetail;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtQtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalesName;
        private System.Windows.Forms.DateTimePicker dtValidity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFetchCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown spnUnitPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown spnQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridViewQT;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage AddDetail;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemName;
    }
}

