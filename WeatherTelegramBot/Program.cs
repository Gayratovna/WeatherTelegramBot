using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using WeatherTelegramBot.Models;
using WeatherTelegramBot.Service;

namespace WeatherTelegramBot
{
    class Program
    {
        static string token = "7177218608:AAHk9LKMwRKd4UL3tRmBpIjmVv19ySSnD7c";

        static void Main()
        {
            TelegramBotClient client = new TelegramBotClient(token);
            client.StartReceiving(HandleUpdate, HandleError);

            Console.ReadKey();
        }

        private static async Task HandleUpdate(ITelegramBotClient client, Update update, CancellationToken token)
        {
            if(update.Message?.Type is MessageType.Text)
            {
                if(update.Message.Text is "/start")
                {
                    await client.SendTextMessageAsync(
                        chatId: update.Message.Chat.Id,
                        text: "Welcome to, Weather bot\nMenu👇🏻",
                        replyMarkup: MenuMarkupButton());

                    return;
                }
                if (update.Message.Text is "🏙 Toshkent sh")
                {
                    var information = await ApiService.GetWeather(41.311081, 69.240562);
                    string path = "../../../Images/toshkent-city.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Qashqadaryo v")
                {
                    var information = await ApiService.GetWeather(38.5639397, 65.53110959);
                    string path = "../../../Images/surxondaryo.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "Sirdaryo v")
                {
                    var information = await ApiService.GetWeather(40.3737191, 68.4341132);
                    string path = "../../../Images/surxondaryo.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Samarkand sh")
                {
                    var information = await ApiService.GetWeather(39.6550017, 66.9756954);
                    string path = "../../../Images/samarqand.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Buxoro v")
                {
                    var information = await ApiService.GetWeather(39.7802967, 64.4384298);
                    string path = "../../../Images/buxoro.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Andijon v")
                {
                    var information = await ApiService.GetWeather(40.7833471, 72.3506746);
                    string path = "../../../Images/andijon.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Navoiy v")
                {
                    var information = await ApiService.GetWeather(42, 64);
                    string path = "../../../Images/navoiy.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Jizzax v")
                {
                    var information = await ApiService.GetWeather(40.1331797, 67.8234081);
                    string path = "../../../Images/navoiy.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Toshkent v")
                {
                    var information = await ApiService.GetWeather(40.7291558, 68.1011867);
                    string path = "../../../Images/toshkent.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Nukus v")
                {
                    var information = await ApiService.GetWeather(42.4600229, 59.6176603);
                    string path = "../../../Images/nukus.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🏙 Surxondaryo v")
                {
                    var information = await ApiService.GetWeather(37.232927, 67.2767964);
                    string path = "../../../Images/surxondaryo.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }


                if (update.Message.Text is "🏙 Namangan v")
                {
                    var information = await ApiService.GetWeather(41.0036287, 71.2611952);
                    string path = "../../../Images/namangan.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }

                if (update.Message.Text is "🌆 Shakhrisabz sh")
                {
                    var information = await ApiService.GetWeather(39.0525821, 66.8278643);
                    string path = "../../../Images/shahrisabz.png";
                    using (var stream = new FileStream(path, FileMode.Open))
                    {
                        await client.SendPhotoAsync(
                            chatId: update.Message.Chat.Id,
                            photo: InputFileId.FromStream(stream),
                            caption: $"Country: City name: {information.city.name}\nDescription {information.list[0].weather[0].icon.ToString()}\nGradus {Convert.ToInt32(information.list[0].main.temp) + " °C"}"
                            );

                        return;
                    }
                }
            }

           
        }
        private static IReplyMarkup? MenuMarkupButton()
        {
            var keyboardButton = new ReplyKeyboardMarkup(
                    new List<KeyboardButton[]>(){

                new KeyboardButton[]
                {
                    new KeyboardButton("🏙 Toshkent sh"),
                    new KeyboardButton("🏙 Qashqadaryo v"),
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("🏙 Sirdaryo v "),
                    new KeyboardButton("🏙 Samarkand sh"),
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("🏙 Buxoro v"),
                    new KeyboardButton("🏙 Andijon v"),
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("🏙 Navoiy v"),
                    new KeyboardButton("🏙 Jizzax v"),
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("🏙 Toshkent v"),
                    new KeyboardButton("🏙 Nukus v"),
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("🏙 Surxondaryo v"),
                    new KeyboardButton("🏙 Namangan v"),
                },
                new KeyboardButton[]
                {
                    new KeyboardButton("🌆 Shakhrisabz sh"),
                    new KeyboardButton("🗺 My Location")
                },
                    });

            return keyboardButton;
        }
        

        private static async Task HandleError(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            System.Console.WriteLine(exception.Message);
        }
    }
}