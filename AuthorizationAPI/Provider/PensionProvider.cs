using AuthorizationAPI.Data;
using AuthorizationAPI.Model;
using System.Collections.Generic;
using System.Linq;


namespace AuthorizationAPI.Provider
{
    public class PensionProvider : IPensionProvider
    {

        private readonly ApplicationDbContext _db;

        public PensionProvider(ApplicationDbContext db)
        {
            _db = db;

        }


        public PensionCredentials GetPensioner(PensionCredentials cred)
        {
            var user = _db.Credentials.FirstOrDefault(user => user.Username == cred.Username && user.Password == cred.Password);

            PensionCredentials penCred = new PensionCredentials()
            {
                Username = user.Username,
                Password = user.Password
            };

            return penCred;
        }
    }
}
