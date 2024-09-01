using System;
using System.Net.Http;

namespace assetsMvc
{
    public class PersonsService
    {
         
        private string _Url = $"http://localhost:5216/Persons/";



        // Get Person By Rank
        public async Task<Person> GetPersonByRank(string Rank)
        {
            var response = await _httpClient.GetAsync(_Url + Rank);
            return response;
        }


        // Get Person By Service Number
        public async Task<Person> GetPersonByServiceNumber(string ServiceNumber)
        {
            var response = await _httpClient.GetAsync(_Url + ServiceNumber);
            return response;
        }


        // Get Person By Assigned Unit
        public async Task<Person> GetPersonByAssignedUnit(string AssignedUnit)
        {
            var response = await _httpClient.GetAsync(_Url + AssignedUnit);
            return response;
        }

    }
}
