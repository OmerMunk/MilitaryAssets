using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Services
{
    public class WeaponsServices
    {
        public async Task<IActionResult> createweapon(Weapon weapon)
        {
            await DBServis.createweapon(weapon);
        }

        public async Task<IActionResult> updetweapon(Weapon weapon)
        {
            await DBServis.updetweapon(weapon);
        }
    }
}
