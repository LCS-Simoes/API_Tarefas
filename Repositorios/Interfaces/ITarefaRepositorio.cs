using API_Tarefas.Models;

namespace API_Tarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> TodasTarefas();
        Task<TarefaModel> BuscarID(int id);
        Task<TarefaModel> Adicionar(TarefaModel tarefa);
        Task<TarefaModel> Atualizar(TarefaModel tarefa, int id);
        Task<bool> Deletar(int id);

    }
}
