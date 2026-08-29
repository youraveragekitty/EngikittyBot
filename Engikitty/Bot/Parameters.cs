using Engikitty.Types;

namespace Engikitty.Bot
{
    /// <summary>
    /// Class containing general info regarding the bot
    /// (Commands, version, etc)
    /// </summary>
    public static class Info
    {
        /// <summary>
        /// Dictionary containing CommandInfo class instances,
        /// used notably in Bot.cs to know if a command is ephemeral and/or is heavy
        /// </summary>
        public static readonly Dictionary<string, CommandInfo> Commands = new()
        {
            // Top
            
            ["translate"] = new(CooldownOnThisCommand:4),
            ["tts"] = new (CooldownOnThisCommand:5),
            
            // Bot
            
            ["bot ping"] = new(),

            // Fun

            ["fun badtranslate"] = new(IsHeavy:true),
            ["fun 8ball"] = new(),
            ["fun ask-engikitty"] = new(IsHeavy:true, CooldownOnThisCommand: 10),

            // Contextual

            ["Bad Translate (5 times)"] = new(IsHeavy:true),
            ["Bad Translate (10 times)"] = new(IsHeavy:true),
            ["Bad Translate (20 times)"] = new(IsHeavy:true),
            ["Engikitty Reply"] = new(IsHeavy:true, CooldownOnThisCommand: 10)
        };
    }
}