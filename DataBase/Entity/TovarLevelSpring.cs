namespace WpfExampleTimur343.DataBase.Entity
{

using System;
using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
using System.Text;
using System.Threading.Tasks;

    [Table("TovarLevelSpring")]
    public partial class TovarLevelSpring
    {
        [Key]
        public string TovarLevelSpringName { get; set; }

        public int TovarLevelSpringCount { get; set; }
    }
}
