namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TABLE_UNION_NAME
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TABLE_NAME { get; set; }

        [StringLength(50)]
        public string TABLE_CONST { get; set; }

        public int? TABLE_TYPE { get; set; }
    }
}
