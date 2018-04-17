namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOG_INFO
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string FS_Infor { get; set; }

        [Column(TypeName = "text")]
        public string JS_Infor { get; set; }

        [Column(TypeName = "text")]
        public string Log_Infor { get; set; }

        [StringLength(50)]
        public string FunName { get; set; }

        public DateTime? LogTime { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(100)]
        public string HostName { get; set; }

        [StringLength(50)]
        public string OpName { get; set; }
    }
}
