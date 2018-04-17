namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_SPEED
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string SDJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string SCSD { get; set; }

        [StringLength(8)]
        public string SDMBZ { get; set; }

        [StringLength(8)]
        public string SDWC { get; set; }

        [StringLength(8)]
        public string SDBZXX { get; set; }

        [StringLength(8)]
        public string SDBZSX { get; set; }

        [StringLength(4)]
        public string SD_PD { get; set; }

        [StringLength(4)]
        public string SDLYLX { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
