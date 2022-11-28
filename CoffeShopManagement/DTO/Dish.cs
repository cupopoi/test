namespace CoffeShopManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Dish")]
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Dish()
        //{
        //    BillInfoes = new HashSet<BillInfo>();
        //}

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? IdDishCategory { get; set; }

        public double Prices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BillInfo> BillInfoes { get; set; }

        //public virtual DishCategory DishCategory { get; set; }

        public Dish(int id, string name, int? idDishCategory, double prices)
        {
            Id = id;
            Name = name;
            IdDishCategory = idDishCategory;
            Prices = prices;
        }

        public Dish(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = (string)row["Name"];
            this.IdDishCategory = (int)row["IdDishCategory"];
            this.Prices = (double)row["Prices"];
        }
    }
}
