namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSPECTION_DEV_REG_INFO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? JCXH { get; set; }

        [StringLength(10)]
        public string SBLX { get; set; }

        [StringLength(50)]
        public string SBMC { get; set; }

        [StringLength(20)]
        public string SBMCDH { get; set; }

        [StringLength(50)]
        public string SBZZC { get; set; }

        [StringLength(50)]
        public string SBXH { get; set; }

        [StringLength(50)]
        public string SBCCBH { get; set; }

        [StringLength(32)]
        public string SBCCRQ { get; set; }

        [StringLength(50)]
        public string SBRZBH { get; set; }

        [StringLength(32)]
        public string SBRZRQ { get; set; }

        [StringLength(32)]
        public string SBRZYXQZ { get; set; }

        [StringLength(50)]
        public string JLBDBH { get; set; }

        [StringLength(32)]
        public string JLBDRQ { get; set; }

        [StringLength(32)]
        public string JLBDYXQZ { get; set; }

        [StringLength(100)]
        public string BZ { get; set; }
    }
}
