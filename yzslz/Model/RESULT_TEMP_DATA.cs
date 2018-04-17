namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_TEMP_DATA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string Temp1 { get; set; }

        [StringLength(50)]
        public string Temp2 { get; set; }

        [StringLength(50)]
        public string Temp3 { get; set; }

        [StringLength(50)]
        public string Temp4 { get; set; }

        [StringLength(50)]
        public string Temp5 { get; set; }

        [StringLength(50)]
        public string Temp6 { get; set; }

        [StringLength(50)]
        public string Temp7 { get; set; }

        [StringLength(50)]
        public string Temp8 { get; set; }

        [StringLength(50)]
        public string Temp9 { get; set; }

        [StringLength(50)]
        public string Temp10 { get; set; }

        [StringLength(50)]
        public string Temp11 { get; set; }

        [StringLength(50)]
        public string Temp12 { get; set; }

        [StringLength(50)]
        public string Temp13 { get; set; }

        [StringLength(50)]
        public string Temp14 { get; set; }

        [StringLength(50)]
        public string Temp15 { get; set; }

        [StringLength(50)]
        public string Temp16 { get; set; }

        [StringLength(50)]
        public string Temp17 { get; set; }

        [StringLength(50)]
        public string Temp18 { get; set; }

        [StringLength(50)]
        public string Temp19 { get; set; }

        [StringLength(50)]
        public string Temp20 { get; set; }
    }
}
