using SoruBankam.Entities;

namespace SoruBankam.Business.Abstract
{
    public interface IQuestionManager : IManager<Question>
    {
        public event Action<Question> questionAdded;
    }
}
