using Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AuthorizationCodeFlow.Controllers
{
    public class AuthorizationServerHttpClient
    {
        private readonly HttpClient _httpClient;

        public AuthorizationServerHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<TokenResponse> GetToken(string code, string redirectUri)
        {
            string path = "/connect/token";
            FormUrlEncodedContent clientCredentialsFlowFormContent = new(new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string,string>("grant_type","authorization_code"),
            new KeyValuePair<string,string>("code",code),
            new KeyValuePair<string,string>("client_id",ConstData.AuthorizationCodeFlowClientId),
            new KeyValuePair<string,string>("client_secret",ConstData.AuthorizationCodeFlowClientSecret),
            new KeyValuePair<string,string>("redirect_uri",redirectUri),
        });

            HttpResponseMessage clientCredentialsResponse = await _httpClient.PostAsync(path, clientCredentialsFlowFormContent);
            return await clientCredentialsResponse.Content.ReadFromJsonAsync<TokenResponse>();
        }


    }
}
