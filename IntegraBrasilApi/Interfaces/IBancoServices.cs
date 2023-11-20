using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces{
    public interface IBancoServices{
        Task<ResponseGeneric<List<BancoResponse>>> SearchAll();
        Task<ResponseGeneric<BancoResponse>> SearchBanco(string codeBanco);
    }
}