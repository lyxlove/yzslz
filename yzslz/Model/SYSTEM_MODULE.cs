namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYSTEM_MODULE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mid { get; set; }

        public int? pid { get; set; }

        public int? morder { get; set; }

        [StringLength(50)]
        public string mname { get; set; }

        [StringLength(250)]
        public string murl { get; set; }

        [StringLength(1)]
        public string mdisabled { get; set; }
    }
}
