using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Test.Models;

namespace WebAPI_Test.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDbContext _context;
        public ContactRepository(ContactDbContext context)
        {
            _context = context;
        }

        public async Task<Contact> Create(Contact c)
        {
            _context.Contact.Add(c);
            await _context.SaveChangesAsync();
            return c;
        }

        public async Task Delete(int id)
        {
            var contactToDelete = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contactToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contact>> Get()
        {
            return await _context.Contact.ToListAsync();
        }

        public async Task<Contact> Get(int id)
        {
            return await _context.Contact.FindAsync(id);
        }

        public async Task Update(Contact c)
        {
            _context.Entry(c).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
