using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Test.Models;

namespace WebAPI_Test.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AddressDbContext _context;
        public AddressRepository(AddressDbContext context)
        {
            _context = context;
        }

        public async Task<Address> Create(Address a)
        {
            _context.Address.Add(a);
            await _context.SaveChangesAsync();
            return a;
        }

        public async Task Delete(int id)
        {
            var addressToDelete = await _context.Address.FindAsync(id);
            _context.Address.Remove(addressToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Address>> Get()
        {
            return await _context.Address.ToListAsync();
        }

        public async Task<Address> Get(int id)
        {
            return await _context.Address.FindAsync(id);
        }

        public async Task Update(Address a)
        {
            _context.Entry(a).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
