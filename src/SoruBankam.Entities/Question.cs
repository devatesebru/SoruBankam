namespace SoruBankam.Entities
{
    public class Question : BaseEntity
    {
        public Byte[] Photo { get; set; }
        public Answer Answer { get; set; }
        public string Description { get; set; }
        
    }
}
