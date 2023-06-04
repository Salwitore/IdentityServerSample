using IdentityModel;
using IdentityServer4.Models;

namespace IdentityServerDemo
{
    public static class Configuration
    {
        public static IEnumerable<ApiScope> GetApiScopes() =>
            new List<ApiScope> { new ApiScope("ApiOne","ApiOne") };


        public static IEnumerable<Client> GetClients() =>
            new List<Client>
            {
                new Client()
                {
                    ClientId = "client",
                    ClientSecrets = {new Secret("secret".ToSha256())},
                    
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = {"ApiOne"} //izin verdiğim apiler
                }
            };
    }
}
