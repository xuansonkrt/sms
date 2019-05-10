namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SV_LHP
    {
        public int ID { get; set; }

        public int? SinhVienID { get; set; }

        public int? LopHocPhanID { get; set; }

        public decimal? Diem1 { get; set; }

        public decimal? Diem2 { get; set; }

        public decimal? Diem3 { get; set; }

        public virtual LopHocPhan LopHocPhan { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
