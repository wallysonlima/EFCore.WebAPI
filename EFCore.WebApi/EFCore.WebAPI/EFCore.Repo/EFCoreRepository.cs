using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Repo
{
    public class EFCoreRepository: IEFCoreRepository
    {
        private readonly HeroiContext _context;

        public EFCoreRepository(HeroiContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T: class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T: class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangeAsync()
        {
           return await_context.SaveChangesAsync() > 0;
        }

        public async Task<Heroi[]> GetAllHerois()
        {
            IQueryable<Heroi> herois = _context.Herois
                .Include(herois => h.Identidade)
                .Include(herois => h.armas);

            query = query.AsNoTracking().OrderBy(herois=>herois.id);

            query.Include(herois=herois.heroisBatalhas)
                .ThenInclude(hb => hb.Batalha);

            return await query.ToArrayAsync();
        }

        public Task<Heroi> GetHeroiById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Heroi> GetHeroiByNome(string nome)
        {
            throw new NotImplementedException();
        }


    }
}