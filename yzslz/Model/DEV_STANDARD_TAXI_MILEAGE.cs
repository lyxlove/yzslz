namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_TAXI_MILEAGE
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string LCWCXX { get; set; }

        [StringLength(8)]
        public string LCWCSX { get; set; }

        [StringLength(8)]
        public string JSWCXX { get; set; }

        [StringLength(8)]
        public string JSWCSX { get; set; }

        [StringLength(8)]
        public string IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
