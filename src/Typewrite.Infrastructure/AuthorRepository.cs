using Typewrite.Infrastructure.Entities;

namespace Typewrite.Infrastructure;

public interface IAuthorRepository
{
    public Task CreateAuthorAsync(Author author);
    public Task<Author> GetAuthorAsync(Guid id);
    public Task<List<Author>> GetAuthorsAsync();
    public Task UpdateAuthorAsync(Author author);
    public Task DeleteAuthorAsync(Guid id);
    public Task<Author> GetAuthorByIdAsync(Guid id);
}
