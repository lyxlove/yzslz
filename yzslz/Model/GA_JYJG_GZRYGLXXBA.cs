namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GA_JYJG_GZRYGLXXBA
    {
        public int ID { get; set; }

        [StringLength(18)]
        public string sfzmhm { get; set; }

        [StringLength(30)]
        public string xm { get; set; }

        [StringLength(300)]
        public string rylb { get; set; }

        [StringLength(12)]
        public string glbm { get; set; }

        [StringLength(10)]
        public string fzjg { get; set; }

        [StringLength(20)]
        public string jczbh { get; set; }

        [StringLength(32)]
        public string gxrq { get; set; }

        [Column(TypeName = "text")]
        public string bz { get; set; }

        [StringLength(2)]
        public string shbj { get; set; }

        [Column(TypeName = "text")]
        public string shyj { get; set; }

        [StringLength(2)]
        public string zt { get; set; }

        [StringLength(32)]
        public string sgzbh { get; set; }

        [StringLength(32)]
        public string sgzyxqz { get; set; }

        [StringLength(300)]
        public string sgzffdw { get; set; }

        [Column(TypeName = "text")]
        public string syglbm { get; set; }
    }
}
