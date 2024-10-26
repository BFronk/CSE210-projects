using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video vid1 = new Video("mr. Beast", "Exploring an underground city", 1235, new List<Comment>());
        videos.Add(vid1);
        vid1.addComment(new Comment("MrBeast", "The Chaos in this video is unreal lol"));
        vid1.addComment(new Comment("lxrdensv", "blurring iShowSpeed and Kais faces like we wouldn't notice"));
        vid1.addComment(new Comment("HOWBRAVE", "Chandlers comeback = YESSSSSS"));
        vid1.addComment(new Comment("Sony777_ss", "aint no party like a mrbeast party"));
        vid1.addComment(new Comment("Grace-pp7pd", "Finally Chandler is back"));
        Video vid2 = new Video("mr. Beast", "Exploring an underground city", 1235, new List<Comment>());
        videos.Add(vid2);
        vid2.addComment(new Comment("MrBeast", "The Chaos in this video is unreal lol"));
        vid2.addComment(new Comment("lxrdensv", "blurring iShowSpeed and Kais faces like we wouldn't notice"));
        vid2.addComment(new Comment("HOWBRAVE", "Chandlers comeback = YESSSSSS"));
        vid2.addComment(new Comment("Sony777_ss", "aint no party like a mrbeast party"));
        vid2.addComment(new Comment("Grace-pp7pd", "Finally Chandler is back"));       
        Video vid3 = new Video("mr. Beast", "Exploring an underground city", 1235, new List<Comment>());
        videos.Add(vid3);
        vid3.addComment(new Comment("MrBeast", "The Chaos in this video is unreal lol"));
        vid3.addComment(new Comment("lxrdensv", "blurring iShowSpeed and Kais faces like we wouldn't notice"));
        vid3.addComment(new Comment("HOWBRAVE", "Chandlers comeback = YESSSSSS"));
        vid3.addComment(new Comment("Sony777_ss", "aint no party like a mrbeast party"));
        vid3.addComment(new Comment("Grace-pp7pd", "Finally Chandler is back"));        
        foreach (var video in videos)
        {
            Console.WriteLine("");
            video.displayInfo();
        }

    }
}