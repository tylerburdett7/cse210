
public class Video {
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;

    public Video(string title, string author, string length, List<Comment> comments) {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetNumOfComments() {
        int numOfComments = _comments.Count;
        return numOfComments;
    }

    public void DisplayVideoInfo() {
        int numOfComments = GetNumOfComments();
        Console.WriteLine($"{_title}, By {_author}, Length: {_length}, Comments: {numOfComments}\n");
        foreach(var Comment in _comments) {
            Comment.DisplayComment();
        }
        Console.WriteLine();
    }

}