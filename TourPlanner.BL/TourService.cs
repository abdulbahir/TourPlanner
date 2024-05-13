using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.DAL;
using TourPlanner.DAL.DTOs;
using TourPlanner.DTOs;

namespace TourPlanner.BL
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _tourRepository;

        public TourService(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        public async Task AddTourAsync(Tour tour)
        {
            await _tourRepository.AddTourAsync(tour);
        }

        public async Task<List<Tour>> GetAllToursAsync()
        {
            return await _tourRepository.GetAllToursAsync();
        }

        public async Task<Tour> GetTourByIdAsync(int id)
        {
            return await _tourRepository.GetTourByIdAsync(id);
        }

        public async Task RemoveTourAsync(Tour tour)
        {
           await _tourRepository.RemoveTourAsync(tour);
        }

        public async Task UpdateTourAsync(Tour tour)
        {
            await _tourRepository.UpdateTourAsync(tour);
        }
    }
}
