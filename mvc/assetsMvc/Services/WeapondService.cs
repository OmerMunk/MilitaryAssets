using assetsMvc.Models;
using System.Net.Http;

namespace assetsMvc.Services
{
    public class WeapondService : BaseService<Weapond>
    {
        
        private string _getAllUrl;
        private string _getByIdUrl;
        private string _addNewUrl;
        private string _updateUrl;

        public WeapondService(HttpClient httpClient) : base(httpClient)
        {

        }

        public async Task<List<Weapond>> GetAllAsync()
        {
            var list = await _httpClient.GetFromJsonAsync<List<Weapond>>(_getAllUrl);

            return list;
        }

        public async Task<Weapond> GetByIdAsync(int id)
        {
            var item = await _httpClient.GetFromJsonAsync<Weapond>(_getByIdUrl + id);

            return item;
        }

        public async Task<Weapond> AddNewAsync(Weapond item)
        {
            var response = await _httpClient.PostAsJsonAsync<Weapond>(_addNewUrl, item);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Weapond>();
            }
            throw new HttpRequestException($"Request to {_addNewUrl} failed with status {response.StatusCode}");
        }

        public async Task<Weapond> UpdateAsync(Weapond item, int id)
        {
            var response = await _httpClient.PutAsJsonAsync(_updateUrl + id, item);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Weapond>();
            }

            throw new HttpRequestException($"Request to {_updateUrl} failed with status {response.StatusCode}");
        }
    }
}
