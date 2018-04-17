namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_SIDESLIP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string CHJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string QQCHSCZ { get; set; }

        [StringLength(4)]
        public string QQCH_PD { get; set; }

        [StringLength(8)]
        public string HQCHSCZ { get; set; }

        [StringLength(4)]
        public string HQCH_PD { get; set; }

        [StringLength(8)]
        public string QQTGSDSCZ { get; set; }

        [StringLength(4)]
        public string QQTGSD_PD { get; set; }

        [StringLength(8)]
        public string HQTGSDSCZ { get; set; }

        [StringLength(4)]
        public string HQTGSD_PD { get; set; }

        [StringLength(8)]
        public string QQCHXZXX { get; set; }

        [StringLength(8)]
        public string QQCHXZSX { get; set; }

        [StringLength(8)]
        public string HQCHXZXX { get; set; }

        [StringLength(8)]
        public string HQCHXZSX { get; set; }

        [StringLength(8)]
        public string QQTGSDXZXX { get; set; }

        [StringLength(8)]
        public string QQTGSDXZSX { get; set; }

        [StringLength(8)]
        public string HQTGSDXZXX { get; set; }

        [StringLength(8)]
        public string HQTGSDXZSX { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
