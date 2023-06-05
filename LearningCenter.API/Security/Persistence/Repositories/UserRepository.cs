using LearningCenter.API.Security.Domain.Models;
using LearningCenter.API.Security.Domain.Repositories;
using LearningCenter.API.Shared.Persistence.Contexts;
using LearningCenter.API.Shared.Persistence.Repositories;

namespace LearningCenter.API.Security.Persistence.Repositories;

public class UserRepository :BaseRepository, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<User>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> FindByUserNameAsync(string userName)
    {
        throw new NotImplementedException();
    }

    public bool ExistsByUserName(string userName)
    {
        throw new NotImplementedException();
    }

    public User FindById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(User user)
    {
        throw new NotImplementedException();
    }

    public void Remove(User user)
    {
        throw new NotImplementedException();
    }
}