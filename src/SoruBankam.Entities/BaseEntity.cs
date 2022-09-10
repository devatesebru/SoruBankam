using SQLite;

namespace SoruBankam.Entities;

public abstract class BaseEntity
{
    [PrimaryKey]
    public Guid Id { get; set; }
}
