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

        public async Task<UsuarioModel> BuscarID(int id)
        {
            return await _dbcontex.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> TodosUsuarios()
        {
            return await _dbcontex.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbcontex.Usuarios.AddAsync(usuario);
            await _dbcontex.SaveChangesAsync();
            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioID = await BuscarID(id);

            if (usuarioID == null)
            {
                throw new Exception($"Usuário {id} não foi encontrado no banco de dados");
            }

            usuarioID.Nome = usuario.Nome;
            usuarioID.Email = usuario.Email;

            _dbcontex.Usuarios.Update(usuarioID);
            await _dbcontex.SaveChangesAsync();
            return usuarioID;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioID = await BuscarID(id);

            if (usuarioID == null)
            {
                throw new Exception($"Usuário {id} não foi encontrado no banco de dados");
            }

            _dbcontex.Usuarios.Remove(usuarioID);
            await _dbcontex.SaveChangesAsync();
            return true ;
        }
    }
}
