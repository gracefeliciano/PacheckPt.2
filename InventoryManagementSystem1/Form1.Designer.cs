namespace InventoryManagementSystem1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navAreaInventory = new System.Windows.Forms.Panel();
            this.ReportsBtnInventory = new System.Windows.Forms.Button();
            this.PurchaseOrdersBtnInventory = new System.Windows.Forms.Button();
            this.SalesReturnsBtnInventory = new System.Windows.Forms.Button();
            this.SalesOrdersBtnInventory = new System.Windows.Forms.Button();
            this.ItemGroupsBtnInventory = new System.Windows.Forms.Button();
            this.InventoryBtnInventory = new System.Windows.Forms.Button();
            this.HomeBtnInventory = new System.Windows.Forms.Button();
            this.labelBrandNameInventory = new System.Windows.Forms.Label();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.InventoryListInventory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaryPanelInventory = new System.Windows.Forms.Panel();
            this.LowStockInventory = new System.Windows.Forms.Label();
            this.OutStockInventory = new System.Windows.Forms.Label();
            this.TotalItemsInventory = new System.Windows.Forms.Label();
            this.SummaryInventory = new System.Windows.Forms.Label();
            this.OutStockLabelInventory = new System.Windows.Forms.Label();
            this.LowStockLabelInventory = new System.Windows.Forms.Label();
            this.TotalItemsLabelInventory = new System.Windows.Forms.Label();
            this.FiltercbInventory = new System.Windows.Forms.ComboBox();
            this.SortcbInventory = new System.Windows.Forms.ComboBox();
            this.SearchBarInventory = new System.Windows.Forms.TextBox();
            this.ExportCSVInventory = new System.Windows.Forms.Button();
            this.ExportPDFInventory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtnInventory = new System.Windows.Forms.Button();
            this.UserNameInventory = new System.Windows.Forms.Label();
            this.ProfilePictureInventory = new System.Windows.Forms.PictureBox();
            this.navAreaInventory.SuspendLayout();
            this.panelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryListInventory)).BeginInit();
            this.SummaryPanelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // navAreaInventory
            // 
            this.navAreaInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navAreaInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.navAreaInventory.Controls.Add(this.ReportsBtnInventory);
            this.navAreaInventory.Controls.Add(this.PurchaseOrdersBtnInventory);
            this.navAreaInventory.Controls.Add(this.SalesReturnsBtnInventory);
            this.navAreaInventory.Controls.Add(this.SalesOrdersBtnInventory);
            this.navAreaInventory.Controls.Add(this.ItemGroupsBtnInventory);
            this.navAreaInventory.Controls.Add(this.InventoryBtnInventory);
            this.navAreaInventory.Controls.Add(this.HomeBtnInventory);
            this.navAreaInventory.Controls.Add(this.labelBrandNameInventory);
            this.navAreaInventory.Location = new System.Drawing.Point(0, 0);
            this.navAreaInventory.Name = "navAreaInventory";
            this.navAreaInventory.Size = new System.Drawing.Size(414, 957);
            this.navAreaInventory.TabIndex = 0;
            this.navAreaInventory.Paint += new System.Windows.Forms.PaintEventHandler(this.navAreaInventory_Paint);
            // 
            // ReportsBtnInventory
            // 
            this.ReportsBtnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsBtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.ReportsBtnInventory.Location = new System.Drawing.Point(12, 469);
            this.ReportsBtnInventory.Name = "ReportsBtnInventory";
            this.ReportsBtnInventory.Size = new System.Drawing.Size(381, 39);
            this.ReportsBtnInventory.TabIndex = 8;
            this.ReportsBtnInventory.Text = "Reports";
            this.ReportsBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsBtnInventory.UseVisualStyleBackColor = true;
            // 
            // PurchaseOrdersBtnInventory
            // 
            this.PurchaseOrdersBtnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOrdersBtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.PurchaseOrdersBtnInventory.Location = new System.Drawing.Point(12, 380);
            this.PurchaseOrdersBtnInventory.Name = "PurchaseOrdersBtnInventory";
            this.PurchaseOrdersBtnInventory.Size = new System.Drawing.Size(380, 40);
            this.PurchaseOrdersBtnInventory.TabIndex = 7;
            this.PurchaseOrdersBtnInventory.Text = "Purchase Orders";
            this.PurchaseOrdersBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PurchaseOrdersBtnInventory.UseVisualStyleBackColor = true;
            // 
            // SalesReturnsBtnInventory
            // 
            this.SalesReturnsBtnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReturnsBtnInventory.Location = new System.Drawing.Point(12, 333);
            this.SalesReturnsBtnInventory.Name = "SalesReturnsBtnInventory";
            this.SalesReturnsBtnInventory.Size = new System.Drawing.Size(380, 37);
            this.SalesReturnsBtnInventory.TabIndex = 6;
            this.SalesReturnsBtnInventory.Text = "Sales Returns";
            this.SalesReturnsBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesReturnsBtnInventory.UseVisualStyleBackColor = true;
            // 
            // SalesOrdersBtnInventory
            // 
            this.SalesOrdersBtnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOrdersBtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.SalesOrdersBtnInventory.Location = new System.Drawing.Point(12, 285);
            this.SalesOrdersBtnInventory.Name = "SalesOrdersBtnInventory";
            this.SalesOrdersBtnInventory.Size = new System.Drawing.Size(380, 38);
            this.SalesOrdersBtnInventory.TabIndex = 5;
            this.SalesOrdersBtnInventory.Text = "Sales Orders";
            this.SalesOrdersBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesOrdersBtnInventory.UseVisualStyleBackColor = true;
            // 
            // ItemGroupsBtnInventory
            // 
            this.ItemGroupsBtnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemGroupsBtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.ItemGroupsBtnInventory.Location = new System.Drawing.Point(12, 202);
            this.ItemGroupsBtnInventory.Name = "ItemGroupsBtnInventory";
            this.ItemGroupsBtnInventory.Size = new System.Drawing.Size(380, 40);
            this.ItemGroupsBtnInventory.TabIndex = 4;
            this.ItemGroupsBtnInventory.Text = "Item Groups";
            this.ItemGroupsBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemGroupsBtnInventory.UseVisualStyleBackColor = true;
            // 
            // InventoryBtnInventory
            // 
            this.InventoryBtnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryBtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.InventoryBtnInventory.Location = new System.Drawing.Point(12, 152);
            this.InventoryBtnInventory.Name = "InventoryBtnInventory";
            this.InventoryBtnInventory.Size = new System.Drawing.Size(380, 40);
            this.InventoryBtnInventory.TabIndex = 3;
            this.InventoryBtnInventory.Text = "Inventory";
            this.InventoryBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBtnInventory.UseVisualStyleBackColor = true;
            // 
            // HomeBtnInventory
            // 
            this.HomeBtnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.HomeBtnInventory.Location = new System.Drawing.Point(12, 71);
            this.HomeBtnInventory.Name = "HomeBtnInventory";
            this.HomeBtnInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomeBtnInventory.Size = new System.Drawing.Size(380, 40);
            this.HomeBtnInventory.TabIndex = 2;
            this.HomeBtnInventory.Text = "Home";
            this.HomeBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtnInventory.UseVisualStyleBackColor = true;
            // 
            // labelBrandNameInventory
            // 
            this.labelBrandNameInventory.AutoSize = true;
            this.labelBrandNameInventory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelBrandNameInventory.ForeColor = System.Drawing.Color.White;
            this.labelBrandNameInventory.Location = new System.Drawing.Point(12, 10);
            this.labelBrandNameInventory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelBrandNameInventory.Name = "labelBrandNameInventory";
            this.labelBrandNameInventory.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.labelBrandNameInventory.Size = new System.Drawing.Size(371, 39);
            this.labelBrandNameInventory.TabIndex = 1;
            this.labelBrandNameInventory.Text = "INVENTORY MANAGEMENT";
            this.labelBrandNameInventory.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelInventory
            // 
            this.panelInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.panelInventory.Controls.Add(this.InventoryListInventory);
            this.panelInventory.Controls.Add(this.SummaryPanelInventory);
            this.panelInventory.Controls.Add(this.FiltercbInventory);
            this.panelInventory.Controls.Add(this.SortcbInventory);
            this.panelInventory.Controls.Add(this.SearchBarInventory);
            this.panelInventory.Controls.Add(this.ExportCSVInventory);
            this.panelInventory.Controls.Add(this.ExportPDFInventory);
            this.panelInventory.Controls.Add(this.panel1);
            this.panelInventory.Controls.Add(this.SearchBtnInventory);
            this.panelInventory.Controls.Add(this.UserNameInventory);
            this.panelInventory.Controls.Add(this.ProfilePictureInventory);
            this.panelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInventory.Location = new System.Drawing.Point(414, 0);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(1166, 957);
            this.panelInventory.TabIndex = 1;
            this.panelInventory.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInventory_Paint);
            // 
            // InventoryListInventory
            // 
            this.InventoryListInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryListInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InventoryListInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InventoryListInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.InventoryListInventory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryListInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InventoryListInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryListInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryListInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.InventoryListInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryListInventory.Location = new System.Drawing.Point(112, 216);
            this.InventoryListInventory.Name = "InventoryListInventory";
            this.InventoryListInventory.ReadOnly = true;
            this.InventoryListInventory.RowHeadersWidth = 51;
            this.InventoryListInventory.RowTemplate.Height = 24;
            this.InventoryListInventory.Size = new System.Drawing.Size(984, 675);
            this.InventoryListInventory.TabIndex = 0;
            this.InventoryListInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serial #";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 107;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 91;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Brand";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 93;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 114;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Unit Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 124;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Warranty";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 121;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Stock Status";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 152;
            // 
            // SummaryPanelInventory
            // 
            this.SummaryPanelInventory.BackColor = System.Drawing.Color.Transparent;
            this.SummaryPanelInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryPanelInventory.Controls.Add(this.LowStockInventory);
            this.SummaryPanelInventory.Controls.Add(this.OutStockInventory);
            this.SummaryPanelInventory.Controls.Add(this.TotalItemsInventory);
            this.SummaryPanelInventory.Controls.Add(this.SummaryInventory);
            this.SummaryPanelInventory.Controls.Add(this.OutStockLabelInventory);
            this.SummaryPanelInventory.Controls.Add(this.LowStockLabelInventory);
            this.SummaryPanelInventory.Controls.Add(this.TotalItemsLabelInventory);
            this.SummaryPanelInventory.Location = new System.Drawing.Point(21, 105);
            this.SummaryPanelInventory.Name = "SummaryPanelInventory";
            this.SummaryPanelInventory.Size = new System.Drawing.Size(725, 87);
            this.SummaryPanelInventory.TabIndex = 21;
            // 
            // LowStockInventory
            // 
            this.LowStockInventory.AutoSize = true;
            this.LowStockInventory.BackColor = System.Drawing.Color.Transparent;
            this.LowStockInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowStockInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.LowStockInventory.Location = new System.Drawing.Point(635, 28);
            this.LowStockInventory.Name = "LowStockInventory";
            this.LowStockInventory.Size = new System.Drawing.Size(23, 28);
            this.LowStockInventory.TabIndex = 20;
            this.LowStockInventory.Text = "0";
            // 
            // OutStockInventory
            // 
            this.OutStockInventory.AutoSize = true;
            this.OutStockInventory.BackColor = System.Drawing.Color.Transparent;
            this.OutStockInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutStockInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.OutStockInventory.Location = new System.Drawing.Point(406, 28);
            this.OutStockInventory.Name = "OutStockInventory";
            this.OutStockInventory.Size = new System.Drawing.Size(23, 28);
            this.OutStockInventory.TabIndex = 19;
            this.OutStockInventory.Text = "0";
            // 
            // TotalItemsInventory
            // 
            this.TotalItemsInventory.AutoSize = true;
            this.TotalItemsInventory.BackColor = System.Drawing.Color.Transparent;
            this.TotalItemsInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.TotalItemsInventory.Location = new System.Drawing.Point(146, 28);
            this.TotalItemsInventory.Name = "TotalItemsInventory";
            this.TotalItemsInventory.Size = new System.Drawing.Size(23, 28);
            this.TotalItemsInventory.TabIndex = 18;
            this.TotalItemsInventory.Text = "0";
            this.TotalItemsInventory.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // SummaryInventory
            // 
            this.SummaryInventory.AutoSize = true;
            this.SummaryInventory.BackColor = System.Drawing.Color.Transparent;
            this.SummaryInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.SummaryInventory.Location = new System.Drawing.Point(3, -1);
            this.SummaryInventory.Name = "SummaryInventory";
            this.SummaryInventory.Size = new System.Drawing.Size(99, 28);
            this.SummaryInventory.TabIndex = 15;
            this.SummaryInventory.Text = "Summary";
            this.SummaryInventory.Click += new System.EventHandler(this.label4_Click);
            // 
            // OutStockLabelInventory
            // 
            this.OutStockLabelInventory.AutoSize = true;
            this.OutStockLabelInventory.BackColor = System.Drawing.Color.Transparent;
            this.OutStockLabelInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutStockLabelInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.OutStockLabelInventory.Location = new System.Drawing.Point(249, 28);
            this.OutStockLabelInventory.Name = "OutStockLabelInventory";
            this.OutStockLabelInventory.Size = new System.Drawing.Size(132, 28);
            this.OutStockLabelInventory.TabIndex = 14;
            this.OutStockLabelInventory.Text = "Out of Stock:";
            // 
            // LowStockLabelInventory
            // 
            this.LowStockLabelInventory.AutoSize = true;
            this.LowStockLabelInventory.BackColor = System.Drawing.Color.Transparent;
            this.LowStockLabelInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowStockLabelInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.LowStockLabelInventory.Location = new System.Drawing.Point(498, 28);
            this.LowStockLabelInventory.Name = "LowStockLabelInventory";
            this.LowStockLabelInventory.Size = new System.Drawing.Size(110, 28);
            this.LowStockLabelInventory.TabIndex = 17;
            this.LowStockLabelInventory.Text = "Low Stock:";
            // 
            // TotalItemsLabelInventory
            // 
            this.TotalItemsLabelInventory.AutoSize = true;
            this.TotalItemsLabelInventory.BackColor = System.Drawing.Color.Transparent;
            this.TotalItemsLabelInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLabelInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.TotalItemsLabelInventory.Location = new System.Drawing.Point(13, 28);
            this.TotalItemsLabelInventory.Name = "TotalItemsLabelInventory";
            this.TotalItemsLabelInventory.Size = new System.Drawing.Size(117, 28);
            this.TotalItemsLabelInventory.TabIndex = 7;
            this.TotalItemsLabelInventory.Text = "Total Items:";
            // 
            // FiltercbInventory
            // 
            this.FiltercbInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltercbInventory.FormattingEnabled = true;
            this.FiltercbInventory.Items.AddRange(new object[] {
            "Filter",
            "Brand",
            "Type",
            "Stock Status"});
            this.FiltercbInventory.Location = new System.Drawing.Point(311, 54);
            this.FiltercbInventory.Name = "FiltercbInventory";
            this.FiltercbInventory.Size = new System.Drawing.Size(284, 33);
            this.FiltercbInventory.TabIndex = 20;
            // 
            // SortcbInventory
            // 
            this.SortcbInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortcbInventory.FormattingEnabled = true;
            this.SortcbInventory.Items.AddRange(new object[] {
            "Sort",
            "Quantity (Low to High)",
            "Quantity (High to Low)",
            "Unit Price (High to Low)",
            "Unit Price (High to Low)"});
            this.SortcbInventory.Location = new System.Drawing.Point(21, 55);
            this.SortcbInventory.Name = "SortcbInventory";
            this.SortcbInventory.Size = new System.Drawing.Size(284, 33);
            this.SortcbInventory.TabIndex = 19;
            this.SortcbInventory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // SearchBarInventory
            // 
            this.SearchBarInventory.ForeColor = System.Drawing.Color.Gray;
            this.SearchBarInventory.Location = new System.Drawing.Point(21, 17);
            this.SearchBarInventory.Name = "SearchBarInventory";
            this.SearchBarInventory.Size = new System.Drawing.Size(357, 30);
            this.SearchBarInventory.TabIndex = 18;
            this.SearchBarInventory.Text = "Search";
            // 
            // ExportCSVInventory
            // 
            this.ExportCSVInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportCSVInventory.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ExportCSVInventory.Location = new System.Drawing.Point(873, 170);
            this.ExportCSVInventory.Name = "ExportCSVInventory";
            this.ExportCSVInventory.Size = new System.Drawing.Size(80, 40);
            this.ExportCSVInventory.TabIndex = 13;
            this.ExportCSVInventory.Text = "Export as CSV";
            this.ExportCSVInventory.UseVisualStyleBackColor = true;
            // 
            // ExportPDFInventory
            // 
            this.ExportPDFInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportPDFInventory.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ExportPDFInventory.Location = new System.Drawing.Point(781, 170);
            this.ExportPDFInventory.Name = "ExportPDFInventory";
            this.ExportPDFInventory.Size = new System.Drawing.Size(73, 40);
            this.ExportPDFInventory.TabIndex = 12;
            this.ExportPDFInventory.Text = "Export as PDF";
            this.ExportPDFInventory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SearchBtnInventory
            // 
            this.SearchBtnInventory.BackColor = System.Drawing.Color.White;
            this.SearchBtnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.SearchBtnInventory.Location = new System.Drawing.Point(384, 14);
            this.SearchBtnInventory.Name = "SearchBtnInventory";
            this.SearchBtnInventory.Size = new System.Drawing.Size(43, 35);
            this.SearchBtnInventory.TabIndex = 5;
            this.SearchBtnInventory.Text = "⌕";
            this.SearchBtnInventory.UseVisualStyleBackColor = false;
            this.SearchBtnInventory.Click += new System.EventHandler(this.button8_Click);
            // 
            // UserNameInventory
            // 
            this.UserNameInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameInventory.AutoSize = true;
            this.UserNameInventory.BackColor = System.Drawing.Color.Transparent;
            this.UserNameInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.UserNameInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.UserNameInventory.Location = new System.Drawing.Point(923, 52);
            this.UserNameInventory.Name = "UserNameInventory";
            this.UserNameInventory.Size = new System.Drawing.Size(135, 32);
            this.UserNameInventory.TabIndex = 3;
            this.UserNameInventory.Text = "User Name";
            this.UserNameInventory.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ProfilePictureInventory
            // 
            this.ProfilePictureInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePictureInventory.BackgroundImage = global::InventoryManagementSystem1.Properties.Resources.users__3_;
            this.ProfilePictureInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProfilePictureInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePictureInventory.Location = new System.Drawing.Point(1082, 39);
            this.ProfilePictureInventory.Name = "ProfilePictureInventory";
            this.ProfilePictureInventory.Size = new System.Drawing.Size(49, 48);
            this.ProfilePictureInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ProfilePictureInventory.TabIndex = 2;
            this.ProfilePictureInventory.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1580, 957);
            this.Controls.Add(this.panelInventory);
            this.Controls.Add(this.navAreaInventory);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navAreaInventory.ResumeLayout(false);
            this.navAreaInventory.PerformLayout();
            this.panelInventory.ResumeLayout(false);
            this.panelInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryListInventory)).EndInit();
            this.SummaryPanelInventory.ResumeLayout(false);
            this.SummaryPanelInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navAreaInventory;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Label labelBrandNameInventory;
        private System.Windows.Forms.Button HomeBtnInventory;
        private System.Windows.Forms.Button InventoryBtnInventory;
        private System.Windows.Forms.Button SalesOrdersBtnInventory;
        private System.Windows.Forms.Button ItemGroupsBtnInventory;
        private System.Windows.Forms.Button ReportsBtnInventory;
        private System.Windows.Forms.Button PurchaseOrdersBtnInventory;
        private System.Windows.Forms.Button SalesReturnsBtnInventory;
        private System.Windows.Forms.PictureBox ProfilePictureInventory;
        private System.Windows.Forms.Label UserNameInventory;
        private System.Windows.Forms.Button SearchBtnInventory;
        private System.Windows.Forms.Label TotalItemsLabelInventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView InventoryListInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button ExportCSVInventory;
        private System.Windows.Forms.Button ExportPDFInventory;
        private System.Windows.Forms.Label OutStockLabelInventory;
        private System.Windows.Forms.Label LowStockLabelInventory;
        private System.Windows.Forms.TextBox SearchBarInventory;
        private System.Windows.Forms.ComboBox FiltercbInventory;
        private System.Windows.Forms.ComboBox SortcbInventory;
        private System.Windows.Forms.Panel SummaryPanelInventory;
        private System.Windows.Forms.Label SummaryInventory;
        private System.Windows.Forms.Label TotalItemsInventory;
        private System.Windows.Forms.Label LowStockInventory;
        private System.Windows.Forms.Label OutStockInventory;
    }
}

