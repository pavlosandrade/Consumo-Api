using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services{
    
    public class BancoService : IBancoServices{
        
    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasiApi;

        public BancoService(IMapper mapper, IBrasilApi brasiApi)
        {
            _mapper = mapper;
            _brasiApi = brasiApi;
        }

        public async Task<ResponseGeneric<List<BancoResponse>>> SearchAll(){
            var bancos = await _brasiApi.SearchAllBancos();
            return _mapper.Map<ResponseGeneric<List<BancoResponse>>>(bancos);
        }

        public async Task<ResponseGeneric<BancoResponse>> SearchBanco(string codeBanco){
            var banco = await _brasiApi.SearchBanco(codeBanco);
            return _mapper.Map<ResponseGeneric<BancoResponse>>(banco);
        }
    }
}