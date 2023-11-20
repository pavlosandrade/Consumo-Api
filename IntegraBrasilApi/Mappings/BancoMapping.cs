using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;
namespace IntegraBrasilApi.Mappings{

    public class BancoMapping: Profile{

        public BancoMapping(){
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();

        }
    }
}