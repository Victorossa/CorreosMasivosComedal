using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCreate.DTO
{
    public class Template
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class Recipient
    {
        public string To { get; set; }

    }

    public class RootObject
    {
        public string Subject { get; set; }
        public string From { get; set; }
        public Template Template { get; set; }
        public string ReplyTo { get; set; }
        public List<Recipient> Recipients { get; set; }
    }
}
