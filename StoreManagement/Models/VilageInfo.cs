using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;// [Table("")]
using System.Linq;
using System.Web;

namespace StoreManagement.Models
{
    [Table("VilageMater")]
    public class VilageInfo
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string VilageName { get; set; }
    }
}