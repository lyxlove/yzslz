namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPLOYEE_USER
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string EMPLOYEE_NO { get; set; }

        [StringLength(32)]
        public string EMPLOYEE_ID { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_PWD { get; set; }

        [StringLength(100)]
        public string EMPLOYEE_POWER { get; set; }

        [StringLength(50)]
        public string EMPLOYEE_OTHER_NO { get; set; }

        [StringLength(100)]
        public string LICENSE_NAME { get; set; }

        [StringLength(40)]
        public string LICENSE_ID { get; set; }

        [StringLength(22)]
        public string LICENSE_START_DATE { get; set; }

        [StringLength(22)]
        public string LICENSE_END_DATE { get; set; }

        [StringLength(30)]
        public string EMPLOYEE_NAME { get; set; }

        [StringLength(32)]
        public string EMPLOYEE_DEPART { get; set; }

        [StringLength(32)]
        public string EMPLOYEE_JOB { get; set; }

        [StringLength(80)]
        public string EMPLOYEE_ADDRESS { get; set; }

        [StringLength(20)]
        public string EMPLOYEE_TEL { get; set; }

        [Column(TypeName = "image")]
        public byte[] EMPLOYEE_PHOTO { get; set; }

        [Column(TypeName = "image")]
        public byte[] EMPLOYEE_CODE { get; set; }

        [StringLength(30)]
        public string EMPLOYEE_ID_NO { get; set; }

        [StringLength(30)]
        public string REG_DATE { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }
    }
}
