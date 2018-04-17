namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BGD_SUGGEST
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string SuggestItems { get; set; }

        public bool? SingleFlag { get; set; }

        [StringLength(50)]
        public string SugNextStartTime { get; set; }

        [StringLength(50)]
        public string SugNextEndTime { get; set; }
    }
}
