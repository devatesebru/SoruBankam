using SoruBankam.Entities;
using SQLite;

namespace SoruBankam.DataAccessLayer.Concrete.SQLiteNet;

public class Repository
{
    protected readonly SQLiteAsyncConnection database;

    public Repository()
    {
        database = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SoruBankam.db3"));
        database.CreateTableAsync<Question>().Wait();
        database.CreateTableAsync<Tag>().Wait();
        database.CreateTableAsync<QuestionTag>().Wait();
    }
}