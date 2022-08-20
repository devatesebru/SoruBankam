namespace SoruBankam.Business.Abstract
{
    public interface IManager<T>
    {
        public void Add(T entity);
        public void Remove(T entity);
        public List<T> GetAll();
    }
}
