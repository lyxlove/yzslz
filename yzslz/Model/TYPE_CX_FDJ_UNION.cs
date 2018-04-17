namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_CX_FDJ_UNION
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string PPZM { get; set; }

        [StringLength(50)]
        public string PP { get; set; }

        [StringLength(30)]
        public string XH { get; set; }

        [StringLength(80)]
        public string PPXH { get; set; }

        [StringLength(30)]
        public string FDJXH { get; set; }
    }
}
