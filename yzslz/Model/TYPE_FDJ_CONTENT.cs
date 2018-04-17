namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_FDJ_CONTENT
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string FDJXH { get; set; }

        [StringLength(50)]
        public string FDJZZC { get; set; }

        [StringLength(30)]
        public string RLLB { get; set; }

        [StringLength(15)]
        public string RYBH { get; set; }

        [StringLength(20)]
        public string GYFS { get; set; }

        [StringLength(20)]
        public string JQFS { get; set; }

        [StringLength(8)]
        public string EDGL { get; set; }

        [StringLength(8)]
        public string EDZS { get; set; }

        [StringLength(8)]
        public string EDNJZS { get; set; }

        [StringLength(8)]
        public string EDNJ { get; set; }

        [StringLength(8)]
        public string EDYH { get; set; }

        [StringLength(8)]
        public string FDJPL { get; set; }

        [StringLength(4)]
        public string FDJGS { get; set; }

        [StringLength(4)]
        public string FDJCC { get; set; }
    }
}
