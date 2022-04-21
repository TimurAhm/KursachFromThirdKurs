using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExampleTimur343.DataBase
{
    public static class AuthClass
     {
        public static Users users;
        public static bool Auth(string login, string pass) {
            users = EfModel.Init().Users.FirstOrDefault(u=>u.UserLogin == login&& u.UserPass == pass);
            return users != null;
        }
    }
}
