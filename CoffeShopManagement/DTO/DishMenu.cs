using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagement.DTO
{
    public class DishMenu
    {
        private string name;
        private int count;
        private double prices;
        private double? totalPrices;

        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public double Prices { get => prices; set => prices = value; }
        public double? TotalPrices { get => totalPrices; set => totalPrices = value; }

        public DishMenu(string name, int count, double prices, double? totalPrices)
        {
            this.Name = name;
            this.Count = count;
            this.Prices = prices;
            this.TotalPrices = TotalPrices;
        }

        public DishMenu(DataRow row)
        {
            this.Name = (string)row["Name"];
            this.Count = (int)row["Count"];
            this.Prices = (double)row["Prices"];
            this.TotalPrices = (double?)row["TotalPrices"];
        }
    }
}
