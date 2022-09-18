using Microsoft.Extensions.Logging;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.Entities;
using SQLiteNetExtensionsAsync.Extensions;
using System;
using System.Linq.Expressions;

namespace SoruBankam.DataAccessLayer.Concrete.SQLiteNet
{
    public class TagRepository : Repository, ITagRepository
    {
        //db.UpdateWithChildren(person1);
        //var personStored = db.GetWithChildren<Person>(person1.Id);
        //var eventStored = db.GetWithChildren<Event>(event1.Id);
        public void Add(Tag entity)
        {
            entity.Id = Guid.NewGuid();
            database.InsertAsync(entity);
        }

        public void Delete(Tag entity)
        {
            throw new NotImplementedException();
        }

        public Tag Get(Expression<Func<Tag, bool>> filter)
        {
            return database.GetWithChildrenAsync<Tag>(database.GetAsync(filter).Result.Id).Result;
        }

        public List<Tag> GetAll(Expression<Func<Tag, bool>> filter = null)
        {
            return database.Table<Tag>().ToListAsync().Result;
        }

        public void Update(Tag entity)
        {
            throw new NotImplementedException();
        }
    }
}
