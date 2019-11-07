using IdentityServer.Admin.Api.Configuration.Constants;

namespace IdentityServer.Admin.Api.Configuration
{
    public class AdminApiConfiguration
    {
        public string IdentityServerBaseUrl { get; set; } = AuthorizationConsts.IdentityServerBaseUrl;

        public string OidcSwaggerUIClientId { get; set; } = AuthorizationConsts.OidcSwaggerUIClientId;

        public string OidcApiName { get; set; } = AuthorizationConsts.OidcApiName;
    }
}