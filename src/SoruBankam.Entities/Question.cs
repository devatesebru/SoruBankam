namespace SoruBankam.Entities
{
    public class Question : BaseEntity
    {
        public Byte[] Photo { get; set; }
        public Byte[] AnswerPhoto { get; set; }
        public string Description { get; set; }

    }
}
