/*

  Code is property of @youraveragekitty on Discord.

  Redistribution that does not follow the "BSD 3-Clause" License protecting the EngikittyBot project is not allowed.

*/

using Engikitty.Bot.Library;
using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Engikitty.Commands
{
    public class TopModule : ApplicationCommandModule<SlashCommandContext>
    {
        [SlashCommand(
            "translate", "Translate text from a language to another",
            Contexts = [InteractionContextType.Guild, InteractionContextType.DMChannel],
            IntegrationTypes = [ApplicationIntegrationType.GuildInstall, ApplicationIntegrationType.UserInstall]
        )]
        public async Task Translate(
            [SlashCommandParameter(Name = "text", Description = "The text to translate", MaxLength = 1024)]
            string Orig,
            [SlashCommandParameter(Name = "target", Description = "The language to target", MaxLength = 1024, AutocompleteProviderType = typeof(LanguageAutocompleteProvider))]
            string Target)
        {
            string Translated = await Bot.Library.CmdLib.TranslateAsync(Orig, Target);

            await Context.Interaction.ModifyResponseAsync(Message =>
            {
                Message.Embeds =
                [
                    new EmbedProperties()
                    {
                        Thumbnail = new EmbedThumbnailProperties(
                            "https://cdn.discordapp.com/attachments/1505301024443994263/1526178240568229958/bleh.jpg?ex=6a5613bf&is=6a54c23f&hm=ea363ec0295c9090ccdefbafa73d3a015b4a54ece56661665750e21e4bd5ea3b&"),
                        Title = "Done!!",
                        Description = "Engikitty translated that using the power of something, I have no idea what",
                        Fields = new List<EmbedFieldProperties>()
                        {
                            new()
                            {
                                Name = "Text",
                                Value = Orig,
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

        [SlashCommand(
            "tts", "Turn text into spoken audio",
            Contexts = [InteractionContextType.Guild, InteractionContextType.DMChannel],
            IntegrationTypes = [ApplicationIntegrationType.GuildInstall, ApplicationIntegrationType.UserInstall]
        )]
        public async Task Tts(
            [SlashCommandParameter(Name = "text", Description = "The text to speak", MaxLength = 1024)]
            string Orig,
            [SlashCommandParameter(Name = "voice", Description = "The voice to speak with", MaxLength = 1024, AutocompleteProviderType = typeof(EdgeVoiceAutocompleteProvider))]
            string Voice = "en-US-JennyNeural",
            [SlashCommandParameter(Name = "speed", Description = "Speech speed, 0.5x to 2x", MinValue = 0.5, MaxValue = 2.0)]
            double Speed = 1.0)
        {
            byte[]? Audio = await Bot.Library.CmdLib.SpeakAsync(Orig, Voice, (float)Speed);

            if (Audio is null)
            {
                await Context.Interaction.ModifyResponseAsync(Message =>
                {
                    Message.Embeds =
                    [
                        new EmbedProperties()
                        {
                            Thumbnail = new EmbedThumbnailProperties(
                                "https://cdn.discordapp.com/attachments/1505301024443994263/1526183398345937006/DEATH.gif?ex=6a92bd8d&is=6a916c0d&hm=206067e8ed4fdcab3d8f7b76e7b68f46261755ea07348699cd9dec2a86fdb87b&"),
                            Title = "Dang it..",
                            Description = "Engikitty lost their voice..",
                            Color = new Color(46, 111, 64),
                            Timestamp = DateTimeOffset.UtcNow,
                        }
                    ];
                });

                return;
            }

            using MemoryStream Stream = new(Audio);

            await Context.Interaction.ModifyResponseAsync(Message =>
            {
                Message.Attachments = new List<AttachmentProperties>()
                {
                    new("tts.mp3", Stream)
                };

                Message.Embeds =
                [
                    new EmbedProperties()
                    {
                        Thumbnail = new EmbedThumbnailProperties(
                            "https://cdn.discordapp.com/attachments/1505301024443994263/1526178240568229958/bleh.jpg?ex=6a5613bf&is=6a54c23f&hm=ea363ec0295c9090ccdefbafa73d3a015b4a54ece56661665750e21e4bd5ea3b&"),
                        Title = "Done!!",
                        Description = "Engikitty spoke that using the power of something, I have no idea what",
                        Fields = new List<EmbedFieldProperties>()
                        {
                            new()
                            {
                                Name = "Text",
                                Value = Orig,
                            },

                            new()
                            {
                                Name = "Voice",
                                Value = CmdStorage.EdgeVoiceNames.GetValueOrDefault(Voice, Voice),
                            }
                        },
                        Color = new Color(46, 111, 64),
                        Timestamp = DateTimeOffset.UtcNow,
                    }
                ];
            });
        }
    }
}