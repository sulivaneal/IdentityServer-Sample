using IdentityServer.STS.Identity.Configuration.Intefaces;

namespace IdentityServer.STS.Identity.Configuration
{
    public class RegisterConfiguration : IRegisterConfiguration
    {
        public bool Enabled { get; set; } = true;
    }
}
