namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_OVERALLSIZE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string WKCCJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string ZCSCWKCCGD { get; set; }

        [StringLength(8)]
        public string ZCSCWKCCGDCZ { get; set; }

        [StringLength(8)]
        public string ZCSCWKCCKD { get; set; }

        [StringLength(8)]
        public string ZCSCWKCCKDCZ { get; set; }

        [StringLength(8)]
        public string ZCSCWKCCCD { get; set; }

        [StringLength(8)]
        public string ZCSCWKCCCDCZ { get; set; }

        [StringLength(4)]
        public string ZCWKCC_PD { get; set; }

        [StringLength(8)]
        public string HXSCWKCCGD { get; set; }

        [StringLength(8)]
        public string HXSCWKCCGDCZ { get; set; }

        [StringLength(8)]
        public string HXSCWKCCKD { get; set; }

        [StringLength(8)]
        public string HXSCWKCCKDCZ { get; set; }

        [StringLength(8)]
        public string HXSCWKCCCD { get; set; }

        [StringLength(8)]
        public string HXSCWKCCCDCZ { get; set; }

        [StringLength(4)]
        public string HXWKCC_PD { get; set; }

        [StringLength(8)]
        public string SCWKCCGDXZXX { get; set; }

        [StringLength(8)]
        public string SCWKCCGDXZSX { get; set; }

        [StringLength(8)]
        public string SCWKCCKDXZXX { get; set; }

        [StringLength(8)]
        public string SCWKCCKDXZSX { get; set; }

        [StringLength(8)]
        public string SCWKCCCDXZXX { get; set; }

        [StringLength(8)]
        public string SCWKCCCDXZSX { get; set; }

        public int? CYDJCFS { get; set; }

        [StringLength(8)]
        public string GCSCWKCCGD { get; set; }

        [StringLength(8)]
        public string GCSCWKCCGDCZ { get; set; }

        [StringLength(8)]
        public string GCSCWKCCKD { get; set; }

        [StringLength(8)]
        public string GCSCWKCCKDCZ { get; set; }

        [StringLength(8)]
        public string GCSCWKCCCD { get; set; }

        [StringLength(8)]
        public string GCSCWKCCCDCZ { get; set; }

        [StringLength(4)]
        public string GCWKCC_PD { get; set; }

        [StringLength(30)]
        public string ZCWKCCXZ { get; set; }

        [StringLength(30)]
        public string GCWKCCXZ { get; set; }

        [StringLength(30)]
        public string HXWKCCXZ { get; set; }

        [StringLength(8)]
        public string YQCLCC { get; set; }

        [StringLength(8)]
        public string YQCLCK { get; set; }

        [StringLength(8)]
        public string YQCLCG { get; set; }

        [StringLength(50)]
        public string QRRXM { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
