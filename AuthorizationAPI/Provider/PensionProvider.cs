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

        private static List<PensionCredentials> List = new List<PensionCredentials>()
        {
            new PensionCredentials{ Username = "Rohit", Password = "Hitman@45"},
            new PensionCredentials{ Username = "Virat", Password = "King@18"},
            new PensionCredentials{ Username = "Dhoni", Password = "CaptainCool@7"},
            new PensionCredentials{ Username = "Sachin", Password = "GodBats@4"},
            new PensionCredentials{ Username = "Hardik", Password = "Pandya@33"},
            new PensionCredentials{ Username = "Bumrah", Password = "Boom@123"},
            new PensionCredentials{ Username = "Shardul", Password = "LordBolthe@10"},

            //new PensionCredentials{ Username = "pensioner1", Password="pensioner1" }
        };
        public List<PensionCredentials> GetList()
        {
            return List;
        }



        public PensionCredentials GetPensioner(PensionCredentials cred)
        {
            var user = _db.Credentials.FirstOrDefault(user => user.Username == cred.Username && user.Password == cred.Password);

            PensionCredentials penCred = new PensionCredentials()
            {
                Username = user.Username,
                Password = user.Password
            };

            //List<PensionCredentials> rList = GetList();
            //PensionCredentials penCred = rList.FirstOrDefault(user => user.Username == cred.Username && user.Password == cred.Password);

            return penCred;
        }
    }
}
