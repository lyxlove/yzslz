namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONST_DEFINE
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string CON_CHNAME { get; set; }

        [StringLength(50)]
        public string CON_NAME { get; set; }

        [StringLength(50)]
        public string CON_CODE { get; set; }

        [StringLength(50)]
        public string CON_CON { get; set; }

        [StringLength(50)]
        public string CON_SPELL { get; set; }

        public int? CON_ORDER { get; set; }

        public int? CON_FLAG { get; set; }

        public int? CON_VTYPE { get; set; }

        public int? CON_CLASS { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string CON_JCTYPE { get; set; }
    }
}
