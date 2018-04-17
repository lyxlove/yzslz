namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSPECTION_LINE_STYLE
    {
        public int ID { get; set; }

        public int? LINE_ID { get; set; }

        public int? WAITE_LINEID { get; set; }

        public int? ISXNLINE { get; set; }

        [StringLength(100)]
        public string ALLOW_DD_LINE { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }
    }
}
