using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slack_OverLoad__Stack_Exchange_Mock_.Models
{
    [Table("answers")]
    public class Answers
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string detail { get; set; }
        public int questionid { get; set; }
        public DateTime posted { get; set; }
        public int upvotes { get; set; }
    }
}
