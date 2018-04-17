namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_ZYJS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string ZYJSJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string ZYJSJG1 { get; set; }

        [StringLength(8)]
        public string ZYJSJG2 { get; set; }

        [StringLength(8)]
        public string ZYJSJG3 { get; set; }

        [StringLength(8)]
        public string ZYJSJG4 { get; set; }

        [StringLength(8)]
        public string ZYJSPJZ { get; set; }

        [StringLength(8)]
        public string ZYJSXZ { get; set; }

        [StringLength(4)]
        public string ZYJS_PD { get; set; }

        [StringLength(8)]
        public string ZYJSYW { get; set; }

        [StringLength(8)]
        public string ZYJSDSZS { get; set; }

        [StringLength(8)]
        public string ZYJSWD { get; set; }

        [StringLength(8)]
        public string ZYJSDQY { get; set; }

        [StringLength(8)]
        public string ZYJSSD { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }

        [StringLength(10)]
        public string SFLZS { get; set; }
    }
}
