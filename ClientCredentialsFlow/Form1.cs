using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCredentialsFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetHomework_Click(object sender, EventArgs e)
        {
           var token= this.GetToken();
            
        }

        private  TokenResponse GetToken()
        {
            var requestBody = new StringBuilder()
                .Append(ConstData.GrantTypeClientCredentials)
                .Append("&scope=read-homework")
                .ToString();

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes($"{ConstData.AuthorizationClientCredentialsFlowId}:{ConstData.ClientCredentialsFlowSecret}");
            var clientPasswordBase64 = System.Convert.ToBase64String(plainTextBytes);

            var client = new RestClient($"https://localhost:5001/connect/token");
            client.UseNewtonsoftJson();
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("authorization", $"basic {clientPasswordBase64}");
            request.AddParameter("application/x-www-form-urlencoded", requestBody, ParameterType.RequestBody);
            var respone= client.Execute<TokenResponse>(request);
            return respone.Data;
        }

        
    
    
    }
}
