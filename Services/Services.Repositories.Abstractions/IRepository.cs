namespace Services.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll(bool noTracking = false);
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false);
        T Get(Guid id);
        Task<T> GetAsync(Guid id, CancellationToken cancellationToken);
        bool Delete(Guid id);
        bool Delete(T entity);
        bool DeleteRange(ICollection<T> entities);
        void Update(T entity);
        T Add(T entity);
        Task<T> AddAsync(T entity);
        void AddRange(List<T> entities);
        Task AddRangeAsync(ICollection<T> entities);
    }
}
