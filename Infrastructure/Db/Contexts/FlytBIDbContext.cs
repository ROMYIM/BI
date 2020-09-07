using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Infrastructure.Db.Dtoes.Pg;

namespace Infrastructure.Db.Contexts
{
    public partial class FlytBIDbContext : DbContext
    {

        public FlytBIDbContext(DbContextOptions<FlytBIDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PeriodMoney> PeriodMoneys { get; set; }
        public virtual DbSet<SopId> SopIds { get; set; }
        public virtual DbSet<Abroadorderparent> Abroadorderparent { get; set; }
        public virtual DbSet<Abroadquestionhistory> Abroadquestionhistory { get; set; }
        public virtual DbSet<Abroadquestionimportlogselfreport> Abroadquestionimportlogselfreport { get; set; }
        public virtual DbSet<Abroadquestionlmportlog> Abroadquestionlmportlog { get; set; }
        public virtual DbSet<Abroadquestionmanage> Abroadquestionmanage { get; set; }
        public virtual DbSet<Abroadquestiontype> Abroadquestiontype { get; set; }
        public virtual DbSet<Accountinfo> Accountinfo { get; set; }
        public virtual DbSet<Accountinfohistory> Accountinfohistory { get; set; }
        public virtual DbSet<Accountuaccounthistory> Accountuaccounthistory { get; set; }
        public virtual DbSet<Administrativeregion> Administrativeregion { get; set; }
        public virtual DbSet<Airbatchfbadetail> Airbatchfbadetail { get; set; }
        public virtual DbSet<Airbatchfightinfo> Airbatchfightinfo { get; set; }
        public virtual DbSet<Airbatchfile> Airbatchfile { get; set; }
        public virtual DbSet<Airbatchflightinfo> Airbatchflightinfo { get; set; }
        public virtual DbSet<Airbatchorderdetail> Airbatchorderdetail { get; set; }
        public virtual DbSet<PostType> PostType { get; set; }
        public virtual DbSet<Tableidcounter> Tableidcounter { get; set; }
        public virtual DbSet<Tbcorderparent> Tbcorderparent { get; set; }
        public virtual DbSet<Templatehistory> Templatehistory { get; set; }
        public virtual DbSet<Tempprintorderhistory> Tempprintorderhistory { get; set; }
        public virtual DbSet<Tempprintrule> Tempprintrule { get; set; }
        public virtual DbSet<Tempreceive> Tempreceive { get; set; }
        public virtual DbSet<Testdate> Testdate { get; set; }
        public virtual DbSet<Testentity> Testentity { get; set; }
        public virtual DbSet<Testlststrpo> Testlststrpo { get; set; }
        public virtual DbSet<Testmid> Testmid { get; set; }
        public virtual DbSet<Testmodel> Testmodel { get; set; }
        public virtual DbSet<UserInResource> UserInResource { get; set; }
        public virtual DbSet<UserInRole> UserInRole { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserInfoAccount> UserInfoAccount { get; set; }
        public virtual DbSet<Userinfogroup> Userinfogroup { get; set; }
        public virtual DbSet<Userinfoidentity> Userinfoidentity { get; set; }
        public virtual DbSet<Usermoneylogs> Usermoneylogs { get; set; }
        public virtual DbSet<Usermoneypreparerecord> Usermoneypreparerecord { get; set; }
        public virtual DbSet<UserMoneyRecord> Usermoneyrecord { get; set; }
        public virtual DbSet<Usermoneyreturnrecord> Usermoneyreturnrecord { get; set; }
        public virtual DbSet<Usernotificationrecord> Usernotificationrecord { get; set; }
        public virtual DbSet<Userordermoneyrecord> Userordermoneyrecord { get; set; }
        public virtual DbSet<Userorderpreparemoneyrecord> Userorderpreparemoneyrecord { get; set; }
        public virtual DbSet<Userorderreturnmoneyrecord> Userorderreturnmoneyrecord { get; set; }
        public virtual DbSet<Userordertag> Userordertag { get; set; }
        public virtual DbSet<Userperiodbilldetail> Userperiodbilldetail { get; set; }
        public virtual DbSet<Userperiodbilllog> Userperiodbilllog { get; set; }
        public virtual DbSet<Userperiodbillrecord> Userperiodbillrecord { get; set; }
        public virtual DbSet<Userperiodbillsend> Userperiodbillsend { get; set; }
        public virtual DbSet<Userperiodbillsum> Userperiodbillsum { get; set; }
        public virtual DbSet<Userperiodbillsumtest> Userperiodbillsumtest { get; set; }
        public virtual DbSet<Userperiodbillsumtestnew> Userperiodbillsumtestnew { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Usersettlementperiodsendmail> Usersettlementperiodsendmail { get; set; }
        public virtual DbSet<Userverification> Userverification { get; set; }
        public virtual DbSet<Verificationorderfield> Verificationorderfield { get; set; }
        public virtual DbSet<Verificationorderrule> Verificationorderrule { get; set; }
        public virtual DbSet<Verificationorderrulebak> Verificationorderrulebak { get; set; }
        public virtual DbSet<Vocabularymapping> Vocabularymapping { get; set; }
        public virtual DbSet<Vovaonlineorder> Vovaonlineorder { get; set; }
        public virtual DbSet<Vovaonlineordercancel> Vovaonlineordercancel { get; set; }
        public virtual DbSet<Wechatintercept> Wechatintercept { get; set; }
        public virtual DbSet<Weightingset> Weightingset { get; set; }
        public virtual DbSet<Windowsservice> Windowsservice { get; set; }
        public virtual DbSet<Wishaccount> Wishaccount { get; set; }
        public virtual DbSet<Wishcarrier> Wishcarrier { get; set; }
        public virtual DbSet<Wishonlineorder> Wishonlineorder { get; set; }
        public virtual DbSet<Wishonlineordercancel> Wishonlineordercancel { get; set; }
        public virtual DbSet<Wishonlineorderquantityrecord> Wishonlineorderquantityrecord { get; set; }
        public virtual DbSet<Wishorder> Wishorder { get; set; }
        public virtual DbSet<Wishordercollection> Wishordercollection { get; set; }
        public virtual DbSet<Wishorderid> Wishorderid { get; set; }
        public virtual DbSet<Wishorderpushhistory> Wishorderpushhistory { get; set; }
        public virtual DbSet<Wishorderrelateinfo> Wishorderrelateinfo { get; set; }
        public virtual DbSet<Wishordertest> Wishordertest { get; set; }
        public virtual DbSet<Workwechatuser> Workwechatuser { get; set; }
        public virtual DbSet<Zipcode> Zipcode { get; set; }
        public virtual DbSet<Zipcoderule> Zipcoderule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=192.168.5.238;Port=5432;User ID=postgres;Password=postgres;Database=FlytBIDW");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abroadorderparent>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Abroadquestionhistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Abroadquestionimportlogselfreport>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Abroadquestionlmportlog>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Abroadquestionmanage>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Abroadquestiontype>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Accountinfo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Accountinfohistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Accountuaccounthistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Administrativeregion>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Airbatchfbadetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Airbatchfightinfo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Airbatchfile>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Airbatchflightinfo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Airbatchorderdetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tableidcounter>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tbcorderparent>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Templatehistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tempprintorderhistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tempprintrule>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tempreceive>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Testdate>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Testentity>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Testlststrpo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Testmid>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Testmodel>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.ReceiveId).HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<UserInfoAccount>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userinfogroup>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userinfoidentity>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Usermoneylogs>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Usermoneypreparerecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Usermoneyreturnrecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Usernotificationrecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userordermoneyrecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userorderpreparemoneyrecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userorderreturnmoneyrecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userordertag>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userperiodbilldetail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userperiodbilllog>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userperiodbillrecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userperiodbillsend>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userperiodbillsum>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userperiodbillsumtest>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userperiodbillsumtestnew>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Usersettlementperiodsendmail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Userverification>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Verificationorderfield>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Verificationorderrule>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Verificationorderrulebak>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Vocabularymapping>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Vovaonlineorder>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Vovaonlineordercancel>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wechatintercept>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Weightingset>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Windowsservice>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishaccount>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishcarrier>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishonlineorder>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishonlineordercancel>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishonlineorderquantityrecord>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishorder>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishordercollection>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishorderid>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishorderpushhistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishorderrelateinfo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Wishordertest>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Workwechatuser>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Zipcode>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Zipcoderule>(entity =>
            {
                entity.HasNoKey();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
