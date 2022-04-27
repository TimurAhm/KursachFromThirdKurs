namespace WpfExampleTimur343.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.CompilerServices;

    [Table("Tovars")]
    public partial class Tovars: INotifyPropertyChanged
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
        public byte[] TovarImg;
        public byte[] TovarPicture {
            get { return TovarImg; }
            set
            {
                TovarImg = value;
                PropChange();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void PropChange([CallerMemberName] string PropName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropName));
        }
    }
}
