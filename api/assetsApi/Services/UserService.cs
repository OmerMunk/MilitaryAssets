namespace assetsApi.Services
{
    public class UserService
    {
        private readonly ApplicationDbCobntext _context;
        public UserService(ApplicationDbCobntext context)
        {
            _context = context;
        }


        //יצירת יוזר
        public async Task<Nullable> Create(User user)
        {
            User ThisUser = await _context.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (ThisUser == null)
            {

                await _context.Users.Add(user);
                await _context.SaveChanges();
            }
            return null;
        }


        //מחיקת יוזר
        public async Task<Nullable> Delete(User user)
        {
            User ThisUser = await _context.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (ThisUser != null)
            {
                await _context.Users.Remove(user);
                await _context.SaveChanges();
            }

            return null;
        }


        //ולידציה של יוזר שמחזירה אובייקט
        public async Task<User> CheckUser(User user)
        {
            User ThisUser = await _context.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (ThisUser == null) 
            {
                return null;
            }

            if (user.Password == null || ThisUser.Password != user.Password)
            {
                return null;
            }
            if (ThisUser.Password == user.Password)
            {
                return ThisUser;
            }
            return null;
        }


        //ולידציה של יוזר שמחזירה ערך בולייאנית
        public async Task<bool> CheckUserBool(User user)
        {
            User ThisUser = await _context.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (ThisUser == null)
            {
                return false;
            }

            if (user.Password == null || ThisUser.Password != user.Password)
            {
                return false;
            }
            if (ThisUser.Password == user.Password)
            {
                return true;
            }
        }
    }
}
