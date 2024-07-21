
class Video
{
    public string _videoTitle;
    public string _videoAuthor;
    public int _videoLength;
    public List<Comment> _comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _videoLength = videoLength;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentsCount()
    {
        return _comments.Count;
    }
}