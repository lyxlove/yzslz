namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHARGE_INFO
    {
        [Key]
        [StringLength(50)]
        public string SFLSH { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        public string JCLSH { get; set; }

        [Required]
        [StringLength(10)]
        public string HPHM { get; set; }

        [Required]
        [StringLength(30)]
        public string HPZL { get; set; }

        [Required]
        [StringLength(8)]
        public string HPZLDH { get; set; }

        [StringLength(30)]
        public string SFZL { get; set; }

        [StringLength(4)]
        public string SFZLDH { get; set; }

        [StringLength(50)]
        public string TFLSH { get; set; }

        [StringLength(30)]
        public string SFXM { get; set; }

        public decimal? SFZJE { get; set; }

        [StringLength(20)]
        public string SFY { get; set; }

        public DateTime? SFRQ { get; set; }

        [StringLength(10)]
        public string SYBZ { get; set; }

        public DateTime? SYRQ { get; set; }
    }
}
