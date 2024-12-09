using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
   public class user
    {
        public string Login;

        private string password;

        public int GetPasswordHash()
        {
            return password.GetHashCode();
        }

    }
}
