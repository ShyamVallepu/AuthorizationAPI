using AuthorizationAPI.Model;
using System.Collections.Generic;

namespace AuthorizationAPI.Provider
{
    public interface IPensionProvider
    {

        public PensionCredentials GetPensioner(PensionCredentials cred);
    }
}
