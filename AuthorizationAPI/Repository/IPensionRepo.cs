using AuthorizationAPI.Model;

namespace AuthorizationAPI.Repository
{
    public interface IPensionRepo
    {
        public PensionCredentials GetPensionerCred(PensionCredentials cred);
    }
}
