using AuthorizationAPI.Model;
using System.Collections.Generic;

namespace AuthorizationAPI.Provider
{
    public interface IPensionProvider
    {
        public List<PensionCredentials> GetList();

        public PensionCredentials GetPensioner(PensionCredentials cred);
    }
}
