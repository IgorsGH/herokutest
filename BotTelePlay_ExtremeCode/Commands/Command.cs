
using BotTelePlay_ExtremeCode.Models;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BotTelePlay_ExtremeCode.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute(Message message, TelegramBotClient client); //принимает сообщение с командой и экземпляр бот-клиента чтоб была возможность отправить обратно ответ
        public bool Contains(string command)
        {
            return command.Contains(this.Name) && command.Contains(AppSetings.BotName); //Проверка на то что команда от данного бота а не от другого
        }
    }
}