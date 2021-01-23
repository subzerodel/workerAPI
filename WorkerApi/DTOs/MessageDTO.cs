using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerApi.DTOs
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}
