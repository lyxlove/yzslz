namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRINT_RECORD
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [Required]
        [StringLength(50)]
        public string PrintDate { get; set; }

        public int IsPrint { get; set; }

        public int DISPATCH_ID { get; set; }

        public DateTime create_at { get; set; }
    }
}
