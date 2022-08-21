using SoruBankam.Business.Abstract;
using SoruBankam.Business.Concrete;
using SoruBankam.DataAccessLayer.Concrete.EntityFramework;

namespace SoruBankam.Presentation.WindowsForms
{
    public static class Factory
    {
        private static IQuestionManager? questionManager;

        public static IQuestionManager CreateQuestionManager()
        {
            questionManager ??= new QuestionManager(new QuestionRepository());
            return questionManager;
        }
    }
}
