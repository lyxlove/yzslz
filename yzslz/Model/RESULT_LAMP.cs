namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_LAMP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string DGZWDJCCS { get; set; }

        [StringLength(4)]
        public string DGZNDJCCS { get; set; }

        [StringLength(4)]
        public string DGYNDJCCS { get; set; }

        [StringLength(4)]
        public string DGYWDJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string ZWDYGGQ { get; set; }

        [StringLength(4)]
        public string ZWDYGGQ_PD { get; set; }

        [StringLength(8)]
        public string ZWDYGCZPYL { get; set; }

        [StringLength(8)]
        public string ZWDYGSPPYL { get; set; }

        [StringLength(8)]
        public string ZWDYGDG { get; set; }

        [StringLength(8)]
        public string ZWDYGCZPY { get; set; }

        [StringLength(4)]
        public string ZWDYGCZPY_PD { get; set; }

        [StringLength(8)]
        public string ZWDYGSPPY { get; set; }

        [StringLength(4)]
        public string ZWDYGSPPY_PD { get; set; }

        [StringLength(8)]
        public string ZWDJGCZPYL { get; set; }

        [StringLength(8)]
        public string ZWDJGSPPYL { get; set; }

        [StringLength(8)]
        public string ZWDJGDG { get; set; }

        [StringLength(8)]
        public string ZWDJGCZPY { get; set; }

        [StringLength(4)]
        public string ZWDJGCZPY_PD { get; set; }

        [StringLength(8)]
        public string ZWDJGSPPY { get; set; }

        [StringLength(4)]
        public string ZWDJGSPPY_PD { get; set; }

        [StringLength(8)]
        public string ZWDZ_PD { get; set; }

        [StringLength(8)]
        public string ZNDYGGQ { get; set; }

        [StringLength(4)]
        public string ZNDYGGQ_PD { get; set; }

        [StringLength(8)]
        public string ZNDYGCZPYL { get; set; }

        [StringLength(8)]
        public string ZNDYGSPPYL { get; set; }

        [StringLength(8)]
        public string ZNDYGDG { get; set; }

        [StringLength(8)]
        public string ZNDYGCZPY { get; set; }

        [StringLength(4)]
        public string ZNDYGCZPY_PD { get; set; }

        [StringLength(8)]
        public string ZNDYGSPPY { get; set; }

        [StringLength(4)]
        public string ZNDYGSPPY_PD { get; set; }

        [StringLength(8)]
        public string ZNDJGCZPYL { get; set; }

        [StringLength(8)]
        public string ZNDJGSPPYL { get; set; }

        [StringLength(8)]
        public string ZNDJGDG { get; set; }

        [StringLength(8)]
        public string ZNDJGCZPY { get; set; }

        [StringLength(4)]
        public string ZNDJGCZPY_PD { get; set; }

        [StringLength(8)]
        public string ZNDJGSPPY { get; set; }

        [StringLength(4)]
        public string ZNDJGSPPY_PD { get; set; }

        [StringLength(8)]
        public string ZNDZ_PD { get; set; }

        [StringLength(8)]
        public string YNDYGGQ { get; set; }

        [StringLength(4)]
        public string YNDYGGQ_PD { get; set; }

        [StringLength(8)]
        public string YNDYGCZPYL { get; set; }

        [StringLength(8)]
        public string YNDYGSPPYL { get; set; }

        [StringLength(8)]
        public string YNDYGDG { get; set; }

        [StringLength(8)]
        public string YNDYGCZPY { get; set; }

        [StringLength(4)]
        public string YNDYGCZPY_PD { get; set; }

        [StringLength(8)]
        public string YNDYGSPPY { get; set; }

        [StringLength(4)]
        public string YNDYGSPPY_PD { get; set; }

        [StringLength(8)]
        public string YNDJGCZPYL { get; set; }

        [StringLength(8)]
        public string YNDJGSPPYL { get; set; }

        [StringLength(8)]
        public string YNDJGDG { get; set; }

        [StringLength(8)]
        public string YNDJGCZPY { get; set; }

        [StringLength(4)]
        public string YNDJGCZPY_PD { get; set; }

        [StringLength(8)]
        public string YNDJGSPPY { get; set; }

        [StringLength(4)]
        public string YNDJGSPPY_PD { get; set; }

        [StringLength(8)]
        public string YNDZ_PD { get; set; }

        [StringLength(8)]
        public string YWDYGGQ { get; set; }

        [StringLength(4)]
        public string YWDYGGQ_PD { get; set; }

        [StringLength(8)]
        public string YWDYGCZPYL { get; set; }

        [StringLength(8)]
        public string YWDYGSPPYL { get; set; }

        [StringLength(8)]
        public string YWDYGDG { get; set; }

        [StringLength(8)]
        public string YWDYGCZPY { get; set; }

        [StringLength(4)]
        public string YWDYGCZPY_PD { get; set; }

        [StringLength(8)]
        public string YWDYGSPPY { get; set; }

        [StringLength(4)]
        public string YWDYGSPPY_PD { get; set; }

        [StringLength(8)]
        public string YWDJGCZPYL { get; set; }

        [StringLength(8)]
        public string YWDJGSPPYL { get; set; }

        [StringLength(8)]
        public string YWDJGDG { get; set; }

        [StringLength(8)]
        public string YWDJGCZPY { get; set; }

        [StringLength(4)]
        public string YWDJGCZPY_PD { get; set; }

        [StringLength(8)]
        public string YWDJGSPPY { get; set; }

        [StringLength(4)]
        public string YWDJGSPPY_PD { get; set; }

        [StringLength(8)]
        public string YWDZ_PD { get; set; }

        [StringLength(8)]
        public string DGZGQ { get; set; }

        [StringLength(4)]
        public string DGZGQ_PD { get; set; }

        [StringLength(8)]
        public string DGGQXZ { get; set; }

        [StringLength(8)]
        public string YGCZPYXZXX { get; set; }

        [StringLength(8)]
        public string YGCZPYXZSX { get; set; }

        [StringLength(8)]
        public string YGZDZPXZ { get; set; }

        [StringLength(8)]
        public string YGZDYPXZ { get; set; }

        [StringLength(8)]
        public string YGYDZPXZ { get; set; }

        [StringLength(8)]
        public string YGYDYPXZ { get; set; }

        [StringLength(8)]
        public string JGCZPYXZXX { get; set; }

        [StringLength(8)]
        public string JGCZPYXZSX { get; set; }

        [StringLength(8)]
        public string JGZDZPXZ { get; set; }

        [StringLength(8)]
        public string JGZDYPXZ { get; set; }

        [StringLength(8)]
        public string JGYDZPXZ { get; set; }

        [StringLength(8)]
        public string JGYDYPXZ { get; set; }

        [StringLength(8)]
        public string ZGQXZ { get; set; }

        [StringLength(4)]
        public string DGZ_PD { get; set; }
    }
}
