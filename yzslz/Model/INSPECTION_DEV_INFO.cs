namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INSPECTION_DEV_INFO
    {
        public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DevID { get; set; }

        [StringLength(30)]
        public string DevName { get; set; }

        [StringLength(30)]
        public string DevEspName { get; set; }

        [StringLength(100)]
        public string DevItem { get; set; }
    }
}
