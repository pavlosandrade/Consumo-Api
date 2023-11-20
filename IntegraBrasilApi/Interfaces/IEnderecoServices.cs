using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces{
    
    public interface IEnderecoService{
        Task<ResponseGeneric<EnderecoResponse>> SearchEndereco(string cep);
    }
}