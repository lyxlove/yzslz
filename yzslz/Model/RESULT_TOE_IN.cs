namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_TOE_IN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string QSJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }
    }
}
