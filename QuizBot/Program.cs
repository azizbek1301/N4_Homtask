using QuizBot;
using System.Text.Json;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;
using System.Data;
using Telegram.Bot.Types.ReplyMarkups;

public class Program
{
    public static int TestNumber;
    public static async Task Main()
    {

        string token = "6635159812:AAGJpbsG6wY0oizUfwrixl0RYYBNsnV4OIc";
        var botClient = new TelegramBotClient(token);

        using CancellationTokenSource cts = new();

        // StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
        ReceiverOptions receiverOptions = new()
        {
            AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
        };

        botClient.StartReceiving(
            updateHandler: HandleUpdateAsync,
            pollingErrorHandler: HandlePollingErrorAsync,
            receiverOptions: receiverOptions,
            cancellationToken: cts.Token
        );

        var me = await botClient.GetMeAsync();

        Console.WriteLine($"Start listening for @{me.Username}");
        Console.ReadLine();

        // Send cancellation request to stop bot
        cts.Cancel();

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var handler = update.Type switch
            {
                UpdateType.Message => HandleMessageAsync(botClient, update, cancellationToken),
                UpdateType.CallbackQuery => HandleCallBackQueryAsyn(botClient,update, cancellationToken)
            };

            try
            {
                await handler;
            }
            catch(Exception ex)
            {
                await Console.Out.WriteLineAsync($"Xato:{ex.Message}");
            }

   

            //Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");




            

        }

        Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }



    }

    private static async Task HandleCallBackQueryAsyn(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        
        var callBack = update.CallbackQuery;
        var tests = Testlar.GetTests();
        var test = tests[TestNumber - 1];
        var nextTest = tests[TestNumber];

        await CheckAnswerAsync(test,botClient, callBack, cancellationToken);
        TestNumber++;
        await SendNextQuestion(nextTest, botClient, update, cancellationToken);
    }

    private static async Task SendNextQuestion(Test nextTest, ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        // using Telegram.Bot.Types.ReplyMarkups;

        InlineKeyboardMarkup inlineKeyboard = new(new[]
        {
            
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: $"{nextTest.A}", callbackData: "A"),
                
            },
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: $"{nextTest.B}", callbackData: "B"),

            },
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: $"{nextTest.C}", callbackData: "C"),

            },
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: $"{nextTest.D}", callbackData: "D"),

            },





        }); 
       
        if(update.Message is null)
        {

            await botClient.SendTextMessageAsync(
                chatId:update.CallbackQuery.From.Id,
                text:$"{nextTest.Question}",
                replyMarkup:inlineKeyboard,
                cancellationToken:cancellationToken);
        }
        else
        {
            await botClient.SendTextMessageAsync(
             chatId: update.Message.Chat.Id,
             text: $"{nextTest.Question}",
             replyMarkup: inlineKeyboard,
             cancellationToken: cancellationToken);

        }


    }

    private static async Task CheckAnswerAsync(Test test,ITelegramBotClient botClient, CallbackQuery? callBack, CancellationToken cancellationToken)
    {
        if(callBack.Data==test.CorrectAnswer)
        {
            await botClient.SendTextMessageAsync(
                chatId: callBack.From.Id,
                text: $"To'g'ri malades",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);

        }
        else
        {
            await botClient.SendTextMessageAsync(
                chatId: callBack.From.Id,
                text: $"Xato",
                parseMode: ParseMode.Html,
                cancellationToken: cancellationToken);
        }
    }

    private static async Task HandleMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Message is not { } message)
            return;
        if (message.Text is not { } messageText)
            return;

        if (messageText == "/start")
        {
            await botClient.SendTextMessageAsync(
                chatId: update.Message.Chat.Id,
                text: $"Assalomu alaykum <b> {update.Message.From.FirstName}</b>",
                parseMode:ParseMode.Html,
                cancellationToken: cancellationToken);
        }
        TestNumber = 1;
        var tests = Testlar.GetTests();
        await SendNextQuestion(tests[0],botClient, update, cancellationToken);
    }

}

