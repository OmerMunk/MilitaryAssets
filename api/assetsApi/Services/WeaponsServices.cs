using Microsoft.AspNetCore.Http;

namespace assetsApi.Services
{
    public class WeaponsServices
    {


        public async Task<Weapon> GetWeaponByOwnerAsync(Guid owner_id)
        {
            var weaponsOrPersonalByVihecle = await WeaponsByVihecle(owner_id);

            if (weaponsOrPersonalByVihecle == null)
            {
                weaponsOrPersonalByVihecle = await WeaponsByVihecle(owner_id);
            }            

            return weaponsOrPersonalByVihecle;
        }



        public async Task<List<Weapon>> GetAllWeponsAsync()
        {
            var weapons = await _DbContext.GetAllWeapons();
            return weapons;
        }
    }
}
    