using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Infrastructure.Db.Dtoes.Pg;

namespace Infrastructure.Db.Contexts
{
    public partial class FlytBIDbContext : DbContext
    {
        public FlytBIDbContext()
        {
        }

        public FlytBIDbContext(DbContextOptions<FlytBIDbContext> options)
            : base(options)
        {
        }

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
        public virtual DbSet<Usermoneyrecord> Usermoneyrecord { get; set; }
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

                entity.ToTable("abroadorderparent");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(255);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(255);

                entity.Property(e => e.Buyerid)
                    .HasColumnName("buyerid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Ciid)
                    .HasColumnName("ciid")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Confirmedremark)
                    .HasColumnName("confirmedremark")
                    .HasMaxLength(255);

                entity.Property(e => e.Countweight).HasColumnName("countweight");

                entity.Property(e => e.Countweightunit).HasColumnName("countweightunit");

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(255);

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Exceptionstate).HasColumnName("exceptionstate");

                entity.Property(e => e.Firstapiorderid)
                    .HasColumnName("firstapiorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Freight)
                    .HasColumnName("freight")
                    .HasMaxLength(255);

                entity.Property(e => e.Goodstype).HasColumnName("goodstype");

                entity.Property(e => e.Haikwanccode)
                    .HasColumnName("haikwanccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Haikwangtid)
                    .HasColumnName("haikwangtid")
                    .HasMaxLength(255);

                entity.Property(e => e.Haikwanproductid)
                    .HasColumnName("haikwanproductid")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasreturnedtraceid)
                    .HasColumnName("hasreturnedtraceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Importtime).HasColumnName("importtime");

                entity.Property(e => e.Inputweight).HasColumnName("inputweight");

                entity.Property(e => e.Isdeducted)
                    .HasColumnName("isdeducted")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasMaxLength(255);

                entity.Property(e => e.Isparent)
                    .HasColumnName("isparent")
                    .HasMaxLength(255);

                entity.Property(e => e.Ispaytariffs)
                    .HasColumnName("ispaytariffs")
                    .HasMaxLength(255);

                entity.Property(e => e.Isprinted)
                    .HasColumnName("isprinted")
                    .HasMaxLength(255);

                entity.Property(e => e.Isresended)
                    .HasColumnName("isresended")
                    .HasMaxLength(255);

                entity.Property(e => e.Issplit)
                    .HasColumnName("issplit")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastprinttime).HasColumnName("lastprinttime");

                entity.Property(e => e.Multipackagequantity).HasColumnName("multipackagequantity");

                entity.Property(e => e.Onlineshippingtype)
                    .HasColumnName("onlineshippingtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Onlineshopname)
                    .HasColumnName("onlineshopname")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Orderdetailsfirstsku)
                    .HasColumnName("orderdetailsfirstsku")
                    .HasMaxLength(255);

                entity.Property(e => e.Ordertype).HasColumnName("ordertype");

                entity.Property(e => e.Ordervolume).HasColumnName("ordervolume");

                entity.Property(e => e.Osid).HasColumnName("osid");

                entity.Property(e => e.Packtype).HasColumnName("packtype");

                entity.Property(e => e.Paymenttime).HasColumnName("paymenttime");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Postedtime).HasColumnName("postedtime");

                entity.Property(e => e.Processcenterid)
                    .HasColumnName("processcenterid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ptid)
                    .HasColumnName("ptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivedtime).HasColumnName("receivedtime");

                entity.Property(e => e.Receivercompany)
                    .HasColumnName("receivercompany")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivername)
                    .HasColumnName("receivername")
                    .HasMaxLength(255);

                entity.Property(e => e.Receiverstateabbreviation)
                    .HasColumnName("receiverstateabbreviation")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks0)
                    .HasColumnName("Remarks[0]")
                    .HasMaxLength(255);

                entity.Property(e => e.Rsid)
                    .HasColumnName("rsid")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesPlatformTransactionIds0)
                    .HasColumnName("SalesPlatformTransactionIds[0]")
                    .HasMaxLength(255);

                entity.Property(e => e.Salesplatformflag).HasColumnName("salesplatformflag");

                entity.Property(e => e.Salesplatformmsg)
                    .HasColumnName("salesplatformmsg")
                    .HasMaxLength(255);

                entity.Property(e => e.Salesplatformwebsit)
                    .HasColumnName("salesplatformwebsit")
                    .HasMaxLength(255);

                entity.Property(e => e.Senttime).HasColumnName("senttime");

                entity.Property(e => e.Synabroadatetime)
                    .HasColumnName("synabroadatetime")
                    .HasMaxLength(255);

                entity.Property(e => e.Syncplatformflag)
                    .HasColumnName("syncplatformflag")
                    .HasMaxLength(255);

                entity.Property(e => e.Syndomesticdatetime)
                    .HasColumnName("syndomesticdatetime")
                    .HasMaxLength(255);

                entity.Property(e => e.Taxnumber)
                    .HasColumnName("taxnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Totalprice)
                    .HasColumnName("totalprice")
                    .HasMaxLength(255);

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Transitno)
                    .HasColumnName("transitno")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Weightunit).HasColumnName("weightunit");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Abroadquestionhistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("abroadquestionhistory");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Operatename)
                    .HasColumnName("operatename")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Quentionid)
                    .HasColumnName("quentionid")
                    .HasMaxLength(255);

                entity.Property(e => e.Statename)
                    .HasColumnName("statename")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Abroadquestionimportlogselfreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("abroadquestionimportlogselfreport");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Logid)
                    .HasColumnName("logid")
                    .HasMaxLength(255);

                entity.Property(e => e.Reportdata)
                    .HasColumnName("reportdata")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<Abroadquestionlmportlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("abroadquestionlmportlog");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Errorcount).HasColumnName("errorcount");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Importcount).HasColumnName("importcount");

                entity.Property(e => e.Isselfreport)
                    .HasColumnName("isselfreport")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatename)
                    .HasColumnName("operatename")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Selfreportcount).HasColumnName("selfreportcount");
            });

            modelBuilder.Entity<Abroadquestionmanage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("abroadquestionmanage");

                entity.Property(e => e.Apiorderid)
                    .HasColumnName("apiorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Attachfilekey)
                    .HasColumnName("attachfilekey")
                    .HasMaxLength(255);

                entity.Property(e => e.Attachname)
                    .HasColumnName("attachname")
                    .HasMaxLength(255);

                entity.Property(e => e.Attachurl)
                    .HasColumnName("attachurl")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Createuserid).HasColumnName("createuserid");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Deletetime).HasColumnName("deletetime");

                entity.Property(e => e.Deleteuserid).HasColumnName("deleteuserid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Finishtime).HasColumnName("finishtime");

                entity.Property(e => e.Finishuserid).HasColumnName("finishuserid");

                entity.Property(e => e.Handler).HasMaxLength(255);

                entity.Property(e => e.Handlerid).HasColumnName("handlerid");

                entity.Property(e => e.Handletime).HasColumnName("handletime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isuploadtmall)
                    .HasColumnName("isuploadtmall")
                    .HasMaxLength(255);

                entity.Property(e => e.Logisticsnumber)
                    .HasColumnName("logisticsnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Occuetime).HasColumnName("occuetime");

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Passbackmessage)
                    .HasColumnName("passbackmessage")
                    .HasMaxLength(255);

                entity.Property(e => e.Passbacktocainiaostate).HasColumnName("passbacktocainiaostate");

                entity.Property(e => e.Platformorderid)
                    .HasColumnName("platformorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Questionsection).HasColumnName("questionsection");

                entity.Property(e => e.Questionsource).HasColumnName("questionsource");

                entity.Property(e => e.Questiontype)
                    .HasColumnName("questiontype")
                    .HasMaxLength(255);

                entity.Property(e => e.Solution)
                    .HasColumnName("solution")
                    .HasMaxLength(255);

                entity.Property(e => e.Solvehandler)
                    .HasColumnName("solvehandler")
                    .HasMaxLength(255);

                entity.Property(e => e.Solvehandlerid).HasColumnName("solvehandlerid");

                entity.Property(e => e.Solveremark)
                    .HasColumnName("solveremark")
                    .HasMaxLength(255);

                entity.Property(e => e.Solvetime).HasColumnName("solvetime");

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Abroadquestiontype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("abroadquestiontype");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Creatorid).HasColumnName("creatorid");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.Questionsection).HasColumnName("questionsection");
            });

            modelBuilder.Entity<Accountinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("accountinfo");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(255);

                entity.Property(e => e.Accounttype).HasColumnName("accounttype");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasMaxLength(255);

                entity.Property(e => e.Branchname)
                    .HasColumnName("branchname")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencyname)
                    .HasColumnName("currencyname")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdeleted)
                    .HasColumnName("isdeleted")
                    .HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivestationids)
                    .HasColumnName("receivestationids")
                    .HasColumnType("json");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Accountinfohistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("accountinfohistory");

                entity.Property(e => e.Accountinfoid)
                    .HasColumnName("accountinfoid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Logcontent)
                    .HasColumnName("logcontent")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Operatename)
                    .HasColumnName("operatename")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Accountuaccounthistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("accountuaccounthistory");

                entity.Property(e => e.Accountinfoid)
                    .HasColumnName("accountinfoid")
                    .HasMaxLength(255);

                entity.Property(e => e.Accountinfoname)
                    .HasColumnName("accountinfoname")
                    .HasMaxLength(255);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Administrativeregion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("administrativeregion");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryid)
                    .HasColumnName("countryid")
                    .HasMaxLength(255);

                entity.Property(e => e.Distrcttown)
                    .HasColumnName("distrcttown")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Airbatchfbadetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("airbatchfbadetail");

                entity.Property(e => e.Airbatchid)
                    .HasColumnName("airbatchid")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataversion)
                    .HasColumnName("dataversion")
                    .HasMaxLength(255);

                entity.Property(e => e.Deliverytime)
                    .HasColumnName("deliverytime")
                    .HasMaxLength(255);

                entity.Property(e => e.Destinationcountry)
                    .HasColumnName("destinationcountry")
                    .HasMaxLength(255);

                entity.Property(e => e.Fbashipmentid)
                    .HasColumnName("fbashipmentid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Pkg)
                    .HasColumnName("pkg")
                    .HasMaxLength(255);

                entity.Property(e => e.Postingcountry)
                    .HasColumnName("postingcountry")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypeid)
                    .HasColumnName("posttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sendtime).HasColumnName("sendtime");

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Airbatchfightinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("airbatchfightinfo");

                entity.Property(e => e.Airbatchid)
                    .HasColumnName("airbatchid")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Deliverytime)
                    .HasColumnName("deliverytime")
                    .HasMaxLength(255);

                entity.Property(e => e.Destinationcountry)
                    .HasColumnName("destinationcountry")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Pkg)
                    .HasColumnName("pkg")
                    .HasMaxLength(255);

                entity.Property(e => e.Postingcountry)
                    .HasColumnName("postingcountry")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypeid)
                    .HasColumnName("posttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivetime).HasColumnName("receivetime");

                entity.Property(e => e.Sendtime).HasColumnName("sendtime");

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Airbatchfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("airbatchfile");

                entity.Property(e => e.Airbatchid)
                    .HasColumnName("airbatchid")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(255);

                entity.Property(e => e.Filekey)
                    .HasColumnName("filekey")
                    .HasMaxLength(255);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Airbatchflightinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("airbatchflightinfo");

                entity.Property(e => e.Airlinemark)
                    .HasColumnName("airlinemark")
                    .HasMaxLength(255);

                entity.Property(e => e.Batchno)
                    .HasColumnName("batchno")
                    .HasMaxLength(255);

                entity.Property(e => e.Batchweight)
                    .HasColumnName("batchweight")
                    .HasMaxLength(255);

                entity.Property(e => e.Collecttime).HasColumnName("collecttime");

                entity.Property(e => e.Departurecity)
                    .HasColumnName("departurecity")
                    .HasMaxLength(255);

                entity.Property(e => e.Destinationcity)
                    .HasColumnName("destinationcity")
                    .HasMaxLength(255);

                entity.Property(e => e.Eventtime)
                    .HasColumnName("eventtime")
                    .HasMaxLength(255);

                entity.Property(e => e.Flightnumber)
                    .HasColumnName("flightnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.Quantities)
                    .HasColumnName("quantities")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Serialno).HasColumnName("serialno");

                entity.Property(e => e.Station)
                    .HasColumnName("station")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.Totalweight)
                    .HasColumnName("totalweight")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");
            });

            modelBuilder.Entity<Airbatchorderdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("airbatchorderdetail");

                entity.Property(e => e.Airbatchid)
                    .HasColumnName("airbatchid")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Deliverytime)
                    .HasColumnName("deliverytime")
                    .HasMaxLength(255);

                entity.Property(e => e.Destinationcountry)
                    .HasColumnName("destinationcountry")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Pkg)
                    .HasColumnName("pkg")
                    .HasMaxLength(255);

                entity.Property(e => e.Postingcountry)
                    .HasColumnName("postingcountry")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypeid)
                    .HasColumnName("posttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivetime).HasColumnName("receivetime");

                entity.Property(e => e.Sendtime).HasColumnName("sendtime");

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Tableidcounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tableidcounter");

                entity.Property(e => e.Countertype)
                    .HasColumnName("countertype")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Maxquantities)
                    .HasColumnName("maxquantities")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Staticsdate)
                    .HasColumnName("staticsdate")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tbcorderparent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbcorderparent");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(255);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(255);

                entity.Property(e => e.Apiorderids)
                    .HasColumnName("apiorderids")
                    .HasColumnType("json");

                entity.Property(e => e.Buyerid)
                    .HasColumnName("buyerid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Ciid)
                    .HasColumnName("ciid")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Confirmedremark)
                    .HasColumnName("confirmedremark")
                    .HasMaxLength(255);

                entity.Property(e => e.Countweight).HasColumnName("countweight");

                entity.Property(e => e.Countweightunit).HasColumnName("countweightunit");

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(255);

                entity.Property(e => e.Deliverytype).HasColumnName("deliverytype");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Freight)
                    .HasColumnName("freight")
                    .HasMaxLength(255);

                entity.Property(e => e.Goodstype).HasColumnName("goodstype");

                entity.Property(e => e.Haikwanccode)
                    .HasColumnName("haikwanccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Haikwandetiallist)
                    .HasColumnName("haikwandetiallist")
                    .HasColumnType("json");

                entity.Property(e => e.Haikwangtid)
                    .HasColumnName("haikwangtid")
                    .HasMaxLength(255);

                entity.Property(e => e.Haikwanproductid)
                    .HasColumnName("haikwanproductid")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasreturnedtraceid).HasColumnName("hasreturnedtraceid");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Importtime).HasColumnName("importtime");

                entity.Property(e => e.Inputweight).HasColumnName("inputweight");

                entity.Property(e => e.Iscancel)
                    .HasColumnName("iscancel")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdeducted).HasColumnName("isdeducted");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.Isparent).HasColumnName("isparent");

                entity.Property(e => e.Ispassverification).HasColumnName("ispassverification");

                entity.Property(e => e.Ispaytariffs).HasColumnName("ispaytariffs");

                entity.Property(e => e.Isprinted).HasColumnName("isprinted");

                entity.Property(e => e.Issplit).HasColumnName("issplit");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Multipackagequantity).HasColumnName("multipackagequantity");

                entity.Property(e => e.Onlineshippingtype)
                    .HasColumnName("onlineshippingtype")
                    .HasMaxLength(255);

                entity.Property(e => e.Onlineshopname)
                    .HasColumnName("onlineshopname")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Orderdetailist)
                    .HasColumnName("orderdetailist")
                    .HasColumnType("json");

                entity.Property(e => e.Orderdetailsfirstsku)
                    .HasColumnName("orderdetailsfirstsku")
                    .HasMaxLength(255);

                entity.Property(e => e.Ordertype).HasColumnName("ordertype");

                entity.Property(e => e.Ordervolume).HasColumnName("ordervolume");

                entity.Property(e => e.Osid).HasColumnName("osid");

                entity.Property(e => e.Packtype).HasColumnName("packtype");

                entity.Property(e => e.Paymenttime).HasColumnName("paymenttime");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Postedtime).HasColumnName("postedtime");

                entity.Property(e => e.Processcenterid)
                    .HasColumnName("processcenterid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ptid)
                    .HasColumnName("ptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivedtime).HasColumnName("receivedtime");

                entity.Property(e => e.Receiverandshopmergemd5)
                    .HasColumnName("receiverandshopmergemd5")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivermergemd5)
                    .HasColumnName("receivermergemd5")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivername)
                    .HasColumnName("receivername")
                    .HasMaxLength(255);

                entity.Property(e => e.Receiverstateabbreviation)
                    .HasColumnName("receiverstateabbreviation")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("json");

                entity.Property(e => e.Rsid)
                    .HasColumnName("rsid")
                    .HasMaxLength(255);

                entity.Property(e => e.Salesplatformflag).HasColumnName("salesplatformflag");

                entity.Property(e => e.Salesplatformmsg)
                    .HasColumnName("salesplatformmsg")
                    .HasMaxLength(255);

                entity.Property(e => e.Salesplatformtransactionids)
                    .HasColumnName("salesplatformtransactionids")
                    .HasColumnType("json");

                entity.Property(e => e.Salesplatformwebsit)
                    .HasColumnName("salesplatformwebsit")
                    .HasMaxLength(255);

                entity.Property(e => e.Salesrecordnumbers)
                    .HasColumnName("salesrecordnumbers")
                    .HasColumnType("json");

                entity.Property(e => e.Senttime).HasColumnName("senttime");

                entity.Property(e => e.Syncplatformflag)
                    .HasColumnName("syncplatformflag")
                    .HasMaxLength(255);

                entity.Property(e => e.Taxnumber)
                    .HasColumnName("taxnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Tbcordercheckinfos)
                    .HasColumnName("tbcordercheckinfos")
                    .HasColumnType("json");

                entity.Property(e => e.Tbcordercheckinfos1)
                    .HasColumnName("_tbcordercheckinfos")
                    .HasColumnType("json");

                entity.Property(e => e.Totalprice)
                    .HasColumnName("totalprice")
                    .HasMaxLength(255);

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Weightunit).HasColumnName("weightunit");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Templatehistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("templatehistory");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(255);

                entity.Property(e => e.Originjsontemplate)
                    .HasColumnName("originjsontemplate")
                    .HasMaxLength(255);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(255);

                entity.Property(e => e.Templateid).HasColumnName("templateid");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Xmltemplate)
                    .HasColumnName("xmltemplate")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tempprintorderhistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempprintorderhistory");

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Newchanneltraceid)
                    .HasColumnName("newchanneltraceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Oldchanneltraceid)
                    .HasColumnName("oldchanneltraceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatename)
                    .HasColumnName("operatename")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Tracknumber)
                    .HasColumnName("tracknumber")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tempprintrule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempprintrule");

                entity.Property(e => e.Countrys)
                    .HasColumnName("countrys")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Creatorid).HasColumnName("creatorid");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isgettargettracknumber)
                    .HasColumnName("isgettargettracknumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.Originalchannelids)
                    .HasColumnName("originalchannelids")
                    .HasColumnType("json");

                entity.Property(e => e.Rulename)
                    .HasColumnName("rulename")
                    .HasMaxLength(255);

                entity.Property(e => e.Targetchannelid)
                    .HasColumnName("targetchannelid")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tempreceive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempreceive");

                entity.Property(e => e.Auid).HasColumnName("auid");

                entity.Property(e => e.Begindate).HasColumnName("begindate");

                entity.Property(e => e.Createdatetime).HasColumnName("createdatetime");

                entity.Property(e => e.Creator).HasColumnName("creator");

                entity.Property(e => e.Delflag).HasColumnName("delflag");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Trflag).HasColumnName("trflag");

                entity.Property(e => e.Uiid)
                    .HasColumnName("uiid")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Testdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testdate");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Testdatefield).HasColumnName("testdatefield");
            });

            modelBuilder.Entity<Testentity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testentity");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Cardfilename)
                    .HasColumnName("cardfilename")
                    .HasMaxLength(255);

                entity.Property(e => e.Cardnumber)
                    .HasColumnName("cardnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasMaxLength(255);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(255);

                entity.Property(e => e.Creditrating).HasColumnName("creditrating");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Enname)
                    .HasColumnName("enname")
                    .HasMaxLength(255);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(255);

                entity.Property(e => e.Fuid)
                    .HasColumnName("fuid")
                    .HasMaxLength(255);

                entity.Property(e => e.Groups)
                    .HasColumnName("groups")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Id1)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Idctid)
                    .HasColumnName("idctid")
                    .HasMaxLength(255);

                entity.Property(e => e.Linkman)
                    .HasColumnName("linkman")
                    .HasMaxLength(255);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(255);

                entity.Property(e => e.Msnqq)
                    .HasColumnName("msnqq")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Opendate)
                    .HasColumnName("opendate")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Passwd)
                    .HasColumnName("passwd")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Puaccount)
                    .HasColumnName("puaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Receiveid)
                    .HasColumnName("receiveid")
                    .HasMaxLength(255);

                entity.Property(e => e.Regtime).HasColumnName("regtime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasMaxLength(255);

                entity.Property(e => e.Stateflag).HasColumnName("stateflag");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(255);

                entity.Property(e => e.Tokenexpiretime).HasColumnName("tokenexpiretime");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(255);

                entity.Property(e => e.Uiid)
                    .HasColumnName("uiid")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Utype).HasColumnName("utype");

                entity.Property(e => e.Zhname)
                    .HasColumnName("zhname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Testlststrpo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testlststrpo");

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Names)
                    .HasColumnName("names")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<Testmid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testmid");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Names)
                    .HasColumnName("names")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Testmodel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testmodel");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<UserInResource>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Resources).HasColumnType("json");

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<UserInRole>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.RoleId).HasColumnType("json");

                entity.Property(e => e.UserId).HasMaxLength(255);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("_Id")
                    .HasMaxLength(255);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AuditOperatorId).HasMaxLength(255);

                entity.Property(e => e.AuditState).HasMaxLength(255);

                entity.Property(e => e.AuthenticationType).HasMaxLength(255);

                entity.Property(e => e.CardFilename).HasMaxLength(255);

                entity.Property(e => e.CardNumber).HasMaxLength(255);

                entity.Property(e => e.CertifyFileKey).HasMaxLength(255);

                entity.Property(e => e.CertifyFileName).HasMaxLength(255);

                entity.Property(e => e.Cid)
                    .HasColumnName("CId")
                    .HasMaxLength(255);

                entity.Property(e => e.Cname)
                    .HasColumnName("CName")
                    .HasMaxLength(255);

                entity.Property(e => e.Competitor).HasMaxLength(255);

                entity.Property(e => e.ContactServiceUid).HasMaxLength(255);

                entity.Property(e => e.CreditRating).HasMaxLength(255);

                entity.Property(e => e.CtId).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EnName).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.FlytProduct).HasMaxLength(255);

                entity.Property(e => e.FuId).HasMaxLength(255);

                entity.Property(e => e.Groups).HasColumnType("json");

                entity.Property(e => e.IdctId).HasMaxLength(255);

                entity.Property(e => e.IsNeedVatinvoice).HasColumnName("IsNeedVATInvoice");

                entity.Property(e => e.LinkMan).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.MsnQq).HasMaxLength(255);

                entity.Property(e => e.OpenDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.OperateDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.Passwd).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PlatformFlags).HasMaxLength(255);

                entity.Property(e => e.ProductsTypes).HasMaxLength(255);

                entity.Property(e => e.Puaccount)
                    .HasColumnName("PUaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.ReceiveId)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Regtime).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.Rid)
                    .HasColumnName("RId")
                    .HasMaxLength(255);

                entity.Property(e => e.SignCompanyId).HasMaxLength(255);

                entity.Property(e => e.Token).HasMaxLength(255);

                entity.Property(e => e.TokenExpireTime).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UiId).HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnName("UId")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.Property(e => e.Utype)
                    .HasColumnName("UType")
                    .HasMaxLength(255);

                entity.Property(e => e.ZhName).HasMaxLength(255);
            });

            modelBuilder.Entity<UserInfoAccount>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaid).HasMaxLength(255);
            });

            modelBuilder.Entity<Userinfogroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userinfogroup");

                entity.Property(e => e.Delflag)
                    .HasColumnName("delflag")
                    .HasMaxLength(255);

                entity.Property(e => e.Gname)
                    .HasColumnName("gname")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatedate)
                    .HasColumnName("operatedate")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userinfoidentity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userinfoidentity");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityname)
                    .HasColumnName("identityname")
                    .HasMaxLength(255);

                entity.Property(e => e.Identityno)
                    .HasColumnName("identityno")
                    .HasMaxLength(255);

                entity.Property(e => e.Identitytype)
                    .HasColumnName("identitytype")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime)
                    .HasColumnName("operatetime")
                    .HasColumnType("timestamp(6) without time zone");
            });

            modelBuilder.Entity<Usermoneylogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usermoneylogs");

                entity.Property(e => e.Computername)
                    .HasColumnName("computername")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.Objectid)
                    .HasColumnName("objectid")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Serviceip)
                    .HasColumnName("serviceip")
                    .HasMaxLength(255);

                entity.Property(e => e.Times).HasColumnName("times");
            });

            modelBuilder.Entity<Usermoneypreparerecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usermoneypreparerecord");

                entity.Property(e => e.Accountsrepaygroupid)
                    .HasColumnName("accountsrepaygroupid")
                    .HasMaxLength(255);

                entity.Property(e => e.Apiorderid)
                    .HasColumnName("apiorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Aubalancedate)
                    .HasColumnName("aubalancedate")
                    .HasMaxLength(255);

                entity.Property(e => e.Balancecycle)
                    .HasColumnName("balancecycle")
                    .HasMaxLength(255);

                entity.Property(e => e.Balancedate)
                    .HasColumnName("balancedate")
                    .HasMaxLength(255);

                entity.Property(e => e.Bauserid)
                    .HasColumnName("bauserid")
                    .HasMaxLength(255);

                entity.Property(e => e.Buserid)
                    .HasColumnName("buserid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode1)
                    .HasColumnName("ccode_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Chargebackplatform).HasColumnName("chargebackplatform");

                entity.Property(e => e.Chargeclass).HasColumnName("chargeclass");

                entity.Property(e => e.Ciid)
                    .HasColumnName("ciid")
                    .HasMaxLength(255);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(255);

                entity.Property(e => e.Costmoney)
                    .HasColumnName("costmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Costposttypename)
                    .HasColumnName("costposttypename")
                    .HasMaxLength(255);

                entity.Property(e => e.Costprice).HasColumnName("costprice");

                entity.Property(e => e.Costptid)
                    .HasColumnName("costptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Countinfor)
                    .HasColumnName("countinfor")
                    .HasMaxLength(255);

                entity.Property(e => e.Dan)
                    .HasColumnName("dan")
                    .HasMaxLength(255);

                entity.Property(e => e.Deductfee).HasColumnName("deductfee");

                entity.Property(e => e.Deductfeedatetime)
                    .HasColumnName("deductfeedatetime")
                    .HasMaxLength(255);

                entity.Property(e => e.Deducttype).HasColumnName("deducttype");

                entity.Property(e => e.Deductuserid)
                    .HasColumnName("deductuserid")
                    .HasMaxLength(255);

                entity.Property(e => e.Depositplatform).HasColumnName("depositplatform");

                entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");

                entity.Property(e => e.Feestype).HasColumnName("feestype");

                entity.Property(e => e.Fsname)
                    .HasColumnName("fsname")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingflag).HasColumnName("hedgingflag");

                entity.Property(e => e.Hedgingflag1).HasColumnName("hedgingflag_1");

                entity.Property(e => e.Hedginggroup)
                    .HasColumnName("hedginggroup")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingid)
                    .HasColumnName("hedgingid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Ioflag).HasColumnName("ioflag");

                entity.Property(e => e.Isdeduct)
                    .HasColumnName("isdeduct")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(255);

                entity.Property(e => e.Istate).HasColumnName("istate");

                entity.Property(e => e.Itemmoney).HasColumnName("itemmoney");

                entity.Property(e => e.Leftmoney).HasColumnName("leftmoney");

                entity.Property(e => e.Mathdatetime).HasColumnName("mathdatetime");

                entity.Property(e => e.Occode)
                    .HasColumnName("occode")
                    .HasMaxLength(255);

                entity.Property(e => e.Oexchangerate).HasColumnName("oexchangerate");

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Ordercount).HasColumnName("ordercount");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Oricurfeevalue).HasColumnName("oricurfeevalue");

                entity.Property(e => e.Oumoney).HasColumnName("oumoney");

                entity.Property(e => e.Packtype).HasColumnName("packtype");

                entity.Property(e => e.Periodmoenys)
                    .HasColumnName("periodmoenys")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypename)
                    .HasColumnName("posttypename")
                    .HasMaxLength(255);

                entity.Property(e => e.Preparerecordoperatetype)
                    .HasColumnName("preparerecordoperatetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Ptid)
                    .HasColumnName("ptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Rechagetype).HasColumnName("rechagetype");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sopids)
                    .HasColumnName("sopids")
                    .HasColumnType("json");

                entity.Property(e => e.Synmongoflag)
                    .HasColumnName("synmongoflag")
                    .HasMaxLength(255);

                entity.Property(e => e.Tranceid)
                    .HasColumnName("tranceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Transno)
                    .HasColumnName("transno")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Ucspids)
                    .HasColumnName("ucspids")
                    .HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(255);

                entity.Property(e => e.Umoney).HasColumnName("umoney");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Usermoneyrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usermoneyrecord");

                entity.Property(e => e.Aubalancedate)
                    .HasColumnName("aubalancedate")
                    .HasMaxLength(255);

                entity.Property(e => e.Balancecycle)
                    .HasColumnName("balancecycle")
                    .HasMaxLength(255);

                entity.Property(e => e.Balancedate)
                    .HasColumnName("balancedate")
                    .HasMaxLength(255);

                entity.Property(e => e.Bauserid)
                    .HasColumnName("bauserid")
                    .HasMaxLength(255);

                entity.Property(e => e.Buserid)
                    .HasColumnName("buserid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Chargebackplatform).HasColumnName("chargebackplatform");

                entity.Property(e => e.Ciid)
                    .HasColumnName("ciid")
                    .HasMaxLength(255);

                entity.Property(e => e.Costmoney)
                    .HasColumnName("costmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Costposttypefeesclassitemslist)
                    .HasColumnName("costposttypefeesclassitemslist")
                    .HasMaxLength(255);

                entity.Property(e => e.Costposttypename)
                    .HasColumnName("costposttypename")
                    .HasMaxLength(255);

                entity.Property(e => e.Costptid)
                    .HasColumnName("costptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Dan)
                    .HasColumnName("dan")
                    .HasMaxLength(255);

                entity.Property(e => e.Deducttype).HasColumnName("deducttype");

                entity.Property(e => e.Depositplatform).HasColumnName("depositplatform");

                entity.Property(e => e.Feestype).HasColumnName("feestype");

                entity.Property(e => e.Fsname)
                    .HasColumnName("fsname")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingflag).HasColumnName("hedgingflag");

                entity.Property(e => e.Hedginggroup)
                    .HasColumnName("hedginggroup")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingid)
                    .HasColumnName("hedgingid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Ioflag).HasColumnName("ioflag");

                entity.Property(e => e.Istate).HasColumnName("istate");

                entity.Property(e => e.Leftmoney).HasColumnName("leftmoney");

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Ordercount).HasColumnName("ordercount");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypename)
                    .HasColumnName("posttypename")
                    .HasMaxLength(255);

                entity.Property(e => e.Ptid)
                    .HasColumnName("ptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Rechagetype).HasColumnName("rechagetype");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sopids)
                    .HasColumnName("sopids")
                    .HasMaxLength(255);

                entity.Property(e => e.Synmongoflag)
                    .HasColumnName("synmongoflag")
                    .HasMaxLength(255);

                entity.Property(e => e.Tranceid)
                    .HasColumnName("tranceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Transno)
                    .HasColumnName("transno")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(255);

                entity.Property(e => e.Umoney).HasColumnName("umoney");

                entity.Property(e => e.Userfeesclassitemslist)
                    .HasColumnName("userfeesclassitemslist")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Usermoneyreturnrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usermoneyreturnrecord");

                entity.Property(e => e.Accountsrepaygroupid)
                    .HasColumnName("accountsrepaygroupid")
                    .HasMaxLength(255);

                entity.Property(e => e.Apiorderid)
                    .HasColumnName("apiorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Aubalancedate)
                    .HasColumnName("aubalancedate")
                    .HasMaxLength(255);

                entity.Property(e => e.Balancecycle)
                    .HasColumnName("balancecycle")
                    .HasMaxLength(255);

                entity.Property(e => e.Balancedate)
                    .HasColumnName("balancedate")
                    .HasMaxLength(255);

                entity.Property(e => e.Bauserid)
                    .HasColumnName("bauserid")
                    .HasMaxLength(255);

                entity.Property(e => e.Buserid)
                    .HasColumnName("buserid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode1)
                    .HasColumnName("ccode_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Chargebackplatform).HasColumnName("chargebackplatform");

                entity.Property(e => e.Chargeclass).HasColumnName("chargeclass");

                entity.Property(e => e.Ciid)
                    .HasColumnName("ciid")
                    .HasMaxLength(255);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(255);

                entity.Property(e => e.Costmoney)
                    .HasColumnName("costmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Costposttypefeesclassitemslist)
                    .HasColumnName("costposttypefeesclassitemslist")
                    .HasMaxLength(255);

                entity.Property(e => e.Costposttypename)
                    .HasColumnName("costposttypename")
                    .HasMaxLength(255);

                entity.Property(e => e.Costprice).HasColumnName("costprice");

                entity.Property(e => e.Costptid)
                    .HasColumnName("costptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Countinfor)
                    .HasColumnName("countinfor")
                    .HasMaxLength(255);

                entity.Property(e => e.Dan)
                    .HasColumnName("dan")
                    .HasMaxLength(255);

                entity.Property(e => e.Deducttype).HasColumnName("deducttype");

                entity.Property(e => e.Depositplatform).HasColumnName("depositplatform");

                entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");

                entity.Property(e => e.Feestype).HasColumnName("feestype");

                entity.Property(e => e.Fsname)
                    .HasColumnName("fsname")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingflag).HasColumnName("hedgingflag");

                entity.Property(e => e.Hedgingflag1).HasColumnName("hedgingflag_1");

                entity.Property(e => e.Hedginggroup)
                    .HasColumnName("hedginggroup")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingid)
                    .HasColumnName("hedgingid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Ioflag).HasColumnName("ioflag");

                entity.Property(e => e.Isreturnflag)
                    .HasColumnName("isreturnflag")
                    .HasMaxLength(255);

                entity.Property(e => e.Istate).HasColumnName("istate");

                entity.Property(e => e.Itemmoney).HasColumnName("itemmoney");

                entity.Property(e => e.Leftmoney).HasColumnName("leftmoney");

                entity.Property(e => e.Mathdatetime).HasColumnName("mathdatetime");

                entity.Property(e => e.Occode)
                    .HasColumnName("occode")
                    .HasMaxLength(255);

                entity.Property(e => e.Oexchangerate).HasColumnName("oexchangerate");

                entity.Property(e => e.Operatedate).HasColumnName("operatedate");

                entity.Property(e => e.Ordercount).HasColumnName("ordercount");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Oricurfeevalue).HasColumnName("oricurfeevalue");

                entity.Property(e => e.Oumoney).HasColumnName("oumoney");

                entity.Property(e => e.Packtype).HasColumnName("packtype");

                entity.Property(e => e.Periodmoenys)
                    .HasColumnName("periodmoenys")
                    .HasMaxLength(255);

                entity.Property(e => e.Platformuaccount)
                    .HasColumnName("platformuaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Platformumoney).HasColumnName("platformumoney");

                entity.Property(e => e.Posttypename)
                    .HasColumnName("posttypename")
                    .HasMaxLength(255);

                entity.Property(e => e.Ptid)
                    .HasColumnName("ptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Rechagetype).HasColumnName("rechagetype");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Retrundatetime)
                    .HasColumnName("retrundatetime")
                    .HasMaxLength(255);

                entity.Property(e => e.Returnmoney).HasColumnName("returnmoney");

                entity.Property(e => e.Returntype).HasColumnName("returntype");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .HasMaxLength(255);

                entity.Property(e => e.Sopids)
                    .HasColumnName("sopids")
                    .HasMaxLength(255);

                entity.Property(e => e.Synmongoflag)
                    .HasColumnName("synmongoflag")
                    .HasMaxLength(255);

                entity.Property(e => e.Tranceid)
                    .HasColumnName("tranceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Transno)
                    .HasColumnName("transno")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Ucspids)
                    .HasColumnName("ucspids")
                    .HasMaxLength(255);

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Umoney).HasColumnName("umoney");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Usernotificationrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usernotificationrecord");

                entity.Property(e => e.Hasread)
                    .HasColumnName("hasread")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Id1)
                    .HasColumnName("_id_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Noticeid)
                    .HasColumnName("noticeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Pushed)
                    .HasColumnName("pushed")
                    .HasMaxLength(255);

                entity.Property(e => e.Readtime).HasColumnName("readtime");

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userordermoneyrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userordermoneyrecord");

                entity.Property(e => e.Chargebackplatform).HasColumnName("chargebackplatform");

                entity.Property(e => e.Createdatetime).HasColumnName("createdatetime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<Userorderpreparemoneyrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userorderpreparemoneyrecord");

                entity.Property(e => e.Createdatetime).HasColumnName("createdatetime");

                entity.Property(e => e.Feestype).HasColumnName("feestype");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(255);

                entity.Property(e => e.Md5code)
                    .HasColumnName("md5code")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<Userorderreturnmoneyrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userorderreturnmoneyrecord");

                entity.Property(e => e.Createdatetime).HasColumnName("createdatetime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<Userordertag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userordertag");

                entity.Property(e => e.Creationtime).HasColumnName("creationtime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Tagid)
                    .HasColumnName("tagid")
                    .HasMaxLength(255);

                entity.Property(e => e.Tagname)
                    .HasColumnName("tagname")
                    .HasMaxLength(255);

                entity.Property(e => e.Tagtype).HasColumnName("tagtype");

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userperiodbilldetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userperiodbilldetail");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(255);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(255);

                entity.Property(e => e.Apiorderid)
                    .HasColumnName("apiorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Balancecycletype).HasColumnName("balancecycletype");

                entity.Property(e => e.Billid)
                    .HasColumnName("billid")
                    .HasMaxLength(255);

                entity.Property(e => e.Businessuserid).HasColumnName("businessuserid");

                entity.Property(e => e.Businessusername)
                    .HasColumnName("businessusername")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccode)
                    .HasColumnName("ccode")
                    .HasMaxLength(255);

                entity.Property(e => e.Chargeclass).HasColumnName("chargeclass");

                entity.Property(e => e.Chargeplatform).HasColumnName("chargeplatform");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(255);

                entity.Property(e => e.Costprice).HasColumnName("costprice");

                entity.Property(e => e.Countryid)
                    .HasColumnName("countryid")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryname)
                    .HasColumnName("countryname")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(255);

                entity.Property(e => e.Deducttype).HasColumnName("deducttype");

                entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");

                entity.Property(e => e.Feeitemclasses)
                    .HasColumnName("feeitemclasses")
                    .HasColumnType("json");

                entity.Property(e => e.Feestype).HasColumnName("feestype");

                entity.Property(e => e.Formula)
                    .HasColumnName("formula")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingflag).HasColumnName("hedgingflag");

                entity.Property(e => e.Hedgingflag1).HasColumnName("hedgingflag_1");

                entity.Property(e => e.Hedginggroup)
                    .HasColumnName("hedginggroup")
                    .HasMaxLength(255);

                entity.Property(e => e.Hedgingid)
                    .HasColumnName("hedgingid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Ioflag).HasColumnName("ioflag");

                entity.Property(e => e.Itemmoney).HasColumnName("itemmoney");

                entity.Property(e => e.Leftmoney)
                    .HasColumnName("leftmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(255);

                entity.Property(e => e.Moneyrecordid)
                    .HasColumnName("moneyrecordid")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Ordercount).HasColumnName("ordercount");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderplatform)
                    .HasColumnName("orderplatform")
                    .HasMaxLength(255);

                entity.Property(e => e.Oricurfeevalue).HasColumnName("oricurfeevalue");

                entity.Property(e => e.Packtype).HasColumnName("packtype");

                entity.Property(e => e.Packtypedesc)
                    .HasColumnName("packtypedesc")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodid)
                    .HasColumnName("periodid")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodkey)
                    .HasColumnName("periodkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypeid)
                    .HasColumnName("posttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypename)
                    .HasColumnName("posttypename")
                    .HasMaxLength(255);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(255);

                entity.Property(e => e.Receiver)
                    .HasColumnName("receiver")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivestationid)
                    .HasColumnName("receivestationid")
                    .HasMaxLength(255);

                entity.Property(e => e.Receivestationname)
                    .HasColumnName("receivestationname")
                    .HasMaxLength(255);

                entity.Property(e => e.Rechagetype).HasColumnName("rechagetype");

                entity.Property(e => e.Rechagetypedesc)
                    .HasColumnName("rechagetypedesc")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Transitno)
                    .HasColumnName("transitno")
                    .HasMaxLength(255);

                entity.Property(e => e.Transno)
                    .HasColumnName("transno")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccountname)
                    .HasColumnName("uaccountname")
                    .HasMaxLength(255);

                entity.Property(e => e.Umoney)
                    .HasColumnName("umoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(255);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userperiodbilllog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userperiodbilllog");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatelog)
                    .HasColumnName("operatelog")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatename)
                    .HasColumnName("operatename")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatorname)
                    .HasColumnName("operatorname")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodid)
                    .HasColumnName("periodid")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userperiodbillrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userperiodbillrecord");

                entity.Property(e => e.Balancecycletype).HasColumnName("balancecycletype");

                entity.Property(e => e.Balancedays).HasColumnName("balancedays");

                entity.Property(e => e.Balanceendtime).HasColumnName("balanceendtime");

                entity.Property(e => e.Beginbalance)
                    .HasColumnName("beginbalance")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Creditdays).HasColumnName("creditdays");

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencyname)
                    .HasColumnName("currencyname")
                    .HasMaxLength(255);

                entity.Property(e => e.Havearrearagerecord)
                    .HasColumnName("havearrearagerecord")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isgeneral)
                    .HasColumnName("isgeneral")
                    .HasMaxLength(255);

                entity.Property(e => e.Ishandled)
                    .HasColumnName("ishandled")
                    .HasMaxLength(255);

                entity.Property(e => e.Isoverdatetime)
                    .HasColumnName("isoverdatetime")
                    .HasMaxLength(255);

                entity.Property(e => e.Md5code)
                    .HasColumnName("md5code")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Periodcreatetime).HasColumnName("periodcreatetime");

                entity.Property(e => e.Periodkey)
                    .HasColumnName("periodkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodupdatetime).HasColumnName("periodupdatetime");

                entity.Property(e => e.Postingmoney)
                    .HasColumnName("postingmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaysettlementperiodleftmoney)
                    .HasColumnName("repaysettlementperiodleftmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaysettlementperiodmoney)
                    .HasColumnName("repaysettlementperiodmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Settlementbegintime).HasColumnName("settlementbegintime");

                entity.Property(e => e.Settlementendtime).HasColumnName("settlementendtime");

                entity.Property(e => e.Settlementperiodmoney)
                    .HasColumnName("settlementperiodmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userperiodbillsend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userperiodbillsend");

                entity.Property(e => e.Billid)
                    .HasColumnName("billid")
                    .HasMaxLength(255);

                entity.Property(e => e.Billsendbody)
                    .HasColumnName("billsendbody")
                    .HasMaxLength(255);

                entity.Property(e => e.Billsendsubject)
                    .HasColumnName("billsendsubject")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodid)
                    .HasColumnName("periodid")
                    .HasMaxLength(255);

                entity.Property(e => e.Toemails)
                    .HasColumnName("toemails")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<Userperiodbillsum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userperiodbillsum");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasMaxLength(255);

                entity.Property(e => e.Beginbalance)
                    .HasColumnName("beginbalance")
                    .HasMaxLength(255);

                entity.Property(e => e.Begintime).HasColumnName("begintime");

                entity.Property(e => e.Billmoney)
                    .HasColumnName("billmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Cratetime).HasColumnName("cratetime");

                entity.Property(e => e.Creditdays).HasColumnName("creditdays");

                entity.Property(e => e.Creditmoney)
                    .HasColumnName("creditmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencyname)
                    .HasColumnName("currencyname")
                    .HasMaxLength(255);

                entity.Property(e => e.Cycletype).HasColumnName("cycletype");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Detailtotal).HasColumnName("detailtotal");

                entity.Property(e => e.Downloadbillcount).HasColumnName("downloadbillcount");

                entity.Property(e => e.Endtime).HasColumnName("endtime");

                entity.Property(e => e.Feetype).HasColumnName("feetype");

                entity.Property(e => e.Filekey)
                    .HasColumnName("filekey")
                    .HasMaxLength(255);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.Fileurl)
                    .HasColumnName("fileurl")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isgeneraled)
                    .HasColumnName("isgeneraled")
                    .HasMaxLength(255);

                entity.Property(e => e.Ishavearrears)
                    .HasColumnName("ishavearrears")
                    .HasMaxLength(255);

                entity.Property(e => e.Ishavedetail)
                    .HasColumnName("ishavedetail")
                    .HasMaxLength(255);

                entity.Property(e => e.Issend)
                    .HasColumnName("issend")
                    .HasMaxLength(255);

                entity.Property(e => e.Isupload)
                    .HasColumnName("isupload")
                    .HasMaxLength(255);

                entity.Property(e => e.Md5code)
                    .HasColumnName("md5code")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodid)
                    .HasColumnName("periodid")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodkey)
                    .HasColumnName("periodkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Postingmoney)
                    .HasColumnName("postingmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repayleftmoney)
                    .HasColumnName("repayleftmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaymoney)
                    .HasColumnName("repaymoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaytime).HasColumnName("repaytime");

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Userperiodbillsumtest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userperiodbillsumtest");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasMaxLength(255);

                entity.Property(e => e.Beginbalance)
                    .HasColumnName("beginbalance")
                    .HasMaxLength(255);

                entity.Property(e => e.Begintime).HasColumnName("begintime");

                entity.Property(e => e.Billmoney)
                    .HasColumnName("billmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Cratetime).HasColumnName("cratetime");

                entity.Property(e => e.Creditdays).HasColumnName("creditdays");

                entity.Property(e => e.Creditmoney)
                    .HasColumnName("creditmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencyname)
                    .HasColumnName("currencyname")
                    .HasMaxLength(255);

                entity.Property(e => e.Cycletype).HasColumnName("cycletype");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Detailtotal).HasColumnName("detailtotal");

                entity.Property(e => e.Endtime).HasColumnName("endtime");

                entity.Property(e => e.Feetype).HasColumnName("feetype");

                entity.Property(e => e.Filekey)
                    .HasColumnName("filekey")
                    .HasMaxLength(255);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.Fileurl)
                    .HasColumnName("fileurl")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isgeneraled)
                    .HasColumnName("isgeneraled")
                    .HasMaxLength(255);

                entity.Property(e => e.Ishavedetail)
                    .HasColumnName("ishavedetail")
                    .HasMaxLength(255);

                entity.Property(e => e.Issend)
                    .HasColumnName("issend")
                    .HasMaxLength(255);

                entity.Property(e => e.Isupload)
                    .HasColumnName("isupload")
                    .HasMaxLength(255);

                entity.Property(e => e.Md5code)
                    .HasColumnName("md5code")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodid)
                    .HasColumnName("periodid")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodkey)
                    .HasColumnName("periodkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Repayleftmoney)
                    .HasColumnName("repayleftmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaymoney)
                    .HasColumnName("repaymoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaytime).HasColumnName("repaytime");

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Userperiodbillsumtestnew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userperiodbillsumtestnew");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasMaxLength(255);

                entity.Property(e => e.Beginbalance)
                    .HasColumnName("beginbalance")
                    .HasMaxLength(255);

                entity.Property(e => e.Begintime).HasColumnName("begintime");

                entity.Property(e => e.Billmoney)
                    .HasColumnName("billmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Cratetime).HasColumnName("cratetime");

                entity.Property(e => e.Creditdays).HasColumnName("creditdays");

                entity.Property(e => e.Creditmoney)
                    .HasColumnName("creditmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencycode)
                    .HasColumnName("currencycode")
                    .HasMaxLength(255);

                entity.Property(e => e.Currencyname)
                    .HasColumnName("currencyname")
                    .HasMaxLength(255);

                entity.Property(e => e.Cycletype).HasColumnName("cycletype");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Detailtotal).HasColumnName("detailtotal");

                entity.Property(e => e.Endtime).HasColumnName("endtime");

                entity.Property(e => e.Feetype).HasColumnName("feetype");

                entity.Property(e => e.Filekey)
                    .HasColumnName("filekey")
                    .HasMaxLength(255);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.Fileurl)
                    .HasColumnName("fileurl")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isgeneraled)
                    .HasColumnName("isgeneraled")
                    .HasMaxLength(255);

                entity.Property(e => e.Ishavedetail)
                    .HasColumnName("ishavedetail")
                    .HasMaxLength(255);

                entity.Property(e => e.Issend)
                    .HasColumnName("issend")
                    .HasMaxLength(255);

                entity.Property(e => e.Isupload)
                    .HasColumnName("isupload")
                    .HasMaxLength(255);

                entity.Property(e => e.Md5code)
                    .HasColumnName("md5code")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodid)
                    .HasColumnName("periodid")
                    .HasMaxLength(255);

                entity.Property(e => e.Periodkey)
                    .HasColumnName("periodkey")
                    .HasMaxLength(255);

                entity.Property(e => e.Repayleftmoney)
                    .HasColumnName("repayleftmoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaymoney)
                    .HasColumnName("repaymoney")
                    .HasMaxLength(255);

                entity.Property(e => e.Repaytime).HasColumnName("repaytime");

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CnName).HasMaxLength(255);

                entity.Property(e => e.CompanyId).HasColumnType("character varying");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EnName).HasMaxLength(255);

                entity.Property(e => e.LastLoginIp).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(255);

                entity.Property(e => e.Permissions).HasColumnType("json");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PositionId).HasMaxLength(255);

                entity.Property(e => e.QqNumber).HasMaxLength(255);

                entity.Property(e => e.Rid)
                    .HasColumnName("RId")
                    .HasMaxLength(255);

                entity.Property(e => e.Roleds).HasColumnType("json");

                entity.Property(e => e.Uid)
                    .HasColumnName("UId")
                    .HasMaxLength(255);

                entity.Property(e => e.Unumber)
                    .HasColumnName("UNumber")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VerfiyUserId).HasMaxLength(255);
            });

            modelBuilder.Entity<Usersettlementperiodsendmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usersettlementperiodsendmail");

                entity.Property(e => e.Cpid)
                    .HasColumnName("cpid")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Eobjecttype)
                    .HasColumnName("eobjecttype")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Userverification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userverification");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Longitudelatitude)
                    .HasColumnName("longitudelatitude")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Pictureattachs)
                    .HasColumnName("pictureattachs")
                    .HasColumnType("json");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Verificationorderfield>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("verificationorderfield");

                entity.Property(e => e.Annotation)
                    .HasColumnName("annotation")
                    .HasMaxLength(255);

                entity.Property(e => e.Filetype).HasColumnName("filetype");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdefault)
                    .HasColumnName("isdefault")
                    .HasMaxLength(255);

                entity.Property(e => e.Moduletype).HasColumnName("moduletype");

                entity.Property(e => e.Names)
                    .HasColumnName("names")
                    .HasMaxLength(255);

                entity.Property(e => e.Resourcetype).HasColumnName("resourcetype");
            });

            modelBuilder.Entity<Verificationorderrule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("verificationorderrule");

                entity.Property(e => e.Conditions)
                    .HasColumnName("conditions")
                    .HasColumnType("json");

                entity.Property(e => e.Countries)
                    .HasColumnName("countries")
                    .HasColumnType("json");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Id1)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.OperateId)
                    .HasColumnName("operateId")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatetype)
                    .HasColumnName("operatetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Optrnodes)
                    .HasColumnName("optrnodes")
                    .HasColumnType("json");

                entity.Property(e => e.Posttypes)
                    .HasColumnName("posttypes")
                    .HasColumnType("json");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Rulename)
                    .HasColumnName("rulename")
                    .HasMaxLength(255);

                entity.Property(e => e.Uiids)
                    .HasColumnName("uiids")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<Verificationorderrulebak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("verificationorderrulebak");

                entity.Property(e => e.Conditions)
                    .HasColumnName("conditions")
                    .HasColumnType("json");

                entity.Property(e => e.Countries)
                    .HasColumnName("countries")
                    .HasColumnType("json");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Id1)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operateld)
                    .HasColumnName("operateld")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatetype)
                    .HasColumnName("operatetype")
                    .HasMaxLength(255);

                entity.Property(e => e.Optrnodes)
                    .HasColumnName("optrnodes")
                    .HasColumnType("json");

                entity.Property(e => e.Posttypes)
                    .HasColumnName("posttypes")
                    .HasColumnType("json");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Rulename)
                    .HasColumnName("rulename")
                    .HasMaxLength(255);

                entity.Property(e => e.Uiids)
                    .HasColumnName("uiids")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<Vocabularymapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vocabularymapping");

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Createuserid).HasColumnName("createuserid");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Mappingword)
                    .HasColumnName("mappingword")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Operatorid).HasColumnName("operatorid");

                entity.Property(e => e.Word)
                    .HasColumnName("word")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Vovaonlineorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vovaonlineorder");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Addressen)
                    .HasColumnName("addressen")
                    .HasMaxLength(255);

                entity.Property(e => e.Addresslocal)
                    .HasColumnName("addresslocal")
                    .HasMaxLength(255);

                entity.Property(e => e.Apikey)
                    .HasColumnName("apikey")
                    .HasMaxLength(255);

                entity.Property(e => e.Apiusername)
                    .HasColumnName("apiusername")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.City1)
                    .HasColumnName("city_1")
                    .HasMaxLength(255);

                entity.Property(e => e.City2)
                    .HasColumnName("city_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(255);

                entity.Property(e => e.Company1)
                    .HasColumnName("company_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.Country1)
                    .HasColumnName("country_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Country2)
                    .HasColumnName("country_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(255);

                entity.Property(e => e.Countrycode1)
                    .HasColumnName("countrycode_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryoforigin)
                    .HasColumnName("countryoforigin")
                    .HasMaxLength(255);

                entity.Property(e => e.Countryoforigincode)
                    .HasColumnName("countryoforigincode")
                    .HasMaxLength(255);

                entity.Property(e => e.Createflytordererrormsg)
                    .HasColumnName("createflytordererrormsg")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Declarevalue).HasColumnName("declarevalue");

                entity.Property(e => e.Declarevalue1).HasColumnName("declarevalue_1");

                entity.Property(e => e.Descriptionen)
                    .HasColumnName("descriptionen")
                    .HasMaxLength(255);

                entity.Property(e => e.Descriptionen1)
                    .HasColumnName("descriptionen_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Descriptionlocal)
                    .HasColumnName("descriptionlocal")
                    .HasMaxLength(255);

                entity.Property(e => e.Descriptionlocal1)
                    .HasColumnName("descriptionlocal_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Dimensionunit)
                    .HasColumnName("dimensionunit")
                    .HasMaxLength(255);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(255);

                entity.Property(e => e.District1)
                    .HasColumnName("district_1")
                    .HasMaxLength(255);

                entity.Property(e => e.District2)
                    .HasColumnName("district_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Email1)
                    .HasColumnName("email_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Flytorderid)
                    .HasColumnName("flytorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasbattery)
                    .HasColumnName("hasbattery")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasbattery1)
                    .HasColumnName("hasbattery_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasflammable)
                    .HasColumnName("hasflammable")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasliquid)
                    .HasColumnName("hasliquid")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasmetal)
                    .HasColumnName("hasmetal")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasmetal1)
                    .HasColumnName("hasmetal_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Haspowder)
                    .HasColumnName("haspowder")
                    .HasMaxLength(255);

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Height1).HasColumnName("height_1");

                entity.Property(e => e.Hscode)
                    .HasColumnName("hscode")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Imageurl)
                    .HasColumnName("imageurl")
                    .HasMaxLength(255);

                entity.Property(e => e.Incoterm)
                    .HasColumnName("incoterm")
                    .HasMaxLength(255);

                entity.Property(e => e.Iscreateflytorder)
                    .HasColumnName("iscreateflytorder")
                    .HasMaxLength(255);

                entity.Property(e => e.Isflammable)
                    .HasColumnName("isflammable")
                    .HasMaxLength(255);

                entity.Property(e => e.Isliquid)
                    .HasColumnName("isliquid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ispowder)
                    .HasColumnName("ispowder")
                    .HasMaxLength(255);

                entity.Property(e => e.Istest)
                    .HasColumnName("istest")
                    .HasMaxLength(255);

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Length1).HasColumnName("length_1");

                entity.Property(e => e.Logisticsproductid).HasColumnName("logisticsproductid");

                entity.Property(e => e.Logisticstrackingnumber)
                    .HasColumnName("logisticstrackingnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(255);

                entity.Property(e => e.Mobile1)
                    .HasColumnName("mobile_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Name1)
                    .HasColumnName("name_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Name2)
                    .HasColumnName("name_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Name3)
                    .HasColumnName("name_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Name4)
                    .HasColumnName("name_4")
                    .HasMaxLength(255);

                entity.Property(e => e.Paidwithvova)
                    .HasColumnName("paidwithvova")
                    .HasMaxLength(255);

                entity.Property(e => e.Payercontactname)
                    .HasColumnName("payercontactname")
                    .HasMaxLength(255);

                entity.Property(e => e.Payeremail)
                    .HasColumnName("payeremail")
                    .HasMaxLength(255);

                entity.Property(e => e.Payerid)
                    .HasColumnName("payerid")
                    .HasMaxLength(255);

                entity.Property(e => e.Payermobile)
                    .HasColumnName("payermobile")
                    .HasMaxLength(255);

                entity.Property(e => e.Payername)
                    .HasColumnName("payername")
                    .HasMaxLength(255);

                entity.Property(e => e.Payerphone)
                    .HasColumnName("payerphone")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone1)
                    .HasColumnName("phone_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Pickuptype).HasColumnName("pickuptype");

                entity.Property(e => e.Pricecurrency)
                    .HasColumnName("pricecurrency")
                    .HasMaxLength(255);

                entity.Property(e => e.Priceunit)
                    .HasColumnName("priceunit")
                    .HasMaxLength(255);

                entity.Property(e => e.Producturl)
                    .HasColumnName("producturl")
                    .HasMaxLength(255);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(255);

                entity.Property(e => e.Province1)
                    .HasColumnName("province_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Province2)
                    .HasColumnName("province_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Quantity1).HasColumnName("quantity_1");

                entity.Property(e => e.Requirelabel)
                    .HasColumnName("requirelabel")
                    .HasMaxLength(255);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(255);

                entity.Property(e => e.Street1)
                    .HasColumnName("street_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Street2)
                    .HasColumnName("street_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Streetaddress1)
                    .HasColumnName("streetaddress1")
                    .HasMaxLength(255);

                entity.Property(e => e.Streetaddress11)
                    .HasColumnName("streetaddress1_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Streetaddress12)
                    .HasColumnName("streetaddress1_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Streetaddress2)
                    .HasColumnName("streetaddress2")
                    .HasMaxLength(255);

                entity.Property(e => e.Streetaddress21)
                    .HasColumnName("streetaddress2_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Streetaddress22)
                    .HasColumnName("streetaddress2_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");

                entity.Property(e => e.Vovaplatformid)
                    .HasColumnName("vovaplatformid")
                    .HasMaxLength(255);

                entity.Property(e => e.Vovapostordersn)
                    .HasColumnName("vovapostordersn")
                    .HasMaxLength(255);

                entity.Property(e => e.Vovapostordertime)
                    .HasColumnName("vovapostordertime")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Weight1).HasColumnName("weight_1");

                entity.Property(e => e.Weightunit)
                    .HasColumnName("weightunit")
                    .HasMaxLength(255);

                entity.Property(e => e.Weightunit1)
                    .HasColumnName("weightunit_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.Width1).HasColumnName("width_1");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(255);

                entity.Property(e => e.Zipcode1)
                    .HasColumnName("zipcode_1")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Vovaonlineordercancel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vovaonlineordercancel");

                entity.Property(e => e.Apikey)
                    .HasColumnName("apikey")
                    .HasMaxLength(255);

                entity.Property(e => e.Apiusername)
                    .HasColumnName("apiusername")
                    .HasMaxLength(255);

                entity.Property(e => e.Cancelreason)
                    .HasColumnName("cancelreason")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Logisticstrackingnumber)
                    .HasColumnName("logisticstrackingnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Timestamp).HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");

                entity.Property(e => e.Vovapostordersn)
                    .HasColumnName("vovapostordersn")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Wechatintercept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wechatintercept");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(255);

                entity.Property(e => e.Wechatname)
                    .HasColumnName("wechatname")
                    .HasMaxLength(255);

                entity.Property(e => e.Wechattime)
                    .HasColumnName("wechattime")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Weightingset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weightingset");

                entity.Property(e => e.Companyid)
                    .HasColumnName("companyid")
                    .HasMaxLength(255);

                entity.Property(e => e.Feesweight)
                    .HasColumnName("feesweight")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasMaxLength(255);

                entity.Property(e => e.Operatedatetime).HasColumnName("operatedatetime");

                entity.Property(e => e.Operateuserid).HasColumnName("operateuserid");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Servicelevelweight)
                    .HasColumnName("servicelevelweight")
                    .HasMaxLength(255);

                entity.Property(e => e.Serviceprescriptionweight)
                    .HasColumnName("serviceprescriptionweight")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Windowsservice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("windowsservice");

                entity.Property(e => e.Creater)
                    .HasColumnName("creater")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Enable)
                    .HasColumnName("enable")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastruntime).HasColumnName("lastruntime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Processname)
                    .HasColumnName("processname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Wishaccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishaccount");

                entity.Property(e => e.Accesstoken)
                    .HasColumnName("accesstoken")
                    .HasMaxLength(255);

                entity.Property(e => e.Clientid)
                    .HasColumnName("clientid")
                    .HasMaxLength(255);

                entity.Property(e => e.Clientsecret)
                    .HasColumnName("clientsecret")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime)
                    .HasColumnName("createtime")
                    .HasMaxLength(255);

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastdownloadtime)
                    .HasColumnName("lastdownloadtime")
                    .HasMaxLength(255);

                entity.Property(e => e.Refreshtoken)
                    .HasColumnName("refreshtoken")
                    .HasMaxLength(255);

                entity.Property(e => e.Tokenenable)
                    .HasColumnName("tokenenable")
                    .HasMaxLength(255);

                entity.Property(e => e.Tokenexpire)
                    .HasColumnName("tokenexpire")
                    .HasMaxLength(255);

                entity.Property(e => e.Totalcount).HasColumnName("totalcount");

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Uiid)
                    .HasColumnName("uiid")
                    .HasMaxLength(255);

                entity.Property(e => e.Wishid)
                    .HasColumnName("wishid")
                    .HasMaxLength(255);

                entity.Property(e => e.Wishname)
                    .HasColumnName("wishname")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Wishcarrier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishcarrier");

                entity.Property(e => e.Carrier)
                    .HasColumnName("carrier")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypeid)
                    .HasColumnName("posttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypename)
                    .HasColumnName("posttypename")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Wishonlineorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishonlineorder");

                entity.Property(e => e.ApiKey)
                    .HasColumnName("api_key")
                    .HasMaxLength(255);

                entity.Property(e => e.CarrierCode).HasColumnName("carrier_code");

                entity.Property(e => e.CarryType).HasColumnName("carry_type");

                entity.Property(e => e.Createflytordererrormsg)
                    .HasColumnName("createflytordererrormsg")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Flytorderid)
                    .HasColumnName("flytorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Incoterm)
                    .HasColumnName("incoterm")
                    .HasMaxLength(255);

                entity.Property(e => e.IsTest).HasColumnName("is_test");

                entity.Property(e => e.Iscreateflytorder).HasColumnName("iscreateflytorder");

                entity.Property(e => e.LogisticsOrderCode)
                    .HasColumnName("logistics_order_code")
                    .HasMaxLength(255);

                entity.Property(e => e.LogisticsProductAccount)
                    .HasColumnName("logistics_product_account")
                    .HasMaxLength(255);

                entity.Property(e => e.NextCarrierCode)
                    .HasColumnName("next_carrier_code")
                    .HasMaxLength(255);

                entity.Property(e => e.NextCarrierName)
                    .HasColumnName("next_carrier_name")
                    .HasMaxLength(255);

                entity.Property(e => e.NextLogsticsOrderCode)
                    .HasColumnName("next_logstics_order_code")
                    .HasMaxLength(255);

                entity.Property(e => e.NextOperationCenterCode)
                    .HasColumnName("next_operation_center_code")
                    .HasMaxLength(255);

                entity.Property(e => e.OperationCenterCode)
                    .HasColumnName("operation_center_code")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderTime).HasColumnName("order_time");

                entity.Property(e => e.Otype)
                    .HasColumnName("otype")
                    .HasMaxLength(255);

                entity.Property(e => e.PaidWithWish).HasColumnName("paid_with_wish");

                entity.Property(e => e.Parcel)
                    .HasColumnName("parcel")
                    .HasColumnType("json");

                entity.Property(e => e.PaymentAccount)
                    .HasColumnName("payment_account")
                    .HasColumnType("json");

                entity.Property(e => e.Pickup)
                    .HasColumnName("pickup")
                    .HasColumnType("json");

                entity.Property(e => e.PickupType).HasColumnName("pickup_type");

                entity.Property(e => e.PreCarrierCode)
                    .HasColumnName("pre_carrier_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PreCarrierName)
                    .HasColumnName("pre_carrier_name")
                    .HasMaxLength(255);

                entity.Property(e => e.PreLogisticsOrderCode)
                    .HasColumnName("pre_logistics_order_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PreOperationCenterCode)
                    .HasColumnName("pre_operation_center_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Receiver)
                    .HasColumnName("receiver")
                    .HasColumnType("json");

                entity.Property(e => e.ReturnInfo)
                    .HasColumnName("return_info")
                    .HasColumnType("json");

                entity.Property(e => e.Sender)
                    .HasColumnName("sender")
                    .HasColumnType("json");

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(255);

                entity.Property(e => e.Stype).HasColumnName("stype");

                entity.Property(e => e.TrackingId)
                    .HasColumnName("tracking_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Wishonlineordercancel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishonlineordercancel");

                entity.Property(e => e.Apikey)
                    .HasColumnName("apikey")
                    .HasMaxLength(255);

                entity.Property(e => e.Cancelreason)
                    .HasColumnName("cancelreason")
                    .HasMaxLength(255);

                entity.Property(e => e.Carrytype).HasColumnName("carrytype");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Logisticsordercode)
                    .HasColumnName("logisticsordercode")
                    .HasMaxLength(255);

                entity.Property(e => e.Trackingid)
                    .HasColumnName("trackingid")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Wishonlineorderquantityrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishonlineorderquantityrecord");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Recorddate)
                    .HasColumnName("recorddate")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Wishorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishorder");

                entity.Property(e => e.Buyerid)
                    .HasColumnName("buyerid")
                    .HasMaxLength(255);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(255);

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasMaxLength(255);

                entity.Property(e => e.Daystofulfill)
                    .HasColumnName("daystofulfill")
                    .HasMaxLength(255);

                entity.Property(e => e.Downloadtime).HasColumnName("downloadtime");

                entity.Property(e => e.Hourstofulfill)
                    .HasColumnName("hourstofulfill")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdownload).HasColumnName("isdownload");

                entity.Property(e => e.Laseupdated)
                    .HasColumnName("laseupdated")
                    .HasMaxLength(255);

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Ordertime).HasColumnName("ordertime");

                entity.Property(e => e.Ordertotal)
                    .HasColumnName("ordertotal")
                    .HasMaxLength(255);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(255);

                entity.Property(e => e.Productid)
                    .HasColumnName("productid")
                    .HasMaxLength(255);

                entity.Property(e => e.Productimageurl)
                    .HasColumnName("productimageurl")
                    .HasMaxLength(255);

                entity.Property(e => e.Productname)
                    .HasColumnName("productname")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shipping)
                    .HasColumnName("shipping")
                    .HasMaxLength(255);

                entity.Property(e => e.Shippingcost)
                    .HasColumnName("shippingcost")
                    .HasMaxLength(255);

                entity.Property(e => e.Shippingdetail)
                    .HasColumnName("shippingdetail")
                    .HasColumnType("json");

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(255);

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(255);

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(255);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(255);

                entity.Property(e => e.Trackingnumber)
                    .HasColumnName("trackingnumber")
                    .HasMaxLength(255);

                entity.Property(e => e.Transactionid)
                    .HasColumnName("transactionid")
                    .HasMaxLength(255);

                entity.Property(e => e.Variantid)
                    .HasColumnName("variantid")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Wishordercollection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishordercollection");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Channelid)
                    .HasColumnName("channelid")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.Issign).HasColumnName("issign");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Posttypeid)
                    .HasColumnName("posttypeid")
                    .HasMaxLength(255);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(255);

                entity.Property(e => e.Signer)
                    .HasColumnName("signer")
                    .HasMaxLength(255);

                entity.Property(e => e.Signtime).HasColumnName("signtime");

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Wishorderid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishorderid");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Wishorderpushhistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishorderpushhistory");

                entity.Property(e => e.Apiorderid)
                    .HasColumnName("apiorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Issuccess).HasColumnName("issuccess");

                entity.Property(e => e.Operatetime).HasColumnName("operatetime");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Wishorderrelateinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishorderrelateinfo");

                entity.Property(e => e.Actualuaccount)
                    .HasColumnName("actualuaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Isbangdingoffline).HasColumnName("isbangdingoffline");

                entity.Property(e => e.Isonlinepaied).HasColumnName("isonlinepaied");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Platformorderid)
                    .HasColumnName("platformorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount)
                    .HasColumnName("uaccount")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");
            });

            modelBuilder.Entity<Wishordertest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishordertest");

                entity.Property(e => e.Firstapiorderid)
                    .HasColumnName("firstapiorderid")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Ptid)
                    .HasColumnName("ptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Traceid)
                    .HasColumnName("traceid")
                    .HasMaxLength(255);

                entity.Property(e => e.Uaccount).HasColumnName("uaccount");
            });

            modelBuilder.Entity<Workwechatuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("workwechatuser");

                entity.Property(e => e.Createtime).HasColumnName("createtime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Openid)
                    .HasColumnName("openid")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Zipcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zipcode");

                entity.Property(e => e.Alphathress)
                    .HasColumnName("alphathress")
                    .HasMaxLength(255);

                entity.Property(e => e.Alphatwo)
                    .HasColumnName("alphatwo")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.Endzip)
                    .HasColumnName("endzip")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Startzip)
                    .HasColumnName("startzip")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zipcoderule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zipcoderule");

                entity.Property(e => e.Countrycode)
                    .HasColumnName("countrycode")
                    .HasMaxLength(255);

                entity.Property(e => e.Creationtime)
                    .HasColumnName("creationtime")
                    .HasColumnType("json");

                entity.Property(e => e.Dataversion).HasColumnName("dataversion");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Utccanceltime).HasColumnName("utccanceltime");

                entity.Property(e => e.Utccreatetime).HasColumnName("utccreatetime");

                entity.Property(e => e.Utcmodifytime).HasColumnName("utcmodifytime");

                entity.Property(e => e.Zipdigit)
                    .HasColumnName("zipdigit")
                    .HasMaxLength(255);

                entity.Property(e => e.Zipregular)
                    .HasColumnName("zipregular")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
