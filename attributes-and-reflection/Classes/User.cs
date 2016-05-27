using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes_and_reflection
{
    class User
    {
        public User(string name, string login)
        {
            Name = name;
            Login = login;
        }
        [Color(Colors.red)]
        public string Name { get; set; }
        //[Color(Colors.white)]
        public string Login { get; set; }


    }
}
