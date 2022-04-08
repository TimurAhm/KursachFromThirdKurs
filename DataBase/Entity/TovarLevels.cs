namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ISPr22-43_AhmadulinTI_EntityFramework_Kursovaya.TovarLevels")]
    public partial class TovarLevels
    {
        [Key]
        public string TovarName { get; set; }

        public int TovarCount { get; set; }
    }
}
