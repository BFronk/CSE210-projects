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
        Video vid2 = new Video("mr. Beast", "100 identical twins fight for $100,000", 2139, new List<Comment>());
        videos.Add(vid2);
        vid2.addComment(new Comment("MrBeast", "What was your favorite challenge in the video?"));
        vid2.addComment(new Comment("MFTN2", "THe Karen twins were mad annoying"));
        vid2.addComment(new Comment("xVongolaXH", "Am I stupid? I wouldnt even be abke to get thriugh the second round of remembering the colors lol"));
        vid2.addComment(new Comment("Y_simxne", "This was more like 98 identical twins and 2 Karens"));
        vid2.addComment(new Comment("Hellothere720", "Bro no way I could remember 27 colours"));       
        Video vid3 = new Video("mr. Beast", "Men VS. Women survive the wilderness for $500,000", 1908, new List<Comment>());
        videos.Add(vid3);
        vid3.addComment(new Comment("MrBeast", "Do you think you coould survive this challenge?"));
        vid3.addComment(new Comment("jossepinocencio6322", "Chandler being back is insane"));
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