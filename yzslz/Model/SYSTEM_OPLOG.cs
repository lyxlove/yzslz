namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYSTEM_OPLOG
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string CZY { get; set; }

        [StringLength(30)]
        public string CZYID { get; set; }

        [StringLength(50)]
        public string CZGNMC { get; set; }

        [StringLength(500)]
        public string CZNC { get; set; }

        [StringLength(30)]
        public string CZDATE { get; set; }
    }
}
