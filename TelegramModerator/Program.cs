using System;
using Telegram;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TelegramModerator
{
    class Program
    {
        static TelegramBotClient bot;
        static void Main(string[] args)
        {
            bot = new TelegramBotClient("Enter key");//<<<<<<
            bot.OnMessage += OnMessage;
            bot.StartReceiving();
            Console.ReadKey();
        }

        private static void OnMessage(object sender, MessageEventArgs e)
        {
            bot.SendTextMessageAsync(e.Message.Chat.Id,"Hello, " + e.Message.Chat.Username);
        }
    }
}
