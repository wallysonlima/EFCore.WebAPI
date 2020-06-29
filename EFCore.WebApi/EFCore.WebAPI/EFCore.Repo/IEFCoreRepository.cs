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

       Task<Heroi[]> GetAllHerois(bool incluirBatalha = false);
       Task<Heroi[]> GetHeroiById(int id, bool incluirBatalha = false);
       Task<Heroi[]> GetHeroisByNome(string nome, bool incluirBatalha = false);

       Task<Heroi[]> GetAllBatalhas(bool incluirBatalha = false);
       Task<Heroi[]> GetBatalhaById(int id, bool incluirBatalha = false);
    }
}