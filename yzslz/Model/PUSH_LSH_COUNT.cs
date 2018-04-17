namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PUSH_LSH_COUNT
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string TEST_DATE { get; set; }

        [StringLength(10)]
        public string LOGIN_PC_NO { get; set; }

        [StringLength(10)]
        public string LSH_COUNT { get; set; }

        [StringLength(30)]
        public string UPDATE_TIME { get; set; }

        public int? COUNT_TYPE { get; set; }

        [StringLength(10)]
        public string TEST_TYPE { get; set; }
    }
}
