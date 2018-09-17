using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using System.Threading.Tasks;
using BotTelePlay_ExtremeCode.Commands;

namespace BotTelePlay_ExtremeCode.Models
{
    public static class Bot
    {
        private static TelegramBotClient _client;

        public static List<Command> commandsList;
        public static IReadOnlyList<Command> Commands { get => commandsList.AsReadOnly(); }
        public static async Task<TelegramBotClient> Get()
        {
            if (_client != null)
            {
                return _client;
            }

            commandsList = new List<Command>();
            commandsList.Add(new HelloCommand()); // Инициализация всех команд
                      
            _client = new TelegramBotClient(AppSetings.ApiKey);

            var hook = String.Format(AppSetings.BotUlr, "api/message/update");

            await _client.SetWebhookAsync(hook); //Идея WebHook заключается в том чтоб мы не стучали сами каждый раз, а если будет что то новое то нам постучат по указанной ссылке
            return _client;      
        }
    }
}