namespace CoffeShopManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(1000)]
        public string Password { get; set; }

        public Account(string userName, string displayName, string passWord)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = passWord;
        }

        public Account(DataRow row)
        {
            this.UserName = (string)row["UserName"];
            this.DisplayName = (string)row["DisplayName"];
            this.Password = (string)row["Password"];
        }
    }
}
