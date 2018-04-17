namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CALIB_DATA
    {
        public int ID { get; set; }

        [StringLength(5)]
        public string JCXH { get; set; }

        [StringLength(5)]
        public string DevID { get; set; }

        [StringLength(50)]
        public string DevName { get; set; }

        [StringLength(50)]
        public string DevCalibName { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        [StringLength(10)]
        public string DevCalibNum { get; set; }

        [StringLength(50)]
        public string DevNo { get; set; }

        [StringLength(50)]
        public string DevCalibPot { get; set; }

        [StringLength(30)]
        public string StartTime { get; set; }

        [StringLength(50)]
        public string EndTime { get; set; }

        [StringLength(50)]
        public string DYZ { get; set; }

        [StringLength(50)]
        public string CLZ { get; set; }

        [StringLength(50)]
        public string BZZ { get; set; }

        [StringLength(50)]
        public string JDWC { get; set; }

        [StringLength(50)]
        public string XDWC { get; set; }

        [StringLength(10)]
        public string PD { get; set; }
    }
}
