using HControl;

namespace QuanLyBanHang
{
    partial class frmMain
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
            this.palListBill = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.palBillDetail = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.palListItem = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.grdBillDetail = new HControl.hDataGridView();
            this.STT_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPurchase = new HControl.hButton();
            this.btnAdj = new HControl.hButton();
            this.grdListItem = new HControl.hDataGridView();
            this.STT_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddItem = new HControl.hButton();
            this.grdListBill = new HControl.hDataGridView();
            this.STT_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddBill = new HControl.hButton();
            this.palListBill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.palBillDetail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.palListItem.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListBill)).BeginInit();
            this.SuspendLayout();
            // 
            // palListBill
            // 
            this.palListBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palListBill.Controls.Add(this.groupBox1);
            this.palListBill.Controls.Add(this.flowLayoutPanel1);
            this.palListBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.palListBill.Location = new System.Drawing.Point(0, 0);
            this.palListBill.Name = "palListBill";
            this.palListBill.Padding = new System.Windows.Forms.Padding(4);
            this.palListBill.Size = new System.Drawing.Size(420, 561);
            this.palListBill.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdListBill);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Bill";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddBill);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 505);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(410, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // palBillDetail
            // 
            this.palBillDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palBillDetail.Controls.Add(this.groupBox2);
            this.palBillDetail.Controls.Add(this.flowLayoutPanel2);
            this.palBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palBillDetail.Location = new System.Drawing.Point(420, 0);
            this.palBillDetail.Name = "palBillDetail";
            this.palBillDetail.Padding = new System.Windows.Forms.Padding(4);
            this.palBillDetail.Size = new System.Drawing.Size(368, 561);
            this.palBillDetail.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdBillDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 501);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Bill";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnPurchase);
            this.flowLayoutPanel2.Controls.Add(this.btnAdj);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 505);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(358, 50);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // palListItem
            // 
            this.palListItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palListItem.Controls.Add(this.groupBox3);
            this.palListItem.Controls.Add(this.flowLayoutPanel3);
            this.palListItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.palListItem.Location = new System.Drawing.Point(788, 0);
            this.palListItem.Name = "palListItem";
            this.palListItem.Padding = new System.Windows.Forms.Padding(4);
            this.palListItem.Size = new System.Drawing.Size(500, 561);
            this.palListItem.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdListItem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 501);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thực đơn";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAddItem);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 505);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(490, 50);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // grdBillDetail
            // 
            this.grdBillDetail.AllowUserToAddRows = false;
            this.grdBillDetail.AllowUserToDeleteRows = false;
            this.grdBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_2,
            this.ItemName,
            this.ItemPrice,
            this.ItemQuantity,
            this.ItemAmout});
            this.grdBillDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBillDetail.Location = new System.Drawing.Point(3, 16);
            this.grdBillDetail.Name = "grdBillDetail";
            this.grdBillDetail.ReadOnly = true;
            this.grdBillDetail.RowHeadersVisible = false;
            this.grdBillDetail.Size = new System.Drawing.Size(352, 482);
            this.grdBillDetail.TabIndex = 0;
            // 
            // STT_2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT_2.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT_2.HeaderText = "STT";
            this.STT_2.Name = "STT_2";
            this.STT_2.ReadOnly = true;
            this.STT_2.Width = 40;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemName.HeaderText = "Tên món";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.ItemPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemPrice.HeaderText = "Giá";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.DataPropertyName = "ItemQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = "N0";
            this.ItemQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemQuantity.HeaderText = "Số lượng";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            // 
            // ItemAmout
            // 
            this.ItemAmout.DataPropertyName = "ItemAmout";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.ItemAmout.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemAmout.HeaderText = "Thành tiền";
            this.ItemAmout.Name = "ItemAmout";
            this.ItemAmout.ReadOnly = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(255, 3);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(100, 45);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "Thanh toán";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnAdj
            // 
            this.btnAdj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdj.Location = new System.Drawing.Point(129, 3);
            this.btnAdj.Name = "btnAdj";
            this.btnAdj.Size = new System.Drawing.Size(120, 45);
            this.btnAdj.TabIndex = 2;
            this.btnAdj.Text = "Điều chỉnh bill";
            this.btnAdj.UseVisualStyleBackColor = true;
            // 
            // grdListItem
            // 
            this.grdListItem.AllowUserToAddRows = false;
            this.grdListItem.AllowUserToDeleteRows = false;
            this.grdListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_3,
            this.ItmName,
            this.Price,
            this.Image});
            this.grdListItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListItem.Location = new System.Drawing.Point(3, 16);
            this.grdListItem.Name = "grdListItem";
            this.grdListItem.ReadOnly = true;
            this.grdListItem.RowHeadersVisible = false;
            this.grdListItem.Size = new System.Drawing.Size(484, 482);
            this.grdListItem.TabIndex = 0;
            // 
            // STT_3
            // 
            this.STT_3.HeaderText = "STT";
            this.STT_3.Name = "STT_3";
            this.STT_3.ReadOnly = true;
            this.STT_3.Width = 40;
            // 
            // ItmName
            // 
            this.ItmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItmName.DataPropertyName = "Name";
            this.ItmName.HeaderText = "Tên món";
            this.ItmName.Name = "ItmName";
            this.ItmName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = "N0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle6;
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(367, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 45);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Thêm mới món";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // grdListBill
            // 
            this.grdListBill.AllowUserToAddRows = false;
            this.grdListBill.AllowUserToDeleteRows = false;
            this.grdListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_1,
            this.BillId,
            this.Table,
            this.CheckIn,
            this.TotalAmt});
            this.grdListBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListBill.Location = new System.Drawing.Point(3, 16);
            this.grdListBill.Name = "grdListBill";
            this.grdListBill.ReadOnly = true;
            this.grdListBill.RowHeadersVisible = false;
            this.grdListBill.Size = new System.Drawing.Size(404, 482);
            this.grdListBill.TabIndex = 0;
            // 
            // STT_1
            // 
            this.STT_1.HeaderText = "STT";
            this.STT_1.Name = "STT_1";
            this.STT_1.ReadOnly = true;
            this.STT_1.Width = 40;
            // 
            // BillId
            // 
            this.BillId.DataPropertyName = "BillId";
            this.BillId.HeaderText = "Mã Bill";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            this.BillId.Width = 80;
            // 
            // Table
            // 
            this.Table.DataPropertyName = "Table";
            this.Table.HeaderText = "Bàn";
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Width = 50;
            // 
            // CheckIn
            // 
            this.CheckIn.DataPropertyName = "CheckIn";
            this.CheckIn.HeaderText = "Giờ checkin";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            this.CheckIn.Width = 120;
            // 
            // TotalAmt
            // 
            this.TotalAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAmt.DataPropertyName = "TotalAmt";
            this.TotalAmt.HeaderText = "Tổng tiền";
            this.TotalAmt.Name = "TotalAmt";
            this.TotalAmt.ReadOnly = true;
            // 
            // btnAddBill
            // 
            this.btnAddBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(307, 3);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(100, 45);
            this.btnAddBill.TabIndex = 0;
            this.btnAddBill.Text = "Thêm mới bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 561);
            this.Controls.Add(this.palBillDetail);
            this.Controls.Add(this.palListItem);
            this.Controls.Add(this.palListBill);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.palListBill.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.palBillDetail.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.palListItem.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palListBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private hDataGridView grdListBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private hButton btnAddBill;
        private System.Windows.Forms.Panel palBillDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private hDataGridView grdBillDetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private hButton btnPurchase;
        private hButton btnAdj;
        private System.Windows.Forms.Panel palListItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private hDataGridView grdListItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private hButton btnAddItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmout;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}

