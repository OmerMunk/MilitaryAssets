namespace assetsApi.Services
{
    public class soldierServis
    {
        private readonly ApplicationDbContext _context;

        public soldierServis(ApplicationDbContext mosadDBContext)
        {
            _context = mosadDBContext;
        }

        public async Task Create(Soldier soldier)
        {
            _context.Soldiers.Add(soldier);
            _context.SaveChanges();
        }


        public async Task<List<Soldier>> GetAll()
        {
            Task<List<Soldier>> soldiers = new Task<List<Soldier>>();
            var sol = await _context.Soldiers.ToListAsync();
            foreach (Soldier soldier in sol)
            {
                soldiers.Add(soldier);
            }
            return soldiers;
        }


        public async Task<Soldier> GetOne(Guid id)
        {
            Soldier soldier = await  _context.Soldiers.FindAsync(id);
            return soldier;
        }

    }
}
