using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("A Million Worlds", "SongsOfHope", 600);
        video1.AddComment(new Comment("RoudaboutOfLife", "What a fantastic song! Such a talenetd composer."));
        video1.AddComment(new Comment("ElenorRyloth", "This feels like waking up to the smell of tea in the morning."));
        video1.AddComment(new Comment("WandaWorlds", "WOW! This brings back memories, my mom used to sing this songwhile she baked."));

        //Fun fact, this is a real video with its real comments!
        Video video2 = new Video("My Jolly Sailor Bold", "Ashley Serena", 264);
        video2.AddComment(new Comment("williamb.5032", "So, as an active duty sailor, can confirm, would drag me to my death."));
        video2.AddComment(new Comment("spencer8093", "All pirates: LOOKS LIKE WE'RE DYING TONIGHT!"));
        video2.AddComment(new Comment("gloriaDeb", "Mermaids: (silence) Sailors: Why do I hear boss music?"));

        //Fun fact, this is also a real video with its real comments!
        Video video3 = new Video("Phantom of the Opera", "Lindsey Sterling", 446);
        video3.AddComment(new Comment("Christ-bv1ck", "I love how you can always see her smiling as she plays. She loves what she is doing and it comes through in the quality of her playing"));
        video3.AddComment(new Comment("masonp.6255", "I like this song better BEFORE the moon was destroyed..."));
        video3.AddComment(new Comment("MarkosDantes", "you know you've watched Phantom of the Opera too many times when you can sing all of the songs in this medley."));
        video3.AddComment(new Comment("todddevere8597", "This is one of my all-time favorites. It really shows how good of a performer and violinist she is; mad respect girl"));

        Video video4 = new Video("Epic Mountain Biking", "TrailBlazer", 300);
        video4.AddComment(new Comment("Jack&Rose", "Insane skills!"));
        video4.AddComment(new Comment("KiraLione", "Where was this filmed?"));
        video4.AddComment(new Comment("LeonardoDenierro", "I need a bike like that."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetComment()}");
            }
            Console.WriteLine(new string('-', 50));
        }

    }
}