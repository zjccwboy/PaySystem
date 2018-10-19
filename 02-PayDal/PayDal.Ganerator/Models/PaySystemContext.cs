using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PayDal.Ganerator.Models
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

        public virtual DbSet<TAccount> TAccount { get; set; }
        public virtual DbSet<TAdmin> TAdmin { get; set; }
        public virtual DbSet<TAdminLoginLog> TAdminLoginLog { get; set; }
        public virtual DbSet<TAdminOperationLog> TAdminOperationLog { get; set; }
        public virtual DbSet<TChannelGroup> TChannelGroup { get; set; }
        public virtual DbSet<TCustomer> TCustomer { get; set; }
        public virtual DbSet<TCustomerLoginLog> TCustomerLoginLog { get; set; }
        public virtual DbSet<TDfFailureOrder> TDfFailureOrder { get; set; }
        public virtual DbSet<TDfOrder> TDfOrder { get; set; }
        public virtual DbSet<TDfSetting> TDfSetting { get; set; }
        public virtual DbSet<TDfSuccessOrder> TDfSuccessOrder { get; set; }
        public virtual DbSet<TFailureOrder> TFailureOrder { get; set; }
        public virtual DbSet<TMerchant> TMerchant { get; set; }
        public virtual DbSet<TMerchantChannel> TMerchantChannel { get; set; }
        public virtual DbSet<TMerchantExtend> TMerchantExtend { get; set; }
        public virtual DbSet<TNotifyTicket> TNotifyTicket { get; set; }
        public virtual DbSet<TOrder> TOrder { get; set; }
        public virtual DbSet<TPaySetting> TPaySetting { get; set; }
        public virtual DbSet<TPercentage> TPercentage { get; set; }
        public virtual DbSet<TRefundOrder> TRefundOrder { get; set; }
        public virtual DbSet<TSuccessOrder> TSuccessOrder { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.DbConnectingString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAccount>(entity =>
            {
                entity.ToTable("T_Account");

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

            modelBuilder.Entity<TAdmin>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_Admin");

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

            modelBuilder.Entity<TAdminLoginLog>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_AdminLoginLog");

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

            modelBuilder.Entity<TAdminOperationLog>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_AdminOperationLog");

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

            modelBuilder.Entity<TChannelGroup>(entity =>
            {
                entity.ToTable("T_ChannelGroup");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Fchannels)
                    .HasColumnName("FChannels")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgroupName)
                    .IsRequired()
                    .HasColumnName("FGroupName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FgroupType).HasColumnName("FGroupType");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_Customer");

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

            modelBuilder.Entity<TCustomerLoginLog>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_CustomerLoginLog");

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

            modelBuilder.Entity<TDfFailureOrder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("T_DfFailureOrder");

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

            modelBuilder.Entity<TDfOrder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("T_DfOrder");

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

            modelBuilder.Entity<TDfSetting>(entity =>
            {
                entity.ToTable("T_DfSetting");

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

            modelBuilder.Entity<TDfSuccessOrder>(entity =>
            {
                entity.HasKey(e => e.FoderNum);

                entity.ToTable("T_DfSuccessOrder");

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

            modelBuilder.Entity<TFailureOrder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("T_FailureOrder");

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

            modelBuilder.Entity<TMerchant>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_Merchant");

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

            modelBuilder.Entity<TMerchantChannel>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_MerchantChannel");

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

            modelBuilder.Entity<TMerchantExtend>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_MerchantExtend");

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

            modelBuilder.Entity<TNotifyTicket>(entity =>
            {
                entity.ToTable("T_NotifyTicket");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FcreateBy).HasColumnName("FCreateBy");

                entity.Property(e => e.FcreateTime)
                    .HasColumnName("FCreateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ForderNum).HasColumnName("FOrderNum");

                entity.Property(e => e.Fstate).HasColumnName("FState");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TOrder>(entity =>
            {
                entity.HasKey(e => e.ForderNum);

                entity.ToTable("T_Order");

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

            modelBuilder.Entity<TPaySetting>(entity =>
            {
                entity.ToTable("T_PaySetting");

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

            modelBuilder.Entity<TPercentage>(entity =>
            {
                entity.HasKey(e => e.FaccountId);

                entity.ToTable("T_Percentage");

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

            modelBuilder.Entity<TRefundOrder>(entity =>
            {
                entity.HasKey(e => e.FoderNum);

                entity.ToTable("T_RefundOrder");

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

            modelBuilder.Entity<TSuccessOrder>(entity =>
            {
                entity.HasKey(e => e.FoderNum);

                entity.ToTable("T_SuccessOrder");

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

                entity.Property(e => e.FrefundTime)
                    .HasColumnName("FRefundTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fstate).HasColumnName("FState");

                entity.Property(e => e.FupdateBy).HasColumnName("FUpdateBy");

                entity.Property(e => e.FupdateTime)
                    .HasColumnName("FUpdateTime")
                    .HasColumnType("datetime");
            });
        }
    }
}
