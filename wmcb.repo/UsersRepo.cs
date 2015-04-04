using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wmcb.model;

namespace wmcb.repo
{
    public class UsersRepo
    {
        public User GetUserDetails( string email)
        {
            using (var context = new wmcbContext())
            {
                var user = context.Users
                    .Where(u => u.Email.Equals(email))
                    .Take(1);
                return user.FirstOrDefault();
            }
        }
    }
}
