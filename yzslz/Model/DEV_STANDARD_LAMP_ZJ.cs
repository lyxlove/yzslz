namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_STANDARD_LAMP_ZJ
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string SEARCH_CONDITION { get; set; }

        [StringLength(50)]
        public string ZXMC { get; set; }

        [StringLength(8)]
        public string YDZDGGQXZ { get; set; }

        [StringLength(8)]
        public string EDZDGGQXZ { get; set; }

        [StringLength(8)]
        public string SDZDGGQXZ { get; set; }

        [StringLength(8)]
        public string YGCZPYXZXX { get; set; }

        [StringLength(8)]
        public string YGCZPYXZSX { get; set; }

        [StringLength(8)]
        public string JGCZPYXZXX { get; set; }

        [StringLength(8)]
        public string JGCZPYXZSX { get; set; }

        [StringLength(8)]
        public string YGZDZPXZ { get; set; }

        [StringLength(8)]
        public string YGZDYPXZ { get; set; }

        [StringLength(8)]
        public string YGYDZPXZ { get; set; }

        [StringLength(8)]
        public string YGYDYPXZ { get; set; }

        [StringLength(8)]
        public string JGZDZPXZ { get; set; }

        [StringLength(8)]
        public string JGZDYPXZ { get; set; }

        [StringLength(8)]
        public string JGYDZPXZ { get; set; }

        [StringLength(8)]
        public string JGYDYPXZ { get; set; }

        [StringLength(8)]
        public string ZGQXZ { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(50)]
        public string AREA_NAME { get; set; }

        public int? UTYPE { get; set; }
    }
}
