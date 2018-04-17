namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PUSH_INSPECT_NO
    {
        [Key]
        [StringLength(50)]
        public string sCode { get; set; }

        [StringLength(100)]
        public string sName { get; set; }

        [StringLength(30)]
        public string sDate { get; set; }

        [StringLength(80)]
        public string sValue { get; set; }
    }
}
