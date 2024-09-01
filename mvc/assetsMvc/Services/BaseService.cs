using assetsMvc.Interfaces;
using System;

namespace assetsMvc.Services
{
    public class BaseService<T> : IService<T>
    {
        protected readonly HttpClient _httpClient;
        private string _getAllUrl;
        private string _getByIdUrl;
        private string _addNewUrl;
        private string _updateUrl;
        public BaseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<T>> GetAllAsync()
        {
            var list = await _httpClient.GetFromJsonAsync<List<T>>(_getAllUrl);

            return list;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var item = await _httpClient.GetFromJsonAsync<T>(_getByIdUrl + id);

            return item;
        }

        public async Task<T> AddNewAsync(T item)
        {
            var response = await _httpClient.PostAsJsonAsync<T>(_addNewUrl, item);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<T>();
            }
            throw new HttpRequestException($"Request to {_addNewUrl} failed with status {response.StatusCode}");
        }

        public async Task<T> UpdateAsync(T item, int id)
        {
            var response = await _httpClient.PutAsJsonAsync(_updateUrl + id, item);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<T>();
            }

            throw new HttpRequestException($"Request to {_updateUrl} failed with status {response.StatusCode}");
        }


    }
}
