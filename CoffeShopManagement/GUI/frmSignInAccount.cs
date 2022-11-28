using CoffeShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagement.GUI
{
    public partial class frmSignInAccount : Form
    {
        public frmSignInAccount()
        {
            InitializeComponent();
        }

        #region EVENTS
        private void btnExit_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pasword = txtPassword.Text;
            string displayname = txtDisplayname.Text;
            InsertAccount(username, displayname, pasword);
        }
        #endregion

        #region METHODS
        public void ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi đăng ký tài khoản không?", "Thông báo", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                this.Hide();
                frmAmin FormAdmin = new frmAmin();
                FormAdmin.ShowDialog();
            }
        }
        public void InsertAccount(string username, string displayname, string password)
        {
            if(AccountBelongToAdminDAO.Instance.InsertAccount(username, displayname, password))
            {
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                frmAmin formAdmin = new frmAmin();
                formAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
