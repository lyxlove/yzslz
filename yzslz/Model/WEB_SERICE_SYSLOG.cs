namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WEB_SERICE_SYSLOG
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string LWLSH { get; set; }

        [StringLength(30)]
        public string JCZHDH { get; set; }

        [StringLength(120)]
        public string WebURL { get; set; }

        [StringLength(30)]
        public string JCXH { get; set; }

        [StringLength(50)]
        public string JKSBDH { get; set; }

        [StringLength(10)]
        public string JCCS { get; set; }

        [StringLength(50)]
        public string VEHICLEID { get; set; }

        [StringLength(10)]
        public string HPZLDH { get; set; }

        [StringLength(30)]
        public string WriteDate { get; set; }

        public int? JKType { get; set; }

        public int? UpStatus { get; set; }

        [StringLength(20)]
        public string WebCode { get; set; }

        [Column(TypeName = "ntext")]
        public string RequestXML { get; set; }

        [Column(TypeName = "ntext")]
        public string ResponseXML { get; set; }

        [StringLength(100)]
        public string CodeName { get; set; }

        [StringLength(10)]
        public string JCGWH { get; set; }

        [StringLength(200)]
        public string JYXM { get; set; }

        [StringLength(50)]
        public string JCLB { get; set; }
    }
}
