
using FilmSearchBot;
using FilmSearchBot.Exceptoins;
using FilmSearchBot.Services;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

public class Program
{
    public static async Task Main(string[] args)
    {
        var botClient = new TelegramBotClient("yourToken");

        using CancellationTokenSource cts = new();

        ReceiverOptions receiverOptions = new()
        {
            AllowedUpdates = Array.Empty<UpdateType>()
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

        cts.Cancel();

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var handler = update.Type switch
            {
                UpdateType.Message => HandleMessageAsync(botClient, update, cancellationToken),
                UpdateType.CallbackQuery => HandleCallBackQueryAsync(botClient, update, cancellationToken),
                _ => HandeUnknownUpdateType(botClient, update, cancellationToken)
                //Yana update larni davom ettirib tutishingiz mumkin
            };

            try
            {
                await handler;
            }
            catch (HandleUnknownException ex)
            {
                await Console.Out.WriteLineAsync($"HandleUnknownException:{ex.Message}");
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync($"Exception:{ex.Message}");
            }
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

    private static async Task HandeUnknownUpdateType(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        throw new HandleUnknownException("Unknown update type");
    }

    private static async Task HandleCallBackQueryAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.CallbackQuery is not { } callBack)
            return;

        if (callBack.Data.StartsWith("page="))
        {
            await BotService.EditFilmListAsync(botClient, callBack, cancellationToken);
        }

        else if (callBack.Data.StartsWith("delete="))
        {
            await botClient.DeleteMessageAsync(
                chatId: callBack.From.Id,
                messageId: callBack.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else
        {
            var film = await ApiBroker.GetFilmAsync(callBack.Data);
            await BotService.SendFilmAsync(film, botClient, callBack, cancellationToken);
        }
    }

    private static async Task HandleMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Message is not { } message)
            return;
        if (message.Text is not { } messageText)
            return;

        Console.WriteLine($"Received a '{messageText}' message in chat {update.Message.Chat.Id}.");

        var root = await ApiBroker.GetFilmListAsync(messageText);

        await BotService.SendFilmListAsync(messageText, botClient, update, cancellationToken);
    }
}
