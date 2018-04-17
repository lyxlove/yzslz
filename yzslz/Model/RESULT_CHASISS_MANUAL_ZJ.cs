namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_CHASISS_MANUAL_ZJ
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

        [StringLength(120)]
        public string LTHWSD { get; set; }

        [StringLength(12)]
        public string CSYJSS { get; set; }

        [StringLength(12)]
        public string CSBMTZ { get; set; }

        [StringLength(12)]
        public string MCBL { get; set; }

        [StringLength(100)]
        public string DCBWGDC { get; set; }

        [StringLength(50)]
        public string ZXPZDZYZDL { get; set; }

        [StringLength(50)]
        public string CXLBGD { get; set; }

        [StringLength(5)]
        public string ZXPZDZYZDL_PD { get; set; }

        [StringLength(5)]
        public string LTHWSD_PD { get; set; }

        [StringLength(5)]
        public string MCBL_PD { get; set; }

        [StringLength(5)]
        public string CSYJSSL_PD { get; set; }

        [StringLength(5)]
        public string DCBWGDC_PD { get; set; }

        [StringLength(5)]
        public string CSBMTZ_PD { get; set; }

        [StringLength(1200)]
        public string RGJYBJCX { get; set; }

        [StringLength(1200)]
        public string DGJYBJCX { get; set; }

        [StringLength(2000)]
        public string WYXRD_MS { get; set; }

        [StringLength(2000)]
        public string ZCGZZD_MS { get; set; }

        [StringLength(2000)]
        public string WGJC_MS { get; set; }

        [StringLength(2000)]
        public string DPBJ_MS { get; set; }

        [StringLength(2000)]
        public string YXJC_MS { get; set; }

        [StringLength(2000)]
        public string HCPD_MS { get; set; }

        [StringLength(5)]
        public string PSZDQ_PD { get; set; }

        [StringLength(5)]
        public string ZDJXZDTZZZ_PD { get; set; }

        [StringLength(5)]
        public string YSKQGZHYSFLZZ_PD { get; set; }

        [StringLength(5)]
        public string XSGNXXZZ_PD { get; set; }

        [StringLength(5)]
        public string FDJCNZDMHZZ_PD { get; set; }

        [StringLength(5)]
        public string HSQHQTFZZZ_PD { get; set; }

        [StringLength(5)]
        public string ZDFBSZZ_PD { get; set; }

        [StringLength(5)]
        public string ZWXLT_PD { get; set; }

        [StringLength(5)]
        public string AQD_PD { get; set; }

        [StringLength(5)]
        public string WXDWXTCZZD_PD { get; set; }

        [StringLength(5)]
        public string YXJC_PD { get; set; }

        [StringLength(5)]
        public string HCPD_PD { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
