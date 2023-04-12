using Djvaleting.Server.AppDbContext;
using Djvaleting.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Djvaleting.Server.Core.Repository
{
  public class ValetBookingRepository : IGenericRepository<ValetBooking> 
  {
        ApplicationDbContext _dbContext;

        public ValetBookingRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<ValetBooking> CreateAsync(ValetBooking _object)
        {
            var obj = await _dbContext.ValetBookings.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task UpdateAsync(ValetBooking _object)
        {
            _dbContext.ValetBookings.Update(_object);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<ValetBooking>> GetAllAsync()
        {
            return await _dbContext.ValetBookings.ToListAsync();
        }

        public async Task<ValetBooking> GetByIdAsync(int Id)
        {
            return await _dbContext.ValetBookings.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.ValetBookings.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
    }
}
