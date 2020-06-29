using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Repo
{
    public class EFCoreRepository: IEFCoreRepository
    {
        public void Add<T>(T entity) where T: class
        {
            throw new NotImplementedExeption();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}