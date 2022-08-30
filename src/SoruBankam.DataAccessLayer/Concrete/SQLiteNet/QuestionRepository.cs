using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.Entities;
using SQLite;
using System.Linq.Expressions;

namespace SoruBankam.DataAccessLayer.Concrete.SQLiteNet
{
    public class QuestionRepository : IQuestionRepository
    {
        readonly SQLiteAsyncConnection database;

        public QuestionRepository()
        {
            database = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SoruBankam.db3"));
            database.CreateTableAsync<Question>().Wait();
        }

        public void Add(Question entity)
        {
            entity.Id = Guid.NewGuid();
            database.InsertAsync(entity);
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
            return database.Table<Question>().ToListAsync().Result;
        }

        public void Update(Question entity)
        {
            throw new NotImplementedException();
        }
    }
}
