using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DayOffManager.Models
{
    public class DateAsked
    {
        public int DateAskedId { get; set; }
        public string Value { get; set; }

        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }

    }
}