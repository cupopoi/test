namespace CoffeShopManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("DishCategory")]
    public partial class DishCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DishCategory()
        //{
        //    Dishes = new HashSet<Dish>();
        //}

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Dish> Dishes { get; set; }

        public DishCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public DishCategory(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = (string)row["Name"];
        }
    }
}
