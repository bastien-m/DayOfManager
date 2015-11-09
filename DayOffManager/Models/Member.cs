using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DayOffManager.Models
{
    public class Member
    {

        public int MemberId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }

        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }
    }
}