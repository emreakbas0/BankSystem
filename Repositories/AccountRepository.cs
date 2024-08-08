using BankSystem.interfaces;
using BankSystem.Context;
using Microsoft.EntityFrameworkCore;


namespace BankSystem.Repositories;

public class Repository<T> : IAccountRepository<T> where T : class
{
    private readonly AccountContext _dbContext;
    internal DbSet<T> set;

    public Repository(AccountContext dbContext)
    {
        _dbContext = dbContext;
        this.set = _dbContext.Set<T>();
    }
    public IEnumerable<T> GetAll()
    {
        IQueryable<T> sorgu = set;
        return sorgu.ToList();
    }
    public T GetById(int id)
    {
        return set.Find(id);
    }
    public void Add(T entity)
    {
        set.Add(entity);
        _dbContext.SaveChanges();
    }
    public void Update(T entity)
    {
        set.Update(entity);
        _dbContext.SaveChanges();
    }
    public void Delete(int id)
    {
        var entity = set.Find(id);
        if (entity != null)
        {
            set.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
