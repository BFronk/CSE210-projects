using System;

public class Video
{
    private string _title;
    private string _author;

    private float _duration;

    private  List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = comments;
    }
    public int countComments()
    {
        return _comments.Count();
    }
    public void displayInfo()
    {
        Console.WriteLine($"{_title} by {_author} at {Math.Floor(_duration/60)}:{_duration - (Math.Floor(_duration/60) * 60)}");
        Console.WriteLine("");
        // Console.WriteLine($"There are {_comments.CountComments()} comments. Would you like to see them? ");
        // string displayComments = Console.ReadLine();
        // if (displayComments.ToLower() == "yes")
        Console.WriteLine($"Comments({countComments()}):");
        Console.WriteLine("");
        ListComments();
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void ListComments()
    {
        foreach (var comment in _comments)
            {
                comment.displayComment();
                Console.WriteLine("");
            }
    }
}










