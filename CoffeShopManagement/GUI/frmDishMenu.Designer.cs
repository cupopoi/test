namespace CoffeShopManagement.GUI
{
    partial class frmDishMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDishMenu));
            this.panel_BillToPay = new System.Windows.Forms.Panel();
            this.lvBill_andBillInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.lblTableNumberId = new System.Windows.Forms.Label();
            this.lblTableNumberName = new System.Windows.Forms.Label();
            this.panel_Pay = new System.Windows.Forms.Panel();
            this.lblDishCategory = new System.Windows.Forms.Label();
            this.lblDish = new System.Windows.Forms.Label();
            this.cmbDish = new System.Windows.Forms.ComboBox();
            this.cmbDishCategory = new System.Windows.Forms.ComboBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.numericUpDown_Count = new System.Windows.Forms.NumericUpDown();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.panel_BillToPay.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel_Pay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_BillToPay
            // 
            this.panel_BillToPay.Controls.Add(this.lvBill_andBillInfo);
            this.panel_BillToPay.Location = new System.Drawing.Point(12, 61);
            this.panel_BillToPay.Name = "panel_BillToPay";
            this.panel_BillToPay.Size = new System.Drawing.Size(489, 377);
            this.panel_BillToPay.TabIndex = 1;
            // 
            // lvBill_andBillInfo
            // 
            this.lvBill_andBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill_andBillInfo.GridLines = true;
            this.lvBill_andBillInfo.HideSelection = false;
            this.lvBill_andBillInfo.Location = new System.Drawing.Point(3, 3);
            this.lvBill_andBillInfo.Name = "lvBill_andBillInfo";
            this.lvBill_andBillInfo.Size = new System.Drawing.Size(483, 371);
            this.lvBill_andBillInfo.TabIndex = 0;
            this.lvBill_andBillInfo.UseCompatibleStateImageBehavior = false;
            this.lvBill_andBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng";
            this.columnHeader4.Width = 195;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.lblTableNumberId);
            this.panel_Title.Controls.Add(this.lblTableNumberName);
            this.panel_Title.Location = new System.Drawing.Point(12, 12);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(776, 43);
            this.panel_Title.TabIndex = 0;
            // 
            // lblTableNumberId
            // 
            this.lblTableNumberId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableNumberId.AutoSize = true;
            this.lblTableNumberId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberId.Location = new System.Drawing.Point(97, 11);
            this.lblTableNumberId.Name = "lblTableNumberId";
            this.lblTableNumberId.Size = new System.Drawing.Size(37, 25);
            this.lblTableNumberId.TabIndex = 1;
            this.lblTableNumberId.Text = "Số";
            // 
            // lblTableNumberName
            // 
            this.lblTableNumberName.AutoSize = true;
            this.lblTableNumberName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberName.Location = new System.Drawing.Point(3, 11);
            this.lblTableNumberName.Name = "lblTableNumberName";
            this.lblTableNumberName.Size = new System.Drawing.Size(88, 25);
            this.lblTableNumberName.TabIndex = 1;
            this.lblTableNumberName.Text = "Bàn số:";
            // 
            // panel_Pay
            // 
            this.panel_Pay.Controls.Add(this.lblDishCategory);
            this.panel_Pay.Controls.Add(this.lblDish);
            this.panel_Pay.Controls.Add(this.cmbDish);
            this.panel_Pay.Controls.Add(this.cmbDishCategory);
            this.panel_Pay.Controls.Add(this.lblTotalMoney);
            this.panel_Pay.Controls.Add(this.txtTotalMoney);
            this.panel_Pay.Controls.Add(this.btnPay);
            this.panel_Pay.Controls.Add(this.numericUpDown_Count);
            this.panel_Pay.Controls.Add(this.btnAddDish);
            this.panel_Pay.Location = new System.Drawing.Point(507, 61);
            this.panel_Pay.Name = "panel_Pay";
            this.panel_Pay.Size = new System.Drawing.Size(281, 377);
            this.panel_Pay.TabIndex = 2;
            // 
            // lblDishCategory
            // 
            this.lblDishCategory.AutoSize = true;
            this.lblDishCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishCategory.Location = new System.Drawing.Point(4, 3);
            this.lblDishCategory.Name = "lblDishCategory";
            this.lblDishCategory.Size = new System.Drawing.Size(64, 25);
            this.lblDishCategory.TabIndex = 8;
            this.lblDishCategory.Text = "Loại:";
            // 
            // lblDish
            // 
            this.lblDish.AutoSize = true;
            this.lblDish.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDish.Location = new System.Drawing.Point(4, 58);
            this.lblDish.Name = "lblDish";
            this.lblDish.Size = new System.Drawing.Size(68, 25);
            this.lblDish.TabIndex = 7;
            this.lblDish.Text = "Món:";
            // 
            // cmbDish
            // 
            this.cmbDish.FormattingEnabled = true;
            this.cmbDish.Location = new System.Drawing.Point(3, 86);
            this.cmbDish.Name = "cmbDish";
            this.cmbDish.Size = new System.Drawing.Size(275, 24);
            this.cmbDish.TabIndex = 2;
            // 
            // cmbDishCategory
            // 
            this.cmbDishCategory.FormattingEnabled = true;
            this.cmbDishCategory.Location = new System.Drawing.Point(3, 31);
            this.cmbDishCategory.Name = "cmbDishCategory";
            this.cmbDishCategory.Size = new System.Drawing.Size(275, 24);
            this.cmbDishCategory.TabIndex = 1;
            this.cmbDishCategory.SelectedIndexChanged += new System.EventHandler(this.cmbDishCategory_SelectedIndexChanged);
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.Location = new System.Drawing.Point(3, 185);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(137, 32);
            this.lblTotalMoney.TabIndex = 0;
            this.lblTotalMoney.Text = "Tổng tiền:";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.Location = new System.Drawing.Point(9, 220);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(269, 39);
            this.txtTotalMoney.TabIndex = 5;
            this.txtTotalMoney.Text = "0VNĐ";
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Gold;
            this.btnPay.Location = new System.Drawing.Point(103, 265);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(175, 109);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // numericUpDown_Count
            // 
            this.numericUpDown_Count.Location = new System.Drawing.Point(3, 138);
            this.numericUpDown_Count.Name = "numericUpDown_Count";
            this.numericUpDown_Count.Size = new System.Drawing.Size(172, 22);
            this.numericUpDown_Count.TabIndex = 3;
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackColor = System.Drawing.Color.Black;
            this.btnAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDish.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDish.ForeColor = System.Drawing.Color.Gold;
            this.btnAddDish.Location = new System.Drawing.Point(184, 132);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(97, 33);
            this.btnAddDish.TabIndex = 4;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = false;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // frmDishMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(206)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Pay);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_BillToPay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDishMenu";
            this.Text = "Passio";
            this.panel_BillToPay.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_Pay.ResumeLayout(false);
            this.panel_Pay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_BillToPay;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Pay;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.NumericUpDown numericUpDown_Count;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Label lblTableNumberId;
        private System.Windows.Forms.Label lblTableNumberName;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.ComboBox cmbDish;
        private System.Windows.Forms.ComboBox cmbDishCategory;
        private System.Windows.Forms.ListView lvBill_andBillInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblDishCategory;
        private System.Windows.Forms.Label lblDish;
    }
}