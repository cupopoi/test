using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagement.DAO
{
    public class DishCategoryBelongToAdminDAO
    {
        private static DishCategoryBelongToAdminDAO instance;

        public static DishCategoryBelongToAdminDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new DishCategoryBelongToAdminDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private DishCategoryBelongToAdminDAO() { }

        public List<DishCategory> ShowDishCategory()
        {
            List<DishCategory> list = new List<DishCategory>();
            string query = "SHOW_DISHCATEGORY";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow dr in data.Rows)
            {
                DishCategory dishCategory = new DishCategory(dr);
                list.Add(dishCategory);
            }

            return list;
        }

        public bool InsertDishCategory(string name)
        {
            string query = $"INSERT_DISHCATEGORY @Name = N'{name}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool EditDishCategory(int id, string name)
        {
            string query = $"EDIT_DISHCATEGORY @Id = {id}, @Name = N'{name}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDishcategory(int id)
        {
            string query = $"DELETE_DISHCATEGORY @Id = N'{id}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
