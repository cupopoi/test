using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DAO
{
    public class TableNumberDAO
    {
        private static TableNumberDAO instance;

        public static TableNumberDAO Instance
        {
            get
            {
                if(instance == null) TableNumberDAO.instance = new TableNumberDAO();
                return TableNumberDAO.instance;
            }
            set
            {
                TableNumberDAO.instance = value;
            }
        }

        private TableNumberDAO() { }

        public List<TableNumber> ShowTableNumber()
        {
            string query = "SHOW_TABLENUMBER";
            List<TableNumber> list = new List<TableNumber>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow row in data.Rows)
            {
                TableNumber tableNumber = new TableNumber(row);
                list.Add(tableNumber);
            }
            return list;
        }
    }
}
