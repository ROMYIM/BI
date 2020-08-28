using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("abroadquestionmanage")]
    public partial class Abroadquestionmanage
    {
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("passbacktocainiaostate")]
        public double? Passbacktocainiaostate { get; set; }
        [Column("deletetime")]
        public DateTime? Deletetime { get; set; }
        [Column("solvehandler")]
        [StringLength(255)]
        public string Solvehandler { get; set; }
        [Column("solvetime")]
        public DateTime? Solvetime { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("solveremark")]
        [StringLength(255)]
        public string Solveremark { get; set; }
        [Column("finishtime")]
        public DateTime? Finishtime { get; set; }
        [Column("apiorderid")]
        [StringLength(255)]
        public string Apiorderid { get; set; }
        [Column("finishuserid")]
        public double? Finishuserid { get; set; }
        [Column("solution")]
        [StringLength(255)]
        public string Solution { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
        [Column("handlerid")]
        public double? Handlerid { get; set; }
        [Column("questionsection")]
        public double? Questionsection { get; set; }
        [Column("deleteuserid")]
        public double? Deleteuserid { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("createuserid")]
        public double? Createuserid { get; set; }
        [StringLength(255)]
        public string Handler { get; set; }
        [Column("passbackmessage")]
        [StringLength(255)]
        public string Passbackmessage { get; set; }
        [Column("questiontype")]
        [StringLength(255)]
        public string Questiontype { get; set; }
        [Column("logisticsnumber")]
        [StringLength(255)]
        public string Logisticsnumber { get; set; }
        [Column("attachname")]
        [StringLength(255)]
        public string Attachname { get; set; }
        [Column("platformorderid")]
        [StringLength(255)]
        public string Platformorderid { get; set; }
        [Column("isuploadtmall")]
        [StringLength(255)]
        public string Isuploadtmall { get; set; }
        [Column("attachurl")]
        [StringLength(255)]
        public string Attachurl { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("solvehandlerid")]
        public double? Solvehandlerid { get; set; }
        [Column("attachfilekey")]
        [StringLength(255)]
        public string Attachfilekey { get; set; }
        [Column("occuetime")]
        public DateTime? Occuetime { get; set; }
        public double? State { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("handletime")]
        public DateTime? Handletime { get; set; }
        [Column("questionsource")]
        public double? Questionsource { get; set; }
    }
}
