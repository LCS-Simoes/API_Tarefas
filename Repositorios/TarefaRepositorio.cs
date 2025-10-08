using API_Tarefas.Data;
using API_Tarefas.Models;
using API_Tarefas.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_Tarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly APITarefasDbContex _dbcontex;
        public TarefaRepositorio(APITarefasDbContex apitarefasDbContex)
        {
            _dbcontex = apitarefasDbContex;
        }

        public async Task<TarefaModel> BuscarID(int id)
        {
            return await _dbcontex.Tarefas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<TarefaModel>> TodasTarefas()
        {
            return await _dbcontex.Tarefas.ToListAsync();
        }

        public async Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
            await _dbcontex.Tarefas.AddAsync(tarefa);
            await _dbcontex.SaveChangesAsync();
            return tarefa;
        }

        public async Task<TarefaModel> Atualizar(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaID = await BuscarID(id);

            if (tarefaID == null)
            {
                throw new Exception($"Tarefa ID: {id} não foi encontrado no banco de dados");
            }

            tarefaID.Nome = tarefa.Nome;
            tarefaID.Descricao = tarefa.Descricao;
            tarefaID.Status = tarefa.Status;
            tarefaID.UsuarioID = tarefa.UsuarioID;
            
            _dbcontex.Tarefas.Update(tarefaID);
            await _dbcontex.SaveChangesAsync();
            return tarefaID;
        }

        public async Task<bool> Deletar(int id)
        {
            TarefaModel tarefaID = await BuscarID(id);

            if (tarefaID == null)
            {
                throw new Exception($"Tarefa para o ID: {id} não foi encontrado no banco de dados");
            }

            _dbcontex.Tarefas.Remove(tarefaID);
            await _dbcontex.SaveChangesAsync();
            return true;
        }
    }
}
