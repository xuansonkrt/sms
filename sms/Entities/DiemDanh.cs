namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemDanh")]
    public partial class DiemDanh
    {
        public int ID { get; set; }

        public int SinhVienID { get; set; }

        public int? LopHocPhanID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public int? TinhTrang { get; set; }

        public virtual LopHocPhan LopHocPhan { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
