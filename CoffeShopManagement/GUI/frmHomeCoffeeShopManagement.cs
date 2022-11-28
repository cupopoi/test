using CoffeShopManagement.DAO;
using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagement.GUI
{
    public partial class frmHomeCoffeeShopManagement : Form
    {
        public frmHomeCoffeeShopManagement()
        {
            InitializeComponent();
            LoadTable();
        }

        //Declare
        private EventHandler btntTableNumber_CLick;
        public Button btntTableNumber;

        #region EVENTS
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAmin formAdmin = new frmAmin();
            this.Hide();
            formAdmin.ShowDialog();
            this.Show();
        }

        private void BtntTableNumber_Click(object sender, EventArgs e)
        {
            frmDishMenu dishMenu = new frmDishMenu();
         
             btntTableNumber = sender as Button;
           
            frmDishMenu.instacne.lv.Tag = (sender as Button).Tag;
            frmDishMenu.instacne.lbl.Text = btntTableNumber.Text;

            //Send IdTable to listview in frmDishMenu
            List<TableNumber> list = new List<TableNumber>();
            //int TableId = Table.Id;
            int TableId = int.Parse(btntTableNumber.Text); 
    frmDishMenu.instacne.ShowBill_andBillInfo(TableId);

            

            this.Hide();
            dishMenu.ShowDialog();
            this.Show();
        }

        private void LoginInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Show();
        }

        #endregion

        #region METHODS
        public void LoadTable()
        {
          
            //get data
            List<TableNumber> tableList = TableNumberDAO.Instance.ShowTableNumber();

            foreach (TableNumber table in tableList)
            {
                btntTableNumber = new Button();
                btntTableNumber.Tag = table;
                //set layout for flow layout panel
                flpHomeCoffeeShopManagement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                flpHomeCoffeeShopManagement.AutoScroll = true;

                //set layout for button Table Number
                btntTableNumber.Width = 110;
                btntTableNumber.Height = 110;
                
                btntTableNumber.Tag = table.Id; //set tag and send to form DishMenu

                //click btnTaleNumber event
                btntTableNumber.Click += BtntTableNumber_Click;
                //btntTableNumber.Tag = table.Id;
                btntTableNumber.Text = (table.Id).ToString(); //Show text of button


                //add btn to flow layout panel
                flpHomeCoffeeShopManagement.Controls.Add(btntTableNumber);

            }
            #endregion

        }

 
    }
}
