using Djvaleting.Server.Core.Repository;
using Djvaleting.Shared.Models;
using Djvaleting.Shared.ViewModels;
using System;

namespace Djvaleting.Server.Core.Services
{
    public class ValetBookingService : IValetBookingService
    {
        private readonly IGenericRepository<ValetBooking> _valetBookingRepository;

        public ValetBookingService(IGenericRepository<ValetBooking> valetBookingRepository)
        {
            _valetBookingRepository = valetBookingRepository;
        }

        public async Task<ValetBooking> AddValetBooking(ValetBookingViewModel valetBookingViewModel)
        {
            var newValetBooking = new ValetBooking()
            {
                ContactNumber = valetBookingViewModel.ContactNumber,
                Flexibility = valetBookingViewModel.Flexibility,
                EmailAddress = valetBookingViewModel.EmailAddress,
                BookingDate = valetBookingViewModel.BookingDate,
                Name = valetBookingViewModel.Name,
                VehicleSize = valetBookingViewModel.VehicleSize,
            };
            return await _valetBookingRepository.CreateAsync(newValetBooking);
        }

        public async Task<bool> DeleteValetBooking(int id)
        {
            await _valetBookingRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<ValetBookingViewModel>> GetAllValetBookings()
        {
            var allValetbookings = new List<ValetBookingViewModel>();
            var allValetbookingsFromDB = await _valetBookingRepository.GetAllAsync();
            foreach (var valetBooking in allValetbookingsFromDB)
            {
                var valetBookingViewModel = new ValetBookingViewModel()
                {
                    Id = valetBooking.Id,
                    ContactNumber = valetBooking.ContactNumber,
                    Flexibility = valetBooking.Flexibility,
                    EmailAddress = valetBooking.EmailAddress,
                    BookingDate = valetBooking.BookingDate,
                    Name = valetBooking.Name,
                    VehicleSize = valetBooking.VehicleSize,
                };

                allValetbookings.Add(valetBookingViewModel);
            }
            return allValetbookings;
        }

        public async Task<ValetBookingViewModel> GetValetBooking(int id)
        {
            var valetBooking = await _valetBookingRepository.GetByIdAsync(id);
            var valetBookingViewModel = new ValetBookingViewModel()
            {
                Id = valetBooking.Id,
                ContactNumber = valetBooking.ContactNumber,
                Flexibility = valetBooking.Flexibility,
                EmailAddress = valetBooking.EmailAddress,
                BookingDate = valetBooking.BookingDate,
                Name = valetBooking.Name,
                VehicleSize = valetBooking.VehicleSize,
            };

            return valetBookingViewModel;
        }

        public Task<bool> UpdateValetBooking(int id, ValetBookingViewModel valetBookingViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
