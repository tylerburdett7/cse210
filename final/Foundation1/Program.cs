using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> firstVideoComments = new List<Comment> {
            new Comment("Taylor Swift", "So proud of you! You'll do great things"),
            new Comment("The King James", "You've grown up so fast good work man"),
            new Comment("Leo Messi", "Hey, you're better than me at Futbol")
        };

        var firstVideo = new Video("I am going to pass CSE210 (Not Clickbait!!!!)", "Tyler Burdett", "10:32", firstVideoComments);
        firstVideo.DisplayVideoInfo();

        List<Comment> secondVideoComments = new List<Comment> {
            new Comment("1996-Toyota-Corolla", "honk"),
            new Comment("billfrommontana", "Cool video"),
            new Comment("poor college student", "I don't really know what to put in these comments")
        };

        var secondVideo = new Video("Doom scrolling until I pass out", "RelaxingAtom", "72:37:21", secondVideoComments);
        secondVideo.DisplayVideoInfo();

        List<Comment> thirdVideoComments = new List<Comment> {
            new Comment("BruhLoon", "Bro lost 10 bucks"),
            new Comment("gulliblegoblin76", "This is awesome I'm gonna try this with my friend later"),
            new Comment("fortniteEpicTime", "does this work for V-bucks??"),
            new Comment("mrbubbles", "I tried it and it didn't work. Reported video for false information")
        };

        var thirdVideo = new Video("Infinite Money Glitch IRL", "stupidSteve123", "00:36", thirdVideoComments);
        thirdVideo.DisplayVideoInfo();
    }
}