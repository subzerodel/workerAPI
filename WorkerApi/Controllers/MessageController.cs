using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkerApi.DTOs;
using WorkerApi.Models;
using WorkerApi.Repositories;

namespace WorkerApi.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        [HttpPost("add")]
        public async Task<ActionResult> Add(MessageDTO message)
        {
            Message m = new Message()
            {
                Id = Guid.NewGuid(),
                Type = message.Type,
                Handled = false,
                Content = message.Content,
                AddedAt = DateTime.Now
            };

            await _messageRepository.NewMessageAsync(m);
            return Ok("A new message was added.");
        }


        [HttpGet("handled/{messageId}")]
        public async Task<ActionResult> SetHandled(Guid messageId)
        {
            if (await _messageRepository.SetHandled(messageId))
            {
                return Ok("Message Handled.");
            }

            return BadRequest("Error.");
        }


        [HttpGet("retrieve/email")]
        public async Task<ActionResult> GetEmail()
        {
            var messages = await _messageRepository.GetEmailMessage();
            return Ok(messages);
        }


        [HttpGet("retrieve/log")]
        public async Task<ActionResult> GetLog()
        {
            var messages = await _messageRepository.GetLoggingMessage();
            return Ok(messages);
        }
    }
}
