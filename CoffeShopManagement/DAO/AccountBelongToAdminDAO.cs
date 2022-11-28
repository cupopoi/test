    using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeShopManagement.DAO
{
    public class AccountBelongToAdminDAO
    {
        private static AccountBelongToAdminDAO instance;

        public static AccountBelongToAdminDAO Instance
        {
            get
            {
                if(instance == null) 
                    instance = new AccountBelongToAdminDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private AccountBelongToAdminDAO() { }

        public List<Account> ShowAccount()
        {
            List<Account> list = new List<Account>();
            string query = "SHOW_ACCOUNT";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow row in data.Rows)
            {
                Account account = new Account(row);
                list.Add(account);
            }
            return list;
        }

        public bool InsertAccount(string Username, string Displayname, string Password)
        {
            string query = $"INSERT_ACCOUNT @Username = N'{Username}', @DisplayName = N'{Displayname}', @PassWord = N'{Password}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool EditAccount(string username, string displayname, string password)
        {
            string query = $"EDIT_ACCOUNT @UserName = N'{username}', @DisplayName = N'{displayname}', @Password = N'{password}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(string username)
        {
            string query = $"DELETE_ACCOUNT @UserName = N'{username}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
