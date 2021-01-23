using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerApi.Data;
using WorkerApi.Models;

namespace WorkerApi.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DataContext _dataContext;

        public MessageRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task NewMessageAsync(Message message)
        {
            await _dataContext.Messages.AddAsync(message);
            await _dataContext.SaveChangesAsync();
        }
    }
}
