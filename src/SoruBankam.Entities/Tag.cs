using SQLiteNetExtensions.Attributes;

namespace SoruBankam.Entities;

public class Tag : BaseEntity
{
    public string Name { get; set; }

    [ManyToMany(typeof(QuestionTag))]
    public List<Question> Questions { get; set; }

    public Tag()
    {
        Questions = new List<Question>();
    }
}
