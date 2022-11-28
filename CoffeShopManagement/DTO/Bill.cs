namespace CoffeShopManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Bill()
        //{
        //    BillInfoes = new HashSet<BillInfo>();
        //}

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCheckIn { get; set; }

        public int PayStatus { get; set; }

        public int? IdTableNumber { get; set; }


        //public virtual TableNumber TableNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BillInfo> BillInfoes { get; set; }

        public Bill(int id, DateTime? dateCheckIn, int? idTableNumber)
        {
            Id = id;
            DateCheckIn = dateCheckIn;
            IdTableNumber = idTableNumber;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            this.PayStatus = (int)row["PayStatus"];
            this.IdTableNumber = (int)row["IdTableNumber"];
        }
    }
}
