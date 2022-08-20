namespace SoruBankam.DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public void Delete(Guid id);
        public List<T> GetAll();
    }
}