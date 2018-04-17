namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOGIN_VEHICLE_INFO
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string VEHICLEID { get; set; }

        [StringLength(30)]
        public string HPHM { get; set; }

        [StringLength(30)]
        public string HPZL { get; set; }

        [StringLength(8)]
        public string HPZLDH { get; set; }

        [StringLength(30)]
        public string GLCHPHM { get; set; }

        [StringLength(30)]
        public string VIN { get; set; }

        [StringLength(38)]
        public string JYLB { get; set; }

        [StringLength(30)]
        public string JYLBDH { get; set; }

        [StringLength(30)]
        public string FDJH { get; set; }

        [StringLength(30)]
        public string FDJXH { get; set; }

        [StringLength(50)]
        public string FDJZZCS { get; set; }

        [StringLength(30)]
        public string DPXH { get; set; }

        [StringLength(100)]
        public string PP { get; set; }

        [StringLength(50)]
        public string CLZZCS { get; set; }

        [StringLength(100)]
        public string XH { get; set; }

        [StringLength(100)]
        public string PPXH { get; set; }

        [StringLength(30)]
        public string QDXS { get; set; }

        [StringLength(4)]
        public string QDXSDH { get; set; }

        [StringLength(10)]
        public string QDZWZ { get; set; }

        [StringLength(10)]
        public string ZCZWZ { get; set; }

        [StringLength(15)]
        public string QZDZ { get; set; }

        [StringLength(8)]
        public string QZDZDH { get; set; }

        [StringLength(10)]
        public string YGGSNFKT { get; set; }

        [StringLength(2)]
        public string YGGSNFKTDH { get; set; }

        [StringLength(30)]
        public string RLLB { get; set; }

        [StringLength(8)]
        public string RLLBDH { get; set; }

        [StringLength(15)]
        public string RYBH { get; set; }

        [StringLength(20)]
        public string GYFS { get; set; }

        [StringLength(4)]
        public string GYFSDH { get; set; }

        [StringLength(30)]
        public string CCDJRQ { get; set; }

        [StringLength(30)]
        public string CCRQ { get; set; }

        [StringLength(8)]
        public string ZBZL { get; set; }

        [StringLength(8)]
        public string ZZL { get; set; }

        [StringLength(12)]
        public string CYS { get; set; }

        [StringLength(20)]
        public string CSYS { get; set; }

        [StringLength(20)]
        public string CSYSDH { get; set; }

        [StringLength(30)]
        public string ZDFS { get; set; }

        [StringLength(8)]
        public string ZDFSDH { get; set; }

        [StringLength(38)]
        public string CLZL { get; set; }

        [StringLength(8)]
        public string CLZLDH { get; set; }

        [StringLength(16)]
        public string ZXZXJXS { get; set; }

        [StringLength(2)]
        public string ZXZXJXSDH { get; set; }

        [StringLength(10)]
        public string ZXZLX { get; set; }

        [StringLength(2)]
        public string ZXZLXDH { get; set; }

        [StringLength(8)]
        public string ZGSJCS { get; set; }

        [StringLength(8)]
        public string EDGL { get; set; }

        [StringLength(8)]
        public string EDZS { get; set; }

        [StringLength(8)]
        public string EDNJZS { get; set; }

        [StringLength(8)]
        public string EDNJ { get; set; }

        [StringLength(8)]
        public string EDYH { get; set; }

        [StringLength(20)]
        public string JQFS { get; set; }

        [StringLength(4)]
        public string JQFSDH { get; set; }

        [StringLength(8)]
        public string FDJPL { get; set; }

        [StringLength(4)]
        public string FDJGS { get; set; }

        [StringLength(4)]
        public string FDJCC { get; set; }

        [StringLength(50)]
        public string BSXLX { get; set; }

        [StringLength(4)]
        public string BSXLXDH { get; set; }

        [StringLength(20)]
        public string CXXL { get; set; }

        [StringLength(8)]
        public string CXXLDH { get; set; }

        [StringLength(8)]
        public string LJXSLC { get; set; }

        [StringLength(12)]
        public string LTQY { get; set; }

        [StringLength(25)]
        public string LTGG { get; set; }

        [StringLength(4)]
        public string LTSL { get; set; }

        [StringLength(100)]
        public string SYXZ { get; set; }

        [StringLength(4)]
        public string SYXZDH { get; set; }

        [StringLength(30)]
        public string YYZH { get; set; }

        [StringLength(80)]
        public string SJDW { get; set; }

        [StringLength(80)]
        public string SYR { get; set; }

        [StringLength(28)]
        public string LXDH { get; set; }

        [StringLength(80)]
        public string LXDZ { get; set; }

        [StringLength(10)]
        public string YZBH { get; set; }

        [StringLength(30)]
        public string DLRQ { get; set; }

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

        [StringLength(8)]
        public string CSC { get; set; }

        [StringLength(8)]
        public string CSK { get; set; }

        [StringLength(8)]
        public string CSG { get; set; }

        [StringLength(8)]
        public string ZJ { get; set; }

        [StringLength(8)]
        public string YZLJ { get; set; }

        [StringLength(8)]
        public string EZLJ { get; set; }

        [StringLength(8)]
        public string SZLJ { get; set; }

        [StringLength(8)]
        public string SIZLJ { get; set; }

        [StringLength(8)]
        public string WZLJ { get; set; }

        [StringLength(8)]
        public string LZLJ { get; set; }

        [StringLength(8)]
        public string YZZLZ { get; set; }

        [StringLength(8)]
        public string YZYLZ { get; set; }

        [StringLength(8)]
        public string YZZZ { get; set; }

        [StringLength(8)]
        public string EZZLZ { get; set; }

        [StringLength(8)]
        public string EZYLZ { get; set; }

        [StringLength(8)]
        public string EZZZ { get; set; }

        [StringLength(8)]
        public string SZZLZ { get; set; }

        [StringLength(8)]
        public string SZYLZ { get; set; }

        [StringLength(8)]
        public string SZZZ { get; set; }

        [StringLength(8)]
        public string SIZZLZ { get; set; }

        [StringLength(8)]
        public string SIZYLZ { get; set; }

        [StringLength(8)]
        public string SIZZZ { get; set; }

        [StringLength(8)]
        public string WZZLZ { get; set; }

        [StringLength(8)]
        public string WZYLZ { get; set; }

        [StringLength(8)]
        public string WZZZ { get; set; }

        [StringLength(8)]
        public string LZZLZ { get; set; }

        [StringLength(8)]
        public string LZYLZ { get; set; }

        [StringLength(8)]
        public string LZZZ { get; set; }

        [StringLength(20)]
        public string CHZHQQK { get; set; }

        [StringLength(4)]
        public string CHZHQQKDH { get; set; }

        [StringLength(10)]
        public string PQHCLZZ { get; set; }

        [StringLength(4)]
        public string PQHCLZZDH { get; set; }

        [StringLength(10)]
        public string JZZZWZ { get; set; }

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

        [StringLength(200)]
        public string JYXM_EX { get; set; }

        [StringLength(20)]
        public string FWQ_ZYXZ { get; set; }

        [StringLength(50)]
        public string DSBH { get; set; }

        [StringLength(50)]
        public string JCBSB { get; set; }

        [StringLength(50)]
        public string JCBXH { get; set; }

        [StringLength(32)]
        public string JCBAZRQ { get; set; }

        [StringLength(50)]
        public string JCBDYJSB { get; set; }

        [StringLength(50)]
        public string JCBDYJXH { get; set; }

        [StringLength(50)]
        public string JCBAZGS { get; set; }

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

        [StringLength(12)]
        public string GCZS { get; set; }

        [StringLength(50)]
        public string HCCSXS { get; set; }

        [StringLength(25)]
        public string YWLX { get; set; }

        [StringLength(12)]
        public string KCLXDJ { get; set; }

        [StringLength(50)]
        public string YXSSZJ { get; set; }

        [StringLength(50)]
        public string GCYYZH { get; set; }

        [StringLength(50)]
        public string GCYXSSZJ { get; set; }

        [StringLength(200)]
        public string JYXM { get; set; }

        [StringLength(200)]
        public string ZJXM { get; set; }

        [StringLength(200)]
        public string AJXM { get; set; }

        [StringLength(8)]
        public string MTCSFDJSS { get; set; }

        [StringLength(8)]
        public string MTCSFDJSSDH { get; set; }

        [StringLength(50)]
        public string ZYWLB { get; set; }

        [StringLength(8)]
        public string ZYWLBDH { get; set; }

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

        [StringLength(30)]
        public string BZZXS { get; set; }

        [StringLength(4)]
        public string BZZXSDH { get; set; }

        [StringLength(50)]
        public string AJLSH { get; set; }

        [StringLength(50)]
        public string ZJLSH { get; set; }

        [StringLength(50)]
        public string WQLSH { get; set; }

        [StringLength(50)]
        public string MTLSH { get; set; }

        [StringLength(300)]
        public string JYXM_LW { get; set; }

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
        public string DWS { get; set; }

        [StringLength(20)]
        public string DCZZ { get; set; }

        [StringLength(20)]
        public string SYQK { get; set; }

        [StringLength(20)]
        public string SYQKDH { get; set; }

        [StringLength(200)]
        public string CPMC { get; set; }

        [StringLength(30)]
        public string HPYS { get; set; }

        [StringLength(8)]
        public string HPYSDH { get; set; }

        [StringLength(8)]
        public string HCCSXSDH { get; set; }

        [StringLength(8)]
        public string KCLXDJDH { get; set; }

        [StringLength(8)]
        public string KCCC { get; set; }

        [StringLength(30)]
        public string GCYXXSZJ { get; set; }

        [StringLength(20)]
        public string GCVIN { get; set; }

        [StringLength(15)]
        public string GCCCDJRQ { get; set; }

        [StringLength(15)]
        public string GCCCRQ { get; set; }

        [StringLength(50)]
        public string GCPPXH { get; set; }

        [StringLength(8)]
        public string YHXZ { get; set; }

        [StringLength(8)]
        public string YHSD { get; set; }

        [StringLength(8)]
        public string YDXZ { get; set; }

        public int? SFPDZC { get; set; }
    }
}
