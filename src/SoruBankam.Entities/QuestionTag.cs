using SQLiteNetExtensions.Attributes;

namespace SoruBankam.Entities;

public class QuestionTag
{
    [ForeignKey(typeof(Question))]
    public Guid QuestionId { get; set; }

    [ForeignKey(typeof(Tag))]
    public Guid TagId { get; set; }
}
