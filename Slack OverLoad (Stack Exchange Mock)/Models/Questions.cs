using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slack_OverLoad__Stack_Exchange_Mock_.Models
{
    [Table("questions")]
    public class Questions
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public DateTime posted { get; set; }
        public string category { get; set; }
        public int status { get; set; }
    }
}
