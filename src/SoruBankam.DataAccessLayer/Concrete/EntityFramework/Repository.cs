using Microsoft.EntityFrameworkCore;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.Entities;
using System.Linq.Expressions;
namespace SoruBankam.DataAccessLayer.Concrete.EntityFramework
{
    public class Repository<TEntity, Tcontext> : IRepository<TEntity>
        //bana bir tane entity ve context ver sana impelemt verip ama Ientity türünden
        where TEntity : BaseEntity, new()
        where Tcontext : DbContext, new()

    {
        public void Add(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var addedEntity = context.Entry(entity);
                //benim bir nesnem var veri tabanında ona abone ol fakat bu yeni nesne bulamayacaksın önce onu ekle sonra kayıt ol
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var deleteEntity = context.Entry(entity);

                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public void Update(TEntity entity)
        {
            using (Tcontext context = new Tcontext())
            {
                var uptadeEntity = context.Entry(entity);

                uptadeEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (Tcontext context = new Tcontext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (Tcontext context = new Tcontext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }

}
