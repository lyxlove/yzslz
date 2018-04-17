namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_CHASISS_MANUAL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string DPBJJCCS { get; set; }

        [StringLength(4)]
        public string DTDPJCCS { get; set; }

        [StringLength(4)]
        public string WGJCJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(1200)]
        public string RGJYBHGX { get; set; }

        [StringLength(4)]
        public string WGJC_PD { get; set; }

        [StringLength(20)]
        public string WGJCCZY { get; set; }

        [StringLength(4)]
        public string WYXRD_PD { get; set; }

        [StringLength(20)]
        public string WYXRDJYY { get; set; }

        [StringLength(4)]
        public string ZCGZZD_PD { get; set; }

        [StringLength(20)]
        public string ZCGZZJYY { get; set; }

        [StringLength(4)]
        public string DPBJ_PD { get; set; }

        [StringLength(20)]
        public string DPBJCZY { get; set; }

        [StringLength(4)]
        public string DTDP_PD { get; set; }

        [StringLength(20)]
        public string DTDPCZY { get; set; }

        [StringLength(4)]
        public string CLTZCSJC_PD { get; set; }

        [StringLength(20)]
        public string CLTZCSJCJYY { get; set; }

        [StringLength(4)]
        public string AQZZJY_PD { get; set; }

        [StringLength(20)]
        public string AQZZJYY { get; set; }

        [StringLength(4)]
        public string LWCX_PD { get; set; }

        [StringLength(20)]
        public string LWCXJYY { get; set; }

        [StringLength(1200)]
        public string DGJYBHGX { get; set; }

        [StringLength(1200)]
        public string RGJYBJCX { get; set; }

        [StringLength(1200)]
        public string WYXRD_MS { get; set; }

        [StringLength(1200)]
        public string CLTZCSJC_MS { get; set; }

        [StringLength(1200)]
        public string WGJC_MS { get; set; }

        [StringLength(1200)]
        public string AQZZJY_MS { get; set; }

        [StringLength(1200)]
        public string LWCX_MS { get; set; }

        [StringLength(1200)]
        public string DTDP_MS { get; set; }

        [StringLength(1200)]
        public string DPBJ_MS { get; set; }

        [StringLength(255)]
        public string BZ_CLWYXJC { get; set; }

        [StringLength(255)]
        public string BZ_CLTZCSJC { get; set; }

        [StringLength(255)]
        public string BZ_CLWGJC { get; set; }

        [StringLength(255)]
        public string BZ_AQZZJC { get; set; }

        [StringLength(255)]
        public string BZ_LWCX { get; set; }

        [StringLength(255)]
        public string BZ_DTDPJY { get; set; }

        [StringLength(255)]
        public string BZ_DPBJJC { get; set; }
    }
}
