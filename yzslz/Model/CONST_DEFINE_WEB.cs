namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONST_DEFINE_WEB
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string ValueOfName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? SeqNumber { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
