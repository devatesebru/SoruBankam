using SoruBankam.Business.Abstract;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.DataAccessLayer.Concrete.EntityFramework;
using SoruBankam.Entities;

namespace SoruBankam.Business.Concrete
{
    public class QuestionManager : IQuestionManager
    {
        private IQuestionRepository questionRepository;
        public event Action<Question> questionAdded;

        public QuestionManager(IQuestionRepository questionRepository)
        {
           this.questionRepository = questionRepository;
        }

        public void Add(Question entity)
        {
            questionRepository.Add(entity);
            questionAdded?.Invoke(entity);
        }

        public List<Question> GetAll()
        {
            return questionRepository.GetAll();
        }

        public void Remove(Question entity)
        {
            questionRepository.Delete(entity);
        }
    }
}
