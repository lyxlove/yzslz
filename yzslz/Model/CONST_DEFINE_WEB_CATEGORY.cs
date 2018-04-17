namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONST_DEFINE_WEB_CATEGORY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(200)]
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }
    }
}
