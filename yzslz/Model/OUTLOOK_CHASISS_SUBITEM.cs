namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OUTLOOK_CHASISS_SUBITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? MID { get; set; }

        [StringLength(200)]
        public string MNAME { get; set; }

        public int? SUBID { get; set; }

        [StringLength(200)]
        public string SNAME { get; set; }

        [StringLength(10)]
        public string JUDGECLASS { get; set; }

        [StringLength(4)]
        public string APPLYCLASS { get; set; }

        public int? MITEMID { get; set; }

        [StringLength(50)]
        public string MITEMNAME { get; set; }

        public int? IsItemValid { get; set; }

        public int? JSDJPDNUM { get; set; }

        public int? JSDJPDType { get; set; }
    }
}
