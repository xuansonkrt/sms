namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HocPhan_HocKy
    {
        public int ID { get; set; }

        public int HocKyID { get; set; }

        public int HocPhanID { get; set; }

        public virtual HocKy HocKy { get; set; }

        public virtual HocPhan HocPhan { get; set; }
    }
}
