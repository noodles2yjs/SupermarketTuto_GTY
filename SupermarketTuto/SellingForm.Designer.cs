
namespace SupermarketTuto
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.label7 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.prodNameLbl = new System.Windows.Forms.Label();
            this.billIdLbl = new System.Windows.Forms.Label();
            this.sellsOrderListDgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.prodDgv = new System.Windows.Forms.DataGridView();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.billIdTb = new System.Windows.Forms.TextBox();
            this.prodNameTb = new System.Windows.Forms.TextBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.qtyTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orderDgv = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amtLbl = new System.Windows.Forms.Label();
            this.SellerNameLbl = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellsOrderListDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1297, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseMnemonic = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.DarkOrange;
            this.priceLbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceLbl.ForeColor = System.Drawing.Color.White;
            this.priceLbl.Location = new System.Drawing.Point(178, 182);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(64, 28);
            this.priceLbl.TabIndex = 28;
            this.priceLbl.Text = "Price";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceLbl.UseMnemonic = false;
            // 
            // prodNameLbl
            // 
            this.prodNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodNameLbl.AutoSize = true;
            this.prodNameLbl.BackColor = System.Drawing.Color.DarkOrange;
            this.prodNameLbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prodNameLbl.ForeColor = System.Drawing.Color.White;
            this.prodNameLbl.Location = new System.Drawing.Point(178, 137);
            this.prodNameLbl.Name = "prodNameLbl";
            this.prodNameLbl.Size = new System.Drawing.Size(126, 28);
            this.prodNameLbl.TabIndex = 29;
            this.prodNameLbl.Text = "ProdName";
            this.prodNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prodNameLbl.UseMnemonic = false;
            // 
            // billIdLbl
            // 
            this.billIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billIdLbl.AutoSize = true;
            this.billIdLbl.BackColor = System.Drawing.Color.DarkOrange;
            this.billIdLbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.billIdLbl.ForeColor = System.Drawing.Color.White;
            this.billIdLbl.Location = new System.Drawing.Point(178, 94);
            this.billIdLbl.Name = "billIdLbl";
            this.billIdLbl.Size = new System.Drawing.Size(65, 28);
            this.billIdLbl.TabIndex = 30;
            this.billIdLbl.Text = "BillId";
            this.billIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billIdLbl.UseMnemonic = false;
            // 
            // sellsOrderListDgv
            // 
            this.sellsOrderListDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellsOrderListDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sellsOrderListDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.sellsOrderListDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellsOrderListDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sellsOrderListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellsOrderListDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.sellsOrderListDgv.GridColor = System.Drawing.Color.White;
            this.sellsOrderListDgv.Location = new System.Drawing.Point(699, 440);
            this.sellsOrderListDgv.Name = "sellsOrderListDgv";
            this.sellsOrderListDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellsOrderListDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.sellsOrderListDgv.RowTemplate.Height = 23;
            this.sellsOrderListDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellsOrderListDgv.Size = new System.Drawing.Size(570, 243);
            this.sellsOrderListDgv.TabIndex = 20;
            this.sellsOrderListDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellsOrderListDgv_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(641, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 46);
            this.label2.TabIndex = 27;
            this.label2.Text = "SELLING";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.DarkOrange;
            this.dateLbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(1221, 43);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(62, 28);
            this.dateLbl.TabIndex = 30;
            this.dateLbl.Text = "Date";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateLbl.UseMnemonic = false;
            // 
            // prodDgv
            // 
            this.prodDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.prodDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.prodDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.prodDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.prodDgv.GridColor = System.Drawing.Color.White;
            this.prodDgv.Location = new System.Drawing.Point(139, 409);
            this.prodDgv.Name = "prodDgv";
            this.prodDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.prodDgv.RowTemplate.Height = 23;
            this.prodDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDgv.Size = new System.Drawing.Size(409, 369);
            this.prodDgv.TabIndex = 32;
            this.prodDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDgv_CellContentClick);
            // 
            // qtyLbl
            // 
            this.qtyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.BackColor = System.Drawing.Color.DarkOrange;
            this.qtyLbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qtyLbl.ForeColor = System.Drawing.Color.White;
            this.qtyLbl.Location = new System.Drawing.Point(178, 225);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(121, 28);
            this.qtyLbl.TabIndex = 28;
            this.qtyLbl.Text = "Quentities";
            this.qtyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qtyLbl.UseMnemonic = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(407, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 42);
            this.button4.TabIndex = 34;
            this.button4.Text = "REFLESH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CatCb
            // 
            this.CatCb.BackColor = System.Drawing.Color.DarkOrange;
            this.CatCb.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.CatCb.ForeColor = System.Drawing.Color.White;
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.CatCb.Location = new System.Drawing.Point(179, 357);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(193, 36);
            this.CatCb.TabIndex = 33;
            this.CatCb.Text = "Select Category";
            this.CatCb.SelectionChangeCommitted += new System.EventHandler(this.CatCb_SelectionChangeCommitted);
            // 
            // billIdTb
            // 
            this.billIdTb.BackColor = System.Drawing.Color.DarkOrange;
            this.billIdTb.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.billIdTb.ForeColor = System.Drawing.Color.White;
            this.billIdTb.Location = new System.Drawing.Point(355, 94);
            this.billIdTb.Multiline = true;
            this.billIdTb.Name = "billIdTb";
            this.billIdTb.Size = new System.Drawing.Size(193, 28);
            this.billIdTb.TabIndex = 35;
            // 
            // prodNameTb
            // 
            this.prodNameTb.BackColor = System.Drawing.Color.DarkOrange;
            this.prodNameTb.Enabled = false;
            this.prodNameTb.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.prodNameTb.ForeColor = System.Drawing.Color.White;
            this.prodNameTb.Location = new System.Drawing.Point(355, 137);
            this.prodNameTb.Multiline = true;
            this.prodNameTb.Name = "prodNameTb";
            this.prodNameTb.Size = new System.Drawing.Size(193, 28);
            this.prodNameTb.TabIndex = 35;
            // 
            // priceTb
            // 
            this.priceTb.BackColor = System.Drawing.Color.DarkOrange;
            this.priceTb.Enabled = false;
            this.priceTb.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.priceTb.ForeColor = System.Drawing.Color.White;
            this.priceTb.Location = new System.Drawing.Point(355, 179);
            this.priceTb.Multiline = true;
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(193, 28);
            this.priceTb.TabIndex = 35;
            // 
            // qtyTb
            // 
            this.qtyTb.BackColor = System.Drawing.Color.DarkOrange;
            this.qtyTb.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.qtyTb.ForeColor = System.Drawing.Color.White;
            this.qtyTb.Location = new System.Drawing.Point(355, 225);
            this.qtyTb.Multiline = true;
            this.qtyTb.Name = "qtyTb";
            this.qtyTb.Size = new System.Drawing.Size(193, 28);
            this.qtyTb.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(286, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderDgv
            // 
            this.orderDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.orderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.orderDgv.GridColor = System.Drawing.Color.White;
            this.orderDgv.Location = new System.Drawing.Point(699, 94);
            this.orderDgv.Name = "orderDgv";
            this.orderDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.orderDgv.RowTemplate.Height = 23;
            this.orderDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDgv.Size = new System.Drawing.Size(627, 258);
            this.orderDgv.TabIndex = 36;
            this.orderDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDgv_CellContentClick);
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "Price";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "Quentity";
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(850, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 42);
            this.button2.TabIndex = 34;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1018, 709);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 42);
            this.button3.TabIndex = 34;
            this.button3.Text = "PRINT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(917, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "SELLS LIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(831, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // amtLbl
            // 
            this.amtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amtLbl.AutoSize = true;
            this.amtLbl.BackColor = System.Drawing.Color.DarkOrange;
            this.amtLbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amtLbl.ForeColor = System.Drawing.Color.White;
            this.amtLbl.Location = new System.Drawing.Point(975, 365);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(40, 28);
            this.amtLbl.TabIndex = 30;
            this.amtLbl.Text = "RS";
            this.amtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amtLbl.UseMnemonic = false;
            // 
            // SellerNameLbl
            // 
            this.SellerNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SellerNameLbl.AutoSize = true;
            this.SellerNameLbl.BackColor = System.Drawing.Color.DarkOrange;
            this.SellerNameLbl.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SellerNameLbl.ForeColor = System.Drawing.Color.White;
            this.SellerNameLbl.Location = new System.Drawing.Point(33, 46);
            this.SellerNameLbl.Name = "SellerNameLbl";
            this.SellerNameLbl.Size = new System.Drawing.Size(70, 28);
            this.SellerNameLbl.TabIndex = 30;
            this.SellerNameLbl.Text = "Seller";
            this.SellerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SellerNameLbl.UseMnemonic = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 723);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "LogOut";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1348, 800);
            this.Controls.Add(this.orderDgv);
            this.Controls.Add(this.qtyTb);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.prodNameTb);
            this.Controls.Add(this.billIdTb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.prodDgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.prodNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SellerNameLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amtLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.billIdLbl);
            this.Controls.Add(this.sellsOrderListDgv);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellsOrderListDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label prodNameLbl;
        private System.Windows.Forms.Label billIdLbl;
        private System.Windows.Forms.DataGridView sellsOrderListDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DataGridView prodDgv;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.TextBox billIdTb;
        private System.Windows.Forms.TextBox prodNameTb;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.TextBox qtyTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView orderDgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label amtLbl;
        private System.Windows.Forms.Label SellerNameLbl;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label4;
    }
}