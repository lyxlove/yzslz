namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CASH_CAHARE_TOTALSTD
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FIELD_NAME1 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME2 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME3 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME4 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME5 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME6 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME7 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME8 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME9 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME10 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME11 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME12 { get; set; }

        [StringLength(50)]
        public string FIELD_NAME13 { get; set; }
    }
}
