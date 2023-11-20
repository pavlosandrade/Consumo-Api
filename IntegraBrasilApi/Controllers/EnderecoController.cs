using System.Net;
using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controller{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController:ControllerBase{
        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("buscar/{cep}")]        
        public async Task<ActionResult> BuscarEndereco([FromRoute] string cep){
            var response = await _enderecoService.SearchEndereco(cep);
            if(response.CodeHttp == HttpStatusCode.OK){
                return Ok(response.DataReturn);
            }else{
                return StatusCode((int)response.CodeHttp, response.ErrorReturn);
            }
        }
    }
}