namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_SPEED
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string SDBZXX { get; set; }

        [StringLength(8)]
        public string SDBZSX { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
