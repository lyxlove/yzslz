namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DATA_DB_VERSION
    {
        public int ID { get; set; }

        public int? DB_TYPE { get; set; }

        [StringLength(50)]
        public string DB_NOW_VERSION { get; set; }

        [StringLength(20)]
        public string DB_SETUP_PERSON { get; set; }

        [StringLength(100)]
        public string DB_SETUP_CON { get; set; }

        [StringLength(30)]
        public string DB_SETUP_DATE { get; set; }

        [StringLength(50)]
        public string DB_COMPANY_NAME { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }
    }
}
