namespace TourPlanner.DAL
{
    public interface ITourRepository
    {
        Task<List<Tour>> GetAllToursAsync();
        Task AddTourAsync(Tour tour);
        Task RemoveTourAsync(Tour tour);
        Task UpdateTourAsync(Tour tour);
        Task<Tour> GetTourByIdAsync(int id);
    }
}
