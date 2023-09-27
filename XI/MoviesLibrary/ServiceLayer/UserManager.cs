using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace ServiceLayer
{
    public class UserManager : IContext<User, int>
    {
        private UserContext _userContext;
        public UserManager(MovieLibraryDbContext context)
        {
            _userContext = new UserContext(context);
        }
        public void Create(User user)
        {
            _userContext.Create(user);
        }

        public void Delete(int key)
        {
            _userContext.Delete(key);
        }

        public User Read(int key)
        {
            return _userContext.Read(key);
        }

        public IEnumerable<User> ReadAll()
        {
            return _userContext.ReadAll();
        }

        public void Update(User user)
        {
            _userContext.Update(user);
        }
    }
}
