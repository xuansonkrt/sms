namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NienKhoa")]
    public partial class NienKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NienKhoa()
        {
            Lops = new HashSet<Lop>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string IDView { get; set; }

        [StringLength(500)]
        public string Ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lop> Lops { get; set; }
    }
}
