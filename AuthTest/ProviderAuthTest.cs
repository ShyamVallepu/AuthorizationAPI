using AuthorizationAPI.Data;
using AuthorizationAPI.Model;
using AuthorizationAPI.Provider;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace AuthTest
{
    public class Tests
    {
        List<PensionCredentials> user = new List<PensionCredentials>();
        
        [SetUp]
        public void Setup()
        {
            user = new List<PensionCredentials>()
            {
                new PensionCredentials{Username = "user1",Password = "user1"}
            };
            
        }


        [TestCase("user1","user1")]
        public void GetPensioner_Returns_Object(string uname,string pass)
        {
            Mock<IPensionProvider> mock = new Mock<IPensionProvider>();

            DbContextOptions<ApplicationDbContext> options = new DbContextOptions<ApplicationDbContext>();
            ApplicationDbContext db = new ApplicationDbContext(options);
            PensionCredentials cred = new PensionCredentials { Username = uname, Password = pass };

            PensionProvider pro = new PensionProvider(db);

            Assert.IsNotNull(pro);
        }

          
    }
}