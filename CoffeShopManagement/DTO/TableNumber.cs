namespace CoffeShopManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("TableNumber")]
    public partial class TableNumber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public TableNumber()
        //{
        //    Bills = new HashSet<Bill>();
        //}

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Bill> Bills { get; set; }


        public TableNumber(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public TableNumber(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = (string)row["Name"];
        }
    }
}
