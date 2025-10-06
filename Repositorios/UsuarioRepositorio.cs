using API_Tarefas.Data;
using API_Tarefas.Models;
using API_Tarefas.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_Tarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly APITarefasDbContex _dbcontex;
        public UsuarioRepositorio(APITarefasDbContex apitarefasDbContex)
        {
            _dbcontex = apitarefasDbContex;
        }

        async Task<UsuarioModel> IUsuarioRepositorio.BuscarID(int id)
        {
            return await _dbcontex.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        Task<List<UsuarioModel>> IUsuarioRepositorio.TodosUsuarios()
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUsuarioRepositorio.Apagar(int id)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
