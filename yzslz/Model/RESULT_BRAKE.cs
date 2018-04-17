namespace yzslz.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESULT_BRAKE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(4)]
        public string ZDYZJCCS { get; set; }

        [StringLength(4)]
        public string ZDEZJCCS { get; set; }

        [StringLength(4)]
        public string ZDSZJCCS { get; set; }

        [StringLength(4)]
        public string ZDSIZJCCS { get; set; }

        [StringLength(4)]
        public string ZDWZJCCS { get; set; }

        [StringLength(4)]
        public string ZDLZJCCS { get; set; }

        [StringLength(4)]
        public string ZDSZDJCCS { get; set; }

        [StringLength(4)]
        public string ZDZCJCCS { get; set; }

        [Key]
        [StringLength(50)]
        public string JCLSH { get; set; }

        [StringLength(8)]
        public string YZZLZ { get; set; }

        [StringLength(8)]
        public string YZYLZ { get; set; }

        [StringLength(8)]
        public string YZZZ { get; set; }

        [StringLength(8)]
        public string EZZLZ { get; set; }

        [StringLength(8)]
        public string EZYLZ { get; set; }

        [StringLength(8)]
        public string EZZZ { get; set; }

        [StringLength(8)]
        public string SZZLZ { get; set; }

        [StringLength(8)]
        public string SZYLZ { get; set; }

        [StringLength(8)]
        public string SZZZ { get; set; }

        [StringLength(8)]
        public string SIZZLZ { get; set; }

        [StringLength(8)]
        public string SIZYLZ { get; set; }

        [StringLength(8)]
        public string SIZZZ { get; set; }

        [StringLength(8)]
        public string WZZLZ { get; set; }

        [StringLength(8)]
        public string WZYLZ { get; set; }

        [StringLength(8)]
        public string WZZZ { get; set; }

        [StringLength(8)]
        public string LZZLZ { get; set; }

        [StringLength(8)]
        public string LZYLZ { get; set; }

        [StringLength(8)]
        public string LZZZ { get; set; }

        [StringLength(8)]
        public string YZZDTLH { get; set; }

        [StringLength(8)]
        public string YZYDTLH { get; set; }

        [StringLength(8)]
        public string YZDTLH { get; set; }

        [StringLength(8)]
        public string EZZDTLH { get; set; }

        [StringLength(8)]
        public string EZYDTLH { get; set; }

        [StringLength(8)]
        public string EZDTLH { get; set; }

        [StringLength(8)]
        public string ZCZLZ { get; set; }

        [StringLength(8)]
        public string ZCYLZ { get; set; }

        [StringLength(8)]
        public string ZCZZ { get; set; }

        [StringLength(8)]
        public string YZZZZL { get; set; }

        [StringLength(8)]
        public string YZYZZL { get; set; }

        [StringLength(8)]
        public string YZZZZLV { get; set; }

        [StringLength(8)]
        public string YZYZZLV { get; set; }

        [StringLength(4)]
        public string YZZZZL_PD { get; set; }

        [StringLength(4)]
        public string YZYZZL_PD { get; set; }

        [StringLength(4)]
        public string YZZZL_PD { get; set; }

        [StringLength(8)]
        public string EZZZZL { get; set; }

        [StringLength(8)]
        public string EZYZZL { get; set; }

        [StringLength(8)]
        public string EZZZZLV { get; set; }

        [StringLength(8)]
        public string EZYZZLV { get; set; }

        [StringLength(4)]
        public string EZZZZL_PD { get; set; }

        [StringLength(4)]
        public string EZYZZL_PD { get; set; }

        [StringLength(4)]
        public string EZZZL_PD { get; set; }

        [StringLength(8)]
        public string SZZZZL { get; set; }

        [StringLength(8)]
        public string SZYZZL { get; set; }

        [StringLength(8)]
        public string SZZZZLV { get; set; }

        [StringLength(8)]
        public string SZYZZLV { get; set; }

        [StringLength(4)]
        public string SZZZZL_PD { get; set; }

        [StringLength(4)]
        public string SZYZZL_PD { get; set; }

        [StringLength(4)]
        public string SZZZL_PD { get; set; }

        [StringLength(8)]
        public string SIZZZZL { get; set; }

        [StringLength(8)]
        public string SIZYZZL { get; set; }

        [StringLength(8)]
        public string SIZZZZLV { get; set; }

        [StringLength(8)]
        public string SIZYZZLV { get; set; }

        [StringLength(4)]
        public string SIZZZZL_PD { get; set; }

        [StringLength(4)]
        public string SIZYZZL_PD { get; set; }

        [StringLength(4)]
        public string SIZZZL_PD { get; set; }

        [StringLength(8)]
        public string WZZZZL { get; set; }

        [StringLength(8)]
        public string WZYZZL { get; set; }

        [StringLength(8)]
        public string WZZZZLV { get; set; }

        [StringLength(8)]
        public string WZYZZLV { get; set; }

        [StringLength(4)]
        public string WZZZZL_PD { get; set; }

        [StringLength(4)]
        public string WZYZZL_PD { get; set; }

        [StringLength(4)]
        public string WZZZL_PD { get; set; }

        [StringLength(8)]
        public string LZZZZL { get; set; }

        [StringLength(8)]
        public string LZYZZL { get; set; }

        [StringLength(8)]
        public string LZZZZLV { get; set; }

        [StringLength(8)]
        public string LZYZZLV { get; set; }

        [StringLength(4)]
        public string LZZZZL_PD { get; set; }

        [StringLength(4)]
        public string LZYZZL_PD { get; set; }

        [StringLength(4)]
        public string LZZZL_PD { get; set; }

        [StringLength(8)]
        public string YZZZDCZD { get; set; }

        [StringLength(8)]
        public string YZYZDCZD { get; set; }

        [StringLength(8)]
        public string YZBPHLV { get; set; }

        [StringLength(8)]
        public string YZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string EZZZDCZD { get; set; }

        [StringLength(8)]
        public string EZYZDCZD { get; set; }

        [StringLength(8)]
        public string EZBPHLV { get; set; }

        [StringLength(4)]
        public string EZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string SZZZDCZD { get; set; }

        [StringLength(8)]
        public string SZYZDCZD { get; set; }

        [StringLength(8)]
        public string SZBPHLV { get; set; }

        [StringLength(4)]
        public string SZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string SIZZZDCZD { get; set; }

        [StringLength(8)]
        public string SIZYZDCZD { get; set; }

        [StringLength(8)]
        public string SIZBPHLV { get; set; }

        [StringLength(4)]
        public string SIZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string WZZZDCZD { get; set; }

        [StringLength(8)]
        public string WZYZDCZD { get; set; }

        [StringLength(8)]
        public string WZBPHLV { get; set; }

        [StringLength(4)]
        public string WZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string LZZZDCZD { get; set; }

        [StringLength(8)]
        public string LZYZDCZD { get; set; }

        [StringLength(8)]
        public string LZBPHLV { get; set; }

        [StringLength(4)]
        public string LZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string YZZZDZDL { get; set; }

        [StringLength(8)]
        public string YZYZDZDL { get; set; }

        [StringLength(8)]
        public string YZZDLV { get; set; }

        [StringLength(4)]
        public string YZZDLV_PD { get; set; }

        [StringLength(8)]
        public string EZZZDZDL { get; set; }

        [StringLength(8)]
        public string EZYZDZDL { get; set; }

        [StringLength(8)]
        public string EZZDLV { get; set; }

        [StringLength(4)]
        public string EZZDLV_PD { get; set; }

        [StringLength(8)]
        public string SZZZDZDL { get; set; }

        [StringLength(8)]
        public string SZYZDZDL { get; set; }

        [StringLength(8)]
        public string SZZDLV { get; set; }

        [StringLength(4)]
        public string SZZDLV_PD { get; set; }

        [StringLength(8)]
        public string SIZZZDZDL { get; set; }

        [StringLength(8)]
        public string SIZYZDZDL { get; set; }

        [StringLength(8)]
        public string SIZZDLV { get; set; }

        [StringLength(4)]
        public string SIZZDLV_PD { get; set; }

        [StringLength(8)]
        public string WZZZDZDL { get; set; }

        [StringLength(8)]
        public string WZYZDZDL { get; set; }

        [StringLength(8)]
        public string WZZDLV { get; set; }

        [StringLength(4)]
        public string WZZDLV_PD { get; set; }

        [StringLength(8)]
        public string LZZZDZDL { get; set; }

        [StringLength(8)]
        public string LZYZDZDL { get; set; }

        [StringLength(8)]
        public string LZZDLV { get; set; }

        [StringLength(4)]
        public string LZZDLV_PD { get; set; }

        [StringLength(8)]
        public string YZZSZDL { get; set; }

        [StringLength(8)]
        public string YZYSZDL { get; set; }

        [StringLength(8)]
        public string YZSZDL { get; set; }

        [StringLength(8)]
        public string EZZSZDL { get; set; }

        [StringLength(8)]
        public string EZYSZDL { get; set; }

        [StringLength(8)]
        public string EZSZDL { get; set; }

        [StringLength(8)]
        public string SZZSZDL { get; set; }

        [StringLength(8)]
        public string SZYSZDL { get; set; }

        [StringLength(8)]
        public string SZSZDL { get; set; }

        [StringLength(8)]
        public string SIZZSZDL { get; set; }

        [StringLength(8)]
        public string SIZYSZDL { get; set; }

        [StringLength(8)]
        public string SIZSZDL { get; set; }

        [StringLength(8)]
        public string WZZSZDL { get; set; }

        [StringLength(8)]
        public string WZYSZDL { get; set; }

        [StringLength(8)]
        public string WZSZDL { get; set; }

        [StringLength(8)]
        public string LZZSZDL { get; set; }

        [StringLength(8)]
        public string LZYSZDL { get; set; }

        [StringLength(8)]
        public string LZSZDL { get; set; }

        [StringLength(8)]
        public string ZZSZDL { get; set; }

        [StringLength(8)]
        public string ZYSZDL { get; set; }

        [StringLength(8)]
        public string ZSZDL { get; set; }

        [StringLength(8)]
        public string ZCSZDLV { get; set; }

        [StringLength(4)]
        public string SZDLV_PD { get; set; }

        [StringLength(8)]
        public string ZCZDL { get; set; }

        [StringLength(8)]
        public string ZCZDLV { get; set; }

        [StringLength(4)]
        public string ZCZDLV_PD { get; set; }

        [StringLength(8)]
        public string YZJZZZ { get; set; }

        [StringLength(8)]
        public string EZJZZZ { get; set; }

        [StringLength(8)]
        public string SZJZZZ { get; set; }

        [StringLength(8)]
        public string SIZJZZZ { get; set; }

        [StringLength(8)]
        public string WZJZZZ { get; set; }

        [StringLength(8)]
        public string LZJZZZ { get; set; }

        [StringLength(8)]
        public string YZJZZDLV { get; set; }

        [StringLength(8)]
        public string YZJZZDLV_PD { get; set; }

        [StringLength(8)]
        public string EZJZZDLV { get; set; }

        [StringLength(8)]
        public string EZJZZDLV_PD { get; set; }

        [StringLength(8)]
        public string SZJZZDLV { get; set; }

        [StringLength(4)]
        public string SZJZZDLV_PD { get; set; }

        [StringLength(8)]
        public string SIZJZZDLV { get; set; }

        [StringLength(4)]
        public string SIZJZZDLV_PD { get; set; }

        [StringLength(8)]
        public string WZJZZDLV { get; set; }

        [StringLength(4)]
        public string WZJZZDLV_PD { get; set; }

        [StringLength(8)]
        public string LZJZZDLV { get; set; }

        [StringLength(4)]
        public string LZJZZDLV_PD { get; set; }

        [StringLength(8)]
        public string YZJZBPHLV { get; set; }

        [StringLength(4)]
        public string YZJZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string EZJZBPHLV { get; set; }

        [StringLength(4)]
        public string EZJZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string SZJZBPHLV { get; set; }

        [StringLength(4)]
        public string SZJZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string SIZJZBPHLV { get; set; }

        [StringLength(4)]
        public string SIZJZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string WZJZBPHLV { get; set; }

        [StringLength(4)]
        public string WZJZBPHLV_PD { get; set; }

        [StringLength(8)]
        public string LZJZBPHLV { get; set; }

        [StringLength(4)]
        public string LZJZBPHLV_PD { get; set; }

        [StringLength(4)]
        public string YZZDZ_PD { get; set; }

        [StringLength(4)]
        public string EZZDZ_PD { get; set; }

        [StringLength(4)]
        public string SZZDZ_PD { get; set; }

        [StringLength(4)]
        public string SIZZDZ_PD { get; set; }

        [StringLength(4)]
        public string WZZDZ_PD { get; set; }

        [StringLength(4)]
        public string LZZDZ_PD { get; set; }

        [StringLength(8)]
        public string YZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string EZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string SZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string SIZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string WZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string LZZZLVXZBZ { get; set; }

        [StringLength(8)]
        public string YZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string EZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string SZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string SIZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string WZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string LZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string YZZDLVBZ { get; set; }

        [StringLength(8)]
        public string EZZDLVBZ { get; set; }

        [StringLength(8)]
        public string SZZDLVBZ { get; set; }

        [StringLength(8)]
        public string SIZZDLVBZ { get; set; }

        [StringLength(8)]
        public string WZZDLVBZ { get; set; }

        [StringLength(8)]
        public string LZZDLVBZ { get; set; }

        [StringLength(8)]
        public string SZDLVBZ { get; set; }

        [StringLength(8)]
        public string ZCZDLVBZ { get; set; }

        [StringLength(8)]
        public string QCLCZCBZ { get; set; }

        [StringLength(4)]
        public string QCLCZC_PD { get; set; }

        [StringLength(8)]
        public string QCLCZCZDLV { get; set; }

        [StringLength(8)]
        public string ZZCZDL { get; set; }

        [StringLength(8)]
        public string YZCZDL { get; set; }

        [StringLength(8)]
        public string QZBPHLVBZ { get; set; }

        [StringLength(8)]
        public string HZBPHLVBZDY60 { get; set; }

        [StringLength(8)]
        public string HZBPHLVBZXY60 { get; set; }

        [StringLength(8)]
        public string FHTYZZZ { get; set; }

        [StringLength(8)]
        public string FHTYZZLZ { get; set; }

        [StringLength(8)]
        public string FHTYZYLZ { get; set; }

        [StringLength(8)]
        public string FHTEZZZ { get; set; }

        [StringLength(8)]
        public string FHTEZZLZ { get; set; }

        [StringLength(8)]
        public string FHTEZYLZ { get; set; }

        [StringLength(8)]
        public string FHTSZZZ { get; set; }

        [StringLength(8)]
        public string FHTSZZLZ { get; set; }

        [StringLength(8)]
        public string FHTSZYLZ { get; set; }

        [StringLength(8)]
        public string FHTSIZZZ { get; set; }

        [StringLength(8)]
        public string FHTSIZZLZ { get; set; }

        [StringLength(8)]
        public string FHTSIZYLZ { get; set; }

        [StringLength(8)]
        public string FHTWZZZ { get; set; }

        [StringLength(8)]
        public string FHTWZZLZ { get; set; }

        [StringLength(8)]
        public string FHTWZYLZ { get; set; }

        [StringLength(8)]
        public string FHTLZZZ { get; set; }

        [StringLength(8)]
        public string FHTLZZLZ { get; set; }

        [StringLength(8)]
        public string FHTLZYLZ { get; set; }

        [StringLength(8)]
        public string YZJZZDLVBZ { get; set; }

        [StringLength(8)]
        public string EZJZZDLVBZ { get; set; }

        [StringLength(8)]
        public string SZJZZDLVBZ { get; set; }

        [StringLength(8)]
        public string SIZJZZDLVBZ { get; set; }

        [StringLength(8)]
        public string WZJZZDLVBZ { get; set; }

        [StringLength(8)]
        public string LZJZZDLVBZ { get; set; }

        [StringLength(5)]
        public string YZJZBPHLVBZ { get; set; }

        [StringLength(5)]
        public string EZJZBPHLVBZ { get; set; }

        [StringLength(5)]
        public string SZJZBPHLVBZ { get; set; }

        [StringLength(5)]
        public string SIZJZBPHLVBZ { get; set; }

        [StringLength(5)]
        public string WZJZBPHLVBZ { get; set; }

        [StringLength(5)]
        public string LZJZBPHLVBZ { get; set; }

        [StringLength(12)]
        public string FHTZCZZ { get; set; }
    }
}
