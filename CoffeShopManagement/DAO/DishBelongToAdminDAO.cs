using CoffeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DAO
{
    public class DishBelongToAdminDAO
    {
        private static DishBelongToAdminDAO instance;

        public static DishBelongToAdminDAO Instance
        {
            get
            {
                if(instance == null)
                    instance = new DishBelongToAdminDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private DishBelongToAdminDAO() { }

        public List<Dish> ShowDish()
        {
            List<Dish> list = new List<Dish>();
            string query = "SHOW_DISH";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                Dish dish = new Dish(dr);
                list.Add(dish);
            }
            return list;
        }
        public bool InsertDish(string name, int IdDishCategory, double prices)
        {
            string query = $"INSERT_DISH @Name = N'{name}', @IdDishCategory = {IdDishCategory}, @Prices = {prices}"; 

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool EditDish(int id, string name, int IdDishCategory, double prices)
        {
            string query = $"EDIT_DISH @Id = {id}, @Name = N'{name}', @IdDishCategory = {IdDishCategory}, @Prices = {prices}";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDish(int id)
        {
            string query = $"DELETE_DISH @Id = N'{id}'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public List<Dish> SearchDish(string name)
        {
            List<Dish> list = new List<Dish>();
            string query = $"SEARCH_DISH @Name = N'{name}'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                Dish dish = new Dish(dr);
                list.Add(dish);
            }
            return list;
        }
        public List<Dish> ShowDish_BydIdDishCategory(int id)
        {
            List<Dish> list = new List<Dish>();
            string query = $"SELECT * FROM Dish WHERE IdDishCategory = {id}";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                Dish dish = new Dish(dr);
                list.Add(dish);
            }
            return list;
        }
    }
}
