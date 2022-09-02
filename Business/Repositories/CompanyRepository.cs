using System;
using Business.Services;
using DataAccessLayer.Context;
using Entity.Entities;
using Exceptions.EntityExceptions;
using Microsoft.EntityFrameworkCore;

namespace Business.Repositories
{
    public class CompanyRepository : ICompanyService
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Company> Get(int id)
        {
            var data = await _context.Companies.Where(n => n.Id == id && !n.IsDeleted).FirstOrDefaultAsync();
            if (data is null)
            {
               throw new EntityCouldNotFoundExceptions();
            }
            return data;

        }

        public async Task<List<Company>> GetAll()
        {
            var data = await _context.Companies.Where(n => !n.IsDeleted).ToListAsync();
            if (data is null)
            {
                throw new EntityCouldNotFoundExceptions();
            }
            return data;
        }


        public Task Create(Company entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        
        public Task Update(int id, Company entity)
        {
            throw new NotImplementedException();
        }
    }
}

