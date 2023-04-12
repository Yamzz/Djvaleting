using Djvaleting.Shared.Models;
using Djvaleting.Shared.ViewModels;
using System;

namespace Djvaleting.Server.Core.Services
{
    public interface IValetBookingService
    {
        Task<ValetBooking> AddValetBooking(ValetBookingViewModel valetBookingViewModelg);
        Task<bool> UpdateValetBooking(ValetBookingViewModel valetBookingViewModel);
        Task<bool> DeleteValetBooking(int id);
        Task<List<ValetBookingViewModel>> GetAllValetBookings();
        Task<ValetBookingViewModel> GetValetBooking(int id);
    }
}
