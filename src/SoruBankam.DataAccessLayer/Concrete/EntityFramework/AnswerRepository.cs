using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.Entities;

namespace SoruBankam.DataAccessLayer.Concrete.EntityFramework
{
    public class AnswerRepository : Repository<Answer, SoruBankamDbContext>, IAnswerRepository
    {
    }
}
