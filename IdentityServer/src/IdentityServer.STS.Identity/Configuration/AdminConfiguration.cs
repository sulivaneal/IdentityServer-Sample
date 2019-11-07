using IdentityServer.STS.Identity.Configuration.Intefaces;

namespace IdentityServer.STS.Identity.Configuration
{
    public class AdminConfiguration : IAdminConfiguration
    {
        public string IdentityAdminBaseUrl { get; set; } = "http://localhost:9000";
    }
}