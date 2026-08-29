namespace Engikitty.Bot.Library
{
    public static class CmdStorage
    {
        public static readonly string[] EightBallResponses =
        [
            "idk bro", "yess my love", "no fuck you", "ew what no???", "i'm not answering that.",
            "not answering until you release the children in your basement", "absolutely not, delete this",
            "my lawyers have advised me not to answer this question",
            "signs point to... you crying about it later", "leave me alone", "ask your mom",
            "the answer is hiding in your walls", "outlook looks like a skill issue", "fuc koff, next",
            "reply hazy, try asking when you aren't hard", "yeah sure, whatever floats your boat",
            "the voices say yes", "the voices say no", "i'd say yes but then we'd both be wrong",
            "chances are lower than your grades", "yes, but it's gonna cost you", "maybe... if you say please",
            "imma keep it real with you chief, no", "concentrate and ask again when you aren't an air particle",
            "it is certain||ly no||", "bro, obviously yes", "bro, obviously no", "i sleep, check back later",
            "can you repeat that in a way that doesn't hurt my brain?", "signs point to absolutely yes",
            "my sources say you're coping", "without a single doubt",
            "dude stop, just stop", "outlook looks fantastic honestly",
            "the universe said no, don't shoot the messenger", "google is free you know", "yes, and that's a threat",
            "no, and that's a promise", "i've seen the future and it doesn't look good for you",
            "sounds like a tuesday problem",
            "you already know the answer is no", "bet", "yes (me when i lie)",
            "no, and i'm eating your leftovers in the fridge right now",
            "yeah sure totally (i didn't even read your question lol)", "yes, but a very large bird is coming for you",
            "no, and i'm stealing one shoe from every pair you own", "absolutely! (prepare to cry in your car later)",
            "no xoxo, hope you stub your toe on the coffee table",
            "yes, but i'm telling everyone you pee in the shower", "outlook looks bad, time to delete your account tbh",
            "yes, but it's going to taste like copper", "no, and i'm unfollowing you on everything",
            "yes, but only because i want to see the drama unfold", "no ❤️ (i am hating from the sidelines)",
            "sure, if you want the universe to immediately smite you",
            "i'd love to say yes, but i already sold your data to a sketchy offshore casino",
            "yes, but expect a pipe bomb in your mailbox by friday", "yes xoxo (i am lying to you)",
            "don't look behind you", "the council says maybe", "absolutely not bestie",
            "yeah probably unless you explode first", "my cat says yes",
            "my cat says no", "no but i respect the delusion", "you should be studied in a lab for asking that",
            "yes, but in a deeply embarrassing way", "the prophecy says maybe", "you got me giggling so yes",
            "no but points for confidence", "you already know the answer bro",
            "yeah but don't quote me on that", "nah gng", "yeah gng", "this is why aliens won't visit us",
            "i can't legally answer that", "yes but only if you do a backflip first",
            "i can smell the bad decision already", "you scare me sometimes",
            "i'm putting this in my cringe compilation", "yes, but only in ohio", "no, not even in ohio",
            "you need to be stopped", "i'd explain but the government is watching",
            "you don't wanna know the answer trust me", "yeah okay whatever",
            "you've got about a 3% success rate chief",
            "this feels illegal somehow", "yes but you're gonna trip down the stairs after",
            "no but you'll survive probably", "i'm not paid enough for this shit", "yes, unfortunately",
            "no, fortunately", "i need a cigarette after reading that", "brother ew",
            "you got this (you absolutely do not got this)", "no but it'd be really funny", "the answer is classified",
            "bro i'm just an 8ball not a therapist", "yeah no definitely maybe not", "you should delete this and run",
            "i can't stop you but i can judge you", "this is canon now",
            "you are NOT surviving the next patch notes", "no and your socks are wet now",
            "brother what are you talking about", "you've lost speaking privileges temporarily",
            "i'm sending this directly to nasa", "the answer is yes but in italics",
            "the answer is no in 4k ultra hd dolby atmos", "no but thanks for the free entertainment",
            "i need to sit down after this one", "there are easier ways to ruin your life",
            "yes but your toaster won't forgive you", "the ancient texts say lmao no", "the ancient texts say send it",
            "you should absolutely not call me again", "yes, and somehow that's worse", "no, and somehow that's better",
            "you're playing dangerous games here",
        ];

        public static readonly Dictionary<string, string> KokoroVoices = new()
        {
            // American English - Female
            ["af_heart"] = "Heart",
            ["af_bella"] = "Bella",
            ["af_nicole"] = "Nicole",
            ["af_aoede"] = "Aoede",
            ["af_kore"] = "Kore",
            ["af_sarah"] = "Sarah",
            ["af_nova"] = "Nova",
            ["af_alloy"] = "Alloy",
            ["af_sky"] = "Sky",
            ["af_jessica"] = "Jessica",
            ["af_river"] = "River",
 
            // American English - Male
            ["am_michael"] = "Michael",
            ["am_fenrir"] = "Fenrir",
            ["am_puck"] = "Puck",
            ["am_adam"] = "Adam",
            ["am_echo"] = "Echo",
            ["am_eric"] = "Eric",
            ["am_liam"] = "Liam",
            ["am_onyx"] = "Onyx",
            ["am_santa"] = "Santa",
 
            // British English - Female
            ["bf_emma"] = "Emma",
            ["bf_isabella"] = "Isabella",
            ["bf_alice"] = "Alice",
            ["bf_lily"] = "Lily",
 
            // British English - Male
            ["bm_george"] = "George (UK Male) - authoritative",
            ["bm_fable"] = "Fable (UK Male) - storyteller, warm",
            ["bm_lewis"] = "Lewis (UK Male) - confident, articulate",
            ["bm_daniel"] = "Daniel (UK Male) - professional, clear",
 
            // French
            ["ff_siwis"] = "Siwis (FR Female)",
 
            // Italian
            ["if_sara"] = "Sara (IT Female)",
            ["im_nicola"] = "Nicola (IT Male)",
 
            // Japanese
            ["jf_alpha"] = "Alpha (JP Female)",
            ["jf_gongitsune"] = "Gongitsune (JP Female)",
            ["jf_nezumi"] = "Nezumi (JP Female)",
            ["jf_tebukuro"] = "Tebukuro (JP Female)",
            ["jm_kumo"] = "Kumo (JP Male)",
 
            // Mandarin Chinese
            ["zf_xiaoxiao"] = "Xiaoxiao (CN Female)",
            ["zf_xiaobei"] = "Xiaobei (CN Female)",
            ["zf_xiaoni"] = "Xiaoni (CN Female)",
            ["zf_xiaoyi"] = "Xiaoyi (CN Female)",
            ["zm_yunxi"] = "Yunxi (CN Male)",
            ["zm_yunjian"] = "Yunjian (CN Male)",
            ["zm_yunxia"] = "Yunxia (CN Male)",
            ["zm_yunyang"] = "Yunyang (CN Male)"
        };
    }
}