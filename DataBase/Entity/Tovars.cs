namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ISPr22-43_AhmadulinTI_EntityFramework_Kursovaya.Tovars")]
    public partial class Tovars
    {
        [Key]
        public int TovarId { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string TovarName { get; set; }

        public int TovarCount { get; set; }

        public DateTime TovarCreateDate { get; set; }

        public DateTime TovarExpirationDate { get; set; }

        public decimal TovarPrice { get; set; }

        [Column(TypeName = "blob")]
        public byte[] TovarPicture { get; set; }
    }
}
