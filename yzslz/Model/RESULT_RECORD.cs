namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_RECORD
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string LWLSH { get; set; }

        [StringLength(4)]
        public string Z_PD { get; set; }

        public int? JCCS { get; set; }

        public int? JCXH { get; set; }

        public int? DownLineStatus { get; set; }

        [StringLength(30)]
        public string DownLineTime { get; set; }

        public int? IsPrintReport { get; set; }

        [StringLength(30)]
        public string HPHM { get; set; }

        [StringLength(8)]
        public string HPZLDH { get; set; }

        [StringLength(30)]
        public string ZHJYLBDH { get; set; }

        [StringLength(4)]
        public string JYLBDH { get; set; }

        [StringLength(30)]
        public string JYLB { get; set; }

        [StringLength(50)]
        public string FJXM { get; set; }
    }
}
