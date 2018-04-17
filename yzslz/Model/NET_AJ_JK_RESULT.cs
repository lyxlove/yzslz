namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NET_AJ_JK_RESULT
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string JYCS { get; set; }

        [StringLength(50)]
        public string LWLSH { get; set; }

        [StringLength(50)]
        public string LWType { get; set; }

        [StringLength(50)]
        public string JKName { get; set; }

        [StringLength(100)]
        public string JYXM { get; set; }

        [Column(TypeName = "text")]
        public string SendInfo { get; set; }

        [Column(TypeName = "text")]
        public string RevcInfo { get; set; }

        [StringLength(1)]
        public string IsSuc { get; set; }

        public DateTime? LogTime { get; set; }
    }
}
