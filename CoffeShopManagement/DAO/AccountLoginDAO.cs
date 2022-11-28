using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DAO
{
    public class AccountLoginDAO
    {
        private static AccountLoginDAO instance;

        public static AccountLoginDAO Instance
        {
            get
            {
                if (instance == null) AccountLoginDAO.instance = new AccountLoginDAO();
                return instance;
            }
            set
            {
                AccountLoginDAO.instance = value;
            }    
        }

        private AccountLoginDAO() { }

        //Check Login
        public bool CheckLogin(string Username, string Password)
        {
            string query = "Account_CheckLogin @Username , @Password";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { Username, Password });

            return result.Rows.Count > 0; //true
        }
    }
}
