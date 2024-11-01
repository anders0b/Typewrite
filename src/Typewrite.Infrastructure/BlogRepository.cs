using Microsoft.Extensions.Configuration;
using Typewrite.Infrastructure.Entities;

namespace Typewrite.Infrastructure;

public interface IBlogRepository
{
    public Task CreateBlogAsync(Blog blog);
    public Task<Blog> GetBlogAsync(Guid id);
    public Task<List<Blog>> GetBlogsAsync();
    public Task UpdateBlogAsync(Blog blog);
    public Task DeleteBlogAsync(Guid id);
    public Task<Blog> GetBlogByIdAsync(Guid id);
}
public class BlogRepository : IBlogRepository
{
    private readonly string _connectionString;
    public BlogRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }
    public Task CreateBlogAsync(Blog blog)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBlogAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> GetBlogAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> GetBlogByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Blog>> GetBlogsAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateBlogAsync(Blog blog)
    {
        throw new NotImplementedException();
    }
}
