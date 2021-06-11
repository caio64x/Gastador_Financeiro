using Dapper;

using Gastador.Negocios.Mapeamento;
using Gastador;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gastador.Negocios.DAL
{
    public class UsuarioDAO : Conexao
    {
        MySqlConnection banco;

        public UsuarioDAO()
        {
            this.banco = Conexao.getConnection();
        }

        //funciona
        public List<Usuario> Listar(string nome)
        {
            return banco.Query<Usuario>(@"SELECT * FROM Usuarios WHERE Nome LIKE '%" + nome + "%' Order By Nome").ToList();
        }



        public Usuario Buscar(int id)
        {
            return banco.Query<Usuario>(@"SELECT * FROM Usuarios WHERE ID = @id", new { id }).SingleOrDefault();
        }

        public Usuario EfetuarLogin(string login, string senha)
        {
            return banco.Query<Usuario>(@"SELECT * FROM Usuarios WHERE Login = @Login  and Senha = @Senha", new { login, senha }).SingleOrDefault();
        }


        public bool Excluir(int id)
        {
            return banco.Execute(@"DELETE FROM Usuarios WHERE ID = @xxxxxx", new { xxxxxx = id }) == 1;
        }



        public int Salvar(Usuario usuario)
        {
            if (usuario.ID == 0)
            {
                //se o id for zero, é inclusão
                return banco.Query<int>(
                "INSERT INTO Usuarios (Nome, Ativo, Login, Senha) values " +
                "(@Nome, @Ativo, @Login, @Senha) " +
                "select @@Identity", usuario).SingleOrDefault();
            }
            else
            {
                //update
                if (banco.Execute("UPDATE Usuarios SET " +
                "Nome = @Nome, Ativo = @Ativo, Senha = @Senha " +
                "WHERE ID = @ID", usuario) == 1)
                    return usuario.ID;
                else
                    return 0;
            }
        }
    }
}