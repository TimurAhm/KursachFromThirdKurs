namespace WpfExampleTimur343.DataBase.Entity
{
    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
using System.Text;
using System.Threading.Tasks;

    [Table("UserPriorityType")]
    public partial class UserPriorityType
    {
        [Key]
        public string UsersPriorityType { get; set; }
    }
}
