namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_DOWNLINE_HB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string WQLSH { get; set; }

        [StringLength(50)]
        public string AJLSH { get; set; }

        [StringLength(50)]
        public string ZJLSH { get; set; }

        [StringLength(50)]
        public string MTLSH { get; set; }

        [StringLength(50)]
        public string JCBGDBH01 { get; set; }

        [StringLength(50)]
        public string JCBGDBH02 { get; set; }

        [StringLength(4)]
        public string JCCS { get; set; }

        [StringLength(30)]
        public string HPHM { get; set; }

        [StringLength(30)]
        public string HPZL { get; set; }

        [StringLength(8)]
        public string HPZLDH { get; set; }

        [StringLength(30)]
        public string VIN { get; set; }

        [StringLength(38)]
        public string CLZL { get; set; }

        [StringLength(8)]
        public string CLZLDH { get; set; }

        [StringLength(38)]
        public string JYLB { get; set; }

        [StringLength(30)]
        public string JYLBDH { get; set; }

        [StringLength(30)]
        public string YWLX { get; set; }

        [StringLength(50)]
        public string ZYWLB { get; set; }

        [StringLength(8)]
        public string ZYWLBDH { get; set; }

        [StringLength(80)]
        public string SYR { get; set; }

        public int? JCXH { get; set; }

        [StringLength(4)]
        public string Z_PD { get; set; }

        [StringLength(4)]
        public string AJ_Z_PD { get; set; }

        [StringLength(4)]
        public string ZJ_Z_PD { get; set; }

        [StringLength(4)]
        public string WQ_Z_PD { get; set; }

        [StringLength(4)]
        public string QT_Z_PD { get; set; }

        public int? IsUpload { get; set; }

        public int? IsAudit { get; set; }

        public int? IsPrint { get; set; }

        [StringLength(32)]
        public string DOWNLINEDATE { get; set; }

        [StringLength(12)]
        public string JYLB_TYPE { get; set; }

        [StringLength(30)]
        public string CLSXSJ { get; set; }

        [StringLength(20)]
        public string YCY { get; set; }

        [StringLength(30)]
        public string JCRQ { get; set; }
    }
}
