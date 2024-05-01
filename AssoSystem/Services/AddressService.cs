using AssoSystem.Data;
using AssoSystem.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using SerranaLogCargas.Services.Exceptions;
using System.Data;

namespace AssoSystem.Services
{
    public class AddressService
    {
        private readonly AssoSystemContext _context;
        public AddressService (AssoSystemContext context)
        {
            _context = context;
        }

        // List to index
        public async Task<List<Address>> FindAllAsync()
        {
            return await _context.addresses.ToListAsync();
        }

        // Create
        public async Task InsertAsync(Address address)
        {
            _context.Add(address);
            await _context.SaveChangesAsync();
        }

        public async Task<Address> FindById(int id)
        {
            return await _context.addresses.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task UpdateAsync (Address address)
        {
            bool hasAny = await _context.addresses.AnyAsync(x => x.Id == address.Id);
            if (!hasAny)
            {
                throw new NotFoundException("ID não encontrado");
            }
            try
            {
                _context.Update(address);
                await _context.SaveChangesAsync();
            } catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }

        public async Task Remove (int id)
        {
            var address = _context.addresses.Find(id);
            _context.addresses.Remove(address);
            await _context.SaveChangesAsync();
        }
    }
}
