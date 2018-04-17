namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_SDS
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string GDSCOXZ { get; set; }

        [StringLength(8)]
        public string GDSHCXZ { get; set; }

        [StringLength(8)]
        public string DSCOXZ { get; set; }

        [StringLength(8)]
        public string DSHCXZ { get; set; }

        [StringLength(8)]
        public string GLKQXSSX { get; set; }

        [StringLength(8)]
        public string GLKQXSXX { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
