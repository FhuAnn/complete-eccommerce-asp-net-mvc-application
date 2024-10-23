using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Service
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {   
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> getAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }


        public Actor Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
