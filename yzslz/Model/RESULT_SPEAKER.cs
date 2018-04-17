namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_SPEAKER
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string SJJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string SCSJZ { get; set; }

        [StringLength(4)]
        public string SJZ_PD { get; set; }

        [StringLength(8)]
        public string SJXZXX { get; set; }

        [StringLength(8)]
        public string SJXZSX { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
