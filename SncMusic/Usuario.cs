using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace SncMusic
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }

        public Usuario(int _id, string _nome, string _email, string _senha, string _situacao)
        {
            Id = _id;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            Situacao = _situacao;
        }
        public Usuario(string _nome, string _email, string _senha, string _situacao)
        {
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            Situacao = _situacao;
        }
        public Usuario(int _id, string _nome, string _senha, string _situacao)
        {
            Id = _id;
            Nome = _nome;
            Senha = _senha;
            Situacao = _situacao;
        }
        public Usuario()
        {

        }
   


        public void Inserir()
        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_usuario values (0,@nome,@email,@senha,@situacao)";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            comm.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = Situacao;
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            Id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();
        }
        public bool Alterar(Usuario usuario)
        {
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "uptdate tb_usuario set nome_usuario = @nome, email_usuario = @email, senha_usuario = @senha, situacao_usuario = @situacao where id_usuario = @id";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = usuario.Nome;
                comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = usuario.Email;
                comm.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;
                comm.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = usuario.Situacao;
                comm.Parameters.Add("@id", MySqlDbType.Int32).Value = usuario.Id;
                comm.ExecuteNonQuery();

                Banco.Fechar();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void ConsultarPorId(int _id)
        {
            var comm = Banco.Abrir();
            comm.CommandText = "Select * from tb_usuario where id_usuario = " + _id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Nome = dr.GetString(1);
                Email = dr.GetString(2);
                Senha = dr.GetString(3);
                Situacao = dr.GetString(4);

            }
        }
    }
}
