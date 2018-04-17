namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CASH_CHARGE_DETAILED
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CHARGE_ID { get; set; }

        [StringLength(50)]
        public string CHARGE_NAME { get; set; }

        [StringLength(12)]
        public string CHARGE_DATA { get; set; }

        [StringLength(8)]
        public string CHARGE_TYPE { get; set; }

        [StringLength(26)]
        public string CREATE_OPERATORS { get; set; }

        [StringLength(30)]
        public string CREATE_DATE { get; set; }
    }
}
