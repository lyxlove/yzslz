namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GA_JYYXX_BAJG
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string babh { get; set; }

        [StringLength(64)]
        public string jyxtmc { get; set; }

        [StringLength(256)]
        public string jyxtsm { get; set; }

        [StringLength(64)]
        public string bbbh { get; set; }

        [StringLength(256)]
        public string kfdw { get; set; }

        [StringLength(128)]
        public string sjkbb { get; set; }

        [Column(TypeName = "text")]
        public string xtjgms { get; set; }

        [StringLength(10)]
        public string jczbh { get; set; }

        [StringLength(100)]
        public string jcxxh { get; set; }

        [StringLength(32)]
        public string jcsj { get; set; }

        [StringLength(32)]
        public string yssj { get; set; }

        [StringLength(2)]
        public string syzt { get; set; }

        [StringLength(512)]
        public string ztyy { get; set; }

        [StringLength(30)]
        public string jbr { get; set; }

        [StringLength(2)]
        public string shbj { get; set; }

        [Column(TypeName = "text")]
        public string shyj { get; set; }

        [StringLength(30)]
        public string shr { get; set; }

        [StringLength(32)]
        public string shsj { get; set; }

        [StringLength(10)]
        public string fzjg { get; set; }

        [StringLength(12)]
        public string glbm { get; set; }

        [StringLength(32)]
        public string gxsj { get; set; }

        [Column(TypeName = "text")]
        public string syglbm { get; set; }
    }
}
