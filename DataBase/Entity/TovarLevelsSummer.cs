namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TovarLevels")]
    public partial class TovarLevelsSummer
    {
        [Key]
        public string TovarNameLvl { get; set; }

        public int TovarCountLvl { get; set; }
    }
}
