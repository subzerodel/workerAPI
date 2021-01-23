using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerApi.Models;

namespace WorkerApi.Repositories
{
    interface IMessageRepository
    {
        public Task NewMessageAsync(Message message);
        //public Task<Message> GetMessage(Guid id);
    }
}
