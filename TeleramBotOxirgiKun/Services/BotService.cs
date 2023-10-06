﻿using FilmSearchBot.Models;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace FilmSearchBot.Services
{
    public class BotService
    {
        public static async Task SendFilmAsync(Film film, ITelegramBotClient botClient, CallbackQuery callback, CancellationToken cancellationToken)
        {
            InlineKeyboardMarkup inlineKeyboard = new(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "❌", callbackData: $"delete={callback.Message.MessageId}")
                }
            });

            if (film.Poster == null || film.Poster == "N/A")
            {
                await botClient.SendTextMessageAsync(
                    chatId: callback.From.Id,
                    text: $"Title:<i>{film.Title}</i>\n" +
                    $"Year:<i>{film.Year}</i>\n" +
                    $"Released<i>:{film.Released}</i>\n" +
                    $"Duration:<i>{film.Runtime}</i>\n" +
                    $"Genre:<i>{film.Genre}</i>\n" +
                    $"Actors:<i>{film.Actors}</i>\n" +
                    $"Director:<i>{film.Director}</i>\n" +
                    $"Description:<i>{film.Plot}</i>\n" +
                    $"Country:<i>{film.Country}</i>\n" +
                    $"Awards:<i>{film.Awards}</i>\n",
                    replyMarkup: inlineKeyboard,
                    parseMode: ParseMode.Html,
                    cancellationToken: cancellationToken
                    );
            }
            else
            {
                await botClient.SendPhotoAsync(
                    chatId: callback.From.Id,
                    photo: InputFile.FromUri(film.Poster),
                    caption: $"Title:<i>{film.Title}</i>\n" +
                    $"Year:<i>{film.Year}</i>\n" +
                    $"Released<i>:{film.Released}</i>\n" +
                    $"Duration:<i>{film.Runtime}</i>\n" +
                    $"Genre:<i>{film.Genre}</i>\n" +
                    $"Actors:<i>{film.Actors}</i>\n" +
                    $"Director:<i>{film.Director}</i>\n" +
                    $"Description:<i>{film.Plot}</i>\n" +
                    $"Country:<i>{film.Country}</i>\n" +
                    $"Awards:<i>{film.Awards}</i>\n",
                    replyMarkup: inlineKeyboard,
                    parseMode: ParseMode.Html,
                    cancellationToken: cancellationToken
                    );
            }
        }

        public static async Task SendFilmListAsync(string messageText, ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var root = await ApiBroker.GetFilmListAsync(messageText);
            var listOfSearch = root.Search;
            if (listOfSearch == null)
            {
                await botClient.SendTextMessageAsync(
                    chatId: update.Message.Chat.Id,
                    text: "Bu nomli kino topilmadi uzur",
                    replyToMessageId: update.Message.MessageId,
                    cancellationToken: cancellationToken
                    );

                return;
            }

            var page = root.PageNumber;
            var searchKey = root.SearchKey;

            int count = 0;
            var listOfInlineKeyboardButton = new List<List<InlineKeyboardButton>>();
            var inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();


            //agar 5dan kichik bo'lsa bir qator
            if (listOfSearch.Count <= 5)
            {
                inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();
                for (int j = 1; j <= listOfSearch.Count; j++)
                {
                    inlineKeyBoardButtonsRow.Add(InlineKeyboardButton.WithCallbackData($"{count + 1}", $"{listOfSearch[count].imdbID}"));
                    count++;
                }
                listOfInlineKeyboardButton.Add(inlineKeyBoardButtonsRow);
            }
            else//agar 5dan katta bo'lsa 2 qator
            {
                inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();
                for (int j = 1; j <= 5; j++)
                {
                    inlineKeyBoardButtonsRow.Add(InlineKeyboardButton.WithCallbackData($"{count + 1}", $"{listOfSearch[count].imdbID}"));
                    count++;
                }
                listOfInlineKeyboardButton.Add(inlineKeyBoardButtonsRow);

                inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();
                for (int j = 1; j <= listOfSearch.Count - 5; j++)
                {
                    inlineKeyBoardButtonsRow.Add(InlineKeyboardButton.WithCallbackData($"{count + 1}", $"{listOfSearch[count].imdbID}"));
                    count++;
                }
                listOfInlineKeyboardButton.Add(inlineKeyBoardButtonsRow);
            }

            //pagination uchun yana bir qator 
            //shu yerga paginationni oxirgi pagemi yo'qmi biladigan code yozish kerak 
            listOfInlineKeyboardButton.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData($"⬅️", $"page={page-1} {searchKey}"),
            InlineKeyboardButton.WithCallbackData($"➡️", $"page={page+1} {searchKey}"),
        });

            var inlineKeyboard = new InlineKeyboardMarkup(listOfInlineKeyboardButton);

            var TitleOfFilms = $"<b>Films page:{page} <i>(search:{searchKey} total result:{root.totalResults})</i>:</b>";
            for (int i = 0; i < listOfSearch.Count; i++)
            {
                TitleOfFilms += $"\n{i + 1}.<i>{listOfSearch[i].Title}-{listOfSearch[i].Year}</i>";
            }

            await botClient.SendTextMessageAsync(
                chatId: update.Message.Chat.Id,
                text: TitleOfFilms,
                parseMode: ParseMode.Html,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }

        public static async Task EditFilmListAsync(ITelegramBotClient botClient, CallbackQuery callBack, CancellationToken cancellationToken)
        {
            var listofKeys = callBack.Data[5..].Split(' ');
            var oldPageNumber = int.Parse(listofKeys[0]);
            var searchKey = listofKeys[1];

            var root = await ApiBroker.GetFilmListAsync(searchKey, oldPageNumber);
            var listOfSearch = root.Search;
            if (listOfSearch == null)
                return;

            var page = root.PageNumber;

            int count = 0;
            var listOfInlineKeyboardButton = new List<List<InlineKeyboardButton>>();
            var inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();


            //agar 5dan kichik bo'lsa bir qator
            if (listOfSearch.Count <= 5)
            {
                inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();
                for (int j = 1; j <= listOfSearch.Count; j++)
                {
                    inlineKeyBoardButtonsRow.Add(InlineKeyboardButton.WithCallbackData($"{count + 1}", $"{listOfSearch[count].imdbID}"));
                    count++;
                }
                listOfInlineKeyboardButton.Add(inlineKeyBoardButtonsRow);
            }
            else//agar 5dan katta bo'lsa 2 qator
            {
                inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();
                for (int j = 1; j <= 5; j++)
                {
                    inlineKeyBoardButtonsRow.Add(InlineKeyboardButton.WithCallbackData($"{count + 1}", $"{listOfSearch[count].imdbID}"));
                    count++;
                }
                listOfInlineKeyboardButton.Add(inlineKeyBoardButtonsRow);

                inlineKeyBoardButtonsRow = new List<InlineKeyboardButton>();
                for (int j = 1; j <= listOfSearch.Count - 5; j++)
                {
                    inlineKeyBoardButtonsRow.Add(InlineKeyboardButton.WithCallbackData($"{count + 1}", $"{listOfSearch[count].imdbID}"));
                    count++;
                }
                listOfInlineKeyboardButton.Add(inlineKeyBoardButtonsRow);
            }

            //pagination uchun yana bir qator 
            //shu yerga paginationni oxirgi pagemi yo'qmi biladigan code yozish kerak 
            listOfInlineKeyboardButton.Add(new List<InlineKeyboardButton>()
        {
            InlineKeyboardButton.WithCallbackData($"⬅️", $"page={page-1} {searchKey}"),
            InlineKeyboardButton.WithCallbackData($"➡️", $"page={page+1} {searchKey}"),
        });

            var inlineKeyboard = new InlineKeyboardMarkup(listOfInlineKeyboardButton);

            var TitleOfFilms = $"<b>Films page:{page} <i>(search:{searchKey} total result:{root.totalResults})</i>:</b>";
            for (int i = 0; i < listOfSearch.Count; i++)
            {
                TitleOfFilms += $"\n{i + 1}.<i>{listOfSearch[i].Title}-{listOfSearch[i].Year}</i>";
            }

            await botClient.EditMessageTextAsync(
                chatId: callBack.From.Id,
                text: TitleOfFilms,
                messageId: callBack.Message.MessageId,
                parseMode: ParseMode.Html,
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }
}