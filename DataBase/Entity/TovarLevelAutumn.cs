namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("TovarLevelAutumn")]
    public partial class TovarLevelAutumn
    {
        [Key]
        public string TovarNameLvlAutumn { get; set; }

        public int TovarCountLvlAutumn { get; set; }
    }
}
