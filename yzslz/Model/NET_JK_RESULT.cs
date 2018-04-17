namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NET_JK_RESULT
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string HPHM { get; set; }

        [StringLength(10)]
        public string JKID { get; set; }

        [StringLength(1)]
        public string IsSuc { get; set; }

        public DateTime? LastUpdateTime { get; set; }
    }
}
