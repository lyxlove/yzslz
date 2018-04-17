namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VEHICLE_DISPATCH
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        public string VEHICLEID { get; set; }

        public int? JCXH { get; set; }

        [StringLength(32)]
        public string JCXHMS { get; set; }

        public int? SCJCXH { get; set; }

        public int? JCZT_STATUS { get; set; }

        public int? GW_STATUS { get; set; }

        public int? GWBH { get; set; }

        [StringLength(20)]
        public string YJGWH { get; set; }

        public int? ZDGWBH { get; set; }

        public int? JCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(200)]
        public string JYXM { get; set; }

        [StringLength(200)]
        public string YJXM { get; set; }

        [StringLength(100)]
        public string FJXM { get; set; }

        [StringLength(50)]
        public string JCBGDBH01 { get; set; }

        [StringLength(50)]
        public string JCBGDBH02 { get; set; }

        [StringLength(30)]
        public string HPHM { get; set; }

        [StringLength(30)]
        public string HPZL { get; set; }

        [StringLength(8)]
        public string HPZLDH { get; set; }

        [StringLength(30)]
        public string GLCHPHM { get; set; }

        [StringLength(8)]
        public string CLZLDH { get; set; }

        [StringLength(30)]
        public string VIN { get; set; }

        [StringLength(38)]
        public string JYLB { get; set; }

        [StringLength(30)]
        public string JYLBDH { get; set; }

        [StringLength(30)]
        public string QDXS { get; set; }

        [StringLength(15)]
        public string QZDZ { get; set; }

        [StringLength(10)]
        public string YGGSNFKT { get; set; }

        [StringLength(30)]
        public string RLLB { get; set; }

        [StringLength(8)]
        public string ZBZL { get; set; }

        [StringLength(16)]
        public string BSXLX { get; set; }

        [StringLength(30)]
        public string CLSXSJ { get; set; }

        [StringLength(30)]
        public string CLXXSJ { get; set; }

        [StringLength(20)]
        public string DLY { get; set; }

        [StringLength(20)]
        public string YCY { get; set; }

        [StringLength(20)]
        public string WGJYY { get; set; }

        [StringLength(20)]
        public string DPJYY { get; set; }

        [StringLength(20)]
        public string DTDPJYY { get; set; }

        [StringLength(20)]
        public string LSJYY { get; set; }

        [StringLength(20)]
        public string SQQZR { get; set; }

        [StringLength(20)]
        public string WQCZY { get; set; }

        [StringLength(30)]
        public string GXRQ { get; set; }

        [StringLength(200)]
        public string JYXM_EX { get; set; }

        [StringLength(4)]
        public string ZZS { get; set; }

        [StringLength(50)]
        public string GLCJCLSH { get; set; }

        [StringLength(50)]
        public string GLCHPZL { get; set; }

        [StringLength(10)]
        public string GLCHPZLDH { get; set; }

        [StringLength(30)]
        public string LWCXWZJL { get; set; }

        [StringLength(4)]
        public string SFSQCLC { get; set; }

        [StringLength(50)]
        public string GLCJYXM { get; set; }

        [StringLength(4)]
        public string LWCXWZJLDH { get; set; }

        [StringLength(8)]
        public string HDZH { get; set; }

        [StringLength(8)]
        public string EDNJGL { get; set; }

        [StringLength(10)]
        public string JZZZWZ { get; set; }

        [StringLength(20)]
        public string FWQ_ZYXZ { get; set; }

        [StringLength(50)]
        public string LWLRLSH { get; set; }

        [StringLength(30)]
        public string LWLRHENF { get; set; }

        [StringLength(20)]
        public string LTGGLX { get; set; }

        [StringLength(4)]
        public string LTGGLXDH { get; set; }

        [StringLength(12)]
        public string QDZKZZL { get; set; }

        [StringLength(50)]
        public string WQLSH { get; set; }

        [StringLength(50)]
        public string AJLSH { get; set; }

        [StringLength(50)]
        public string ZJLSH { get; set; }

        [StringLength(50)]
        public string MTLSH { get; set; }

        [StringLength(8)]
        public string ZZL { get; set; }

        [StringLength(8)]
        public string MTCSFDJSS { get; set; }

        [StringLength(8)]
        public string MTCSFDJSSDH { get; set; }

        [StringLength(50)]
        public string ZYWLB { get; set; }

        [StringLength(8)]
        public string ZYWLBDH { get; set; }

        [StringLength(12)]
        public string JYLB_TYPE { get; set; }

        [StringLength(50)]
        public string CLSSLB { get; set; }

        [StringLength(10)]
        public string CLSSLBDH { get; set; }

        [StringLength(30)]
        public string SYRSFZ { get; set; }

        [StringLength(30)]
        public string ZJJYRQ { get; set; }

        [StringLength(30)]
        public string BXZZRQ { get; set; }

        [StringLength(30)]
        public string JYYXQZ { get; set; }

        [StringLength(4)]
        public string CLYTDH { get; set; }

        [StringLength(4)]
        public string YTSXDH { get; set; }

        [StringLength(300)]
        public string JYXM_LW { get; set; }

        public int? WAIT_LINE { get; set; }

        [StringLength(20)]
        public string GCPZH { get; set; }

        [StringLength(30)]
        public string GCLX { get; set; }

        [StringLength(10)]
        public string GCLXDH { get; set; }

        [StringLength(10)]
        public string QYCMZZZL { get; set; }

        [StringLength(4)]
        public string DCZS { get; set; }

        [StringLength(80)]
        public string XZQY { get; set; }

        [StringLength(10)]
        public string ZCLBGD { get; set; }

        [StringLength(10)]
        public string GCLBGD { get; set; }

        [StringLength(10)]
        public string GCCSC { get; set; }

        [StringLength(10)]
        public string GCCSK { get; set; }

        [StringLength(10)]
        public string GCCSG { get; set; }

        [StringLength(30)]
        public string GCBZZXS { get; set; }

        [StringLength(4)]
        public string GCBZZXSDH { get; set; }

        [StringLength(30)]
        public string ZJCLLX { get; set; }

        [StringLength(4)]
        public string ZJCLLXDH { get; set; }

        [StringLength(20)]
        public string SFSWPC { get; set; }

        [StringLength(30)]
        public string DLYSZH { get; set; }

        [StringLength(12)]
        public string SFSGSQC { get; set; }

        [StringLength(50)]
        public string CLCCLX { get; set; }

        [StringLength(4)]
        public string CLCCLXDH { get; set; }

        [StringLength(20)]
        public string DLRQ { get; set; }

        [StringLength(100)]
        public string LED { get; set; }

        [StringLength(100)]
        public string SJZDYH { get; set; }

        [StringLength(10)]
        public string ZJPZ { get; set; }
    }
}
