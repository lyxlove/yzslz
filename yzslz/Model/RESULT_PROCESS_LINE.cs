namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_PROCESS_LINE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(50)]
        public string LWLSH { get; set; }

        [StringLength(50)]
        public string SerchKey { get; set; }

        [Column(TypeName = "image")]
        public byte[] YZZDQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] EZZDQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] SZZDQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] SIZZDQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] WZZDQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] LZZDQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] ASM { get; set; }

        [Column(TypeName = "image")]
        public byte[] LUGDOWN { get; set; }

        [Column(TypeName = "image")]
        public byte[] VMAS { get; set; }

        [Column(TypeName = "image")]
        public byte[] SDS { get; set; }

        [Column(TypeName = "image")]
        public byte[] ZYJS { get; set; }

        [Column(TypeName = "image")]
        public byte[] YZZXJQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] YZYXJQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] EZZXJQX { get; set; }

        [Column(TypeName = "image")]
        public byte[] EZYXJQX { get; set; }
    }
}
