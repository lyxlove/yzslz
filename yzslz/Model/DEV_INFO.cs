namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_INFO
    {
        public int ID { get; set; }

        public int? JCXH { get; set; }

        [StringLength(50)]
        public string SBRZBH { get; set; }

        [StringLength(50)]
        public string CGJXH { get; set; }

        [StringLength(50)]
        public string CGJSCC { get; set; }

        [StringLength(50)]
        public string CGJCCBH { get; set; }

        [StringLength(50)]
        public string FQYXH { get; set; }

        [StringLength(50)]
        public string FQYSCC { get; set; }

        [StringLength(50)]
        public string FQYCCBH { get; set; }

        [StringLength(50)]
        public string LLJXH { get; set; }

        [StringLength(50)]
        public string LLJSCC { get; set; }

        [StringLength(50)]
        public string LLJCCBH { get; set; }

        [StringLength(50)]
        public string YDJXH { get; set; }

        [StringLength(50)]
        public string YDJSCC { get; set; }

        [StringLength(50)]
        public string YDJCCBH { get; set; }
    }
}
