using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;

namespace SncMusic
{
    public class Professor
    {
        // atributos e propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }





        public Professor(int _id, string _nome, string _cpf, string _sexo, string _email, string _telefone, DateTime _dataCadastro)
        {
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Sexo = _sexo;
            Telefone = _telefone;
            Email = _email;
            DataCadastro = _dataCadastro;
        }

        public Professor(string _nome, string _cpf, string _email, string _telefone)
        {
            Nome = _nome;
            Cpf = _cpf;
            Telefone = _telefone;
            Email = _email;
        }
        public Professor(int _id, string _nome,  string _telefone)
        {
            Nome = _nome;
            Telefone = _telefone;
            Id = _id;
        }
        public Professor()
        {


        }
        //métodos da classe
        public void Inserir()

        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_professor values (0,@nome,@cpf,@sexo,@email,@telefone,default)";
            comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = Sexo;
            comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = Telefone;
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            Id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();
        }

        public bool Alterar(Professor professor)
        {
            try //Bloco de tratamento de excessão 
            {
                var comm = Banco.Abrir();
                comm.CommandText = "update tb_professor set nome_professor = @nome, sexo_aluno = @sexo, telefone_professor = @telefone where id_professor = @id";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = professor.Nome;
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = professor.Sexo;
                comm.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = professor.Telefone;
                comm.Parameters.Add("@id", MySqlDbType.Int32).Value = professor.Id;
                comm.ExecuteNonQuery();

                Banco.Fechar();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public void ConsultarPorId(int id)
        {

        }
        public List<Professor> ListarTodos()
        {

            List<Professor> ListaAluno = new List<Professor>();
            var comm = Banco.Abrir();
            comm.CommandText = "Select * from tb_professor ";
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                ListaAluno.Add(new Professor(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2), dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    Convert.ToDateTime(dr.GetValue(6))));


            }
            Banco.Fechar();
            return ListaAluno;
        }
    }
}

    

    
