namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_BRAKE
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string QZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string HZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string QZZDLVBZ { get; set; }

        [StringLength(8)]
        public string HZZDLVBZ { get; set; }

        [StringLength(8)]
        public string JZZDLVBZ { get; set; }

        [StringLength(8)]
        public string PBHZZDLVBZ { get; set; }

        [StringLength(8)]
        public string QZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string HZBPHLVBZDY60 { get; set; }

        [StringLength(8)]
        public string HZBPHLVBZXY60 { get; set; }

        [StringLength(8)]
        public string SZDLVBZ { get; set; }

        [StringLength(8)]
        public string ZCZDLVBZ { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
