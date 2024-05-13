using Microsoft.EntityFrameworkCore;
using TourPlanner.DAL.DTOs;
using TourPlanner.DTOs;

namespace TourPlanner.DAL
{
    public class TourRepository : ITourRepository
    {
        private readonly AppDbContext _dbContext;

        public TourRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Tour>> GetAllToursAsync()
        {
            return await _dbContext.Tours.ToListAsync();
        }

        public async Task AddTourAsync(Tour tour)
        {
            _dbContext.Tours.Add(tour);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveTourAsync(Tour tour)
        {
            _dbContext.Tours.Remove(tour);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateTourAsync(Tour tour)
        {
            _dbContext.Tours.Update(tour);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Tour> GetTourByIdAsync(int id)
        {
            return await _dbContext.Tours.FindAsync(id);
        }

    }
}
