using SoruBankam.Business.Abstract;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.DataAccessLayer.Concrete.EntityFramework;
using SoruBankam.Entities;

namespace SoruBankam.Business.Concrete;

public class QuestionManager : IQuestionManager
{
    private IQuestionRepository questionRepository;
    private ITagRepository tagRepository;
    public event Action<Question>? questionAdded;

    public QuestionManager(IQuestionRepository questionRepository, ITagRepository tagRepository)
    {
        this.questionRepository = questionRepository;
        this.tagRepository = tagRepository;
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

    public List<Question> GetAllWithTag(Guid tagId)
    {
        var tag = tagRepository.Get(x => x.Id == tagId);

        return tag.Questions;
    }
}
