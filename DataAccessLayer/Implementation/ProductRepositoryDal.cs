using System;
using Core.EFRepository;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Entity.Entities;

namespace DataAccessLayer.Implementation
{
    public class ProductRepositoryDal : EfEntityRepositoryBase<Company,AppDbContext>, ICompanyDal
    {
        public ProductRepositoryDal()
        {
        }
    }
}

