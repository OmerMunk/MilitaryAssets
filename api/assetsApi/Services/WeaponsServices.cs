﻿namespace assetsApi.Services
{
    public class WeaponsServices
    {
        public async Task<List<Weapon>> GetWeponByUnit(Guid guidUnit)
        {
            var weponByUnit = await _DbService.GetWeponByUnitFromDb(guidUnit);
            return weponByUnit;
        }
        public async Task<List<Weapon>> GetAllActiveWepons()
        {
            var activeWeponList = _DbService.GetAllActiveWeponsFromDb();
            return activeWeponList;
        }
        public async Task<Weapon> GetWeponById(Guid id)
        {
            var wepon = await _DbService.GetWeponByIdFromDb(id);
            return wepon;
        }
    }
}
