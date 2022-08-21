using System.Linq.Expressions;

namespace SoruBankam.DataAccessLayer.Abstract
{
    public interface IRepository<TEntity>
    {
        public void Add(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);
        public TEntity Get(Expression<Func<TEntity, bool>> filter);
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}