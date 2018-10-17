using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PayEntities
{
    public partial class PaySystemContext : DbContext
    {
        public PaySystemContext()
        {
        }

        public PaySystemContext(DbContextOptions<PaySystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Taccount> Taccount { get; set; }
        public virtual DbSet<Tadmin> Tadmin { get; set; }
        public virtual DbSet<TadminLoginLog> TadminLoginLog { get; set; }
        public virtual DbSet<TadminOperationLog> TadminOperationLog { get; set; }
        public virtual DbSet<Tcustomer> Tcustomer { get; set; }
        public virtual DbSet<TcustomerLoginLog> TcustomerLoginLog { get; set; }
        public virtual DbSet<TdffailureOrder> TdffailureOrder { get; set; }
        public virtual DbSet<Tdforder> Tdforder { get; set; }
        public virtual DbSet<Tdfsetting> Tdfsetting { get; set; }
        public virtual DbSet<TdfsuccessOrder> TdfsuccessOrder { get; set; }
        public virtual DbSet<TfailureOrder> TfailureOrder { get; set; }
        public virtual DbSet<Tmerchant> Tmerchant { get; set; }
        public virtual DbSet<TmerchantChannel> TmerchantChannel { get; set; }
        public virtual DbSet<TmerchantExtend> TmerchantExtend { get; set; }
        public virtual DbSet<Torder> Torder { get; set; }
        public virtual DbSet<TpaySetting> TpaySetting { get; set; }
        public virtual DbSet<Tpercentage> Tpercentage { get; set; }
        public virtual DbSet<TrefundOrder> TrefundOrder { get; set; }

        // Unable to generate entity type for table 'dbo.TSuccessOrder'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.DbConnectingString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taccount>(entity =>
            {
                entity.ToTable("TAccount");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Femai)
                    .HasColumnName("FEmai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fpassword)
                    .IsRequired()
                    .HasColumnName("FPassword")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FsecretAnswer).HasColumnName("FSecretAnswer");

                entity.Property(e => e.FsecretProblem).HasColumnName("FSecretProblem");

                entity.Property(e => e.Ftype).HasColumnName("FType");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tadmin>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TAdmin");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfirstLoginIp)
                    .HasColumnName("FFirstLoginIp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FfirstLoginTime)
                    .HasColumnName("FFirstLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FjobNumber).HasColumnName("FJobNumber");

                entity.Property(e => e.FlastLoginIp)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FlastLoginTime)
                    .HasColumnName("FLastLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TadminLoginLog>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TAdminLoginLog");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FloginIp)
                    .HasColumnName("FLoginIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TadminOperationLog>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TAdminOperationLog");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlogContent)
                    .IsRequired()
                    .HasColumnName("FLogContent")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FlogType).HasColumnName("FLogType");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tcustomer>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TCustomer");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfirstLoginIp)
                    .HasColumnName("FFirstLoginIp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FfirstLoginTime)
                    .HasColumnName("FFirstLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfullName)
                    .HasColumnName("FFullName")
                    .HasMaxLength(10);

                entity.Property(e => e.FjobNumber).HasColumnName("FJobNumber");

                entity.Property(e => e.FlastLoginIp)
                    .HasColumnName("FLastLoginIp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlastLoginTime)
                    .HasColumnName("FLastLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TcustomerLoginLog>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TCustomerLoginLog");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FloginIp)
                    .HasColumnName("FLoginIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TdffailureOrder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("TDFFailureOrder");

                entity.Property(e => e.ForderNum)
                    .HasColumnName("FOrderNum")
                    .ValueGeneratedNever();

                entity.Property(e => e.Famount)
                    .HasColumnName("FAmount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FchannelCode)
                    .IsRequired()
                    .HasColumnName("FChannelCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FchannelType).HasColumnName("FChannelType");

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfromIp)
                    .HasColumnName("FFromIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fmid).HasColumnName("FMId");

                entity.Property(e => e.FmorderNum)
                    .IsRequired()
                    .HasColumnName("FMOrderNum")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tdforder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("TDFOrder");

                entity.Property(e => e.ForderNum)
                    .HasColumnName("FOrderNum")
                    .ValueGeneratedNever();

                entity.Property(e => e.Famount)
                    .HasColumnName("FAmount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FchannelCode)
                    .IsRequired()
                    .HasColumnName("FChannelCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FchannelType).HasColumnName("FChannelType");

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfromIp)
                    .HasColumnName("FFromIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fmid).HasColumnName("FMId");

                entity.Property(e => e.FmorderNum)
                    .IsRequired()
                    .HasColumnName("FMOrderNum")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FnotifyUrl)
                    .IsRequired()
                    .HasColumnName("FNotifyUrl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Fstate).HasColumnName("FState");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tdfsetting>(entity =>
            {
                entity.ToTable("TDFSetting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Femail)
                    .HasColumnName("FEmail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Fextened)
                    .HasColumnName("FExtened")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FlastInfo)
                    .HasColumnName("FLastInfo")
                    .IsUnicode(false);

                entity.Property(e => e.FpayType).HasColumnName("FPayType");

                entity.Property(e => e.FprivateKey)
                    .HasColumnName("FPrivateKey")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.FpublicKey)
                    .HasColumnName("FPublicKey")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FredirectUrl)
                    .HasColumnName("FRedirectUrl")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Fsid)
                    .HasColumnName("FSId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TdfsuccessOrder>(entity =>
            {
                entity.HasKey(e => e.FoderNum);

                entity.ToTable("TDFSuccessOrder");

                entity.Property(e => e.FoderNum)
                    .HasColumnName("FOderNum")
                    .ValueGeneratedNever();

                entity.Property(e => e.FalipayId)
                    .HasColumnName("FAlipayId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Famount)
                    .HasColumnName("FAmount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FchannelCode)
                    .IsRequired()
                    .HasColumnName("FChannelCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FchannelType).HasColumnName("FChannelType");

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfromIp)
                    .HasColumnName("FFromIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FfrozenState).HasColumnName("FFrozenState");

                entity.Property(e => e.FfrozenTime)
                    .HasColumnName("FFrozenTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fmid).HasColumnName("FMId");

                entity.Property(e => e.FmorderNum)
                    .IsRequired()
                    .HasColumnName("FMOrderNum")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FnotifyState).HasColumnName("FNotifyState");

                entity.Property(e => e.FnotifyUrl)
                    .IsRequired()
                    .HasColumnName("FNotifyUrl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Fpercentage)
                    .HasColumnName("FPercentage")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FrefundState).HasColumnName("FRefundState");

                entity.Property(e => e.Fstate).HasColumnName("FState");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TfailureOrder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("TFailureOrder");

                entity.Property(e => e.ForderNum)
                    .HasColumnName("FOrderNum")
                    .ValueGeneratedNever();

                entity.Property(e => e.Famount)
                    .HasColumnName("FAmount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FchannelCode)
                    .IsRequired()
                    .HasColumnName("FChannelCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FchannelType).HasColumnName("FChannelType");

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfromIp)
                    .HasColumnName("FFromIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fmid).HasColumnName("FMId");

                entity.Property(e => e.FmorderNum)
                    .IsRequired()
                    .HasColumnName("FMOrderNum")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tmerchant>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TMerchant");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamountTotal)
                    .HasColumnName("FAmountTotal")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FbankAddress)
                    .HasColumnName("FBankAddress")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FbankCard)
                    .HasColumnName("FBankCard")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.FbankName)
                    .HasColumnName("FBankName")
                    .HasMaxLength(20);

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FdfuserGroup).HasColumnName("FDFUserGroup");

                entity.Property(e => e.FmerchantNumber).HasColumnName("FMerchantNumber");

                entity.Property(e => e.FpayeeName)
                    .HasColumnName("FPayeeName")
                    .HasMaxLength(20);

                entity.Property(e => e.FrecvNotifyUrl)
                    .HasColumnName("FRecvNotifyUrl")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Frsa2key)
                    .IsRequired()
                    .HasColumnName("FRSA2Key")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Fstate).HasColumnName("FState");

                entity.Property(e => e.FsyncJumpUrl).HasColumnName("FSyncJumpUrl");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FwithdrawPwd)
                    .IsRequired()
                    .HasColumnName("FWithdrawPwd")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmerchantChannel>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TMerchantChannel");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FchannelGroups)
                    .HasColumnName("FChannelGroups")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Fchannels)
                    .HasColumnName("FChannels")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fmid).HasColumnName("FMid");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TmerchantExtend>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TMerchantExtend");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Faddress)
                    .HasColumnName("FAddress")
                    .HasMaxLength(128);

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfullName)
                    .HasColumnName("FFullName")
                    .HasMaxLength(20);

                entity.Property(e => e.FgoogleSecretKey)
                    .HasColumnName("FGoogleSecretKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FidCard)
                    .HasColumnName("FId_card")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlastLoginIp)
                    .HasColumnName("FLastLoginIp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlastLoginTime)
                    .HasColumnName("FLastLoginTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fmid).HasColumnName("FMId");

                entity.Property(e => e.Fmname)
                    .IsRequired()
                    .HasColumnName("FMName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fmobile)
                    .HasColumnName("FMobile")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fmsn)
                    .HasColumnName("FMSN")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Fphone)
                    .HasColumnName("FPhone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fpostcode)
                    .HasColumnName("FPostcode")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Fqq)
                    .HasColumnName("FQQ")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Fremark)
                    .HasColumnName("FRemark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FstieUrl)
                    .HasColumnName("FStieUrl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FwithdrawPwd)
                    .IsRequired()
                    .HasColumnName("FWithdrawPwd")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Torder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("TOrder");

                entity.Property(e => e.ForderNum)
                    .HasColumnName("FOrderNum")
                    .ValueGeneratedNever();

                entity.Property(e => e.Famount)
                    .HasColumnName("FAmount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FchannelCode)
                    .IsRequired()
                    .HasColumnName("FChannelCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FchannelType).HasColumnName("FChannelType");

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfromIp)
                    .HasColumnName("FFromIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fmid).HasColumnName("FMId");

                entity.Property(e => e.FmorderNum)
                    .IsRequired()
                    .HasColumnName("FMOrderNum")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FnotifyUrl)
                    .IsRequired()
                    .HasColumnName("FNotifyUrl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Fstate).HasColumnName("FState");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TpaySetting>(entity =>
            {
                entity.ToTable("TPaySetting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Femail)
                    .HasColumnName("FEmail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Fextened)
                    .HasColumnName("FExtened")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlastInfo)
                    .HasColumnName("FLastInfo")
                    .IsUnicode(false);

                entity.Property(e => e.FpayType).HasColumnName("FPayType");

                entity.Property(e => e.FprivateKey)
                    .HasColumnName("FPrivateKey")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.FpublicKey)
                    .HasColumnName("FPublicKey")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FredirectUrl)
                    .HasColumnName("FRedirectUrl")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Fsid)
                    .HasColumnName("FSId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tpercentage>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("TPercentage");

                entity.Property(e => e.FaccountId)
                    .HasColumnName("FAccountId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FchannelType).HasColumnName("FChannelType");

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fpercentage)
                    .HasColumnName("FPercentage")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TrefundOrder>(entity =>
            {
                entity.HasKey(e => e.FoderNum);

                entity.ToTable("TRefundOrder");

                entity.Property(e => e.FoderNum)
                    .HasColumnName("FOderNum")
                    .ValueGeneratedNever();

                entity.Property(e => e.Famount)
                    .HasColumnName("FAmount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fmid).HasColumnName("FMId");

                entity.Property(e => e.FmorderNum)
                    .IsRequired()
                    .HasColumnName("FMOrderNum")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FrefundAmount)
                    .HasColumnName("FRefundAmount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FrefundCharge)
                    .HasColumnName("FRefundCharge")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FrefundType).HasColumnName("FRefundType");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });
        }
    }
}
