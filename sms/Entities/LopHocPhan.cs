namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHocPhan")]
    public partial class LopHocPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHocPhan()
        {
            DiemDanhs = new HashSet<DiemDanh>();
            SV_LHP = new HashSet<SV_LHP>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string TenLopHocPhan { get; set; }

        [StringLength(100)]
        public string IDView { get; set; }

        public int? HocPhanID { get; set; }

        public int? HocKyID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemDanh> DiemDanhs { get; set; }

        public virtual HocKy HocKy { get; set; }

        public virtual HocPhan HocPhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SV_LHP> SV_LHP { get; set; }
    }
}
