namespace Typewrite.Infrastructure.Entities;

public class Post
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string URL { get; set; }
    public string ImageURL { get; set; }
    public DateTime PublishedDate { get; set; }
    public DateTime LastUpdatedDate { get; set; }
    public List<Tag> Tags { get; set; }
    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }
    public int BlogId { get; set; }
    public virtual Blog Blog { get; set; }
    public List<int> Rating { get; set; }
}