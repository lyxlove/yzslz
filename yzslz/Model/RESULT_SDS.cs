namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_SDS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string SDSJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string GDSCO { get; set; }

        [StringLength(8)]
        public string GDSHC { get; set; }

        [StringLength(8)]
        public string DSCO { get; set; }

        [StringLength(8)]
        public string DSHC { get; set; }

        [StringLength(8)]
        public string GDSCOXZ { get; set; }

        [StringLength(8)]
        public string GDSHCXZ { get; set; }

        [StringLength(8)]
        public string DSCOXZ { get; set; }

        [StringLength(8)]
        public string DSHCXZ { get; set; }

        [StringLength(4)]
        public string GDSCO_PD { get; set; }

        [StringLength(4)]
        public string GDSHC_PD { get; set; }

        [StringLength(4)]
        public string DSCO_PD { get; set; }

        [StringLength(4)]
        public string DSHC_PD { get; set; }

        [StringLength(8)]
        public string GLKQXS { get; set; }

        [StringLength(8)]
        public string GLKQXSSX { get; set; }

        [StringLength(8)]
        public string GLKQXSXX { get; set; }

        [StringLength(4)]
        public string GLKQXS_PD { get; set; }

        [StringLength(8)]
        public string SDSWD { get; set; }

        [StringLength(8)]
        public string SDSDQY { get; set; }

        [StringLength(8)]
        public string SDSSD { get; set; }

        [StringLength(8)]
        public string GDSCO2 { get; set; }

        [StringLength(8)]
        public string GDSO2 { get; set; }

        [StringLength(8)]
        public string DSCO2 { get; set; }

        [StringLength(8)]
        public string DSO2 { get; set; }

        [StringLength(8)]
        public string SDSYW { get; set; }

        [StringLength(8)]
        public string SDSDSZS { get; set; }

        [StringLength(8)]
        public string SDSGDSZS { get; set; }

        [StringLength(8)]
        public string GDSCOXZZ { get; set; }

        [StringLength(8)]
        public string DSCOXZZ { get; set; }

        [StringLength(8)]
        public string GDSCOXYZ { get; set; }

        [StringLength(8)]
        public string GDSCO2XYZ { get; set; }

        [StringLength(8)]
        public string GDSHCXYZ { get; set; }

        [StringLength(8)]
        public string DSCOXYZ { get; set; }

        [StringLength(8)]
        public string DSCO2XYZ { get; set; }

        [StringLength(8)]
        public string DSHCXYZ { get; set; }

        [StringLength(4)]
        public string SDS_PD { get; set; }

        [StringLength(4)]
        public string DS_PD { get; set; }

        [StringLength(4)]
        public string GDS_PD { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
