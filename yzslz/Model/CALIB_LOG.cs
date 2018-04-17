namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CALIB_LOG
    {
        public int ID { get; set; }

        [StringLength(5)]
        public string CalibID { get; set; }

        [StringLength(5)]
        public string JCXH { get; set; }

        [StringLength(50)]
        public string CalibName { get; set; }

        [StringLength(30)]
        public string StartTime { get; set; }

        [StringLength(50)]
        public string EndTime { get; set; }

        [StringLength(5000)]
        public string DetailedData { get; set; }

        [StringLength(500)]
        public string ProcessPath { get; set; }

        [StringLength(5)]
        public string ALL_PD { get; set; }
    }
}
