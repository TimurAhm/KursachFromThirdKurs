namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ISPr22-43_AhmadulinTI_EntityFramework_Kursovaya.IngridientLevels")]
    public partial class IngridientLevels
    {
        [Key]
        public string IngridientName { get; set; }

        public int IngridientCount { get; set; }
    }
}
