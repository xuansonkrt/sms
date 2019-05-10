namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            DiemDanhs = new HashSet<DiemDanh>();
            SV_LHP = new HashSet<SV_LHP>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        public int? LopID { get; set; }

        [MaxLength(1000)]
        public byte[] image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemDanh> DiemDanhs { get; set; }

        public virtual Lop Lop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SV_LHP> SV_LHP { get; set; }
    }
}
