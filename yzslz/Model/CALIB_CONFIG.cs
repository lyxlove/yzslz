namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CALIB_CONFIG
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string DevID { get; set; }

        [StringLength(50)]
        public string DevName { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        [StringLength(50)]
        public string FieldConst { get; set; }

        [StringLength(50)]
        public string BDZQ { get; set; }

        [StringLength(50)]
        public string XDWC { get; set; }

        [StringLength(50)]
        public string JDWC { get; set; }

        [StringLength(10)]
        public string JCXH { get; set; }
    }
}
