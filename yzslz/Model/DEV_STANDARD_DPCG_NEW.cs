namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_DPCG_NEW
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string GLBZXS_CLA1 { get; set; }

        [StringLength(8)]
        public string GLBZXS_CLA2 { get; set; }

        [StringLength(8)]
        public string YHSD { get; set; }

        [StringLength(8)]
        public string YHXZ { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
