namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_IMAGE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [Column(TypeName = "image")]
        public byte[] Lamp_Image { get; set; }

        [Column(TypeName = "image")]
        public byte[] Brake_Image { get; set; }

        [Column(TypeName = "image")]
        public byte[] Power_Image { get; set; }

        [StringLength(20)]
        public string Chasiss_Image { get; set; }

        [StringLength(20)]
        public string Appearance_Image { get; set; }
    }
}
