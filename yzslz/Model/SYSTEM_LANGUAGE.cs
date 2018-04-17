namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYSTEM_LANGUAGE
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string CONDITION { get; set; }

        [StringLength(500)]
        public string SimplifiedChinese { get; set; }

        [StringLength(500)]
        public string TraditionalChinese { get; set; }

        [StringLength(500)]
        public string English { get; set; }

        [StringLength(1000)]
        public string Portuguese { get; set; }

        [StringLength(100)]
        public string CharacterType { get; set; }

        [StringLength(100)]
        public string ProgramName { get; set; }
    }
}
