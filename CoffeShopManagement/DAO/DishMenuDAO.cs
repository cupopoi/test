using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DAO
{
    public class DishMenuDAO
    {
        private static DishMenuDAO instance;

        public static DishMenuDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new DishMenuDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private DishMenuDAO() { }

        public List<DishMenu> ShowDishMenu_ByIdTable(int id)
        {
            List<DishMenu> list = new List<DishMenu>();
            string query = $"DISH_MENU @IdTableNumber = {id}";


            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                DishMenu menu = new DishMenu(row);
                list.Add(menu);
            }

            return list;
        }
    }
}
