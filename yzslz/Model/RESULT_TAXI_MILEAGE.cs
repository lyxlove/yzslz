namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_TAXI_MILEAGE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string LCBJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(4)]
        public string LCB_PD { get; set; }

        [StringLength(8)]
        public string SCLC1 { get; set; }

        [StringLength(8)]
        public string SCLC2 { get; set; }

        [StringLength(8)]
        public string SCLC3 { get; set; }

        [StringLength(8)]
        public string SCLC4 { get; set; }

        [StringLength(8)]
        public string SCLC5 { get; set; }

        [StringLength(8)]
        public string SCLC6 { get; set; }

        [StringLength(8)]
        public string MBLC1 { get; set; }

        [StringLength(8)]
        public string MBLC2 { get; set; }

        [StringLength(8)]
        public string MBLC3 { get; set; }

        [StringLength(8)]
        public string MBLC4 { get; set; }

        [StringLength(8)]
        public string MBLC5 { get; set; }

        [StringLength(8)]
        public string MBLC6 { get; set; }

        [StringLength(8)]
        public string JDWC1 { get; set; }

        [StringLength(8)]
        public string JDWC2 { get; set; }

        [StringLength(8)]
        public string JDWC3 { get; set; }

        [StringLength(8)]
        public string JDWC4 { get; set; }

        [StringLength(8)]
        public string JDWC5 { get; set; }

        [StringLength(8)]
        public string JDWC6 { get; set; }

        [StringLength(8)]
        public string XDWC1 { get; set; }

        [StringLength(8)]
        public string XDWC2 { get; set; }

        [StringLength(8)]
        public string XDWC3 { get; set; }

        [StringLength(8)]
        public string XDWC4 { get; set; }

        [StringLength(8)]
        public string XDWC5 { get; set; }

        [StringLength(8)]
        public string XDWC6 { get; set; }

        [StringLength(4)]
        public string LC1_PD { get; set; }

        [StringLength(4)]
        public string LC2_PD { get; set; }

        [StringLength(4)]
        public string LC3_PD { get; set; }

        [StringLength(4)]
        public string LC4_PD { get; set; }

        [StringLength(4)]
        public string LC5_PD { get; set; }

        [StringLength(4)]
        public string LC6_PD { get; set; }

        [StringLength(8)]
        public string TCDDZSJ { get; set; }

        [StringLength(8)]
        public string TCDDJSSJ { get; set; }

        [StringLength(8)]
        public string TCDDZSJBZ { get; set; }

        [StringLength(8)]
        public string TCDDJSSJBZ { get; set; }

        [StringLength(8)]
        public string TCDDZSJJDWC { get; set; }

        [StringLength(8)]
        public string TCDDJSSJJDWC { get; set; }

        [StringLength(8)]
        public string TCDDZSJXDWC { get; set; }

        [StringLength(8)]
        public string TCDDJSSJXDWC { get; set; }

        [StringLength(4)]
        public string TCDDZSJ_PD { get; set; }

        [StringLength(4)]
        public string TCDDJSSJ_PD { get; set; }

        public int? IsByHandle { get; set; }
    }
}
