using CoffeShopManagement.DAO;
using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagement.GUI
{
    public partial class frmDishMenu : Form
    {
        public static frmDishMenu instacne;
        public Label lbl;
        public ListView lv;
        public int idTableNumber_FromfrmHome;

        //private frmDishMenu() { }
        public frmDishMenu()
        {
            InitializeComponent();
            instacne = this;
            lbl = lblTableNumberId;
            lv = lvBill_andBillInfo;
            LoadDishCategory();
        }

        #region METHODS
        public void ShowBill_andBillInfo(int id)
        {
            lvBill_andBillInfo.Items.Clear();
            List<DishMenu> listDishMenu = DishMenuDAO.Instance.ShowDishMenu_ByIdTable(id);
            double? total = 0;
            foreach (DishMenu item in listDishMenu)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Prices.ToString());
                lvItem.SubItems.Add(item.TotalPrices.ToString());
                total += item.TotalPrices;
                lvBill_andBillInfo.Items.Add(lvItem);
            }
            txtTotalMoney.Text = total.ToString() + "VNĐ";
        }
        public void LoadDishCategory()
        {
            List<DishCategory> list = DishCategoryBelongToAdminDAO.Instance.ShowDishCategory();
            cmbDishCategory.DataSource = list;
            cmbDishCategory.DisplayMember = "Name";
        }
        public void LoadDish_ByIdDishCategory(int id)
        {
            List<Dish> list = DishBelongToAdminDAO.Instance.ShowDish_BydIdDishCategory(id);
            cmbDish.DataSource = list;
            cmbDish.DisplayMember = "Name";
        }
        #endregion

        #region EVENTS
        private void cmbDishCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cmb = sender as ComboBox;
            if (cmb.SelectedItem == null)
                return;
            DishCategory selected = cmb.SelectedItem as DishCategory;
            id = selected.Id;
            LoadDish_ByIdDishCategory(id);
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            //TableNumber table = lvBill_andBillInfo.Tag as TableNumber;
            int id = int.Parse(lvBill_andBillInfo.Tag.ToString());

            int IdBill = BillBelongToAdminDAO.Instance.ShowBillByTableId(id);
            int IdDish = (cmbDish.SelectedItem as Dish).Id;
            int Count = (int)numericUpDown_Count.Value;
            
            //Bill not exist.
            if(IdBill == -1)
            {
                BillBelongToAdminDAO.Instance.InsertBill(id);
                BillInfoBelongToAdminDAO.Instance.InsertBillInfo(BillBelongToAdminDAO.Instance.ShowLastIdBill(), IdDish, Count);
            }
            //Bill existed.
            else
            {
                BillInfoBelongToAdminDAO.Instance.InsertBillInfo(IdBill, IdDish, Count);
            }

            ShowBill_andBillInfo(id);
            frmHomeCoffeeShopManagement frm = new frmHomeCoffeeShopManagement();
            frm.LoadTable();
        }


        #endregion

        private void btnPay_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvBill_andBillInfo.Tag.ToString());
                List<TableNumber> table = TableNumberBelongToAdminDAO.Instance.ShowTableNumber();
                foreach(TableNumber t in table)
                {
                    
                    int IdBill = BillBelongToAdminDAO.Instance.ShowBillByTableId(t.Id);
                    if (IdBill == -1)
                    {
                        BillBelongToAdminDAO.Instance.CheckBill(id);
                        ShowBill_andBillInfo(t.Id);
                    BillInfoBelongToAdminDAO.Instance.deletebillinfo(t.Id);
                    BillBelongToAdminDAO.Instance.deletebill(t.Id);
                    BillInfoBelongToAdminDAO.Instance.deletebillinfo(id);
                    BillBelongToAdminDAO.Instance.deletebill(id);
                }
                }
            DialogResult result = MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmHomeCoffeeShopManagement frm = new frmHomeCoffeeShopManagement();
            frm.LoadTable();
                
            this.Hide();
            //frm.ShowDialog();
           
        }
    }
}
