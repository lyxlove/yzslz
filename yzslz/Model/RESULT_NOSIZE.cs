namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_NOSIZE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string ZYJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string HJZYZ { get; set; }

        [StringLength(8)]
        public string SCZYZ { get; set; }

        [StringLength(4)]
        public string ZYZ_PD { get; set; }

        [StringLength(8)]
        public string ZYXZXX { get; set; }

        [StringLength(8)]
        public string ZYXZSX { get; set; }
    }
}
