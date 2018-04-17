namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_SUSPENSION
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string QZXSLVXZXX { get; set; }

        [StringLength(8)]
        public string QZXSLVXZSX { get; set; }

        [StringLength(8)]
        public string QZXSLVCXZXX { get; set; }

        [StringLength(8)]
        public string QZXSLVCXZSX { get; set; }

        [StringLength(8)]
        public string HZXSLVXZXX { get; set; }

        [StringLength(8)]
        public string HZXSLVXZSX { get; set; }

        [StringLength(8)]
        public string HZXSLVCXZXX { get; set; }

        [StringLength(8)]
        public string HZXSLVCXZSX { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
