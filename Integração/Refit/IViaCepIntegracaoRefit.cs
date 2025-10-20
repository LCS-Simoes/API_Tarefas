using API_Tarefas.Integração.Response;
using Refit;

namespace API_Tarefas.Integração.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterCep(string cep);
    }
}
