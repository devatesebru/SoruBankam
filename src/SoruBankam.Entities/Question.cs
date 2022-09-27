namespace SoruBankam.Entities;

using SQLiteNetExtensions.Attributes;

public class Question : BaseEntity
{
    public Byte[] Photo { get; set; }
    public Byte[] AnswerPhoto { get; set; }
    public string Description { get; set; }

    [ManyToMany(typeof(QuestionTag))]
    public List<Tag> Tags { get; set; }

    public Question()
    {
        Tags = new List<Tag>();
    }
}
