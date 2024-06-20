namespace Typewrite.Infrastructure.Entities;

public class Blog
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public List<Post> Posts { get; set; }
    public List<Tag> Tags { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}