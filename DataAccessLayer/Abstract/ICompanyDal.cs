using System;
using Core.EFRepository.EFBase;
using Entity.Entities;

namespace DataAccessLayer.Abstract
{
    public interface ICompanyDal : IEntityRepositoryBase<Company>
    {
    }
}

