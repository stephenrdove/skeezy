using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skeezy.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Text { get; set; }
    }
}
