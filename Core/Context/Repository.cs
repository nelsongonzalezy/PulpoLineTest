using Microsoft.EntityFrameworkCore;

namespace Core.Context
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbCoreContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DbCoreContext context) {

            _context = context;
            _dbSet = _context.Set<T>();
        
        }
        public async Task<T> GetByKey(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<bool> Update(T entidad)
        {
            _dbSet.Update(entidad);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> Create(T entidad)
        {
            _dbSet.Add(entidad);
            return await _context.SaveChangesAsync()>0;    
        }

        public async Task<bool> HardDelete(int id)
        {
            var entidad= await _dbSet.FindAsync(id);
            if (entidad != null)
            {
                _dbSet.Remove(entidad);
            
                return _context.SaveChanges() > 0;
            }
            else
            { return false; }
        }


    }
}
