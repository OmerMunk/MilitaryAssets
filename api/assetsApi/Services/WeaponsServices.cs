namespace assetsApi.Services
{
    public class WeaponsServices
    {
        public async Task<List<Weapon>> GetWeponByUnit(Guid guidUnit)//
        {
            var weponByUnit = await _DbService.GetWeponByUnitFromDB(guidUnit);
            return weponByUnit;
        }
    }
}
