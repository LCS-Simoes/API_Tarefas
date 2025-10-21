using API_Tarefas.Integração.Interfaces;
using API_Tarefas.Integração.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Tarefas.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _viaCepIntegracao;
        public CepController(IViaCepIntegracao integracao) 
        {
            _viaCepIntegracao = integracao;
        }


        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> ListarEndereco(string cep)
        {
            var response = await _viaCepIntegracao.ObterCep(cep);

            if(response == null)
            {
                return BadRequest("CEP Não encontrado!");
            }

            return Ok(response);
        }
    }
}
