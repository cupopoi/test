using CoffeShopManagement.DAO;
using CoffeShopManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region EVENTS
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (frmHomeCoffeeShopManagement frmHome = new frmHomeCoffeeShopManagement())
            {
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                if (CheckLoginAccount(Username, Password))
                {
                    this.Hide(); //Hide form login.
                    frmHome.ShowDialog(); //Completed this form before doing next action.
                    this.Show(); //Show form login.
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi phần mềm hay không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        //Hide password
        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        //Show password
        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        #endregion

        #region METHODS
        bool CheckLoginAccount(string Username, string Password)
        {
            return AccountLoginDAO.Instance.CheckLogin(Username, Password);
        }
        #endregion
    }
}
