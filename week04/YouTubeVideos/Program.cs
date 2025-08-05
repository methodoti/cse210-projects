using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to W04 Assignment: YouTube Video Program!");

        List<Video> videos = new List<Video>();

        string title;
        string author;
        int length;
        string commenterName;
        string commentText;

        // Video 1
        title = "Learning C# in 10 Minutes";
        author = "Professor Coder";
        length = 600;
        Video video1 = new Video(title, author, length);
        commenterName = "Anna";
        commentText = "Excellent explanation, very straight to the point!";
        video1.AddComment(commenterName, commentText);
        commenterName = "Bruno";
        commentText = "I finally understood the basics of classes. Thank you!";
        video1.AddComment(commenterName, commentText);
        commenterName = "Carla";
        commentText = "I would like more examples in the next video.";
        video1.AddComment(commenterName, commentText);
        videos.Add(video1);

        // Video 2
        title = "Easy Chocolate Cake Recipe";
        author = "Chef Maria";
        length = 450;
        Video video2 = new Video(title, author, length);
        commenterName = "Daniel";
        commentText = "I made it at home and it was delicious! I recommend it.";
        video2.AddComment(commenterName, commentText);
        commenterName = "Eduarda";
        commentText = "The batter was a bit dry, did I get the temperature wrong?";
        video2.AddComment(commenterName, commentText);
        commenterName = "Fernando";
        commentText = "Best recipe on the internet.";
        video2.AddComment(commenterName, commentText);
        commenterName = "Gabriela";
        commentText = "I loved the frosting tips.";
        video2.AddComment(commenterName, commentText);
        videos.Add(video2);

        // Video 3
        title = "Gardening Guide for Beginners";
        author = "Bia's Garden";
        length = 920;
        Video video3 = new Video(title, author, length);
        commenterName = "Hugo";
        commentText = "My plants thank you! Great content.";
        video3.AddComment(commenterName, commentText);
        commenterName = "Isabela";
        commentText = "I didn't know it was so easy to care for succulents.";
        video3.AddComment(commenterName, commentText);
        commenterName = "Joao";
        commentText = "Could you talk about pest control?";
        video3.AddComment(commenterName, commentText);
        videos.Add(video3);

        // Video 4
        title = "Review of the Game 'Cyber Cosmos'";
        author = "Gamer Zone";
        length = 1250;
        Video video4 = new Video(title, author, length);
        commenterName = "Leo";
        commentText = "I agree with the analysis, the graphics are incredible.";
        video4.AddComment(commenterName, commentText);
        commenterName = "Mariana";
        commentText = "I still think the story could be better.";
        video4.AddComment(commenterName, commentText);
        commenterName = "Nelson";
        commentText = "I bought the game because of your review!";
        video4.AddComment(commenterName, commentText);
        videos.Add(video4);

        foreach (Video v in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Video Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length (in seconds): {v.GetLength()}");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            for (int i = 0; i < v.GetCommentCount(); i++)
            {
                Console.WriteLine($"Name: {v.GetComments()[i].GetCommenterName()}");
                Console.WriteLine($"Comment: {v.GetComments()[i].GetText()}");
            }   
        }
    }
}