using SQLite;

namespace SoruBankam.Entities;
//file scope oluyor bütün dosya ismi SoruBankam.Entities oluyor


public abstract class BaseEntity
{
    [PrimaryKey]
    public Guid Id { get; set; }
}
