namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_ASM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(4)]
        public string ASMJCCS { get; set; }

        [StringLength(8)]
        public string HC5025JG { get; set; }

        [StringLength(8)]
        public string CO5025JG { get; set; }

        [StringLength(8)]
        public string NO5025JG { get; set; }

        [StringLength(8)]
        public string HC2540JG { get; set; }

        [StringLength(8)]
        public string CO2540JG { get; set; }

        [StringLength(8)]
        public string NO2540JG { get; set; }

        [StringLength(8)]
        public string HC5025XZ { get; set; }

        [StringLength(8)]
        public string CO5025XZ { get; set; }

        [StringLength(8)]
        public string NO5025XZ { get; set; }

        [StringLength(8)]
        public string HC2540XZ { get; set; }

        [StringLength(8)]
        public string CO2540XZ { get; set; }

        [StringLength(8)]
        public string NO2540XZ { get; set; }

        [StringLength(4)]
        public string HC5025_PD { get; set; }

        [StringLength(4)]
        public string CO5025_PD { get; set; }

        [StringLength(4)]
        public string NO5025_PD { get; set; }

        [StringLength(4)]
        public string HC2540_PD { get; set; }

        [StringLength(4)]
        public string CO2540_PD { get; set; }

        [StringLength(4)]
        public string NO2540_PD { get; set; }

        [StringLength(4)]
        public string ASM_5025_PD { get; set; }

        [StringLength(4)]
        public string ASM_2540_PD { get; set; }

        [StringLength(4)]
        public string ASM_PD { get; set; }

        [StringLength(8)]
        public string ASMWD { get; set; }

        [StringLength(8)]
        public string ASMDQY { get; set; }

        [StringLength(8)]
        public string ASMSD { get; set; }

        [StringLength(8)]
        public string ASMYW { get; set; }

        [StringLength(8)]
        public string DSYW { get; set; }

        [StringLength(8)]
        public string DSHC { get; set; }

        [StringLength(8)]
        public string DSCO { get; set; }

        [StringLength(8)]
        public string DSHCXZ { get; set; }

        [StringLength(8)]
        public string DSCOXZ { get; set; }

        [StringLength(8)]
        public string DSHC_PD { get; set; }

        [StringLength(8)]
        public string DSCO_PD { get; set; }

        [StringLength(8)]
        public string GL5025 { get; set; }

        [StringLength(8)]
        public string GL2540 { get; set; }

        [StringLength(8)]
        public string CO25025JG { get; set; }

        [StringLength(8)]
        public string CO22540JG { get; set; }

        [StringLength(8)]
        public string CO2DSJG { get; set; }

        [StringLength(8)]
        public string O25025JG { get; set; }

        [StringLength(8)]
        public string O22540JG { get; set; }

        [StringLength(8)]
        public string O2DSJG { get; set; }

        [StringLength(8)]
        public string RPM5025JG { get; set; }

        [StringLength(8)]
        public string RPM2540JG { get; set; }

        [StringLength(8)]
        public string RPMDSJG { get; set; }

        [StringLength(8)]
        public string DSNO { get; set; }

        [StringLength(8)]
        public string NMD5025JG { get; set; }

        [StringLength(8)]
        public string NMD2540JG { get; set; }

        [StringLength(8)]
        public string NMDDSJG { get; set; }

        [StringLength(32)]
        public string OBD5025CODE { get; set; }

        [StringLength(32)]
        public string OBD2540CODE { get; set; }

        [StringLength(8)]
        public string CO25025XZ { get; set; }

        [StringLength(8)]
        public string CO22540XZ { get; set; }

        [StringLength(8)]
        public string CO2DSZX { get; set; }

        [StringLength(8)]
        public string O25025XZ { get; set; }

        [StringLength(8)]
        public string O22540XZ { get; set; }

        [StringLength(8)]
        public string O2DSXZ { get; set; }

        [StringLength(8)]
        public string RPM5025XZ { get; set; }

        [StringLength(8)]
        public string RPM2540XZ { get; set; }

        [StringLength(8)]
        public string RPMDSXZ { get; set; }

        [StringLength(8)]
        public string DSNOXZ { get; set; }

        [StringLength(8)]
        public string NMD5025XZ_MAX { get; set; }

        [StringLength(8)]
        public string NMD5025XZ_MIN { get; set; }

        [StringLength(8)]
        public string NMD2540XZ_MAX { get; set; }

        [StringLength(8)]
        public string NMD2540XZ_MIN { get; set; }

        [StringLength(8)]
        public string NMDDSXZ_MAX { get; set; }

        [StringLength(8)]
        public string NMDDSXZ_MIN { get; set; }

        [StringLength(4)]
        public string OBD5025_PD { get; set; }

        [StringLength(4)]
        public string OBD2540_PD { get; set; }

        [StringLength(4)]
        public string CO25025_PD { get; set; }

        [StringLength(4)]
        public string CO22540_PD { get; set; }

        [StringLength(4)]
        public string CO2DS_PD { get; set; }

        [StringLength(4)]
        public string O25025_PD { get; set; }

        [StringLength(4)]
        public string O22540_PD { get; set; }

        [StringLength(4)]
        public string O2DS_PD { get; set; }

        [StringLength(4)]
        public string RPM5025_PD { get; set; }

        [StringLength(4)]
        public string RPM2540_PD { get; set; }

        [StringLength(4)]
        public string RPMDS_PD { get; set; }

        [StringLength(4)]
        public string DSNO_PD { get; set; }

        [StringLength(4)]
        public string NMD5025_PD { get; set; }

        [StringLength(4)]
        public string NMD2540_PD { get; set; }

        [StringLength(4)]
        public string NMDDS_PD { get; set; }

        [StringLength(4)]
        public string ASM_DS_PD { get; set; }

        [StringLength(20)]
        public string KSSJ { get; set; }

        [StringLength(20)]
        public string JSSJ { get; set; }
    }
}
