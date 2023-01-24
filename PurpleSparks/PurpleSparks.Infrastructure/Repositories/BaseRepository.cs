using PurpleSparks.Infrastructure.EntityFramework;
using PurpleSparks.Infrastructure.Repositories.Interface;

namespace PurpleSparks.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        protected readonly PurpleSparksContext _context;
        private Microsoft.EntityFrameworkCore.DbSet<T> _entity;
        public BaseRepository(PurpleSparksContext context)
        {
            this._context = context;
            this._entity = _context.Set<T>();

        }

        public void Delete(Guid id)
        {
            var find = _entity.Find(id);
            if (find == null)
            {
                throw new Exception("Brand not found! ");
            }
            else
            {
                _entity.Remove(find);
                Save();
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<T> GetAll()
        {
            return _entity.ToList();
        }

        public T GetById(Guid id)
        {
            var x = _entity.Find(id);
            if (x == null)
            {
                throw new Exception("Brand not found! ");

            }
            return x;
        }

        public void Insert(T insert)
        {
            _entity.Add(insert);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T updated)
        {
            if (updated == null)
            {
                throw new Exception("Brand not found! ");

            }
            _context.Entry(updated).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
