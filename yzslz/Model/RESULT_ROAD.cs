namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_ROAD
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string LSJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(10)]
        public string LSZDCSD { get; set; }

        [StringLength(10)]
        public string LSZDPPQK { get; set; }

        [StringLength(10)]
        public string LSZDJL { get; set; }

        [StringLength(10)]
        public string MFDD { get; set; }

        [StringLength(10)]
        public string LSZDXTSJ { get; set; }

        [StringLength(4)]
        public string LSZD_PD { get; set; }

        public int? LSYLX { get; set; }

        [StringLength(100)]
        public string LSMS { get; set; }

        [StringLength(20)]
        public string LSJYY { get; set; }

        [StringLength(12)]
        public string LSZCPD { get; set; }

        [StringLength(20)]
        public string LSZCJL { get; set; }

        [StringLength(4)]
        public string LSZC_PD { get; set; }

        [StringLength(20)]
        public string LSZDSCDK { get; set; }

        [StringLength(10)]
        public string LSZDJLXZ { get; set; }

        [StringLength(10)]
        public string MFDDXZ { get; set; }

        [StringLength(4)]
        public string MFDD_PD { get; set; }

        [StringLength(4)]
        public string LSZDJL_PD { get; set; }

        public int? BZJSCLLX { get; set; }

        [StringLength(20)]
        public string LSXTSJXZ { get; set; }

        public int? ZDLX { get; set; }

        [StringLength(4)]
        public string LSZDXTSJ_PD { get; set; }

        [StringLength(8)]
        public string ZXTCSJ { get; set; }

        [StringLength(8)]
        public string FXTCSJ { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
