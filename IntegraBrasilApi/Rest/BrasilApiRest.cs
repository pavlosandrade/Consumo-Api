using System.Dynamic;
using System.Text.Json;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest{

    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGeneric<List<BancoModel>>> SearchAllBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
            var response = new ResponseGeneric<List<BancoModel>>();

            using(var client = new HttpClient()){
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objectResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResponse);

                if(responseBrasilApi.IsSuccessStatusCode){
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.DataReturn = objectResponse;
                }else{
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ResponseGeneric<BancoModel>> SearchBanco(string codeBanco)
        {
             var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codeBanco}");
            var response = new ResponseGeneric<BancoModel>();

            using(var client = new HttpClient()){
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objectResponse = JsonSerializer.Deserialize<BancoModel>(contentResponse);

                if(responseBrasilApi.IsSuccessStatusCode){
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.DataReturn = objectResponse;
                }else{
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public async Task<ResponseGeneric<EnderecoModel>> SearchEnderecoByCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            var response = new ResponseGeneric<EnderecoModel>();
            using(var client = new HttpClient()){
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objectResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResponse);

                if(responseBrasilApi.IsSuccessStatusCode){
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.DataReturn = objectResponse;
                }else{
                    response.CodeHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }

            return response;
        }
    }
}