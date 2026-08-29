/*

  Code is property of @youraveragekitty on Discord.

  Redistribution that does not follow the "BSD 3-Clause" License protecting the EngikittyBot project is not allowed.

*/

using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Engikitty.Commands
{
    /// <summary>
    /// Command module for every contextual command, such as message commands or user commands
    /// </summary>
    public class ContextModule : ApplicationCommandModule<MessageCommandContext>
    {
        /// <summary>
        /// Bad-translates text 5 times
        /// </summary>
        /// <param name="Msg">Message used to extract content</param>
        [MessageCommand(
            "Bad Translate (5 times)",
            Contexts = [InteractionContextType.Guild, InteractionContextType.DMChannel],
            IntegrationTypes = [ApplicationIntegrationType.GuildInstall, ApplicationIntegrationType.UserInstall]
        )]
        public async Task BadTranslate5(RestMessage Msg)
        {
            await Bot.Library.CmdLib.DoMessageBadTranslate(Msg.Content, 5, Context);
        }

        /// <summary>
        /// Bad-translates text 10 times
        /// </summary>
        /// <param name="Msg">Message used to extract content</param>
        [MessageCommand(
            "Bad Translate (10 times)",
            Contexts = [InteractionContextType.Guild, InteractionContextType.DMChannel],
            IntegrationTypes = [ApplicationIntegrationType.GuildInstall, ApplicationIntegrationType.UserInstall]
        )]
        public async Task BadTranslate10(RestMessage Msg)
        {
            await Bot.Library.CmdLib.DoMessageBadTranslate(Msg.Content, 10, Context);
        }

        /// <summary>
        /// Bad-translates text 20 times
        /// </summary>
        /// <param name="Msg">Message used to extract content</param>
        [MessageCommand(
            "Bad Translate (20 times)",
            Contexts = [InteractionContextType.Guild, InteractionContextType.DMChannel],
            IntegrationTypes = [ApplicationIntegrationType.GuildInstall, ApplicationIntegrationType.UserInstall]
        )]
        public async Task BadTranslate20(RestMessage Msg)
        {
            await Bot.Library.CmdLib.DoMessageBadTranslate(Msg.Content, 20, Context);
        }
        
        [MessageCommand(
            "Translate",
            Contexts = [InteractionContextType.Guild, InteractionContextType.DMChannel],
            IntegrationTypes = [ApplicationIntegrationType.GuildInstall, ApplicationIntegrationType.UserInstall]
        )]
        public async Task Translate(RestMessage Msg)
        {
            string Translated = await Bot.Library.CmdLib.TranslateAsync(Msg.Content, "en");
            
            await Context.Interaction.ModifyResponseAsync(Message =>
            {
                Message.Embeds =
                [
                    new EmbedProperties()
                    {
                        Thumbnail = new EmbedThumbnailProperties(
                            "https://cdn.discordapp.com/attachments/1505301024443994263/1526178240568229958/bleh.jpg?ex=6a5613bf&is=6a54c23f&hm=ea363ec0295c9090ccdefbafa73d3a015b4a54ece56661665750e21e4bd5ea3b&"),
                        Title = "Done!!",
                        Description = "Engikitty translated that using the power of something, I have no idea what.",
                        Fields = new List<EmbedFieldProperties>()
                        {
                            new()
                            {
                                Name = "Text",
                                Value = Msg.Content,
                            },

                            new()
                            {
                                Name = "Translated",
                                Value = Translated,
                            }
                        },
                        Color = new Color(46, 111, 64),
                        Timestamp = DateTimeOffset.UtcNow,
                    }
                ];
            });
        }
        
        [MessageCommand(
            "Engikitty Reply",
            Contexts = [InteractionContextType.Guild, InteractionContextType.DMChannel],
            IntegrationTypes = [ApplicationIntegrationType.GuildInstall, ApplicationIntegrationType.UserInstall]
        )]
        public async Task EngikittyReply(RestMessage Msg)
        {
            await Bot.Library.CmdLib.PromptGroq(Msg.Content, Context);
        }
    }
}