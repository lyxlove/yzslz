namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_LD
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(4)]
        public string LDJCCS { get; set; }

        [StringLength(8)]
        public string GLJG { get; set; }

        [StringLength(8)]
        public string GLXZ { get; set; }

        [StringLength(4)]
        public string GL_PD { get; set; }

        [StringLength(8)]
        public string ZSJG { get; set; }

        [StringLength(8)]
        public string ZSXZ { get; set; }

        [StringLength(4)]
        public string ZS_PD { get; set; }

        [StringLength(8)]
        public string GXSXS100 { get; set; }

        [StringLength(8)]
        public string GXSXS90 { get; set; }

        [StringLength(8)]
        public string GXSXS80 { get; set; }

        [StringLength(8)]
        public string GXSXSXZ { get; set; }

        [StringLength(4)]
        public string GXSXS_PD { get; set; }

        [StringLength(8)]
        public string LDWD { get; set; }

        [StringLength(8)]
        public string LDDQY { get; set; }

        [StringLength(8)]
        public string LDSD { get; set; }

        [StringLength(4)]
        public string LD_PD { get; set; }

        [StringLength(8)]
        public string LDYW { get; set; }

        [StringLength(8)]
        public string HSU100 { get; set; }

        [StringLength(8)]
        public string HSU90 { get; set; }

        [StringLength(8)]
        public string HSU80 { get; set; }

        [StringLength(8)]
        public string DSZS { get; set; }

        [StringLength(8)]
        public string JSZDGLXDSD { get; set; }

        [StringLength(8)]
        public string SCZDGLXDSD { get; set; }

        [StringLength(8)]
        public string SMSJ { get; set; }

        [StringLength(8)]
        public string CSSJ { get; set; }

        [StringLength(8)]
        public string GL100 { get; set; }

        [StringLength(8)]
        public string GL90 { get; set; }

        [StringLength(8)]
        public string GL80 { get; set; }

        [StringLength(8)]
        public string ZS100 { get; set; }

        [StringLength(8)]
        public string ZS90 { get; set; }

        [StringLength(8)]
        public string ZS80 { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
