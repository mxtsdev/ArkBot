﻿using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace ArkBot.Extensions
{
    public static class DiscordChannelExtensions
    {
        public static async Task<IUserMessage> SendMessageDirectedAt(this IMessageChannel channel, ulong discordUserId, string text)
        {
            return await ((ISocketMessageChannel)channel).SendMessageAsync(channel.GetMessageDirectedAtText(discordUserId, text));
        }

        public static string GetMessageDirectedAtText(this IMessageChannel channel, ulong discordUserId, string text)
        {
            if (channel is SocketDMChannel) return text.FirstCharToUpper();
            else return $"<@{discordUserId}>, {text}";
        }
    }
}
