namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_KERBMASS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string ZBZLJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(4)]
        public string SCZBZL1 { get; set; }

        [StringLength(8)]
        public string SCZBZL2 { get; set; }

        [StringLength(8)]
        public string SCZBZL3 { get; set; }

        [StringLength(8)]
        public string SCZBZL4 { get; set; }

        [StringLength(8)]
        public string SCZBZL5 { get; set; }

        [StringLength(8)]
        public string SCZBZL6 { get; set; }

        [StringLength(8)]
        public string SCZBZL { get; set; }

        [StringLength(8)]
        public string SCZBZLWC { get; set; }

        [StringLength(8)]
        public string ZBZL_PD { get; set; }

        [StringLength(50)]
        public string ZBZLXZXX { get; set; }

        [StringLength(50)]
        public string ZBZLXZSX { get; set; }

        public int? CYDJCFS { get; set; }

        [StringLength(8)]
        public string ZBZLJDWC { get; set; }

        [StringLength(8)]
        public string ZBZLXDWC { get; set; }
    }
}
