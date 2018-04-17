namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_SIDESLIP
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string QQCHXZXX { get; set; }

        [StringLength(8)]
        public string QQCHXZSX { get; set; }

        [StringLength(8)]
        public string HQCHXZXX { get; set; }

        [StringLength(8)]
        public string HQCHXZSX { get; set; }

        [StringLength(8)]
        public string TGSDXX { get; set; }

        [StringLength(8)]
        public string TGSDSX { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
