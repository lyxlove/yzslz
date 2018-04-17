namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSPECTION_LINE_INFO
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string LINE_NAME { get; set; }

        public int? LINE_ID { get; set; }

        [StringLength(32)]
        public string JCXHMS { get; set; }

        [StringLength(30)]
        public string LINE_TYPE { get; set; }

        [StringLength(30)]
        public string LINE_IP { get; set; }

        public int? STA_ID { get; set; }

        [StringLength(80)]
        public string STA_NAME { get; set; }

        [StringLength(30)]
        public string STA_IP { get; set; }

        [StringLength(10)]
        public string STA_PORT { get; set; }

        [StringLength(50)]
        public string STA_DEVID { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string MARKID { get; set; }
    }
}
