namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_VMAS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(4)]
        public string VMASJCCS { get; set; }

        [StringLength(8)]
        public string HCJG { get; set; }

        [StringLength(8)]
        public string COJG { get; set; }

        [StringLength(8)]
        public string NOJG { get; set; }

        [StringLength(8)]
        public string HC_NOJG { get; set; }

        [StringLength(8)]
        public string HCXZ { get; set; }

        [StringLength(8)]
        public string COXZ { get; set; }

        [StringLength(8)]
        public string NOXZ { get; set; }

        [StringLength(8)]
        public string HC_NOXZ { get; set; }

        [StringLength(4)]
        public string HC_PD { get; set; }

        [StringLength(4)]
        public string CO_PD { get; set; }

        [StringLength(4)]
        public string NO_PD { get; set; }

        [StringLength(4)]
        public string HC_NO_PD { get; set; }

        [StringLength(4)]
        public string PDFS { get; set; }

        [StringLength(8)]
        public string LXWCSJ { get; set; }

        [StringLength(8)]
        public string LJWCSJ { get; set; }

        [StringLength(8)]
        public string LJXXLC { get; set; }

        [StringLength(4)]
        public string VMAS_PD { get; set; }

        [StringLength(8)]
        public string WD { get; set; }

        [StringLength(8)]
        public string SD { get; set; }

        [StringLength(8)]
        public string DQY { get; set; }

        [StringLength(8)]
        public string BJ_O2 { get; set; }

        [StringLength(8)]
        public string CL_HC { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
