using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Repo
{
    public interface IEFCoreRepository
    {
       void Add<T>(T entity) where T : class;
       void Update<T>(T entity) where T : class; 
       void Delete<T>(T entity) where T : class;
       Task<bool> SaveChangeAsync();

       Task<Heroi[]> GetAllHerois();
       Task<Heroi[]> GetHeroiById(int id);
       Task<Heroi[]> GetHeroiByNome(string nome);
    }
}