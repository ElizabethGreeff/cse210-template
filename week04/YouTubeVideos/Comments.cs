using System;

class Comment
{
    private string _name;
    private string _comment;

    public Comment(string commentName, string commentText)
    {
        _name = commentName;
        _comment = commentText;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetComment()
    {
        return _comment;
    }
}