using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using BotTelePlay_ExtremeCode.Models;
using System.Threading.Tasks;

namespace BotTelePlay_ExtremeCode.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")] //web hook uri part //по этому маршрут будет обрабатыватся инф присланная телеграмом
        public async Task<OkResult> Update([FromBody] Update update) //api тип в котором находится актуальная инф для Бота
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.Contains(message.Text)) //проверка на тот ли Бот
                {
                    command.Execute(message, client);
                    return Ok();
                }
            }

            return Ok();
        }
    }
}
