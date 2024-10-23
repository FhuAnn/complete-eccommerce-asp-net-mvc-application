using eTickets.Models;

namespace eTickets.Data.Service
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> getAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Actor Update(int id, Actor actor);
		Task DeleteAsync(int id);
    }
}
