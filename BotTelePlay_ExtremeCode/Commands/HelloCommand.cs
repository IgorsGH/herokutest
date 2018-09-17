using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BotTelePlay_ExtremeCode.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "Hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO код с логикой бота

            await client.SendTextMessageAsync(chatId, "Hallo! My friend", replyToMessageId: message.MessageId); //опциональное цитирование отправителя с помощью replyToMessageId
        }
    }
}