namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEV_MaintenanceRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(20)]
        public string JCXH { get; set; }

        [StringLength(50)]
        public string DevName { get; set; }

        [StringLength(50)]
        public string DevFaultComponent { get; set; }

        [StringLength(50)]
        public string DevMaintenanceMode { get; set; }

        [StringLength(500)]
        public string DevFaultDescription { get; set; }

        [StringLength(20)]
        public string DevMaintenanceTime { get; set; }
    }
}
