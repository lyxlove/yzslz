namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_DPCG
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string NJGKSDSD { get; set; }

        [StringLength(8)]
        public string NJGKXZ { get; set; }

        [StringLength(8)]
        public string GLGKSDSD { get; set; }

        [StringLength(8)]
        public string GLGKXZ { get; set; }

        [StringLength(8)]
        public string HXJLXZ { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
