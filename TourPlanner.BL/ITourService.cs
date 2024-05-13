using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.DAL.DTOs;
using TourPlanner.DTOs;


namespace TourPlanner.BL
{
    public interface ITourService
    {
        Task<List<Tour>> GetAllToursAsync();
        Task AddTourAsync(Tour tour);
        Task RemoveTourAsync(Tour tour);
        Task UpdateTourAsync(Tour tour);
        Task<Tour> GetTourByIdAsync(int id);
    }

}
