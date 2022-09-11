using SoruBankam.Business.Abstract;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.Entities;

namespace SoruBankam.Business.Concrete;

public class TagManager : ITagManager
{
    private readonly ITagRepository tagRepository;

    public TagManager(ITagRepository tagRepository)
    {
        this.tagRepository = tagRepository;
    }

    public void Add(Tag entity)
    {
        tagRepository.Add(entity);
    }

    public List<Tag> GetAll()
    {
        return tagRepository.GetAll();
    }

    public void Remove(Tag entity)
    {
        tagRepository.Delete(entity);
    }
}
