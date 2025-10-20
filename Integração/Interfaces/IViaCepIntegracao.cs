using API_Tarefas.Integração.Response;

namespace API_Tarefas.Integração.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterCep(string cep);
    }
}
