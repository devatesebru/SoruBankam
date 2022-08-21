using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.Entities;

namespace SoruBankam.DataAccessLayer.Concrete.EntityFramework
{
    public class QuestionRepository : Repository<Question, SoruBankamDbContext>, IQuestionRepository
    {

    }
}
