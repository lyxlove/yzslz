namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GB_SMOKE_STANDAR
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string QCZZC { get; set; }

        [StringLength(100)]
        public string CPCX { get; set; }

        [StringLength(100)]
        public string CLXH { get; set; }

        [StringLength(100)]
        public string FDJZZC { get; set; }

        [StringLength(100)]
        public string FDJXH { get; set; }

        [StringLength(10)]
        public string ZDJGL { get; set; }

        [StringLength(10)]
        public string XSHZBZ { get; set; }

        [StringLength(10)]
        public string CGJCBZ { get; set; }
    }
}
