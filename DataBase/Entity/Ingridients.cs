namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingridients")]
    public partial class Ingridients
    {
        [Key]
        public int IngridientId { get; set; }

        [Required]
        [StringLength(128)]
        public string IngridientName { get; set; }

        public int IngridientCount { get; set; }

        public DateTime IngridientCreateDate { get; set; }

        public DateTime IngridientExpirationDate { get; set; }
    }
}
