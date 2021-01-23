using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerApi.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public bool Handled { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime? HandledAt { get; set; }
    }
}
