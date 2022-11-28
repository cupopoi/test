using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DAO
{
    public class TableNumberBelongToAdminDAO
    {
        private static TableNumberBelongToAdminDAO instance;

        public static TableNumberBelongToAdminDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new TableNumberBelongToAdminDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private TableNumberBelongToAdminDAO() { }

        public List<TableNumber> ShowTableNumber()
        {
            string query = "SHOW_TABLENUMBER";
            List<TableNumber> list = new List<TableNumber>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TableNumber tableNumber = new TableNumber(row);
                list.Add(tableNumber);
            }
            return list;
        }

        public bool InsertTableNumber(string name)
        {
            string query = $"INSERT_TABLENUMBER @Name = N'{name}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool EditTableNumber(int id, string name)
        {
            string query = $"EDIT_TABLENUMBER @Id = {id}, @Name = N'{name}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTableNumber(int id)
        {
            string query = $"DELETE_TABLENUMBER @Id = N'{id}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
