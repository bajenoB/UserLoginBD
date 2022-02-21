
using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace UserLoginBD
{
    public class UserLoh
    {
        public string Name { get; set; }
        
        public string Email { get; set; }
        public DateTime Dbay { get; set; }
        public string Password { get; set; }

        

        public int Role { get; set; }

        public UserLoh(string name,string email,DateTime bday,string password,int role )
        {
            Name = name;
            Email = email;
            Dbay = bday;
            Password = password;
            Role= role;
                
        }

        public bool isLogLeng { get; set; }
        public bool isPassLeng { get; set; }

       
        public bool CheckLog(string name)
        {
            if (name.Length < 3)
            {
                return isLogLeng = false;
            }
            else
            {
                return isLogLeng = true;
            }

        }

        public bool CheckPass(string password)
        {
            if (password.Length <= 6)
            {
                return isLogLeng = false;
            }
            else
            {
                return isLogLeng = true;
            }

        }

        private string hashpass(string password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

            return hashed;
        }





    }
}
