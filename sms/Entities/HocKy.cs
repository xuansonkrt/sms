namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocKy")]
    public partial class HocKy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocKy()
        {
            HocPhan_HocKy = new HashSet<HocPhan_HocKy>();
            LopHocPhans = new HashSet<LopHocPhan>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string TenHocKy { get; set; }

        public int? Nam1 { get; set; }

        public int? Nam2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocPhan_HocKy> HocPhan_HocKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
