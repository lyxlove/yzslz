namespace yzslz.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YModel : DbContext
    {
        public YModel()
            : base("name=YModel2")
        {
        }

        public virtual DbSet<BGD_SUGGEST> BGD_SUGGEST { get; set; }
        public virtual DbSet<CALIB_DATA> CALIB_DATA { get; set; }
        public virtual DbSet<CAMERA_INFO> CAMERA_INFO { get; set; }
        public virtual DbSet<CHARGE_INFO> CHARGE_INFO { get; set; }
        public virtual DbSet<CONST_DEFINE> CONST_DEFINE { get; set; }
        public virtual DbSet<CONST_DEFINE_WEB> CONST_DEFINE_WEB { get; set; }
        public virtual DbSet<CONST_DEFINE_WEB_CATEGORY> CONST_DEFINE_WEB_CATEGORY { get; set; }
        public virtual DbSet<DEV_INFO> DEV_INFO { get; set; }
        public virtual DbSet<DEV_STANDARD_LAMP> DEV_STANDARD_LAMP { get; set; }
        public virtual DbSet<EMPLOYEE_USER> EMPLOYEE_USER { get; set; }
        public virtual DbSet<GA_JYJG_BAXXBA> GA_JYJG_BAXXBA { get; set; }
        public virtual DbSet<GA_JYJG_GZRYGLXXBA> GA_JYJG_GZRYGLXXBA { get; set; }
        public virtual DbSet<GA_JYYXX_BAJG> GA_JYYXX_BAJG { get; set; }
        public virtual DbSet<INSPECTION_DEV_INFO> INSPECTION_DEV_INFO { get; set; }
        public virtual DbSet<INSPECTION_STATION_INFO> INSPECTION_STATION_INFO { get; set; }
        public virtual DbSet<LOG_INFO> LOG_INFO { get; set; }
        public virtual DbSet<LOGIN_VEHICLE_INFO> LOGIN_VEHICLE_INFO { get; set; }
        public virtual DbSet<NET_AJ_JK_RESULT> NET_AJ_JK_RESULT { get; set; }
        public virtual DbSet<NET_JK_RESULT> NET_JK_RESULT { get; set; }
        public virtual DbSet<PRINT_RECORD> PRINT_RECORD { get; set; }
        public virtual DbSet<PUSH_INSPECT_NO> PUSH_INSPECT_NO { get; set; }
        public virtual DbSet<RESULT_ABS> RESULT_ABS { get; set; }
        public virtual DbSet<RESULT_ANGLE> RESULT_ANGLE { get; set; }
        public virtual DbSet<RESULT_ASM> RESULT_ASM { get; set; }
        public virtual DbSet<RESULT_BRAKE> RESULT_BRAKE { get; set; }
        public virtual DbSet<RESULT_BRAKE_ZJ> RESULT_BRAKE_ZJ { get; set; }
        public virtual DbSet<RESULT_CHASISS_MANUAL> RESULT_CHASISS_MANUAL { get; set; }
        public virtual DbSet<RESULT_CHASISS_MANUAL_ZJ> RESULT_CHASISS_MANUAL_ZJ { get; set; }
        public virtual DbSet<RESULT_DOWNLINE> RESULT_DOWNLINE { get; set; }
        public virtual DbSet<RESULT_DOWNLINE_HB> RESULT_DOWNLINE_HB { get; set; }
        public virtual DbSet<RESULT_DPCG> RESULT_DPCG { get; set; }
        public virtual DbSet<RESULT_IMAGE> RESULT_IMAGE { get; set; }
        public virtual DbSet<RESULT_KERBMASS> RESULT_KERBMASS { get; set; }
        public virtual DbSet<RESULT_LAMP> RESULT_LAMP { get; set; }
        public virtual DbSet<RESULT_LAMP_ZJ> RESULT_LAMP_ZJ { get; set; }
        public virtual DbSet<RESULT_LD> RESULT_LD { get; set; }
        public virtual DbSet<RESULT_NOSIZE> RESULT_NOSIZE { get; set; }
        public virtual DbSet<RESULT_OVERALLSIZE> RESULT_OVERALLSIZE { get; set; }
        public virtual DbSet<RESULT_PROCESS_LINE> RESULT_PROCESS_LINE { get; set; }
        public virtual DbSet<RESULT_RECORD> RESULT_RECORD { get; set; }
        public virtual DbSet<RESULT_ROAD> RESULT_ROAD { get; set; }
        public virtual DbSet<RESULT_SDS> RESULT_SDS { get; set; }
        public virtual DbSet<RESULT_SIDESLIP> RESULT_SIDESLIP { get; set; }
        public virtual DbSet<RESULT_SPEAKER> RESULT_SPEAKER { get; set; }
        public virtual DbSet<RESULT_SPEED> RESULT_SPEED { get; set; }
        public virtual DbSet<RESULT_SUSPENSION> RESULT_SUSPENSION { get; set; }
        public virtual DbSet<RESULT_TAXI_MILEAGE> RESULT_TAXI_MILEAGE { get; set; }
        public virtual DbSet<RESULT_TEMP_DATA> RESULT_TEMP_DATA { get; set; }
        public virtual DbSet<RESULT_TOE_IN> RESULT_TOE_IN { get; set; }
        public virtual DbSet<RESULT_VEHICLE_INFO> RESULT_VEHICLE_INFO { get; set; }
        public virtual DbSet<RESULT_VMAS> RESULT_VMAS { get; set; }
        public virtual DbSet<RESULT_ZYJS> RESULT_ZYJS { get; set; }
        public virtual DbSet<SYSTEM_MODULE> SYSTEM_MODULE { get; set; }
        public virtual DbSet<SYSTEM_ROLE_RIGHT> SYSTEM_ROLE_RIGHT { get; set; }
        public virtual DbSet<TABLE_UNION_CONST> TABLE_UNION_CONST { get; set; }
        public virtual DbSet<TABLE_UNION_ITEM> TABLE_UNION_ITEM { get; set; }
        public virtual DbSet<TABLE_UNION_NAME> TABLE_UNION_NAME { get; set; }
        public virtual DbSet<TYPE_CX_CONTENT> TYPE_CX_CONTENT { get; set; }
        public virtual DbSet<TYPE_CX_FDJ_UNION> TYPE_CX_FDJ_UNION { get; set; }
        public virtual DbSet<TYPE_FDJ_CONTENT> TYPE_FDJ_CONTENT { get; set; }
        public virtual DbSet<VEHICLE_DISPATCH> VEHICLE_DISPATCH { get; set; }
        public virtual DbSet<WEB_SERICE_SYSLOG> WEB_SERICE_SYSLOG { get; set; }
        public virtual DbSet<CALIB_CONFIG> CALIB_CONFIG { get; set; }
        public virtual DbSet<CALIB_LOG> CALIB_LOG { get; set; }
        public virtual DbSet<CASH_CAHARE_TOTALSTD> CASH_CAHARE_TOTALSTD { get; set; }
        public virtual DbSet<CASH_CHARGE_CHECKIN> CASH_CHARGE_CHECKIN { get; set; }
        public virtual DbSet<CASH_CHARGE_DETAILED> CASH_CHARGE_DETAILED { get; set; }
        public virtual DbSet<DATA_DB_VERSION> DATA_DB_VERSION { get; set; }
        public virtual DbSet<DEV_MaintenanceRecord> DEV_MaintenanceRecord { get; set; }
        public virtual DbSet<DEV_STANDARD_ASM> DEV_STANDARD_ASM { get; set; }
        public virtual DbSet<DEV_STANDARD_BRAKE> DEV_STANDARD_BRAKE { get; set; }
        public virtual DbSet<DEV_STANDARD_BRAKE_ZJ> DEV_STANDARD_BRAKE_ZJ { get; set; }
        public virtual DbSet<DEV_STANDARD_CLASS> DEV_STANDARD_CLASS { get; set; }
        public virtual DbSet<DEV_STANDARD_DPCG> DEV_STANDARD_DPCG { get; set; }
        public virtual DbSet<DEV_STANDARD_DPCG_NEW> DEV_STANDARD_DPCG_NEW { get; set; }
        public virtual DbSet<DEV_STANDARD_KERBMASS> DEV_STANDARD_KERBMASS { get; set; }
        public virtual DbSet<DEV_STANDARD_LAMP_ZJ> DEV_STANDARD_LAMP_ZJ { get; set; }
        public virtual DbSet<DEV_STANDARD_LD> DEV_STANDARD_LD { get; set; }
        public virtual DbSet<DEV_STANDARD_NOSIZE> DEV_STANDARD_NOSIZE { get; set; }
        public virtual DbSet<DEV_STANDARD_SDS> DEV_STANDARD_SDS { get; set; }
        public virtual DbSet<DEV_STANDARD_SIDESLIP> DEV_STANDARD_SIDESLIP { get; set; }
        public virtual DbSet<DEV_STANDARD_SPEAKER> DEV_STANDARD_SPEAKER { get; set; }
        public virtual DbSet<DEV_STANDARD_SPEED> DEV_STANDARD_SPEED { get; set; }
        public virtual DbSet<DEV_STANDARD_SUSPENSION> DEV_STANDARD_SUSPENSION { get; set; }
        public virtual DbSet<DEV_STANDARD_TAXI_MILEAGE> DEV_STANDARD_TAXI_MILEAGE { get; set; }
        public virtual DbSet<DEV_STANDARD_VMAS> DEV_STANDARD_VMAS { get; set; }
        public virtual DbSet<DEV_STANDARD_ZYJS> DEV_STANDARD_ZYJS { get; set; }
        public virtual DbSet<GB_SMOKE_STANDAR> GB_SMOKE_STANDAR { get; set; }
        public virtual DbSet<INSPECTION_DEV_REG_INFO> INSPECTION_DEV_REG_INFO { get; set; }
        public virtual DbSet<INSPECTION_LINE_INFO> INSPECTION_LINE_INFO { get; set; }
        public virtual DbSet<INSPECTION_LINE_STYLE> INSPECTION_LINE_STYLE { get; set; }
        public virtual DbSet<OUTLOOK_CHASISS_SUBITEM> OUTLOOK_CHASISS_SUBITEM { get; set; }
        public virtual DbSet<PUSH_LSH_COUNT> PUSH_LSH_COUNT { get; set; }
        public virtual DbSet<SYSTEM_LANGUAGE> SYSTEM_LANGUAGE { get; set; }
        public virtual DbSet<SYSTEM_OPLOG> SYSTEM_OPLOG { get; set; }
        public virtual DbSet<WKY_DATA> WKY_DATA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BGD_SUGGEST>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<BGD_SUGGEST>()
                .Property(e => e.SuggestItems)
                .IsUnicode(false);

            modelBuilder.Entity<BGD_SUGGEST>()
                .Property(e => e.SugNextStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<BGD_SUGGEST>()
                .Property(e => e.SugNextEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.JCXH)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.DevID)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.DevName)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.DevCalibName)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.DevCalibNum)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.DevNo)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.DevCalibPot)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.EndTime)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.DYZ)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.CLZ)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.BZZ)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.JDWC)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.XDWC)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_DATA>()
                .Property(e => e.PD)
                .IsUnicode(false);

            modelBuilder.Entity<CAMERA_INFO>()
                .Property(e => e.CameraIP)
                .IsUnicode(false);

            modelBuilder.Entity<CAMERA_INFO>()
                .Property(e => e.CameraPort)
                .IsUnicode(false);

            modelBuilder.Entity<CAMERA_INFO>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<CAMERA_INFO>()
                .Property(e => e.UserPwd)
                .IsUnicode(false);

            modelBuilder.Entity<CAMERA_INFO>()
                .Property(e => e.LineNum)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.SFLSH)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.HPZL)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.SFZL)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.SFZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.TFLSH)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.SFXM)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.SFZJE)
                .HasPrecision(8, 2);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.SFY)
                .IsUnicode(false);

            modelBuilder.Entity<CHARGE_INFO>()
                .Property(e => e.SYBZ)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE>()
                .Property(e => e.CON_CHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE>()
                .Property(e => e.CON_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE>()
                .Property(e => e.CON_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE>()
                .Property(e => e.CON_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE>()
                .Property(e => e.CON_SPELL)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE>()
                .Property(e => e.CON_JCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE_WEB>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE_WEB>()
                .Property(e => e.ValueOfName)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE_WEB>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE_WEB>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE_WEB_CATEGORY>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<CONST_DEFINE_WEB_CATEGORY>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.SBRZBH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.CGJXH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.CGJSCC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.CGJCCBH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.FQYXH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.FQYSCC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.FQYCCBH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.LLJXH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.LLJSCC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.LLJCCBH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.YDJXH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.YDJSCC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_INFO>()
                .Property(e => e.YDJCCBH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.YDZDGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.EDZDGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.SDZDGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.YGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.YGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.JGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.JGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.YGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.YGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.YGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.YGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.JGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.JGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.JGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.JGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.ZGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.BIG1000JGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP>()
                .Property(e => e.BIG1000JGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_PWD)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_POWER)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_OTHER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.LICENSE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.LICENSE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.LICENSE_START_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.LICENSE_END_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_JOB)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.EMPLOYEE_ID_NO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.REG_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_USER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.jczbh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.jczmc)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.sflw)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.rdsbh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.rdyxqs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.rdyxqz)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.shejirjcnl)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.shijirjcnl)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.jcryzs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.wjgwrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.lrgwrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.ycyrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.dpgwrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.zjgwrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.qtgwrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.tgszjbmkhrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.wtgszjbmkhrs)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.fzjg)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.glbm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.gxrq)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.bz)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.shejirjcmtsl)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.shijirjcmtsl)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.shbj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.syglbm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.shyj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.zt)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.ztyy)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.dwdz)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.yzbm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.xkjyfw)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.rdsffdw)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.frdb)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.frdbsfzh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.frdblxdh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.fzr)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.fzrsfzh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.fzrlxdh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.rclxr)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.rclxrsfzh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_BAXXBA>()
                .Property(e => e.rclxrlxdh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.sfzmhm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.xm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.rylb)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.glbm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.fzjg)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.jczbh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.gxrq)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.bz)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.shbj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.shyj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.zt)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.sgzbh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.sgzyxqz)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.sgzffdw)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYJG_GZRYGLXXBA>()
                .Property(e => e.syglbm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.babh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.jyxtmc)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.jyxtsm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.bbbh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.kfdw)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.sjkbb)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.xtjgms)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.jczbh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.jcxxh)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.jcsj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.yssj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.syzt)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.ztyy)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.jbr)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.shbj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.shyj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.shr)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.shsj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.fzjg)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.glbm)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.gxsj)
                .IsUnicode(false);

            modelBuilder.Entity<GA_JYYXX_BAJG>()
                .Property(e => e.syglbm)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_INFO>()
                .Property(e => e.DevName)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_INFO>()
                .Property(e => e.DevEspName)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_INFO>()
                .Property(e => e.DevItem)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.STATION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.STATION_NO)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.STATION_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.LICENSE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.STATION_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.STATION_POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.MANAGERS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.MANAGERS_ID_NO)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.MANAGERS_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.DEV_MANAGERS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.DEV_MANAGERS_ID_NO)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.DEV_MANAGERS_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.LICENSE_SDATE)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.LICENSE_EDATE)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_STATION_INFO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.FS_Infor)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.JS_Infor)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.Log_Infor)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.FunName)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.HostName)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_INFO>()
                .Property(e => e.OpName)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.VEHICLEID)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HPZL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GLCHPHM)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JYLB)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JYLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.FDJH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.FDJXH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.FDJZZCS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DPXH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.PP)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLZZCS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.XH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.PPXH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.QDXS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.QDXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.QDZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZCZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.QZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.QZDZDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YGGSNFKT)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YGGSNFKTDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.RLLB)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.RLLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GYFS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GYFSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CCDJRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZBZL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZZL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CYS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CSYS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CSYSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZDFS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZDFSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLZL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZXZXJXS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZXZXJXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZXZLX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZXZLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZGSJCS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EDGL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EDZS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EDNJZS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EDNJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EDYH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JQFS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JQFSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.FDJPL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.FDJGS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.FDJCC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.BSXLX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.BSXLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CXXL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CXXLDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LJXSLC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LTQY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LTGG)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LTSL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SYXZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SYXZDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YYZH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SJDW)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SYR)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LXDZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YZBH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DLRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DLY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YCY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.WGJYY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DPJYY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DTDPJYY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LSJYY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SQQZR)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.WQCZY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CSC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CSK)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CSG)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SIZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.WZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SIZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SIZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SIZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.WZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.WZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.WZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CHZHQQK)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CHZHQQKDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.PQHCLZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.PQHCLZZDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JZZZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZZS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GLCJCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GLCHPZL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GLCHPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LWCXWZJL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SFSQCLC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GLCJYXM)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LWCXWZJLDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HDZH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.EDNJGL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JYXM_EX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.FWQ_ZYXZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DSBH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JCBSB)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JCBXH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JCBAZRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JCBDYJSB)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JCBDYJXH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JCBAZGS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LWLRLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LWLRHENF)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LTGGLX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.LTGGLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.QDZKZZL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCZS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HCCSXS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YWLX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.KCLXDJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YXSSZJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCYYZH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCYXSSZJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JYXM)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZJXM)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.AJXM)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.MTCSFDJSS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.MTCSFDJSSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZYWLB)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZYWLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLSSLB)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLSSLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SYRSFZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZJJYRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.BXZZRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JYYXQZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLYTDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YTSXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.BZZXS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.BZZXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.AJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.WQLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.MTLSH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.JYXM_LW)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCPZH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCLX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.QYCMZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DCZS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.XZQY)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZCLBGD)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCLBGD)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCCSC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCCSK)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCCSG)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCBZZXS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCBZZXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZJCLLX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.ZJCLLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SFSWPC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DLYSZH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SFSGSQC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLCCLX)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CLCCLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DWS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.DCZZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SYQK)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.SYQKDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.CPMC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HPYS)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HPYSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.HCCSXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.KCLXDJDH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.KCCC)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCYXXSZJ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCVIN)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCCCDJRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCCCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.GCPPXH)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YHXZ)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YHSD)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN_VEHICLE_INFO>()
                .Property(e => e.YDXZ)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.JYCS)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.LWLSH)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.LWType)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.JKName)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.JYXM)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.SendInfo)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.RevcInfo)
                .IsUnicode(false);

            modelBuilder.Entity<NET_AJ_JK_RESULT>()
                .Property(e => e.IsSuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NET_JK_RESULT>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<NET_JK_RESULT>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<NET_JK_RESULT>()
                .Property(e => e.JKID)
                .IsUnicode(false);

            modelBuilder.Entity<NET_JK_RESULT>()
                .Property(e => e.IsSuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_RECORD>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_RECORD>()
                .Property(e => e.PrintDate)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_INSPECT_NO>()
                .Property(e => e.sCode)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_INSPECT_NO>()
                .Property(e => e.sName)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_INSPECT_NO>()
                .Property(e => e.sDate)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_INSPECT_NO>()
                .Property(e => e.sValue)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ABS>()
                .Property(e => e.ABSJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ABS>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZJJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLZZJD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLYZJD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLZZJD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLYZJD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLYZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLYZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLZZXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLZZXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLYZXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.ZLYZXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLZZXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLZZXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLYZXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ANGLE>()
                .Property(e => e.YLYZXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASMJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.HC5025JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO5025JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NO5025JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.HC2540JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO2540JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NO2540JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.HC5025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO5025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NO5025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.HC2540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO2540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NO2540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.HC5025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO5025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NO5025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.HC2540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO2540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NO2540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASM_5025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASM_2540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASM_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASMWD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASMDQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASMSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASMYW)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSYW)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSHC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSCO)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSHCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSCOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSHC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSCO_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.GL5025)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.GL2540)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO25025JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO22540JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO2DSJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O25025JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O22540JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O2DSJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPM5025JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPM2540JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPMDSJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSNO)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD5025JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD2540JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMDDSJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.OBD5025CODE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.OBD2540CODE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO25025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO22540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO2DSZX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O25025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O22540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O2DSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPM5025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPM2540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPMDSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSNOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD5025XZ_MAX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD5025XZ_MIN)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD2540XZ_MAX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD2540XZ_MIN)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMDDSXZ_MAX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMDDSXZ_MIN)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.OBD5025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.OBD2540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO25025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO22540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.CO2DS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O25025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O22540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.O2DS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPM5025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPM2540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.RPMDS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.DSNO_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD5025_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMD2540_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.NMDDS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.ASM_DS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ASM>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDYZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDEZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDSZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDSIZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDWZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDLZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDSZDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZDZCJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCSZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZCZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.QCLCZCBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.QCLCZC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.QCLCZCZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.ZZCZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZCZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.QZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.HZBPHLVBZDY60)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.HZBPHLVBZXY60)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTYZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTYZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTYZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTEZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTEZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTEZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTSZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTSZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTSZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTSIZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTSIZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTSIZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTWZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTWZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTWZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTLZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTLZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTLZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.YZJZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.EZJZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SZJZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.SIZJZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.WZJZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.LZJZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE>()
                .Property(e => e.FHTZCZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDYZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDEZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDSZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDSIZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDWZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDLZJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDSZDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZDZCJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZDTLH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZYZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZYZZLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZYZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZYZDCZD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZYZDZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZYSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZSZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCSZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZJZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZJZZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZJZZDLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZJZBPHLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZJZBPHLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZCZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.QCLCZCBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.QCLCZC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.QCLCZCZDLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.ZZCZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZCZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.QZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZDY60)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZXY60)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTYZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTEZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTSZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTSIZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTWZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTLZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTYZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTYZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTEZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTEZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTSZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTSZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTSIZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTSIZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTWZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTWZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTLZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTLZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZJZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.QZBPHLVBZ_1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZDY60_1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZXY60_1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.FHTZCZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.YZJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.EZJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SZJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.SIZJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.WZJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_BRAKE_ZJ>()
                .Property(e => e.LZJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DPBJJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DTDPJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.WGJCJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.RGJYBHGX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.WGJC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.WGJCCZY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.WYXRD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.WYXRDJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.ZCGZZD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.ZCGZZJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DPBJ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DPBJCZY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DTDP_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DTDPCZY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.CLTZCSJC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.CLTZCSJCJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.AQZZJY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.AQZZJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.LWCX_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.LWCXJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DGJYBHGX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.RGJYBJCX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.WYXRD_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.CLTZCSJC_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.WGJC_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.AQZZJY_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.LWCX_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DTDP_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.DPBJ_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.BZ_CLWYXJC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.BZ_CLTZCSJC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.BZ_CLWGJC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.BZ_AQZZJC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.BZ_LWCX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.BZ_DTDPJY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL>()
                .Property(e => e.BZ_DPBJJC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DPBJJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DTDPJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WGJCJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.RGJYBHGX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WGJC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WGJCCZY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WYXRD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WYXRDJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZCGZZD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZCGZZJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DPBJ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DPBJCZY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DTDP_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DTDPCZY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.CLTZCSJC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.CLTZCSJCJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.AQZZJY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.AQZZJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.LWCX_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.LWCXJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DGJYBHGX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.LTHWSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.CSYJSS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.CSBMTZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.MCBL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DCBWGDC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZXPZDZYZDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.CXLBGD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZXPZDZYZDL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.LTHWSD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.MCBL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.CSYJSSL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DCBWGDC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.CSBMTZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.RGJYBJCX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DGJYBJCX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WYXRD_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZCGZZD_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WGJC_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.DPBJ_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.YXJC_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.HCPD_MS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.PSZDQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZDJXZDTZZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.YSKQGZHYSFLZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.XSGNXXZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.FDJCNZDMHZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.HSQHQTFZZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZDFBSZZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.ZWXLT_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.AQD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.WXDWXTCZZD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.YXJC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.HCPD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_CHASISS_MANUAL_ZJ>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.WQLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.AJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.ZJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.MTLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JCBGDBH01)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JCBGDBH02)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.HPZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.CLZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.CLZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JYLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JYLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.YWLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.ZYWLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.ZYWLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.SYR)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.AJ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.ZJ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.WQ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.QT_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.DOWNLINEDATE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JYLB_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.CLSXSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.YCY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE>()
                .Property(e => e.JCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.WQLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.AJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.ZJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.MTLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JCBGDBH01)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JCBGDBH02)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.HPZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.CLZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.CLZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JYLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JYLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.YWLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.ZYWLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.ZYWLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.SYR)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.AJ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.ZJ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.WQ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.QT_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.DOWNLINEDATE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JYLB_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.CLSXSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.YCY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DOWNLINE_HB>()
                .Property(e => e.JCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.DPCGJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGK_SDSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGK_SCGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGK_XZGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGK_LBGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGL_YXBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGL_SCBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGK_SDSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGK_SCGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGK_XZGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGK_LBGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGL_YXBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGL_SCBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.SU_SDSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.SU_JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.SU_BZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.SU_BZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.SU_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.LC_SDLC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.LC_JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.LC_XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.LC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.JS_KSSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.JS_JSSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.JS_SJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.JS_XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.JS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.HX_KSSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.HX_JSSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.HX_SJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.HX_LC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.HX_XZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.HX_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.DPCGWD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.DPCGDQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.DPCGSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_POT)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD7)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL7)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL7)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL7)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD8)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL8)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL8)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL8)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD9)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL9)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL9)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL9)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SDSD10)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_SCGL10)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_XZGL10)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.CG_LBGL10)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.ZGSD_JG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.ZGSD_BZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.ZGSD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GLGK_ZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.NJGK_ZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GK_DBGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GK_EDCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GK_JZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GK_WDCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.GK_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.YH_SCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.YH_BZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.YH_LC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.YH_SD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.YH_JZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.YH_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.DLXKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.DLXJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.RYJJXKSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_DPCG>()
                .Property(e => e.RYJJXJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_IMAGE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_IMAGE>()
                .Property(e => e.Chasiss_Image)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_IMAGE>()
                .Property(e => e.Appearance_Image)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.ZBZLJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZL1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZL2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZL3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZL4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZL5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZL6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.SCZBZLWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.ZBZL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.ZBZLXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.ZBZLXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.ZBZLJDWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_KERBMASS>()
                .Property(e => e.ZBZLXDWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGZWDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGZNDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGYNDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGYWDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZWDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZNDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YNDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YWDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGZGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGZGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.YGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.JGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.JGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.JGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.JGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.JGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.JGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.ZGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP>()
                .Property(e => e.DGZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGZWDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGZNDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGYNDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGYWDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZWDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZNDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YNDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDYGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDJGCZPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDJGSPPYL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDJGDG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDJGCZPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDJGCZPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDJGSPPY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDJGSPPY_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YWDZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGZGQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGZGQ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.YGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.ZGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.DGZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LAMP_ZJ>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.LDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GLJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GLXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.ZSJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.ZSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.ZS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GXSXS100)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GXSXS90)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GXSXS80)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GXSXSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GXSXS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.LDWD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.LDDQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.LDSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.LD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.LDYW)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.HSU100)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.HSU90)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.HSU80)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.DSZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.JSZDGLXDSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.SCZDGLXDSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.SMSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.CSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GL100)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GL90)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.GL80)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.ZS100)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.ZS90)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.ZS80)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_LD>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_NOSIZE>()
                .Property(e => e.ZYJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_NOSIZE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_NOSIZE>()
                .Property(e => e.HJZYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_NOSIZE>()
                .Property(e => e.SCZYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_NOSIZE>()
                .Property(e => e.ZYZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_NOSIZE>()
                .Property(e => e.ZYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_NOSIZE>()
                .Property(e => e.ZYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.WKCCJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCSCWKCCGD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCSCWKCCGDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCSCWKCCKD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCSCWKCCKDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCSCWKCCCD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCSCWKCCCDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCWKCC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXSCWKCCGD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXSCWKCCGDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXSCWKCCKD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXSCWKCCKDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXSCWKCCCD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXSCWKCCCDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXWKCC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.SCWKCCGDXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.SCWKCCGDXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.SCWKCCKDXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.SCWKCCKDXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.SCWKCCCDXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.SCWKCCCDXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCSCWKCCGD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCSCWKCCGDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCSCWKCCKD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCSCWKCCKDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCSCWKCCCD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCSCWKCCCDCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCWKCC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.ZCWKCCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.GCWKCCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.HXWKCCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.YQCLCC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.YQCLCK)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.YQCLCG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.QRRXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_OVERALLSIZE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_PROCESS_LINE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_PROCESS_LINE>()
                .Property(e => e.LWLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_PROCESS_LINE>()
                .Property(e => e.SerchKey)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.LWLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.DownLineTime)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.ZHJYLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.JYLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.JYLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_RECORD>()
                .Property(e => e.FJXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDCSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDPPQK)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDJL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.MFDD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDXTSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSMS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZCPD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZCJL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDSCDK)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDJLXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.MFDDXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.MFDD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDJL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSXTSJXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.LSZDXTSJ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.ZXTCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.FXTCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ROAD>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDSJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSCO)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSHC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSCO)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSHC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSCOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSHCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSCOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSHCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSCO_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSHC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSCO_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSHC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GLKQXS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GLKQXSSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GLKQXSXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GLKQXS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDSWD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDSDQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDSSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSCO2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSO2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSCO2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSO2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDSYW)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDSDSZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDSGDSZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSCOXZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSCOXZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSCOXYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSCO2XYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDSHCXYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSCOXYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSCO2XYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DSHCXYZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.SDS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.DS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.GDS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SDS>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.CHJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQCHSCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQCH_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQCHSCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQCH_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQTGSDSCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQTGSD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQTGSDSCZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQTGSD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQCHXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQCHXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQCHXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQCHXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQTGSDXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.QQTGSDXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQTGSDXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.HQTGSDXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SIDESLIP>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.SJJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.SCSJZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.SJZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.SJXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.SJXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEAKER>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SDJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SCSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SDMBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SDWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SDBZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SDBZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SD_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.SDLYLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SPEED>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.XJJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZZLJTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZZLDTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZZLXSLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZZLXSLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZYLJTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZYLDTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZYLXSLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZYLXSLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZXSLVC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZXSLVC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZZLJTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZZLDTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZZLXSLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZZLXSLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZYLJTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZYLDTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZYLXSLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZYLXSLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZXSLVC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZXSLVC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.XJ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZXSLVXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZXSLVXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZXSLVCXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.QZXSLVCXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZXSLVXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZXSLVXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZXSLVCXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.HZXSLVCXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZZLJTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZYLJTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZZLDTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZYLDTJDL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZZLXSLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZYLXSLV)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZXSLVC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZZLXSLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZYLXSLV_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZXSLVC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.SZ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_SUSPENSION>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LCBJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LCB_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.SCLC1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.SCLC2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.SCLC3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.SCLC4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.SCLC5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.SCLC6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.MBLC1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.MBLC2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.MBLC3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.MBLC4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.MBLC5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.MBLC6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.JDWC1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.JDWC2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.JDWC3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.JDWC4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.JDWC5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.JDWC6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.XDWC1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.XDWC2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.XDWC3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.XDWC4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.XDWC5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.XDWC6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LC1_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LC2_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LC3_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LC4_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LC5_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.LC6_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDZSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDJSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDZSJBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDJSSJBZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDZSJJDWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDJSSJJDWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDZSJXDWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDJSSJXDWC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDZSJ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TAXI_MILEAGE>()
                .Property(e => e.TCDDJSSJ_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp5)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp6)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp7)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp8)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp9)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp10)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp11)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp12)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp13)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp14)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp15)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp16)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp17)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp18)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp19)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TEMP_DATA>()
                .Property(e => e.Temp20)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TOE_IN>()
                .Property(e => e.QSJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_TOE_IN>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCXHMS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JYXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YJXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FJXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WQLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.AJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.MTLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBGDBH01)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBGDBH02)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HPZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GLCHPHM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JYLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JYLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FDJH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FDJXH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FDJZZCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DPXH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.PP)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLZZCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.XH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.PPXH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QDXS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QDXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QDZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZCZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QZDZDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YGGSNFKT)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YGGSNFKTDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.RLLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.RLLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GYFS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GYFSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CCDJRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZBZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CYS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CSYS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZDFS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZDFSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZXZXJXS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZXZXJXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZXZLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZXZLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZGSJCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EDGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EDZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EDNJZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EDNJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EDYH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JQFS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JQFSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FDJPL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FDJGS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FDJCC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.BSXLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.BSXLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CXXL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CXXLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LJXSLC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LTQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LTGG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LTSL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SYXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SYXZDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YYZH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SJDW)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SYR)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LXDZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DLRMC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DLRLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YZBH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DLRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLSXSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLXXSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DLY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YCY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WGJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DPJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DTDPJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LSJYY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SQQZR)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WQCZY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CSC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CSK)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CSG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SIZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SIZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SIZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SIZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CHZHQQK)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CHZHQQKDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.PQHCLZZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.PQHCLZZDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GXRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JZZZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JYXM_EX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GLCJCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GLCHPZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GLCHPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LWCXWZJL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SFSQCLC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GLCJYXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LWCXWZJLDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HDZH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.EDNJGL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.FWQ_ZYXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DSBH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBSB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBXH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBAZRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBDYJSB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBDYJXH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JCBAZGS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LWLRLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LWLRHENF)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.REPORT_JYXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LTGGLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.LTGGLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QDZKZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HCCSXS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YWLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.KCLXDJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YXSSZJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCYYZH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCYXSSZJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.MTCSFDJSS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.MTCSFDJSSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZYWLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZYWLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.AJ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZJ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WQ_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QT_Z_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.AJ_FJXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZJ_FJXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.WQ_FJXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QT_FJXM)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JYLB_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLSSLB)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLSSLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SYRSFZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZJJYRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.BXZZRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JYYXQZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLYTDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.YTSXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.BZZXS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.BZZXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.JYXM_LW)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCPZH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.QYCMZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DCZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.XZQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZCLBGD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCLBGD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCCSC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCCSK)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCCSG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCBZZXS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCBZZXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZJCLLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.ZJCLLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SFSWPC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DLYSZH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.SFSGSQC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLCCLX)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.CLCCLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.DWS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HCCSXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.KCLXDJDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.KCCC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCYXXSZJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCVIN)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCCCDJRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCCCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.GCPPXH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.Z_RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HPYS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VEHICLE_INFO>()
                .Property(e => e.HPYSDH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.VMASJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.HCJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.COJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.NOJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.HC_NOJG)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.HCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.COXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.NOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.HC_NOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.HC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.CO_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.NO_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.HC_NO_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.PDFS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.LXWCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.LJWCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.LJXXLC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.VMAS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.WD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.SD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.DQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.BJ_O2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.CL_HC)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_VMAS>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSJCCS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSJG1)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSJG2)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSJG3)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSJG4)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSPJZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJS_PD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSYW)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSDSZS)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSWD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSDQY)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.ZYJSSD)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.KSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.JSSJ)
                .IsUnicode(false);

            modelBuilder.Entity<RESULT_ZYJS>()
                .Property(e => e.SFLZS)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_MODULE>()
                .Property(e => e.mname)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_MODULE>()
                .Property(e => e.murl)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_MODULE>()
                .Property(e => e.mdisabled)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_ROLE_RIGHT>()
                .Property(e => e.role)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_ROLE_RIGHT>()
                .Property(e => e.rights)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_TABLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_FIELD_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_FIELD_CONST)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_FIELD_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_FIELD_LENTH)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_TABLE_CONST)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_PD_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.TD_PD_DESCRIP)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_CONST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_ITEM>()
                .Property(e => e.TABLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_ITEM>()
                .Property(e => e.TABLE_CONST)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_ITEM>()
                .Property(e => e.TABLE_FIELD)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_ITEM>()
                .Property(e => e.FIELD_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_ITEM>()
                .Property(e => e.FIELD_ITEM_MT)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_ITEM>()
                .Property(e => e.FIELD_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_NAME>()
                .Property(e => e.TABLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_UNION_NAME>()
                .Property(e => e.TABLE_CONST)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.CPMC)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.PP)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.XH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.PPXH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.CXDM)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SFDABS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ABSZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.QDXS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.QDZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZCZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.QZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZBZL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZZL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.HDZH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZZS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.CYS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZGSJCS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZDFS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.CLZL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZXZXJXS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZXZLX)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.BSXLX)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LTQY)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LTGG)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LTGGLX)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LTSL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.CSC)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.CSK)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.CSG)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.ZJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.BZZXS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.YZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.EZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SIZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.WZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LZLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.YZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.YZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.YZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.EZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.EZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.EZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SIZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SIZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.SIZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.WZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.WZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.WZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LZZLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LZYLZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.LZZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.QDZKZZL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.YHXZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.YHSD)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_CONTENT>()
                .Property(e => e.YDXZ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_FDJ_UNION>()
                .Property(e => e.PPZM)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_FDJ_UNION>()
                .Property(e => e.PP)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_FDJ_UNION>()
                .Property(e => e.XH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_FDJ_UNION>()
                .Property(e => e.PPXH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CX_FDJ_UNION>()
                .Property(e => e.FDJXH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.FDJXH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.FDJZZC)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.RLLB)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.GYFS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.JQFS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.EDGL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.EDZS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.EDNJZS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.EDNJ)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.EDYH)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.FDJPL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.FDJGS)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FDJ_CONTENT>()
                .Property(e => e.FDJCC)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.VEHICLEID)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JCXHMS)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.YJGWH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JYXM)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.YJXM)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.FJXM)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JCBGDBH01)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JCBGDBH02)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.HPZL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GLCHPHM)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JYLB)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JYLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.QDXS)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.QZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.YGGSNFKT)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.RLLB)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZBZL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.BSXLX)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLSXSJ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLXXSJ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.DLY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.YCY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.WGJYY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.DPJYY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.DTDPJYY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LSJYY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.SQQZR)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.WQCZY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GXRQ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JYXM_EX)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZZS)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GLCJCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GLCHPZL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GLCHPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LWCXWZJL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.SFSQCLC)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GLCJYXM)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LWCXWZJLDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.HDZH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.EDNJGL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JZZZWZ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.FWQ_ZYXZ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LWLRLSH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LWLRHENF)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LTGGLX)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LTGGLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.QDZKZZL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.WQLSH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.AJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.MTLSH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZZL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.MTCSFDJSS)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.MTCSFDJSSDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZYWLB)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZYWLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JYLB_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLSSLB)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLSSLBDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.SYRSFZ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZJJYRQ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.BXZZRQ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JYYXQZ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLYTDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.YTSXDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.JYXM_LW)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCPZH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCLX)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.QYCMZZZL)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.DCZS)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.XZQY)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZCLBGD)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCLBGD)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCCSC)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCCSK)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCCSG)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCBZZXS)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.GCBZZXSDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZJCLLX)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZJCLLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.SFSWPC)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.DLYSZH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.SFSGSQC)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLCCLX)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.CLCCLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.DLRQ)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.LED)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.SJZDYH)
                .IsUnicode(false);

            modelBuilder.Entity<VEHICLE_DISPATCH>()
                .Property(e => e.ZJPZ)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JCLSH)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.LWLSH)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JCZHDH)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.WebURL)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JCXH)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JKSBDH)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JCCS)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.VEHICLEID)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.WriteDate)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.WebCode)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.CodeName)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JCGWH)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JYXM)
                .IsUnicode(false);

            modelBuilder.Entity<WEB_SERICE_SYSLOG>()
                .Property(e => e.JCLB)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.DevID)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.DevName)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.FieldConst)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.BDZQ)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.XDWC)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.JDWC)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_CONFIG>()
                .Property(e => e.JCXH)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.CalibID)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.JCXH)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.CalibName)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.EndTime)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.DetailedData)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.ProcessPath)
                .IsUnicode(false);

            modelBuilder.Entity<CALIB_LOG>()
                .Property(e => e.ALL_PD)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME1)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME2)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME3)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME4)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME5)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME6)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME7)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME8)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME9)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME10)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME11)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME12)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CAHARE_TOTALSTD>()
                .Property(e => e.FIELD_NAME13)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.LSH)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.HPZL)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.CPCX)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.FYLX)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.FY)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.SFSJ)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.SFYXQ)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.SFY)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_CHECKIN>()
                .Property(e => e.ZFLX)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_DETAILED>()
                .Property(e => e.CHARGE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_DETAILED>()
                .Property(e => e.CHARGE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_DETAILED>()
                .Property(e => e.CHARGE_DATA)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_DETAILED>()
                .Property(e => e.CHARGE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_DETAILED>()
                .Property(e => e.CREATE_OPERATORS)
                .IsUnicode(false);

            modelBuilder.Entity<CASH_CHARGE_DETAILED>()
                .Property(e => e.CREATE_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<DATA_DB_VERSION>()
                .Property(e => e.DB_NOW_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<DATA_DB_VERSION>()
                .Property(e => e.DB_SETUP_PERSON)
                .IsUnicode(false);

            modelBuilder.Entity<DATA_DB_VERSION>()
                .Property(e => e.DB_SETUP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<DATA_DB_VERSION>()
                .Property(e => e.DB_SETUP_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<DATA_DB_VERSION>()
                .Property(e => e.DB_COMPANY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DATA_DB_VERSION>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_MaintenanceRecord>()
                .Property(e => e.JCXH)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_MaintenanceRecord>()
                .Property(e => e.DevName)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_MaintenanceRecord>()
                .Property(e => e.DevFaultComponent)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_MaintenanceRecord>()
                .Property(e => e.DevMaintenanceMode)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_MaintenanceRecord>()
                .Property(e => e.DevFaultDescription)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_MaintenanceRecord>()
                .Property(e => e.DevMaintenanceTime)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.HC5025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.CO5025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.NO5025XZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.HC2540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.CO2540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.NO2540XZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.DSHCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.DSCOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ASM>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.QZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.HZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.QZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.HZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.JZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.PBHZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.QZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.HZBPHLVBZDY60)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.HZBPHLVBZXY60)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.SZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.ZCZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.QZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.HZZZLVXZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.QZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.HZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.PBHZZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.QZBPHLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZDY60)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZXY60)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.QZBPHLVBZ_1)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZDY60_1)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.HZBPHLVBZXY60_1)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.SZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.ZCZDLVBZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_BRAKE_ZJ>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_CLASS>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_CLASS>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_CLASS>()
                .Property(e => e.BZSX1)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_CLASS>()
                .Property(e => e.BZXX1)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_CLASS>()
                .Property(e => e.BZSX2)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_CLASS>()
                .Property(e => e.BZXX2)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_CLASS>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.NJGKSDSD)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.NJGKXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.GLGKSDSD)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.GLGKXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.HXJLXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG_NEW>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG_NEW>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG_NEW>()
                .Property(e => e.GLBZXS_CLA1)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG_NEW>()
                .Property(e => e.GLBZXS_CLA2)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG_NEW>()
                .Property(e => e.YHSD)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG_NEW>()
                .Property(e => e.YHXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_DPCG_NEW>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_KERBMASS>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_KERBMASS>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_KERBMASS>()
                .Property(e => e.ZBZLXDWCXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_KERBMASS>()
                .Property(e => e.ZBZLXDWCSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_KERBMASS>()
                .Property(e => e.ZBZLJDWCXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_KERBMASS>()
                .Property(e => e.ZBZLJDWCSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_KERBMASS>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.YDZDGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.EDZDGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.SDZDGGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.YGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.YGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.JGCZPYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.JGCZPYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.YGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.YGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.YGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.YGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.JGZDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.JGZDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.JGYDZPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.JGYDYPXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.ZGQXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LAMP_ZJ>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LD>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LD>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LD>()
                .Property(e => e.GXSXSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LD>()
                .Property(e => e.GLXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LD>()
                .Property(e => e.ZSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_LD>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_NOSIZE>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_NOSIZE>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_NOSIZE>()
                .Property(e => e.ZYXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_NOSIZE>()
                .Property(e => e.ZYXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_NOSIZE>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.GDSCOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.GDSHCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.DSCOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.DSHCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.GLKQXSSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.GLKQXSXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SDS>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.QQCHXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.QQCHXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.HQCHXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.HQCHXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.TGSDXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.TGSDSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SIDESLIP>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEAKER>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEAKER>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEAKER>()
                .Property(e => e.SJXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEAKER>()
                .Property(e => e.SJXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEAKER>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEED>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEED>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEED>()
                .Property(e => e.SDBZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEED>()
                .Property(e => e.SDBZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SPEED>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.QZXSLVXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.QZXSLVXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.QZXSLVCXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.QZXSLVCXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.HZXSLVXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.HZXSLVXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.HZXSLVCXZXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.HZXSLVCXZSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_SUSPENSION>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.LCWCXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.LCWCSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.JSWCXX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.JSWCSX)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.IS_SHOW)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_TAXI_MILEAGE>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.COXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.HCXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.NOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.HC_NOXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.PDFS)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_VMAS>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ZYJS>()
                .Property(e => e.SEARCH_CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ZYJS>()
                .Property(e => e.ZXMC)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ZYJS>()
                .Property(e => e.ZYJSXZ)
                .IsUnicode(false);

            modelBuilder.Entity<DEV_STANDARD_ZYJS>()
                .Property(e => e.AREA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.QCZZC)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.CPCX)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.CLXH)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.FDJZZC)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.FDJXH)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.ZDJGL)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.XSHZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<GB_SMOKE_STANDAR>()
                .Property(e => e.CGJCBZ)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBLX)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBMC)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBMCDH)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBZZC)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBXH)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBCCBH)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBCCRQ)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBRZBH)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBRZRQ)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.SBRZYXQZ)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.JLBDBH)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.JLBDRQ)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.JLBDYXQZ)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_DEV_REG_INFO>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.LINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.JCXHMS)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.LINE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.LINE_IP)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.STA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.STA_IP)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.STA_PORT)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.STA_DEVID)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_INFO>()
                .Property(e => e.MARKID)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_STYLE>()
                .Property(e => e.ALLOW_DD_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<INSPECTION_LINE_STYLE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OUTLOOK_CHASISS_SUBITEM>()
                .Property(e => e.MNAME)
                .IsUnicode(false);

            modelBuilder.Entity<OUTLOOK_CHASISS_SUBITEM>()
                .Property(e => e.SNAME)
                .IsUnicode(false);

            modelBuilder.Entity<OUTLOOK_CHASISS_SUBITEM>()
                .Property(e => e.JUDGECLASS)
                .IsUnicode(false);

            modelBuilder.Entity<OUTLOOK_CHASISS_SUBITEM>()
                .Property(e => e.APPLYCLASS)
                .IsUnicode(false);

            modelBuilder.Entity<OUTLOOK_CHASISS_SUBITEM>()
                .Property(e => e.MITEMNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_LSH_COUNT>()
                .Property(e => e.TEST_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_LSH_COUNT>()
                .Property(e => e.LOGIN_PC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_LSH_COUNT>()
                .Property(e => e.LSH_COUNT)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_LSH_COUNT>()
                .Property(e => e.UPDATE_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<PUSH_LSH_COUNT>()
                .Property(e => e.TEST_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_LANGUAGE>()
                .Property(e => e.CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_LANGUAGE>()
                .Property(e => e.SimplifiedChinese)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_LANGUAGE>()
                .Property(e => e.TraditionalChinese)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_LANGUAGE>()
                .Property(e => e.English)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_LANGUAGE>()
                .Property(e => e.CharacterType)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_LANGUAGE>()
                .Property(e => e.ProgramName)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_OPLOG>()
                .Property(e => e.CZY)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_OPLOG>()
                .Property(e => e.CZYID)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_OPLOG>()
                .Property(e => e.CZGNMC)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_OPLOG>()
                .Property(e => e.CZNC)
                .IsUnicode(false);

            modelBuilder.Entity<SYSTEM_OPLOG>()
                .Property(e => e.CZDATE)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.HPHM)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.HPZLDH)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.AJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.ZJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.CSC)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.CSK)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.ZJ)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.ZCWKCC_PD)
                .IsUnicode(false);

            modelBuilder.Entity<WKY_DATA>()
                .Property(e => e.SYSDATE)
                .IsUnicode(false);
        }
    }
}
