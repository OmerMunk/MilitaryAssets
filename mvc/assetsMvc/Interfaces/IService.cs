namespace assetsMvc.Interfaces
{
    public interface IService<T>
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<T> AddNewAsync(T t);
        public Task<T> UpdateAsync(T t, int id);

    }
}
