using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces{

    public interface IBrasilApi{
        Task<ResponseGeneric<EnderecoModel>> SearchEnderecoByCEP(string cep);
        Task<ResponseGeneric<List<BancoModel>>> SearchAllBancos();
        Task<ResponseGeneric<BancoModel>> SearchBanco(string codeBanco);
    }
}