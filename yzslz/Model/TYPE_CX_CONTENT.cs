namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_CX_CONTENT
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CPMC { get; set; }

        [StringLength(50)]
        public string PP { get; set; }

        [StringLength(30)]
        public string XH { get; set; }

        [StringLength(80)]
        public string PPXH { get; set; }

        [StringLength(30)]
        public string CXDM { get; set; }

        [StringLength(4)]
        public string SFDABS { get; set; }

        [StringLength(10)]
        public string ABSZWZ { get; set; }

        [StringLength(30)]
        public string QDXS { get; set; }

        [StringLength(10)]
        public string QDZWZ { get; set; }

        [StringLength(10)]
        public string ZCZWZ { get; set; }

        [StringLength(15)]
        public string QZDZ { get; set; }

        [StringLength(8)]
        public string ZBZL { get; set; }

        [StringLength(8)]
        public string ZZL { get; set; }

        [StringLength(8)]
        public string HDZH { get; set; }

        [StringLength(8)]
        public string ZZS { get; set; }

        [StringLength(12)]
        public string CYS { get; set; }

        [StringLength(8)]
        public string ZGSJCS { get; set; }

        [StringLength(30)]
        public string ZDFS { get; set; }

        [StringLength(38)]
        public string CLZL { get; set; }

        [StringLength(16)]
        public string ZXZXJXS { get; set; }

        [StringLength(10)]
        public string ZXZLX { get; set; }

        [StringLength(16)]
        public string BSXLX { get; set; }

        [StringLength(12)]
        public string LTQY { get; set; }

        [StringLength(50)]
        public string LTGG { get; set; }

        [StringLength(20)]
        public string LTGGLX { get; set; }

        [StringLength(4)]
        public string LTSL { get; set; }

        [StringLength(8)]
        public string CSC { get; set; }

        [StringLength(8)]
        public string CSK { get; set; }

        [StringLength(8)]
        public string CSG { get; set; }

        [StringLength(8)]
        public string ZJ { get; set; }

        [StringLength(30)]
        public string BZZXS { get; set; }

        [StringLength(8)]
        public string YZLJ { get; set; }

        [StringLength(8)]
        public string EZLJ { get; set; }

        [StringLength(8)]
        public string SZLJ { get; set; }

        [StringLength(8)]
        public string SIZLJ { get; set; }

        [StringLength(8)]
        public string WZLJ { get; set; }

        [StringLength(8)]
        public string LZLJ { get; set; }

        [StringLength(8)]
        public string YZZLZ { get; set; }

        [StringLength(8)]
        public string YZYLZ { get; set; }

        [StringLength(8)]
        public string YZZZ { get; set; }

        [StringLength(8)]
        public string EZZLZ { get; set; }

        [StringLength(8)]
        public string EZYLZ { get; set; }

        [StringLength(8)]
        public string EZZZ { get; set; }

        [StringLength(8)]
        public string SZZLZ { get; set; }

        [StringLength(8)]
        public string SZYLZ { get; set; }

        [StringLength(8)]
        public string SZZZ { get; set; }

        [StringLength(8)]
        public string SIZZLZ { get; set; }

        [StringLength(8)]
        public string SIZYLZ { get; set; }

        [StringLength(8)]
        public string SIZZZ { get; set; }

        [StringLength(8)]
        public string WZZLZ { get; set; }

        [StringLength(8)]
        public string WZYLZ { get; set; }

        [StringLength(8)]
        public string WZZZ { get; set; }

        [StringLength(8)]
        public string LZZLZ { get; set; }

        [StringLength(8)]
        public string LZYLZ { get; set; }

        [StringLength(8)]
        public string LZZZ { get; set; }

        [StringLength(12)]
        public string QDZKZZL { get; set; }

        [StringLength(8)]
        public string YHXZ { get; set; }

        [StringLength(8)]
        public string YHSD { get; set; }

        [StringLength(8)]
        public string YDXZ { get; set; }
    }
}
