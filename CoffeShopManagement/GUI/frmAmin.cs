using CoffeShopManagement.DAO;
using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeShopManagement.GUI
{
    public partial class frmAmin : Form
    {
        public frmAmin()
        {
            InitializeComponent();
            Load_DGV_Account();
            Load_DGV_Bill();
            Load_DGV_DishCategory();
            Load_DGV_Dish();
            Load_DGV_TableNumber();
        }

        #region EVENTS
        private void btnSignInAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignInAccount frm = new frmSignInAccount();
            frm.ShowDialog();
        }
        private void btnRefreshAccount_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtDisplayName.Text = "";
            txtPassword.Text = "";
        }

        private void btnRefreshDishCategory_Click(object sender, EventArgs e)
        {
            txtIdDishCategory.Text = "";
            txtDishCategoryName.Text = "";
        }

        private void btnRefreshDish_Click(object sender, EventArgs e)
        {
            txt_IdDish.Text = "";
            txt_DishName.Text = "";
            txt_Prices.Text = "";
            txtDishcategoryInDish.Text = "";
        }

        private void btnReFreshTableNumber_Click(object sender, EventArgs e)
        {
            txtTablesID.Text = "";
            txtTablesName.Text = "";
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            DialogResult result = MessageBox.Show("Bạn chắc muốn xóa chứ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                DeleteAccount(username);
            }

        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string displayname = txtDisplayName.Text;
            string password = txtPassword.Text;
            EditAccount(username, displayname, password);
        }
        private void btnAddDishCategory_Click(object sender, EventArgs e)
        {
            string name = txtDishCategoryName.Text;
            Insert_DishCategory(name);
        }

        private void btnDeleteDishCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdDishCategory.Text);
            DialogResult result = MessageBox.Show("Bạn chắc muốn xóa chứ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Delete_DishCategory(id);
            }
        }

        private void btnEditDishCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdDishCategory.Text);
            string name = txtDishCategoryName.Text;
            Edit_DishCategory(id, name);
        }
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            string name = txt_DishName.Text;
            int idDishCateGory = int.Parse(txtDishcategoryInDish.Text);
            double price = double.Parse(txt_Prices.Text);
            Insert_Dish(name, idDishCateGory, price);
        }

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_IdDish.Text);
            DialogResult result = MessageBox.Show("Bạn chắc muốn xóa chứ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Delete_Dish(id);
            }
        }

        private void btnEditDish_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_IdDish.Text);
            string name = txt_DishName.Text;
            int idDishCateGory = int.Parse(txtDishcategoryInDish.Text);
            double price = double.Parse(txt_Prices.Text);
            Edit_Dish(id, name, idDishCateGory, price);
        }

        private void btnSearchDish_Click(object sender, EventArgs e)
        {
            string name = txtSearchDish.Text;
            dgvDish.DataSource = Search_Dish(name);
        }

        private void btnAddTables_Click(object sender, EventArgs e)
        {
            string name = txtTablesName.Text;
            Insert_TableNumber(name);
        }

        private void btnDeleteTables_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTablesID.Text);
            DialogResult result = MessageBox.Show("Bạn chắc muốn xóa chứ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                Delete_TableNumber(id);
            }
        }

        private void btnEditTables_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtTablesID.Text);
            string name = txtTablesName.Text;
            Edit_TableNumber(id, name);
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
            txtUsername.Text = row.Cells[0].Value.ToString();
            txtDisplayName.Text = row.Cells[1].Value.ToString();
            txtPassword.Text = row.Cells[2].Value.ToString();
        }
        private void dgvDishCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDishCategory.Rows[e.RowIndex];
            txtIdDishCategory.Text = row.Cells[0].Value.ToString();
            txtDishCategoryName.Text = row.Cells[1].Value.ToString();
        }
        private void dgvDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDish.Rows[e.RowIndex];
            txt_IdDish.Text = row.Cells[0].Value.ToString();
            txt_DishName.Text = row.Cells[1].Value.ToString();
            txt_Prices.Text = row.Cells[3].Value.ToString();
            txtDishcategoryInDish.Text = row.Cells[2].Value.ToString();
        }
        private void dgvTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTables.Rows[e.RowIndex];
            txtTablesID.Text = row.Cells[0].Value.ToString();
            txtTablesName.Text = row.Cells[1].Value.ToString();
        }
        #endregion

        #region METHODS
        public void Load_DGV_Account()
        {
            List<Account> Accountlist = AccountBelongToAdminDAO.Instance.ShowAccount();
            dgvAccount.DataSource = Accountlist;
        }
        public void Load_DGV_Bill()
        {
            List<Bill> Billlist = BillBelongToAdminDAO.Instance.ShowBill();
            dgvBill.DataSource = Billlist;
        }
        public void Load_DGV_DishCategory()
        {
            List<DishCategory> dishCategories = DishCategoryBelongToAdminDAO.Instance.ShowDishCategory();
            dgvDishCategory.DataSource = dishCategories;
        }
        public void Load_DGV_Dish()
        {
            List<Dish> dishes = DishBelongToAdminDAO.Instance.ShowDish();
            dgvDish.DataSource = dishes;
        }
        public void Load_DGV_TableNumber()
        {
            List<TableNumber> tableNumbers = TableNumberBelongToAdminDAO.Instance.ShowTableNumber();
            dgvTables.DataSource = tableNumbers;
        }
        public void EditAccount(string username, string displayname, string password)
        {
            if (AccountBelongToAdminDAO.Instance.EditAccount(username, displayname, password))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_Account();
        }
        public void DeleteAccount(string username)
        {
            if (AccountBelongToAdminDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_Account();
        }
        public void Insert_DishCategory(string name)
        {
            if (DishCategoryBelongToAdminDAO.Instance.InsertDishCategory(name))
            {
                MessageBox.Show("Thêm loại món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thêm loại món thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_DishCategory();
        }
        public void Edit_DishCategory(int id, string name)
        {
            if (DishCategoryBelongToAdminDAO.Instance.EditDishCategory(id ,name))
            {
                MessageBox.Show("Cập nhật loại món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cập nhật loại món thất bại!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_DishCategory();
        }
        public void Delete_DishCategory(int id)
        {
            if (DishCategoryBelongToAdminDAO.Instance.DeleteDishcategory(id))
            {
                MessageBox.Show("Xóa loại món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa loại món thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_DishCategory();
        }
        public void Insert_Dish(string name, int IdDishCategory, double prices)
        {
            if (DishBelongToAdminDAO.Instance.InsertDish(name, IdDishCategory, prices))
            {
                MessageBox.Show("Thêm món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thêm món thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_Dish();
        }
        public void Edit_Dish(int id, string name, int IdDishCategory, double prices)
        {
            if (DishBelongToAdminDAO.Instance.EditDish(id, name, IdDishCategory, prices))
            {
                MessageBox.Show("Cập nhật món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cập nhật món thất bại!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_Dish();
        }
        public void Delete_Dish(int id)
        {
            if (DishBelongToAdminDAO.Instance.DeleteDish(id))
            {
                MessageBox.Show("Xóa món thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa món thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_Dish();
        }
        public List<Dish> Search_Dish(string name)
        {
            List<Dish> dish = DishBelongToAdminDAO.Instance.SearchDish(name);
            return dish;
        }
        public void Insert_TableNumber(string name)
        {
            if (TableNumberBelongToAdminDAO.Instance.InsertTableNumber(name))
            {
                MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_TableNumber();
        }
        public void Edit_TableNumber(int id, string name)
        {
            if (TableNumberBelongToAdminDAO.Instance.EditTableNumber(id, name))
            {
                MessageBox.Show("Cập nhật bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_TableNumber();
        }
        public void Delete_TableNumber(int id)
        {
            if (TableNumberBelongToAdminDAO.Instance.DeleteTableNumber(id))
            {
                MessageBox.Show("Xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Load_DGV_TableNumber();
        }
        #endregion


    }
}
