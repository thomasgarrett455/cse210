using System;

class Program
{
    static void Main(string[] args)
    {
        Videos myVideo = new Videos("Cool Video", "Thomas", 120);
        myVideo.AddComment(new Comments("Alice", "Great Video!"));
        myVideo.AddComment(new Comments("Bob", "I learned a lot."));
        myVideo.AddComment(new Comments("Jill", "Thank you for sharing."));

        Videos myVideo2 = new Videos("Skating in the park", "Joey", 25);
        myVideo2.AddComment(new Comments("Alice", "It was fun to watch!"));
        myVideo2.AddComment(new Comments("Bob", "Why don't you post more often."));
        myVideo2.AddComment(new Comments("Jill", "Cool tricks."));

        Videos myVideo3 = new Videos("Late nite chats", "John", 35);
        myVideo3.AddComment(new Comments("Frank", "I agree with you opinion."));
        myVideo3.AddComment(new Comments("Phill", "We need more youtubers like you."));
        myVideo3.AddComment(new Comments("Abby", "Politics is not my jam!"));

        List<Videos> myVideos = new List<Videos>();
        myVideos.Add(myVideo);
        myVideos.Add(myVideo2);
        myVideos.Add(myVideo3);
        foreach (Videos video in myVideos)
        {
            DisplayVideoInformation(video);
        }

    }

    private static void DisplayVideoInformation(Videos video)
    {
        Console.WriteLine(video.DisplayVideoInfo());
    }
}