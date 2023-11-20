using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace IntegraBrasilApi.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController: ControllerBase{
        public readonly IBancoServices _bancoServices;

        public BancoController(IBancoServices bancoServices)
        {
            _bancoServices = bancoServices;
        }

        [HttpGet("busca/todos")]
        public async Task<ActionResult> SearchAll(){
            var response = await _bancoServices.SearchAll();
            if(response.CodeHttp == HttpStatusCode.OK){
                return Ok(response.DataReturn);
            }else{
                return StatusCode((int)response.CodeHttp, response.ErrorReturn);
            }
        }


        [HttpGet("busca/{codeBanco}")]
        public async Task<ActionResult> Search([RegularExpression("^[0-9]*$")]string codeBanco){
            var response = await _bancoServices.SearchBanco(codeBanco);
            if(response.CodeHttp == HttpStatusCode.OK){
                return Ok(response.DataReturn);
            }else{
                return StatusCode((int)response.CodeHttp, response.ErrorReturn);
            }
        }
    }
}