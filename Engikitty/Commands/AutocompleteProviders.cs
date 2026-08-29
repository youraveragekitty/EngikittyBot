using Engikitty.Bot.Library;
using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Engikitty.Commands
{
    public class LanguageAutocompleteProvider : IAutocompleteProvider<AutocompleteInteractionContext>
    {
        public ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>?> GetChoicesAsync(
            ApplicationCommandInteractionDataOption Option,
            AutocompleteInteractionContext Context)
        {
            string Input = Option.Value ?? string.Empty;

            IEnumerable<ApplicationCommandOptionChoiceProperties> Results = LingvaSharp.Languages.Target
                .Where(Pair =>
                    Pair.Value.Contains(Input, StringComparison.OrdinalIgnoreCase) ||
                    Pair.Key.Contains(Input, StringComparison.OrdinalIgnoreCase))
                .Take(25)
                .Select(Pair => new ApplicationCommandOptionChoiceProperties(Pair.Value, Pair.Key));

            return ValueTask.FromResult<IEnumerable<ApplicationCommandOptionChoiceProperties>?>(Results);
        }
    }

    public class EdgeVoiceAutocompleteProvider : IAutocompleteProvider<AutocompleteInteractionContext>
    {
        public ValueTask<IEnumerable<ApplicationCommandOptionChoiceProperties>?> GetChoicesAsync(
            ApplicationCommandInteractionDataOption Option, 
            AutocompleteInteractionContext Context)
        {
            string Query = Option.Value ?? "";

            IEnumerable<ApplicationCommandOptionChoiceProperties> Choices = CmdStorage.EdgeVoiceNames
                .Where(Pair =>
                    Query.Length == 0 ||
                    Pair.Key.Contains(Query, StringComparison.OrdinalIgnoreCase) ||
                    Pair.Value.Contains(Query, StringComparison.OrdinalIgnoreCase))
                .Take(25)
                .Select(Pair => new ApplicationCommandOptionChoiceProperties(Pair.Value, Pair.Key));

            return new(Choices);
        }
    }
}