namespace WpfExampleTimur343.DataBase.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("TovarLevelWinter")]
    public partial class TovarLevelWinter
    {
        [Key]
        public string TovarLevelWinterName { get; set; }

        public int TovarLevelWinterCount { get; set; }
    }
}
