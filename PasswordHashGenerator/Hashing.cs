using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using BCrypt = BCrypt.Net.BCrypt;

namespace PasswordHashGenerator
{
    class Hashing
    {
        public static string CreateHashedPassword(string client, string date)
        {
            string dataToHash = client + date;
            string pass = global::BCrypt.Net.BCrypt.HashPassword(dataToHash, "$2a$10$HVMDR55PBi9E8RrrbAewDu");
            return pass.Substring(29);
        }
    }
}
