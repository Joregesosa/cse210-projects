using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Find your way home", "Jonas Thunder", 60);
        video1.AddComment(new Comment("John Doe", "Great video!"));
        video1.AddComment(new Comment("Maria Gutierrez", "I love this video!"));
        video1.AddComment(new Comment("Sara Sotomarino", "This video is amazing!"));

        Video video2 = new Video("The last sunset", "Javier Corsario", 84);
        video2.AddComment(new Comment("Manuel Soto", "Great video!"));
        video2.AddComment(new Comment("Marcos Electro", "What is the song name?"));
        video2.AddComment(new Comment("Dario Jose", "Nice Job!"));

        Video video3 = new Video("Introduction to C# ", "Rocio Santana", 201);
        video3.AddComment(new Comment("Emilio Quiroz", "Great explanation"));
        video3.AddComment(new Comment("Maria Gutierrez", "I love this video!"));
        video3.AddComment(new Comment("Sara Sotomarino", "This video is amazing!"));
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Console.Clear();
        foreach (var video in videos)
        {

            Console.WriteLine($"Title: {video._videoTitle}.");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"    Author: {video._videoAuthor}." );
            Console.WriteLine($"    Length: {video._videoLength} seconds." );
            Console.WriteLine($"    Comments: {video.GetCommentsCount()}." );
            Console.WriteLine("------------------------------------------------------\n");
            
        }
    }
}