namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_DPCG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(4)]
        public string DPCGJCCS { get; set; }

        [StringLength(8)]
        public string NJGK_SDSD { get; set; }

        [StringLength(8)]
        public string NJGK_SCGL { get; set; }

        [StringLength(8)]
        public string NJGK_XZGL { get; set; }

        [StringLength(8)]
        public string NJGK_LBGL { get; set; }

        [StringLength(8)]
        public string NJGL_YXBZ { get; set; }

        [StringLength(8)]
        public string NJGL_SCBZ { get; set; }

        [StringLength(4)]
        public string NJGL_PD { get; set; }

        [StringLength(8)]
        public string GLGK_SDSD { get; set; }

        [StringLength(8)]
        public string GLGK_SCGL { get; set; }

        [StringLength(8)]
        public string GLGK_XZGL { get; set; }

        [StringLength(8)]
        public string GLGK_LBGL { get; set; }

        [StringLength(8)]
        public string GLGL_YXBZ { get; set; }

        [StringLength(8)]
        public string GLGL_SCBZ { get; set; }

        [StringLength(4)]
        public string GLGL_PD { get; set; }

        [StringLength(8)]
        public string SU_SDSD { get; set; }

        [StringLength(8)]
        public string SU_JG { get; set; }

        [StringLength(8)]
        public string SU_BZXX { get; set; }

        [StringLength(8)]
        public string SU_BZSX { get; set; }

        [StringLength(4)]
        public string SU_PD { get; set; }

        [StringLength(8)]
        public string LC_SDLC { get; set; }

        [StringLength(8)]
        public string LC_JG { get; set; }

        [StringLength(8)]
        public string LC_XZ { get; set; }

        [StringLength(4)]
        public string LC_PD { get; set; }

        [StringLength(8)]
        public string JS_KSSD { get; set; }

        [StringLength(8)]
        public string JS_JSSD { get; set; }

        [StringLength(8)]
        public string JS_SJ { get; set; }

        [StringLength(8)]
        public string JS_XZ { get; set; }

        [StringLength(4)]
        public string JS_PD { get; set; }

        [StringLength(8)]
        public string HX_KSSD { get; set; }

        [StringLength(8)]
        public string HX_JSSD { get; set; }

        [StringLength(8)]
        public string HX_SJ { get; set; }

        [StringLength(8)]
        public string HX_LC { get; set; }

        [StringLength(8)]
        public string HX_XZ { get; set; }

        [StringLength(4)]
        public string HX_PD { get; set; }

        [StringLength(8)]
        public string DPCGWD { get; set; }

        [StringLength(8)]
        public string DPCGDQY { get; set; }

        [StringLength(8)]
        public string DPCGSD { get; set; }

        [StringLength(8)]
        public string CG_POT { get; set; }

        [StringLength(8)]
        public string CG_SDSD1 { get; set; }

        [StringLength(8)]
        public string CG_SCGL1 { get; set; }

        [StringLength(8)]
        public string CG_XZGL1 { get; set; }

        [StringLength(8)]
        public string CG_LBGL1 { get; set; }

        [StringLength(8)]
        public string CG_SDSD2 { get; set; }

        [StringLength(8)]
        public string CG_SCGL2 { get; set; }

        [StringLength(8)]
        public string CG_XZGL2 { get; set; }

        [StringLength(8)]
        public string CG_LBGL2 { get; set; }

        [StringLength(8)]
        public string CG_SDSD3 { get; set; }

        [StringLength(8)]
        public string CG_SCGL3 { get; set; }

        [StringLength(8)]
        public string CG_XZGL3 { get; set; }

        [StringLength(8)]
        public string CG_LBGL3 { get; set; }

        [StringLength(8)]
        public string CG_SDSD4 { get; set; }

        [StringLength(8)]
        public string CG_SCGL4 { get; set; }

        [StringLength(8)]
        public string CG_XZGL4 { get; set; }

        [StringLength(8)]
        public string CG_LBGL4 { get; set; }

        [StringLength(8)]
        public string CG_SDSD5 { get; set; }

        [StringLength(8)]
        public string CG_SCGL5 { get; set; }

        [StringLength(8)]
        public string CG_XZGL5 { get; set; }

        [StringLength(8)]
        public string CG_LBGL5 { get; set; }

        [StringLength(8)]
        public string CG_SDSD6 { get; set; }

        [StringLength(8)]
        public string CG_SCGL6 { get; set; }

        [StringLength(8)]
        public string CG_XZGL6 { get; set; }

        [StringLength(8)]
        public string CG_LBGL6 { get; set; }

        [StringLength(8)]
        public string CG_SDSD7 { get; set; }

        [StringLength(8)]
        public string CG_SCGL7 { get; set; }

        [StringLength(8)]
        public string CG_XZGL7 { get; set; }

        [StringLength(8)]
        public string CG_LBGL7 { get; set; }

        [StringLength(8)]
        public string CG_SDSD8 { get; set; }

        [StringLength(8)]
        public string CG_SCGL8 { get; set; }

        [StringLength(8)]
        public string CG_XZGL8 { get; set; }

        [StringLength(8)]
        public string CG_LBGL8 { get; set; }

        [StringLength(8)]
        public string CG_SDSD9 { get; set; }

        [StringLength(8)]
        public string CG_SCGL9 { get; set; }

        [StringLength(8)]
        public string CG_XZGL9 { get; set; }

        [StringLength(8)]
        public string CG_LBGL9 { get; set; }

        [StringLength(8)]
        public string CG_SDSD10 { get; set; }

        [StringLength(8)]
        public string CG_SCGL10 { get; set; }

        [StringLength(8)]
        public string CG_XZGL10 { get; set; }

        [StringLength(8)]
        public string CG_LBGL10 { get; set; }

        [StringLength(8)]
        public string ZGSD_JG { get; set; }

        [StringLength(8)]
        public string ZGSD_BZ { get; set; }

        [StringLength(4)]
        public string ZGSD_PD { get; set; }

        [StringLength(8)]
        public string GLGK_ZS { get; set; }

        [StringLength(8)]
        public string NJGK_ZS { get; set; }

        [StringLength(20)]
        public string GK_DBGL { get; set; }

        [StringLength(20)]
        public string GK_EDCS { get; set; }

        [StringLength(20)]
        public string GK_JZL { get; set; }

        [StringLength(20)]
        public string GK_WDCS { get; set; }

        [StringLength(10)]
        public string GK_PD { get; set; }

        [StringLength(10)]
        public string YH_SCZ { get; set; }

        [StringLength(10)]
        public string YH_BZ { get; set; }

        [StringLength(10)]
        public string YH_LC { get; set; }

        [StringLength(10)]
        public string YH_SD { get; set; }

        [StringLength(10)]
        public string YH_JZL { get; set; }

        [StringLength(10)]
        public string YH_PD { get; set; }

        [StringLength(20)]
        public string DLXKSSJ { get; set; }

        [StringLength(20)]
        public string DLXJSSJ { get; set; }

        [StringLength(20)]
        public string RYJJXKSSJ { get; set; }

        [StringLength(20)]
        public string RYJJXJSSJ { get; set; }
    }
}
