namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TABLE_UNION_CONST
    {
        public int ID { get; set; }

        [StringLength(32)]
        public string TD_TABLE_NAME { get; set; }

        [StringLength(32)]
        public string TD_FIELD_NAME { get; set; }

        [StringLength(32)]
        public string TD_FIELD_CONST { get; set; }

        [StringLength(32)]
        public string TD_FIELD_TYPE { get; set; }

        [StringLength(8)]
        public string TD_FIELD_LENTH { get; set; }

        public int? IS_SHOW { get; set; }

        [StringLength(30)]
        public string TD_TABLE_CONST { get; set; }

        [StringLength(8)]
        public string TD_PD_ITEM { get; set; }

        [StringLength(50)]
        public string TD_PD_DESCRIP { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
