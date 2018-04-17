namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CASH_CHARGE_CHECKIN
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string LSH { get; set; }

        [StringLength(20)]
        public string HPHM { get; set; }

        [StringLength(30)]
        public string HPZL { get; set; }

        [StringLength(10)]
        public string HPZLDH { get; set; }

        [StringLength(50)]
        public string CPCX { get; set; }

        [StringLength(50)]
        public string FYLX { get; set; }

        [StringLength(16)]
        public string FY { get; set; }

        [StringLength(30)]
        public string SFSJ { get; set; }

        [StringLength(30)]
        public string SFYXQ { get; set; }

        [StringLength(28)]
        public string SFY { get; set; }

        [StringLength(100)]
        public string BZ { get; set; }

        [StringLength(50)]
        public string ZFLX { get; set; }
    }
}
