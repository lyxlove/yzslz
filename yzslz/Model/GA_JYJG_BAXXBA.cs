namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GA_JYJG_BAXXBA
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string jczbh { get; set; }

        [StringLength(128)]
        public string jczmc { get; set; }

        [StringLength(2)]
        public string sflw { get; set; }

        [StringLength(32)]
        public string rdsbh { get; set; }

        [StringLength(32)]
        public string rdyxqs { get; set; }

        [StringLength(32)]
        public string rdyxqz { get; set; }

        [StringLength(8)]
        public string shejirjcnl { get; set; }

        [StringLength(8)]
        public string shijirjcnl { get; set; }

        [StringLength(4)]
        public string jcryzs { get; set; }

        [StringLength(4)]
        public string wjgwrs { get; set; }

        [StringLength(4)]
        public string lrgwrs { get; set; }

        [StringLength(4)]
        public string ycyrs { get; set; }

        [StringLength(4)]
        public string dpgwrs { get; set; }

        [StringLength(4)]
        public string zjgwrs { get; set; }

        [StringLength(4)]
        public string qtgwrs { get; set; }

        [StringLength(4)]
        public string tgszjbmkhrs { get; set; }

        [StringLength(4)]
        public string wtgszjbmkhrs { get; set; }

        [StringLength(20)]
        public string fzjg { get; set; }

        [StringLength(20)]
        public string glbm { get; set; }

        [StringLength(32)]
        public string gxrq { get; set; }

        [Column(TypeName = "text")]
        public string bz { get; set; }

        [StringLength(4)]
        public string shejirjcmtsl { get; set; }

        [StringLength(4)]
        public string shijirjcmtsl { get; set; }

        [StringLength(2)]
        public string shbj { get; set; }

        [Column(TypeName = "text")]
        public string syglbm { get; set; }

        [Column(TypeName = "text")]
        public string shyj { get; set; }

        [StringLength(2)]
        public string zt { get; set; }

        [Column(TypeName = "text")]
        public string ztyy { get; set; }

        [StringLength(300)]
        public string dwdz { get; set; }

        [StringLength(6)]
        public string yzbm { get; set; }

        [StringLength(100)]
        public string xkjyfw { get; set; }

        [StringLength(300)]
        public string rdsffdw { get; set; }

        [StringLength(30)]
        public string frdb { get; set; }

        [StringLength(18)]
        public string frdbsfzh { get; set; }

        [StringLength(15)]
        public string frdblxdh { get; set; }

        [StringLength(30)]
        public string fzr { get; set; }

        [StringLength(18)]
        public string fzrsfzh { get; set; }

        [StringLength(15)]
        public string fzrlxdh { get; set; }

        [StringLength(30)]
        public string rclxr { get; set; }

        [StringLength(18)]
        public string rclxrsfzh { get; set; }

        [StringLength(15)]
        public string rclxrlxdh { get; set; }
    }
}
