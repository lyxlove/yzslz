namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSPECTION_STATION_INFO
    {
        public int ID { get; set; }

        [StringLength(80)]
        public string STATION_NAME { get; set; }

        [StringLength(50)]
        public string STATION_NO { get; set; }

        [StringLength(80)]
        public string STATION_ADDRESS { get; set; }

        [StringLength(32)]
        public string LICENSE_NO { get; set; }

        [StringLength(40)]
        public string STATION_TEL { get; set; }

        [StringLength(12)]
        public string STATION_POSTALCODE { get; set; }

        [StringLength(30)]
        public string MANAGERS_NAME { get; set; }

        [StringLength(20)]
        public string MANAGERS_ID_NO { get; set; }

        [StringLength(30)]
        public string MANAGERS_TEL { get; set; }

        [StringLength(30)]
        public string DEV_MANAGERS_NAME { get; set; }

        [StringLength(20)]
        public string DEV_MANAGERS_ID_NO { get; set; }

        [StringLength(30)]
        public string DEV_MANAGERS_TEL { get; set; }

        [StringLength(30)]
        public string LICENSE_SDATE { get; set; }

        [StringLength(30)]
        public string LICENSE_EDATE { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }
    }
}
