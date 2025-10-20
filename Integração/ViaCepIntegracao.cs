using API_Tarefas.Integração.Interfaces;
using API_Tarefas.Integração.Refit;
using API_Tarefas.Integração.Response;

namespace API_Tarefas.Integração
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        public readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;

        public ViaCepIntegracao(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
        }

        public async Task<ViaCepResponse> ObterCep(string cep)
        {
            var responseData = await _viaCepIntegracaoRefit.ObterCep(cep);

            if(responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;
        }
    }
}
