namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAMERA_INFO
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CameraIP { get; set; }

        [StringLength(10)]
        public string CameraPort { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserPwd { get; set; }

        [StringLength(10)]
        public string LineNum { get; set; }

        public bool? IsEnabled { get; set; }
    }
}
