using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StoreManagement.Models
{
    [Table("UserMaster")]
    public class UserInfo
    {
      [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int  UserId    { get; set; }

      [Required]
      public string  UserName  { get; set; }

      [Required]
      public string  Password  { get; set; }
    }
}