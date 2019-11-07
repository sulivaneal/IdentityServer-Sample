namespace IdentityServer.Admin.Api.Configuration.Constants
{
    public class AuthorizationConsts
    {
        public const string IdentityServerBaseUrl = "http://localhost:5000";
        public const string OidcSwaggerUIClientId = "adminId_api_swaggerui";
        public const string OidcApiName = "adminId_api";

        public const string AdministrationPolicy = "RequireAdministratorRole";
        public const string AdministrationRole = "MyRole";
    }
}