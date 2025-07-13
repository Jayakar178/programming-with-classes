using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video(
            "Philosophy – Aristotle",
            "The School of Life",
            450
        );
        video1.AddComment(new Comment("Alice", "Insightful explanation of virtue."));
        video1.AddComment(new Comment("Brian", "Makes Aristotle easy to understand."));
        video1.AddComment(new Comment("Cindy", "Perfect for philosophy beginners."));

        var video2 = new Video(
            "PHILOSOPHY – Thomas Aquinas",
            "The School of Life",
            600
        );
        video2.AddComment(new Comment("Dan", "Perfect overview of Aquinas."));
        video2.AddComment(new Comment("Eva", "Clear and well-presented."));
        video2.AddComment(new Comment("Frank", "It’s great to see faith + reason explained."));

        var video3 = new Video(
            "PHILOSOPHY – Thomas Aquinas (Deep Dive)",
            "The School of Life",
            600
        );
        video3.AddComment(new Comment("Gina", "Loved this detailed breakdown."));
        video3.AddComment(new Comment("Hank", "Really deep and informative."));
        video3.AddComment(new Comment("Ivy", "Helps solidify my understanding."));

        var video4 = new Video(
            "PHILOSOPHY – The Stoics",
            "The School of Life",
            293
        );
        video4.AddComment(new Comment("Jake", "Stoicism has changed my mindset."));
        video4.AddComment(new Comment("Luna", "Loved the illustrations in this one."));
        video4.AddComment(new Comment("Mia", "Clear and powerful message."));

        var videos = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
