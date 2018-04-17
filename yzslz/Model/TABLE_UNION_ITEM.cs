namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TABLE_UNION_ITEM
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TABLE_NAME { get; set; }

        [StringLength(50)]
        public string TABLE_CONST { get; set; }

        [StringLength(50)]
        public string TABLE_FIELD { get; set; }

        [StringLength(50)]
        public string FIELD_ITEM { get; set; }

        [StringLength(50)]
        public string FIELD_ITEM_MT { get; set; }

        [StringLength(50)]
        public string FIELD_NAME { get; set; }

        public int? IS_VALID { get; set; }

        public int? JLBS { get; set; }

        public int? JLBS_MT { get; set; }
    }
}
