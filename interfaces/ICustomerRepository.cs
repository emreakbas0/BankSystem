using System.Linq.Expressions;
namespace BankSystem.interfaces;

public interface ICustomerRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Update(T entity);
    void Add(T entity);
    void Delete(int id);
}