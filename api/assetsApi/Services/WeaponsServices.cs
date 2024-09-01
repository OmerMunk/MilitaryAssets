using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Services
{
    public class WeaponsServices
    {
        public async Task<IActionResult> createweapon(Weapon weapon)
        {
            await DBServis.createweapon(weapon);
        }
    }
}
