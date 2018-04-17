namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_ANGLE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string ZJJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string ZLZZJD { get; set; }

        [StringLength(8)]
        public string ZLYZJD { get; set; }

        [StringLength(8)]
        public string YLZZJD { get; set; }

        [StringLength(8)]
        public string YLYZJD { get; set; }

        [StringLength(4)]
        public string ZLZZ_PD { get; set; }

        [StringLength(4)]
        public string ZLYZ_PD { get; set; }

        [StringLength(4)]
        public string YLZZ_PD { get; set; }

        [StringLength(4)]
        public string YLYZ_PD { get; set; }

        [StringLength(8)]
        public string ZLZZXZXX { get; set; }

        [StringLength(8)]
        public string ZLZZXZSX { get; set; }

        [StringLength(8)]
        public string ZLYZXZXX { get; set; }

        [StringLength(8)]
        public string ZLYZXZSX { get; set; }

        [StringLength(8)]
        public string YLZZXZXX { get; set; }

        [StringLength(8)]
        public string YLZZXZSX { get; set; }

        [StringLength(8)]
        public string YLYZXZXX { get; set; }

        [StringLength(8)]
        public string YLYZXZSX { get; set; }
    }
}
