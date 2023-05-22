using LarningCenter.API.Learning.Persistence.Contexts;

namespace LarningCenter.API.Learning.Persistence.Repositories;

public class BaseRepository
{
   protected readonly AppDbContext _context;

   public BaseRepository(AppDbContext context)
   {
      _context = context;
   }
}