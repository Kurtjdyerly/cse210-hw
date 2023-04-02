using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("OverSimplified","The War of the Bucket",1840);
        video1.AddComment(new Comment("no","what is happing IN THE MIDDLE OF DA VID"));
        video1.AddComment(new Comment(" Rem Crimson","Here we come REEEEEE!"));
        video1.AddComment(new Comment("Henry Stracke","Hahahahah"));

        Video video2 = new Video("MIKAN","Team Core Destruction x Multiply or Release",2000);
        video2.AddComment(new Comment("DoodleChaos","How on earth did you script the bottom thief section to steal from each side so smoothly. The creativity of these challenges blows my mind. Amazing job keep it up!"));
        video2.AddComment(new Comment("RomanQrr","It might be just my preference, but Release zones were a bit too big. Maybe an interesting addition would be a some kind of mechanism for the team to shrink those if only for a time?"));
        video2.AddComment(new Comment("Naail 382","Then best detail that I notice is How Mikan, paired the complementary colours in matching abilities. Orange and cyan are complementary, likewise is Lime and Magenta; yellow and purple. But Blue and red aren't complementary, though they look totally opposite."));

        Video video3 = new Video("Tier Zoo","The Fish Tier List",500);
        video3.AddComment(new Comment("EarleyKJE","I could've gone my whole life without seeing that piranha's eyes bulge out of its head and now here I am.... Great video as always."));
        video3.AddComment(new Comment("May Be Something","You don't play support classes to have fun, you play them to help other players pop off. The Ocean Sunfish is the support class to support classes."));
        video3.AddComment(new Comment("BLM2295","Oh my God that clip of the elephant walking past the lion saying \"Mess around and find out\" kills me 😂"));

        video1.Display();
        video2.Display();
        video3.Display();
    }
}