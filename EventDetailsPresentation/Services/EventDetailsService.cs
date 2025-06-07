using EventDetailsPresentation.Data;
using Microsoft.EntityFrameworkCore;
namespace EventDetailsPresentation.Services;

public class EventDetailsService(DataContext context)
{
    private readonly DataContext _context = context;

    public async Task<IEnumerable<EventDetailsEntity>> GetAllAsync()
    {
        var entities = await _context.EventDetails.ToListAsync();
        return entities;
    }
    public async Task<EventDetailsEntity?> GetAsync(string Id)
    {
        var entity = await _context.EventDetails.FirstOrDefaultAsync(x => x.Id == Id);
        return entity;
    }
}
