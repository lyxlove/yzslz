namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WKY_DATA
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string HPHM { get; set; }

        [StringLength(10)]
        public string HPZLDH { get; set; }

        [StringLength(50)]
        public string AJLSH { get; set; }

        [StringLength(50)]
        public string ZJLSH { get; set; }

        [StringLength(8)]
        public string CSC { get; set; }

        [StringLength(8)]
        public string CSK { get; set; }

        [StringLength(8)]
        public string CSG { get; set; }

        [StringLength(8)]
        public string ZJ { get; set; }

        [StringLength(4)]
        public string ZCWKCC_PD { get; set; }

        public int? ISREAD { get; set; }

        [StringLength(30)]
        public string SYSDATE { get; set; }
    }
}
