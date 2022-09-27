using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.Entities;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;
using System.Linq.Expressions;

namespace SoruBankam.DataAccessLayer.Concrete.SQLiteNet
{
    public class QuestionRepository : Repository, IQuestionRepository
    {
        public void Add(Question entity)
        {
            entity.Id = Guid.NewGuid();
            database.InsertWithChildrenAsync(entity);
        }

        public void Delete(Question entity)
        {
            throw new NotImplementedException();
        }

        public Question Get(Expression<Func<Question, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll(Expression<Func<Question, bool>> filter = null)
        {
            return database.GetAllWithChildrenAsync<Question>().Result;
        }

        public void Update(Question entity)
        {
            //database.UpdateWithChildrenAsync(entity);
            throw new NotImplementedException();
        }
    }
}
