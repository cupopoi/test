namespace CoffeShopManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("BillInfo")]
    public partial class BillInfo
    {
        public int Id { get; set; }

        public int? IdBill { get; set; }

        public int? IdDish { get; set; }

        public int Count { get; set; }

        //public virtual Bill Bill { get; set; }

        //public virtual Dish Dish { get; set; }

        public BillInfo(int id, int? idBill, int? idDish, int count)
        {
            Id = id;
            IdBill = idBill;
            IdDish = idDish;
            Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.IdBill = (int)row["IdBill"];
            this.IdDish = (int)row["idDish"];
            this.Count = (int)row["Count"];
        }
    }
}
