using System.Drawing;

namespace CoffeShopManagement.GUI
{
    partial class frmAmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmin));
            this.tabControl_Admin = new System.Windows.Forms.TabControl();
            this.tabPage_Account = new System.Windows.Forms.TabPage();
            this.panel_Account = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel_AccountInformation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSignInAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_OptionsAccount = new System.Windows.Forms.Panel();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.panel_DisplayName = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabPage_TurnOver = new System.Windows.Forms.TabPage();
            this.panel_Bill = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel_FromDateToDate = new System.Windows.Forms.Panel();
            this.txtTotalTurnOver = new System.Windows.Forms.TextBox();
            this.lblTotalTurnOver = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage_DishCategory = new System.Windows.Forms.TabPage();
            this.panel_DishCategory = new System.Windows.Forms.Panel();
            this.dgvDishCategory = new System.Windows.Forms.DataGridView();
            this.panel_DishCategoryInformation = new System.Windows.Forms.Panel();
            this.panel_DishCategoryName = new System.Windows.Forms.Panel();
            this.txtDishCategoryName = new System.Windows.Forms.TextBox();
            this.lblDishCategoryName = new System.Windows.Forms.Label();
            this.panel_DishCategoryId = new System.Windows.Forms.Panel();
            this.txtIdDishCategory = new System.Windows.Forms.TextBox();
            this.lblDishCategoryID = new System.Windows.Forms.Label();
            this.panel_DishCategoryOptions = new System.Windows.Forms.Panel();
            this.btnEditDishCategory = new System.Windows.Forms.Button();
            this.btnDeleteDishCategory = new System.Windows.Forms.Button();
            this.btnAddDishCategory = new System.Windows.Forms.Button();
            this.tabPage_Dish = new System.Windows.Forms.TabPage();
            this.panel_SearchDish = new System.Windows.Forms.Panel();
            this.btnSearchDish = new System.Windows.Forms.Button();
            this.txtSearchDish = new System.Windows.Forms.TextBox();
            this.panel_OptionsDish = new System.Windows.Forms.Panel();
            this.btnEditDish = new System.Windows.Forms.Button();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.panel_DishInformation = new System.Windows.Forms.Panel();
            this.panel_cmbDishCategory = new System.Windows.Forms.Panel();
            this.lbl_DishCategory = new System.Windows.Forms.Label();
            this.panel_Prices = new System.Windows.Forms.Panel();
            this.txt_Prices = new System.Windows.Forms.TextBox();
            this.lblPrices = new System.Windows.Forms.Label();
            this.panel_DishName = new System.Windows.Forms.Panel();
            this.txt_DishName = new System.Windows.Forms.TextBox();
            this.lbl_DishName = new System.Windows.Forms.Label();
            this.panel_DishID = new System.Windows.Forms.Panel();
            this.txt_IdDish = new System.Windows.Forms.TextBox();
            this.lbl_IdDish = new System.Windows.Forms.Label();
            this.panel_Dish = new System.Windows.Forms.Panel();
            this.dgvDish = new System.Windows.Forms.DataGridView();
            this.tabPage_Table = new System.Windows.Forms.TabPage();
            this.panel_Tabels = new System.Windows.Forms.Panel();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.panel_TablesInformation = new System.Windows.Forms.Panel();
            this.panel_TablesName = new System.Windows.Forms.Panel();
            this.txtTablesName = new System.Windows.Forms.TextBox();
            this.lblTablesName = new System.Windows.Forms.Label();
            this.panel_TablesId = new System.Windows.Forms.Panel();
            this.txtTablesID = new System.Windows.Forms.TextBox();
            this.lblTablesID = new System.Windows.Forms.Label();
            this.panel_OptionsTables = new System.Windows.Forms.Panel();
            this.btnEditTables = new System.Windows.Forms.Button();
            this.btnDeleteTables = new System.Windows.Forms.Button();
            this.btnAddTables = new System.Windows.Forms.Button();
            this.txtDishcategoryInDish = new System.Windows.Forms.TextBox();
            this.btnRefreshDish = new System.Windows.Forms.Button();
            this.btnReFreshTableNumber = new System.Windows.Forms.Button();
            this.btnRefreshDishCategory = new System.Windows.Forms.Button();
            this.btnRefreshAccount = new System.Windows.Forms.Button();
            this.tabControl_Admin.SuspendLayout();
            this.tabPage_Account.SuspendLayout();
            this.panel_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel_AccountInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_OptionsAccount.SuspendLayout();
            this.panel_DisplayName.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.tabPage_TurnOver.SuspendLayout();
            this.panel_Bill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel_FromDateToDate.SuspendLayout();
            this.tabPage_DishCategory.SuspendLayout();
            this.panel_DishCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishCategory)).BeginInit();
            this.panel_DishCategoryInformation.SuspendLayout();
            this.panel_DishCategoryName.SuspendLayout();
            this.panel_DishCategoryId.SuspendLayout();
            this.panel_DishCategoryOptions.SuspendLayout();
            this.tabPage_Dish.SuspendLayout();
            this.panel_SearchDish.SuspendLayout();
            this.panel_OptionsDish.SuspendLayout();
            this.panel_DishInformation.SuspendLayout();
            this.panel_cmbDishCategory.SuspendLayout();
            this.panel_Prices.SuspendLayout();
            this.panel_DishName.SuspendLayout();
            this.panel_DishID.SuspendLayout();
            this.panel_Dish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).BeginInit();
            this.tabPage_Table.SuspendLayout();
            this.panel_Tabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.panel_TablesInformation.SuspendLayout();
            this.panel_TablesName.SuspendLayout();
            this.panel_TablesId.SuspendLayout();
            this.panel_OptionsTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Admin
            // 
            this.tabControl_Admin.Controls.Add(this.tabPage_Account);
            this.tabControl_Admin.Controls.Add(this.tabPage_TurnOver);
            this.tabControl_Admin.Controls.Add(this.tabPage_DishCategory);
            this.tabControl_Admin.Controls.Add(this.tabPage_Dish);
            this.tabControl_Admin.Controls.Add(this.tabPage_Table);
            this.tabControl_Admin.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Admin.Location = new System.Drawing.Point(12, 2);
            this.tabControl_Admin.Name = "tabControl_Admin";
            this.tabControl_Admin.SelectedIndex = 0;
            this.tabControl_Admin.Size = new System.Drawing.Size(879, 475);
            this.tabControl_Admin.TabIndex = 0;
            // 
            // tabPage_Account
            // 
            this.tabPage_Account.Controls.Add(this.panel_Account);
            this.tabPage_Account.Controls.Add(this.panel_AccountInformation);
            this.tabPage_Account.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Account.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Account.Name = "tabPage_Account";
            this.tabPage_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Account.Size = new System.Drawing.Size(871, 447);
            this.tabPage_Account.TabIndex = 0;
            this.tabPage_Account.Text = "Tài khoản";
            this.tabPage_Account.UseVisualStyleBackColor = true;
            // 
            // panel_Account
            // 
            this.panel_Account.Controls.Add(this.dgvAccount);
            this.panel_Account.Location = new System.Drawing.Point(4, 9);
            this.panel_Account.Name = "panel_Account";
            this.panel_Account.Size = new System.Drawing.Size(467, 426);
            this.panel_Account.TabIndex = 1;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(461, 417);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // panel_AccountInformation
            // 
            this.panel_AccountInformation.Controls.Add(this.panel1);
            this.panel_AccountInformation.Controls.Add(this.btnSignInAccount);
            this.panel_AccountInformation.Controls.Add(this.label2);
            this.panel_AccountInformation.Controls.Add(this.panel_OptionsAccount);
            this.panel_AccountInformation.Controls.Add(this.panel_DisplayName);
            this.panel_AccountInformation.Controls.Add(this.panelUsername);
            this.panel_AccountInformation.Location = new System.Drawing.Point(474, 9);
            this.panel_AccountInformation.Name = "panel_AccountInformation";
            this.panel_AccountInformation.Size = new System.Drawing.Size(389, 423);
            this.panel_AccountInformation.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Location = new System.Drawing.Point(3, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 78);
            this.panel1.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(142, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 29);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // btnSignInAccount
            // 
            this.btnSignInAccount.BackColor = System.Drawing.Color.Black;
            this.btnSignInAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInAccount.ForeColor = System.Drawing.Color.Gold;
            this.btnSignInAccount.Location = new System.Drawing.Point(283, 373);
            this.btnSignInAccount.Name = "btnSignInAccount";
            this.btnSignInAccount.Size = new System.Drawing.Size(100, 47);
            this.btnSignInAccount.TabIndex = 7;
            this.btnSignInAccount.Text = "Đăng ký";
            this.btnSignInAccount.UseVisualStyleBackColor = false;
            this.btnSignInAccount.Click += new System.EventHandler(this.btnSignInAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nếu bạn chưa có tài khoản:";
            // 
            // panel_OptionsAccount
            // 
            this.panel_OptionsAccount.Controls.Add(this.btnRefreshAccount);
            this.panel_OptionsAccount.Controls.Add(this.btnEditAccount);
            this.panel_OptionsAccount.Controls.Add(this.btnDeleteAccount);
            this.panel_OptionsAccount.Location = new System.Drawing.Point(55, 256);
            this.panel_OptionsAccount.Name = "panel_OptionsAccount";
            this.panel_OptionsAccount.Size = new System.Drawing.Size(328, 53);
            this.panel_OptionsAccount.TabIndex = 4;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.Black;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.ForeColor = System.Drawing.Color.Gold;
            this.btnEditAccount.Location = new System.Drawing.Point(109, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(100, 47);
            this.btnEditAccount.TabIndex = 5;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Gold;
            this.btnDeleteAccount.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(100, 47);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // panel_DisplayName
            // 
            this.panel_DisplayName.Controls.Add(this.txtDisplayName);
            this.panel_DisplayName.Controls.Add(this.lblDisplayName);
            this.panel_DisplayName.Location = new System.Drawing.Point(3, 87);
            this.panel_DisplayName.Name = "panel_DisplayName";
            this.panel_DisplayName.Size = new System.Drawing.Size(383, 78);
            this.panel_DisplayName.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(142, 21);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(238, 27);
            this.txtDisplayName.TabIndex = 2;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(16, 29);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(103, 19);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Tên hiển thị:";
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.txtUsername);
            this.panelUsername.Controls.Add(this.lblUsername);
            this.panelUsername.Location = new System.Drawing.Point(3, 3);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(383, 78);
            this.panelUsername.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(142, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(238, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(16, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên tài khoản:";
            // 
            // tabPage_TurnOver
            // 
            this.tabPage_TurnOver.Controls.Add(this.panel_Bill);
            this.tabPage_TurnOver.Controls.Add(this.panel_FromDateToDate);
            this.tabPage_TurnOver.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_TurnOver.Location = new System.Drawing.Point(4, 24);
            this.tabPage_TurnOver.Name = "tabPage_TurnOver";
            this.tabPage_TurnOver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TurnOver.Size = new System.Drawing.Size(871, 441);
            this.tabPage_TurnOver.TabIndex = 1;
            this.tabPage_TurnOver.Text = "Doanh thu";
            this.tabPage_TurnOver.UseVisualStyleBackColor = true;
            // 
            // panel_Bill
            // 
            this.panel_Bill.Controls.Add(this.dgvBill);
            this.panel_Bill.Location = new System.Drawing.Point(6, 63);
            this.panel_Bill.Name = "panel_Bill";
            this.panel_Bill.Size = new System.Drawing.Size(859, 372);
            this.panel_Bill.TabIndex = 1;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(853, 366);
            this.dgvBill.TabIndex = 0;
            // 
            // panel_FromDateToDate
            // 
            this.panel_FromDateToDate.Controls.Add(this.txtTotalTurnOver);
            this.panel_FromDateToDate.Controls.Add(this.lblTotalTurnOver);
            this.panel_FromDateToDate.Controls.Add(this.lblFromDate);
            this.panel_FromDateToDate.Controls.Add(this.dateTimePicker1);
            this.panel_FromDateToDate.Location = new System.Drawing.Point(6, 6);
            this.panel_FromDateToDate.Name = "panel_FromDateToDate";
            this.panel_FromDateToDate.Size = new System.Drawing.Size(859, 51);
            this.panel_FromDateToDate.TabIndex = 0;
            // 
            // txtTotalTurnOver
            // 
            this.txtTotalTurnOver.Location = new System.Drawing.Point(309, 21);
            this.txtTotalTurnOver.Name = "txtTotalTurnOver";
            this.txtTotalTurnOver.Size = new System.Drawing.Size(219, 22);
            this.txtTotalTurnOver.TabIndex = 2;
            // 
            // lblTotalTurnOver
            // 
            this.lblTotalTurnOver.AutoSize = true;
            this.lblTotalTurnOver.Location = new System.Drawing.Point(306, 3);
            this.lblTotalTurnOver.Name = "lblTotalTurnOver";
            this.lblTotalTurnOver.Size = new System.Drawing.Size(97, 15);
            this.lblTotalTurnOver.TabIndex = 0;
            this.lblTotalTurnOver.Text = "Tổng doanh thu:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(3, 3);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(183, 15);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Doanh thu theo ngày tháng năm:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // tabPage_DishCategory
            // 
            this.tabPage_DishCategory.Controls.Add(this.panel_DishCategory);
            this.tabPage_DishCategory.Controls.Add(this.panel_DishCategoryInformation);
            this.tabPage_DishCategory.Location = new System.Drawing.Point(4, 24);
            this.tabPage_DishCategory.Name = "tabPage_DishCategory";
            this.tabPage_DishCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DishCategory.Size = new System.Drawing.Size(871, 447);
            this.tabPage_DishCategory.TabIndex = 2;
            this.tabPage_DishCategory.Text = "Loại món ăn";
            this.tabPage_DishCategory.UseVisualStyleBackColor = true;
            // 
            // panel_DishCategory
            // 
            this.panel_DishCategory.Controls.Add(this.dgvDishCategory);
            this.panel_DishCategory.Location = new System.Drawing.Point(6, 6);
            this.panel_DishCategory.Name = "panel_DishCategory";
            this.panel_DishCategory.Size = new System.Drawing.Size(467, 429);
            this.panel_DishCategory.TabIndex = 1;
            // 
            // dgvDishCategory
            // 
            this.dgvDishCategory.AllowUserToAddRows = false;
            this.dgvDishCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvDishCategory.Name = "dgvDishCategory";
            this.dgvDishCategory.RowHeadersWidth = 51;
            this.dgvDishCategory.RowTemplate.Height = 24;
            this.dgvDishCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishCategory.Size = new System.Drawing.Size(458, 423);
            this.dgvDishCategory.TabIndex = 0;
            this.dgvDishCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDishCategory_CellClick);
            // 
            // panel_DishCategoryInformation
            // 
            this.panel_DishCategoryInformation.Controls.Add(this.panel_DishCategoryName);
            this.panel_DishCategoryInformation.Controls.Add(this.panel_DishCategoryId);
            this.panel_DishCategoryInformation.Controls.Add(this.panel_DishCategoryOptions);
            this.panel_DishCategoryInformation.Location = new System.Drawing.Point(479, 9);
            this.panel_DishCategoryInformation.Name = "panel_DishCategoryInformation";
            this.panel_DishCategoryInformation.Size = new System.Drawing.Size(389, 426);
            this.panel_DishCategoryInformation.TabIndex = 2;
            // 
            // panel_DishCategoryName
            // 
            this.panel_DishCategoryName.Controls.Add(this.txtDishCategoryName);
            this.panel_DishCategoryName.Controls.Add(this.lblDishCategoryName);
            this.panel_DishCategoryName.Location = new System.Drawing.Point(3, 87);
            this.panel_DishCategoryName.Name = "panel_DishCategoryName";
            this.panel_DishCategoryName.Size = new System.Drawing.Size(383, 78);
            this.panel_DishCategoryName.TabIndex = 2;
            // 
            // txtDishCategoryName
            // 
            this.txtDishCategoryName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDishCategoryName.Location = new System.Drawing.Point(142, 21);
            this.txtDishCategoryName.Name = "txtDishCategoryName";
            this.txtDishCategoryName.Size = new System.Drawing.Size(238, 27);
            this.txtDishCategoryName.TabIndex = 2;
            // 
            // lblDishCategoryName
            // 
            this.lblDishCategoryName.AutoSize = true;
            this.lblDishCategoryName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishCategoryName.Location = new System.Drawing.Point(16, 29);
            this.lblDishCategoryName.Name = "lblDishCategoryName";
            this.lblDishCategoryName.Size = new System.Drawing.Size(69, 19);
            this.lblDishCategoryName.TabIndex = 0;
            this.lblDishCategoryName.Text = "Tên loại";
            // 
            // panel_DishCategoryId
            // 
            this.panel_DishCategoryId.Controls.Add(this.txtIdDishCategory);
            this.panel_DishCategoryId.Controls.Add(this.lblDishCategoryID);
            this.panel_DishCategoryId.Location = new System.Drawing.Point(3, 3);
            this.panel_DishCategoryId.Name = "panel_DishCategoryId";
            this.panel_DishCategoryId.Size = new System.Drawing.Size(383, 78);
            this.panel_DishCategoryId.TabIndex = 1;
            // 
            // txtIdDishCategory
            // 
            this.txtIdDishCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDishCategory.Location = new System.Drawing.Point(142, 21);
            this.txtIdDishCategory.Name = "txtIdDishCategory";
            this.txtIdDishCategory.ReadOnly = true;
            this.txtIdDishCategory.Size = new System.Drawing.Size(238, 27);
            this.txtIdDishCategory.TabIndex = 1;
            // 
            // lblDishCategoryID
            // 
            this.lblDishCategoryID.AutoSize = true;
            this.lblDishCategoryID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishCategoryID.Location = new System.Drawing.Point(16, 29);
            this.lblDishCategoryID.Name = "lblDishCategoryID";
            this.lblDishCategoryID.Size = new System.Drawing.Size(71, 19);
            this.lblDishCategoryID.TabIndex = 0;
            this.lblDishCategoryID.Text = "ID Loại:";
            // 
            // panel_DishCategoryOptions
            // 
            this.panel_DishCategoryOptions.Controls.Add(this.btnRefreshDishCategory);
            this.panel_DishCategoryOptions.Controls.Add(this.btnEditDishCategory);
            this.panel_DishCategoryOptions.Controls.Add(this.btnDeleteDishCategory);
            this.panel_DishCategoryOptions.Controls.Add(this.btnAddDishCategory);
            this.panel_DishCategoryOptions.Location = new System.Drawing.Point(64, 171);
            this.panel_DishCategoryOptions.Name = "panel_DishCategoryOptions";
            this.panel_DishCategoryOptions.Size = new System.Drawing.Size(322, 108);
            this.panel_DishCategoryOptions.TabIndex = 3;
            // 
            // btnEditDishCategory
            // 
            this.btnEditDishCategory.BackColor = System.Drawing.Color.Black;
            this.btnEditDishCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDishCategory.ForeColor = System.Drawing.Color.Gold;
            this.btnEditDishCategory.Location = new System.Drawing.Point(215, 3);
            this.btnEditDishCategory.Name = "btnEditDishCategory";
            this.btnEditDishCategory.Size = new System.Drawing.Size(100, 47);
            this.btnEditDishCategory.TabIndex = 5;
            this.btnEditDishCategory.Text = "Sửa";
            this.btnEditDishCategory.UseVisualStyleBackColor = false;
            this.btnEditDishCategory.Click += new System.EventHandler(this.btnEditDishCategory_Click);
            // 
            // btnDeleteDishCategory
            // 
            this.btnDeleteDishCategory.BackColor = System.Drawing.Color.Black;
            this.btnDeleteDishCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDishCategory.ForeColor = System.Drawing.Color.Gold;
            this.btnDeleteDishCategory.Location = new System.Drawing.Point(109, 3);
            this.btnDeleteDishCategory.Name = "btnDeleteDishCategory";
            this.btnDeleteDishCategory.Size = new System.Drawing.Size(100, 47);
            this.btnDeleteDishCategory.TabIndex = 4;
            this.btnDeleteDishCategory.Text = "Xóa";
            this.btnDeleteDishCategory.UseVisualStyleBackColor = false;
            this.btnDeleteDishCategory.Click += new System.EventHandler(this.btnDeleteDishCategory_Click);
            // 
            // btnAddDishCategory
            // 
            this.btnAddDishCategory.BackColor = System.Drawing.Color.Black;
            this.btnAddDishCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDishCategory.ForeColor = System.Drawing.Color.Gold;
            this.btnAddDishCategory.Location = new System.Drawing.Point(3, 3);
            this.btnAddDishCategory.Name = "btnAddDishCategory";
            this.btnAddDishCategory.Size = new System.Drawing.Size(100, 47);
            this.btnAddDishCategory.TabIndex = 3;
            this.btnAddDishCategory.Text = "Thêm";
            this.btnAddDishCategory.UseVisualStyleBackColor = false;
            this.btnAddDishCategory.Click += new System.EventHandler(this.btnAddDishCategory_Click);
            // 
            // tabPage_Dish
            // 
            this.tabPage_Dish.Controls.Add(this.panel_SearchDish);
            this.tabPage_Dish.Controls.Add(this.panel_OptionsDish);
            this.tabPage_Dish.Controls.Add(this.panel_DishInformation);
            this.tabPage_Dish.Controls.Add(this.panel_Dish);
            this.tabPage_Dish.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Dish.Name = "tabPage_Dish";
            this.tabPage_Dish.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dish.Size = new System.Drawing.Size(871, 447);
            this.tabPage_Dish.TabIndex = 3;
            this.tabPage_Dish.Text = "Món ăn";
            this.tabPage_Dish.UseVisualStyleBackColor = true;
            // 
            // panel_SearchDish
            // 
            this.panel_SearchDish.Controls.Add(this.btnSearchDish);
            this.panel_SearchDish.Controls.Add(this.txtSearchDish);
            this.panel_SearchDish.Location = new System.Drawing.Point(476, 6);
            this.panel_SearchDish.Name = "panel_SearchDish";
            this.panel_SearchDish.Size = new System.Drawing.Size(389, 53);
            this.panel_SearchDish.TabIndex = 2;
            // 
            // btnSearchDish
            // 
            this.btnSearchDish.BackColor = System.Drawing.Color.Black;
            this.btnSearchDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDish.ForeColor = System.Drawing.Color.Gold;
            this.btnSearchDish.Location = new System.Drawing.Point(286, 3);
            this.btnSearchDish.Name = "btnSearchDish";
            this.btnSearchDish.Size = new System.Drawing.Size(100, 47);
            this.btnSearchDish.TabIndex = 6;
            this.btnSearchDish.Text = "Tìm";
            this.btnSearchDish.UseVisualStyleBackColor = false;
            this.btnSearchDish.Click += new System.EventHandler(this.btnSearchDish_Click);
            // 
            // txtSearchDish
            // 
            this.txtSearchDish.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDish.Location = new System.Drawing.Point(3, 13);
            this.txtSearchDish.Name = "txtSearchDish";
            this.txtSearchDish.Size = new System.Drawing.Size(277, 27);
            this.txtSearchDish.TabIndex = 5;
            // 
            // panel_OptionsDish
            // 
            this.panel_OptionsDish.Controls.Add(this.btnRefreshDish);
            this.panel_OptionsDish.Controls.Add(this.btnEditDish);
            this.panel_OptionsDish.Controls.Add(this.btnDeleteDish);
            this.panel_OptionsDish.Controls.Add(this.btnAddDish);
            this.panel_OptionsDish.Location = new System.Drawing.Point(6, 6);
            this.panel_OptionsDish.Name = "panel_OptionsDish";
            this.panel_OptionsDish.Size = new System.Drawing.Size(464, 53);
            this.panel_OptionsDish.TabIndex = 1;
            // 
            // btnEditDish
            // 
            this.btnEditDish.BackColor = System.Drawing.Color.Black;
            this.btnEditDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDish.ForeColor = System.Drawing.Color.Gold;
            this.btnEditDish.Location = new System.Drawing.Point(215, 3);
            this.btnEditDish.Name = "btnEditDish";
            this.btnEditDish.Size = new System.Drawing.Size(100, 47);
            this.btnEditDish.TabIndex = 3;
            this.btnEditDish.Text = "Sửa";
            this.btnEditDish.UseVisualStyleBackColor = false;
            this.btnEditDish.Click += new System.EventHandler(this.btnEditDish_Click);
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.BackColor = System.Drawing.Color.Black;
            this.btnDeleteDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDish.ForeColor = System.Drawing.Color.Gold;
            this.btnDeleteDish.Location = new System.Drawing.Point(109, 3);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(100, 47);
            this.btnDeleteDish.TabIndex = 2;
            this.btnDeleteDish.Text = "Xóa";
            this.btnDeleteDish.UseVisualStyleBackColor = false;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackColor = System.Drawing.Color.Black;
            this.btnAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDish.ForeColor = System.Drawing.Color.Gold;
            this.btnAddDish.Location = new System.Drawing.Point(3, 3);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(100, 47);
            this.btnAddDish.TabIndex = 1;
            this.btnAddDish.Text = "Thêm";
            this.btnAddDish.UseVisualStyleBackColor = false;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // panel_DishInformation
            // 
            this.panel_DishInformation.Controls.Add(this.panel_cmbDishCategory);
            this.panel_DishInformation.Controls.Add(this.panel_Prices);
            this.panel_DishInformation.Controls.Add(this.panel_DishName);
            this.panel_DishInformation.Controls.Add(this.panel_DishID);
            this.panel_DishInformation.Location = new System.Drawing.Point(476, 65);
            this.panel_DishInformation.Name = "panel_DishInformation";
            this.panel_DishInformation.Size = new System.Drawing.Size(389, 373);
            this.panel_DishInformation.TabIndex = 3;
            // 
            // panel_cmbDishCategory
            // 
            this.panel_cmbDishCategory.Controls.Add(this.txtDishcategoryInDish);
            this.panel_cmbDishCategory.Controls.Add(this.lbl_DishCategory);
            this.panel_cmbDishCategory.Location = new System.Drawing.Point(3, 255);
            this.panel_cmbDishCategory.Name = "panel_cmbDishCategory";
            this.panel_cmbDishCategory.Size = new System.Drawing.Size(383, 78);
            this.panel_cmbDishCategory.TabIndex = 6;
            // 
            // lbl_DishCategory
            // 
            this.lbl_DishCategory.AutoSize = true;
            this.lbl_DishCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DishCategory.Location = new System.Drawing.Point(16, 29);
            this.lbl_DishCategory.Name = "lbl_DishCategory";
            this.lbl_DishCategory.Size = new System.Drawing.Size(49, 19);
            this.lbl_DishCategory.TabIndex = 0;
            this.lbl_DishCategory.Text = "Loại:";
            // 
            // panel_Prices
            // 
            this.panel_Prices.Controls.Add(this.txt_Prices);
            this.panel_Prices.Controls.Add(this.lblPrices);
            this.panel_Prices.Location = new System.Drawing.Point(3, 171);
            this.panel_Prices.Name = "panel_Prices";
            this.panel_Prices.Size = new System.Drawing.Size(383, 78);
            this.panel_Prices.TabIndex = 5;
            // 
            // txt_Prices
            // 
            this.txt_Prices.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prices.Location = new System.Drawing.Point(142, 21);
            this.txt_Prices.Name = "txt_Prices";
            this.txt_Prices.Size = new System.Drawing.Size(238, 27);
            this.txt_Prices.TabIndex = 9;
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.Location = new System.Drawing.Point(16, 29);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(43, 19);
            this.lblPrices.TabIndex = 0;
            this.lblPrices.Text = "Giá:";
            // 
            // panel_DishName
            // 
            this.panel_DishName.Controls.Add(this.txt_DishName);
            this.panel_DishName.Controls.Add(this.lbl_DishName);
            this.panel_DishName.Location = new System.Drawing.Point(3, 87);
            this.panel_DishName.Name = "panel_DishName";
            this.panel_DishName.Size = new System.Drawing.Size(383, 78);
            this.panel_DishName.TabIndex = 4;
            // 
            // txt_DishName
            // 
            this.txt_DishName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DishName.Location = new System.Drawing.Point(142, 21);
            this.txt_DishName.Name = "txt_DishName";
            this.txt_DishName.Size = new System.Drawing.Size(238, 27);
            this.txt_DishName.TabIndex = 8;
            // 
            // lbl_DishName
            // 
            this.lbl_DishName.AutoSize = true;
            this.lbl_DishName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DishName.Location = new System.Drawing.Point(16, 29);
            this.lbl_DishName.Name = "lbl_DishName";
            this.lbl_DishName.Size = new System.Drawing.Size(78, 19);
            this.lbl_DishName.TabIndex = 0;
            this.lbl_DishName.Text = "Tên món:";
            // 
            // panel_DishID
            // 
            this.panel_DishID.Controls.Add(this.txt_IdDish);
            this.panel_DishID.Controls.Add(this.lbl_IdDish);
            this.panel_DishID.Location = new System.Drawing.Point(3, 3);
            this.panel_DishID.Name = "panel_DishID";
            this.panel_DishID.Size = new System.Drawing.Size(383, 78);
            this.panel_DishID.TabIndex = 3;
            // 
            // txt_IdDish
            // 
            this.txt_IdDish.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdDish.Location = new System.Drawing.Point(142, 21);
            this.txt_IdDish.Name = "txt_IdDish";
            this.txt_IdDish.ReadOnly = true;
            this.txt_IdDish.Size = new System.Drawing.Size(238, 27);
            this.txt_IdDish.TabIndex = 7;
            // 
            // lbl_IdDish
            // 
            this.lbl_IdDish.AutoSize = true;
            this.lbl_IdDish.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdDish.Location = new System.Drawing.Point(16, 29);
            this.lbl_IdDish.Name = "lbl_IdDish";
            this.lbl_IdDish.Size = new System.Drawing.Size(92, 19);
            this.lbl_IdDish.TabIndex = 0;
            this.lbl_IdDish.Text = "ID Món ăn:";
            // 
            // panel_Dish
            // 
            this.panel_Dish.Controls.Add(this.dgvDish);
            this.panel_Dish.Location = new System.Drawing.Point(6, 65);
            this.panel_Dish.Name = "panel_Dish";
            this.panel_Dish.Size = new System.Drawing.Size(467, 373);
            this.panel_Dish.TabIndex = 1;
            // 
            // dgvDish
            // 
            this.dgvDish.AllowUserToAddRows = false;
            this.dgvDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDish.Location = new System.Drawing.Point(3, 3);
            this.dgvDish.Name = "dgvDish";
            this.dgvDish.RowHeadersWidth = 51;
            this.dgvDish.RowTemplate.Height = 24;
            this.dgvDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDish.Size = new System.Drawing.Size(458, 367);
            this.dgvDish.TabIndex = 0;
            this.dgvDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDish_CellClick);
            // 
            // tabPage_Table
            // 
            this.tabPage_Table.Controls.Add(this.panel_Tabels);
            this.tabPage_Table.Controls.Add(this.panel_TablesInformation);
            this.tabPage_Table.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Table.Name = "tabPage_Table";
            this.tabPage_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Table.Size = new System.Drawing.Size(871, 447);
            this.tabPage_Table.TabIndex = 4;
            this.tabPage_Table.Text = "Bàn";
            this.tabPage_Table.UseVisualStyleBackColor = true;
            // 
            // panel_Tabels
            // 
            this.panel_Tabels.Controls.Add(this.dgvTables);
            this.panel_Tabels.Location = new System.Drawing.Point(4, 9);
            this.panel_Tabels.Name = "panel_Tabels";
            this.panel_Tabels.Size = new System.Drawing.Size(467, 426);
            this.panel_Tabels.TabIndex = 1;
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(3, 3);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.RowHeadersWidth = 51;
            this.dgvTables.RowTemplate.Height = 24;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(458, 420);
            this.dgvTables.TabIndex = 0;
            this.dgvTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellClick);
            // 
            // panel_TablesInformation
            // 
            this.panel_TablesInformation.Controls.Add(this.panel_TablesName);
            this.panel_TablesInformation.Controls.Add(this.panel_TablesId);
            this.panel_TablesInformation.Controls.Add(this.panel_OptionsTables);
            this.panel_TablesInformation.Location = new System.Drawing.Point(477, 9);
            this.panel_TablesInformation.Name = "panel_TablesInformation";
            this.panel_TablesInformation.Size = new System.Drawing.Size(389, 426);
            this.panel_TablesInformation.TabIndex = 2;
            // 
            // panel_TablesName
            // 
            this.panel_TablesName.Controls.Add(this.txtTablesName);
            this.panel_TablesName.Controls.Add(this.lblTablesName);
            this.panel_TablesName.Location = new System.Drawing.Point(3, 87);
            this.panel_TablesName.Name = "panel_TablesName";
            this.panel_TablesName.Size = new System.Drawing.Size(383, 78);
            this.panel_TablesName.TabIndex = 2;
            // 
            // txtTablesName
            // 
            this.txtTablesName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablesName.Location = new System.Drawing.Point(142, 21);
            this.txtTablesName.Name = "txtTablesName";
            this.txtTablesName.Size = new System.Drawing.Size(238, 27);
            this.txtTablesName.TabIndex = 2;
            // 
            // lblTablesName
            // 
            this.lblTablesName.AutoSize = true;
            this.lblTablesName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablesName.Location = new System.Drawing.Point(16, 29);
            this.lblTablesName.Name = "lblTablesName";
            this.lblTablesName.Size = new System.Drawing.Size(72, 19);
            this.lblTablesName.TabIndex = 0;
            this.lblTablesName.Text = "Tên bàn:";
            // 
            // panel_TablesId
            // 
            this.panel_TablesId.Controls.Add(this.txtTablesID);
            this.panel_TablesId.Controls.Add(this.lblTablesID);
            this.panel_TablesId.Location = new System.Drawing.Point(3, 3);
            this.panel_TablesId.Name = "panel_TablesId";
            this.panel_TablesId.Size = new System.Drawing.Size(383, 78);
            this.panel_TablesId.TabIndex = 1;
            // 
            // txtTablesID
            // 
            this.txtTablesID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablesID.Location = new System.Drawing.Point(142, 21);
            this.txtTablesID.Name = "txtTablesID";
            this.txtTablesID.ReadOnly = true;
            this.txtTablesID.Size = new System.Drawing.Size(238, 27);
            this.txtTablesID.TabIndex = 1;
            // 
            // lblTablesID
            // 
            this.lblTablesID.AutoSize = true;
            this.lblTablesID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablesID.Location = new System.Drawing.Point(16, 29);
            this.lblTablesID.Name = "lblTablesID";
            this.lblTablesID.Size = new System.Drawing.Size(66, 19);
            this.lblTablesID.TabIndex = 0;
            this.lblTablesID.Text = "ID Bàn:";
            // 
            // panel_OptionsTables
            // 
            this.panel_OptionsTables.Controls.Add(this.btnReFreshTableNumber);
            this.panel_OptionsTables.Controls.Add(this.btnEditTables);
            this.panel_OptionsTables.Controls.Add(this.btnDeleteTables);
            this.panel_OptionsTables.Controls.Add(this.btnAddTables);
            this.panel_OptionsTables.Location = new System.Drawing.Point(61, 171);
            this.panel_OptionsTables.Name = "panel_OptionsTables";
            this.panel_OptionsTables.Size = new System.Drawing.Size(325, 110);
            this.panel_OptionsTables.TabIndex = 3;
            // 
            // btnEditTables
            // 
            this.btnEditTables.BackColor = System.Drawing.Color.Black;
            this.btnEditTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTables.ForeColor = System.Drawing.Color.Gold;
            this.btnEditTables.Location = new System.Drawing.Point(215, 3);
            this.btnEditTables.Name = "btnEditTables";
            this.btnEditTables.Size = new System.Drawing.Size(100, 47);
            this.btnEditTables.TabIndex = 5;
            this.btnEditTables.Text = "Sửa";
            this.btnEditTables.UseVisualStyleBackColor = false;
            this.btnEditTables.Click += new System.EventHandler(this.btnEditTables_Click);
            // 
            // btnDeleteTables
            // 
            this.btnDeleteTables.BackColor = System.Drawing.Color.Black;
            this.btnDeleteTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTables.ForeColor = System.Drawing.Color.Gold;
            this.btnDeleteTables.Location = new System.Drawing.Point(109, 3);
            this.btnDeleteTables.Name = "btnDeleteTables";
            this.btnDeleteTables.Size = new System.Drawing.Size(100, 47);
            this.btnDeleteTables.TabIndex = 4;
            this.btnDeleteTables.Text = "Xóa";
            this.btnDeleteTables.UseVisualStyleBackColor = false;
            this.btnDeleteTables.Click += new System.EventHandler(this.btnDeleteTables_Click);
            // 
            // btnAddTables
            // 
            this.btnAddTables.BackColor = System.Drawing.Color.Black;
            this.btnAddTables.FlatAppearance.BorderSize = 0;
            this.btnAddTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTables.ForeColor = System.Drawing.Color.Gold;
            this.btnAddTables.Location = new System.Drawing.Point(3, 3);
            this.btnAddTables.Name = "btnAddTables";
            this.btnAddTables.Size = new System.Drawing.Size(100, 47);
            this.btnAddTables.TabIndex = 3;
            this.btnAddTables.Text = "Thêm";
            this.btnAddTables.UseVisualStyleBackColor = false;
            this.btnAddTables.Click += new System.EventHandler(this.btnAddTables_Click);
            // 
            // txtDishcategoryInDish
            // 
            this.txtDishcategoryInDish.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDishcategoryInDish.Location = new System.Drawing.Point(142, 21);
            this.txtDishcategoryInDish.Name = "txtDishcategoryInDish";
            this.txtDishcategoryInDish.Size = new System.Drawing.Size(238, 27);
            this.txtDishcategoryInDish.TabIndex = 10;
            // 
            // btnRefreshDish
            // 
            this.btnRefreshDish.BackColor = System.Drawing.Color.Black;
            this.btnRefreshDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDish.ForeColor = System.Drawing.Color.Gold;
            this.btnRefreshDish.Location = new System.Drawing.Point(321, 3);
            this.btnRefreshDish.Name = "btnRefreshDish";
            this.btnRefreshDish.Size = new System.Drawing.Size(100, 47);
            this.btnRefreshDish.TabIndex = 4;
            this.btnRefreshDish.Text = "Làm Mới";
            this.btnRefreshDish.UseVisualStyleBackColor = false;
            this.btnRefreshDish.Click += new System.EventHandler(this.btnRefreshDish_Click);
            // 
            // btnReFreshTableNumber
            // 
            this.btnReFreshTableNumber.BackColor = System.Drawing.Color.Black;
            this.btnReFreshTableNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReFreshTableNumber.ForeColor = System.Drawing.Color.Gold;
            this.btnReFreshTableNumber.Location = new System.Drawing.Point(215, 56);
            this.btnReFreshTableNumber.Name = "btnReFreshTableNumber";
            this.btnReFreshTableNumber.Size = new System.Drawing.Size(100, 47);
            this.btnReFreshTableNumber.TabIndex = 6;
            this.btnReFreshTableNumber.Text = "Làm Mới";
            this.btnReFreshTableNumber.UseVisualStyleBackColor = false;
            this.btnReFreshTableNumber.Click += new System.EventHandler(this.btnReFreshTableNumber_Click);
            // 
            // btnRefreshDishCategory
            // 
            this.btnRefreshDishCategory.BackColor = System.Drawing.Color.Black;
            this.btnRefreshDishCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDishCategory.ForeColor = System.Drawing.Color.Gold;
            this.btnRefreshDishCategory.Location = new System.Drawing.Point(215, 56);
            this.btnRefreshDishCategory.Name = "btnRefreshDishCategory";
            this.btnRefreshDishCategory.Size = new System.Drawing.Size(100, 47);
            this.btnRefreshDishCategory.TabIndex = 6;
            this.btnRefreshDishCategory.Text = "Làm Mới";
            this.btnRefreshDishCategory.UseVisualStyleBackColor = false;
            this.btnRefreshDishCategory.Click += new System.EventHandler(this.btnRefreshDishCategory_Click);
            // 
            // btnRefreshAccount
            // 
            this.btnRefreshAccount.BackColor = System.Drawing.Color.Black;
            this.btnRefreshAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAccount.ForeColor = System.Drawing.Color.Gold;
            this.btnRefreshAccount.Location = new System.Drawing.Point(215, 3);
            this.btnRefreshAccount.Name = "btnRefreshAccount";
            this.btnRefreshAccount.Size = new System.Drawing.Size(100, 47);
            this.btnRefreshAccount.TabIndex = 6;
            this.btnRefreshAccount.Text = "Làm Mới";
            this.btnRefreshAccount.UseVisualStyleBackColor = false;
            this.btnRefreshAccount.Click += new System.EventHandler(this.btnRefreshAccount_Click);
            // 
            // frmAmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(205)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(904, 489);
            this.Controls.Add(this.tabControl_Admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAmin";
            this.tabControl_Admin.ResumeLayout(false);
            this.tabPage_Account.ResumeLayout(false);
            this.panel_Account.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel_AccountInformation.ResumeLayout(false);
            this.panel_AccountInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_OptionsAccount.ResumeLayout(false);
            this.panel_DisplayName.ResumeLayout(false);
            this.panel_DisplayName.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.tabPage_TurnOver.ResumeLayout(false);
            this.panel_Bill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel_FromDateToDate.ResumeLayout(false);
            this.panel_FromDateToDate.PerformLayout();
            this.tabPage_DishCategory.ResumeLayout(false);
            this.panel_DishCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishCategory)).EndInit();
            this.panel_DishCategoryInformation.ResumeLayout(false);
            this.panel_DishCategoryName.ResumeLayout(false);
            this.panel_DishCategoryName.PerformLayout();
            this.panel_DishCategoryId.ResumeLayout(false);
            this.panel_DishCategoryId.PerformLayout();
            this.panel_DishCategoryOptions.ResumeLayout(false);
            this.tabPage_Dish.ResumeLayout(false);
            this.panel_SearchDish.ResumeLayout(false);
            this.panel_SearchDish.PerformLayout();
            this.panel_OptionsDish.ResumeLayout(false);
            this.panel_DishInformation.ResumeLayout(false);
            this.panel_cmbDishCategory.ResumeLayout(false);
            this.panel_cmbDishCategory.PerformLayout();
            this.panel_Prices.ResumeLayout(false);
            this.panel_Prices.PerformLayout();
            this.panel_DishName.ResumeLayout(false);
            this.panel_DishName.PerformLayout();
            this.panel_DishID.ResumeLayout(false);
            this.panel_DishID.PerformLayout();
            this.panel_Dish.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDish)).EndInit();
            this.tabPage_Table.ResumeLayout(false);
            this.panel_Tabels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.panel_TablesInformation.ResumeLayout(false);
            this.panel_TablesName.ResumeLayout(false);
            this.panel_TablesName.PerformLayout();
            this.panel_TablesId.ResumeLayout(false);
            this.panel_TablesId.PerformLayout();
            this.panel_OptionsTables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Admin;
        private System.Windows.Forms.TabPage tabPage_Account;
        private System.Windows.Forms.Panel panel_AccountInformation;
        private System.Windows.Forms.Panel panel_DisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel_OptionsAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.TabPage tabPage_TurnOver;
        private System.Windows.Forms.Panel panel_Bill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel_FromDateToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage_DishCategory;
        private System.Windows.Forms.Panel panel_DishCategory;
        private System.Windows.Forms.DataGridView dgvDishCategory;
        private System.Windows.Forms.Panel panel_DishCategoryInformation;
        private System.Windows.Forms.Panel panel_DishCategoryName;
        private System.Windows.Forms.TextBox txtDishCategoryName;
        private System.Windows.Forms.Label lblDishCategoryName;
        private System.Windows.Forms.Panel panel_DishCategoryId;
        private System.Windows.Forms.TextBox txtIdDishCategory;
        private System.Windows.Forms.Label lblDishCategoryID;
        private System.Windows.Forms.Panel panel_DishCategoryOptions;
        private System.Windows.Forms.Button btnEditDishCategory;
        private System.Windows.Forms.Button btnDeleteDishCategory;
        private System.Windows.Forms.Button btnAddDishCategory;
        private System.Windows.Forms.TabPage tabPage_Dish;
        private System.Windows.Forms.Panel panel_SearchDish;
        private System.Windows.Forms.Button btnSearchDish;
        private System.Windows.Forms.TextBox txtSearchDish;
        private System.Windows.Forms.Panel panel_OptionsDish;
        private System.Windows.Forms.Button btnEditDish;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Panel panel_DishInformation;
        private System.Windows.Forms.Panel panel_cmbDishCategory;
        private System.Windows.Forms.Label lbl_DishCategory;
        private System.Windows.Forms.Panel panel_Prices;
        private System.Windows.Forms.TextBox txt_Prices;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.Panel panel_DishName;
        private System.Windows.Forms.TextBox txt_DishName;
        private System.Windows.Forms.Label lbl_DishName;
        private System.Windows.Forms.Panel panel_DishID;
        private System.Windows.Forms.TextBox txt_IdDish;
        private System.Windows.Forms.Label lbl_IdDish;
        private System.Windows.Forms.Panel panel_Dish;
        private System.Windows.Forms.DataGridView dgvDish;
        private System.Windows.Forms.TabPage tabPage_Table;
        private System.Windows.Forms.Panel panel_Tabels;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Panel panel_TablesInformation;
        private System.Windows.Forms.Panel panel_TablesName;
        private System.Windows.Forms.TextBox txtTablesName;
        private System.Windows.Forms.Label lblTablesName;
        private System.Windows.Forms.Panel panel_TablesId;
        private System.Windows.Forms.TextBox txtTablesID;
        private System.Windows.Forms.Label lblTablesID;
        private System.Windows.Forms.Panel panel_OptionsTables;
        private System.Windows.Forms.Button btnEditTables;
        private System.Windows.Forms.Button btnDeleteTables;
        private System.Windows.Forms.Button btnAddTables;
        private System.Windows.Forms.Button btnSignInAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Account;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TextBox txtTotalTurnOver;
        private System.Windows.Forms.Label lblTotalTurnOver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtDishcategoryInDish;
        private System.Windows.Forms.Button btnRefreshAccount;
        private System.Windows.Forms.Button btnRefreshDishCategory;
        private System.Windows.Forms.Button btnRefreshDish;
        private System.Windows.Forms.Button btnReFreshTableNumber;
    }
}