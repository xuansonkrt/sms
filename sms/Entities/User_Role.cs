namespace sms.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Role
    {
        public int? UserID { get; set; }

        public int? RoleID { get; set; }

        public int ID { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
    }
}
