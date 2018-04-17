namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_SUSPENSION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string XJJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string QZZLJTJDL { get; set; }

        [StringLength(8)]
        public string QZZLDTJDL { get; set; }

        [StringLength(8)]
        public string QZZLXSLV { get; set; }

        [StringLength(4)]
        public string QZZLXSLV_PD { get; set; }

        [StringLength(8)]
        public string QZYLJTJDL { get; set; }

        [StringLength(8)]
        public string QZYLDTJDL { get; set; }

        [StringLength(8)]
        public string QZYLXSLV { get; set; }

        [StringLength(4)]
        public string QZYLXSLV_PD { get; set; }

        [StringLength(8)]
        public string QZXSLVC { get; set; }

        [StringLength(4)]
        public string QZXSLVC_PD { get; set; }

        [StringLength(8)]
        public string HZZLJTJDL { get; set; }

        [StringLength(8)]
        public string HZZLDTJDL { get; set; }

        [StringLength(8)]
        public string HZZLXSLV { get; set; }

        [StringLength(4)]
        public string HZZLXSLV_PD { get; set; }

        [StringLength(8)]
        public string HZYLJTJDL { get; set; }

        [StringLength(8)]
        public string HZYLDTJDL { get; set; }

        [StringLength(8)]
        public string HZYLXSLV { get; set; }

        [StringLength(4)]
        public string HZYLXSLV_PD { get; set; }

        [StringLength(8)]
        public string HZXSLVC { get; set; }

        [StringLength(4)]
        public string HZXSLVC_PD { get; set; }

        [StringLength(4)]
        public string QZ_PD { get; set; }

        [StringLength(4)]
        public string HZ_PD { get; set; }

        [StringLength(4)]
        public string XJ_PD { get; set; }

        [StringLength(8)]
        public string QZXSLVXZXX { get; set; }

        [StringLength(8)]
        public string QZXSLVXZSX { get; set; }

        [StringLength(8)]
        public string QZXSLVCXZXX { get; set; }

        [StringLength(8)]
        public string QZXSLVCXZSX { get; set; }

        [StringLength(8)]
        public string HZXSLVXZXX { get; set; }

        [StringLength(8)]
        public string HZXSLVXZSX { get; set; }

        [StringLength(8)]
        public string HZXSLVCXZXX { get; set; }

        [StringLength(8)]
        public string HZXSLVCXZSX { get; set; }

        [StringLength(8)]
        public string SZZLJTJDL { get; set; }

        [StringLength(8)]
        public string SZYLJTJDL { get; set; }

        [StringLength(8)]
        public string SZZLDTJDL { get; set; }

        [StringLength(8)]
        public string SZYLDTJDL { get; set; }

        [StringLength(8)]
        public string SZZLXSLV { get; set; }

        [StringLength(8)]
        public string SZYLXSLV { get; set; }

        [StringLength(8)]
        public string SZXSLVC { get; set; }

        [StringLength(4)]
        public string SZZLXSLV_PD { get; set; }

        [StringLength(4)]
        public string SZYLXSLV_PD { get; set; }

        [StringLength(4)]
        public string SZXSLVC_PD { get; set; }

        [StringLength(4)]
        public string SZ_PD { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
