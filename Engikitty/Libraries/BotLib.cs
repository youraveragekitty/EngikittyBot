/*

  Code is property of @youraveragekitty on Discord.

  Redistribution that does not follow the "BSD 3-Clause" License protecting the EngikittyBot project is not allowed.

*/

using Engikitty.Types;
using NetCord;

namespace Engikitty.Bot.Library
{
    public static class BotLib
    {
        public static string GetFullCommandName(SlashCommandInteraction AppCmdInteraction)
        {
            SlashCommandInteractionData Data = AppCmdInteraction.Data;
            string Name = Data.Name;

            if (Data.Options is { Count: > 0 } Options)
            {
                ApplicationCommandInteractionDataOption FirstOption = Options[0];

                if (FirstOption.Type == ApplicationCommandOptionType.SubCommandGroup)
                {
                    Name += $" {FirstOption.Name}";

                    if (FirstOption.Options is { Count: > 0 } SubOptions &&
                        SubOptions[0].Type == ApplicationCommandOptionType.SubCommand)
                    {
                        Name += $" {SubOptions[0].Name}";
                    }
                }
                else if (FirstOption.Type == ApplicationCommandOptionType.SubCommand)
                {
                    Name += $" {FirstOption.Name}";
                }
            }

            return Name;
        }

        public static CommandInfo GetCommandInfo(ApplicationCommandInteraction AppCmdInteraction)
        {
            string CommandName = AppCmdInteraction switch
            {
                SlashCommandInteraction Slash => GetFullCommandName(Slash),
                _ => AppCmdInteraction.Data.Name
            };

            if (!Info.Commands.TryGetValue(CommandName, out CommandInfo? CmdInfo))
            {
                Logger.Error($"Couldn't find command info for command '{CommandName}'...");
                throw new ArgumentNullException(nameof(CommandName));
            }

            return CmdInfo;
        }
    }
}