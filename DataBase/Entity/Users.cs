namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Users")]
    public partial class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserName { get; set; }

        [Required]
        [StringLength(64)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string UserPass { get; set; }
        [Required]
        public string UserPriority { get; set; }

        public byte[] UsersPicture { get; set; }
    }
}
