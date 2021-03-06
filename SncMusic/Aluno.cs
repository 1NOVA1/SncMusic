﻿  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;

namespace SncMusic
{
    public class Aluno
    {
        // atributos e propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }

        //métodos construtores
        public Aluno(int _id, string _nome, string _cpf, string _sexo, string _email, string _telefone, DateTime _dataCadastro)
        {
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Sexo = _sexo;
            Telefone = _telefone;
            Email = _email;
            DataCadastro = _dataCadastro;
        }
        public Aluno(string _nome, string _cpf, string _sexo, string _email, string _telefone)
        {
            Nome = _nome;
            Cpf = _cpf;
            Sexo = _sexo;
            Telefone = _telefone;
            Email = _email;
        }
        public Aluno(int _id, string _nome, string _sexo, string _telefone)
        {
            Nome = _nome;
            Sexo = _sexo;
            Telefone = _telefone;
            Id = _id;
        }
        public Aluno()
        {


        }
            //métodos da classe
            public void Inserir()

            {
                MySqlCommand comm = Banco.Abrir();
                comm.CommandText = "insert into tb_aluno values (0,@nome,@cpf,@sexo,@email,@telefone,default)";
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
            public bool Alterar(Aluno aluno)
            {
                try //Bloco de tratamento de excessão 
                {
                    var comm = Banco.Abrir();
                    comm.CommandText = "update tb_aluno set nome_aluno = @nome, sexo_aluno = @sexo, telefone_aluno = @telefone where id_aluno = @id";
                    comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = aluno.Nome;
                    comm.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = aluno.Sexo;
                    comm.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = aluno.Telefone;
                    comm.Parameters.Add("@id", MySqlDbType.Int32).Value = aluno.Id;
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
                comm.CommandText = "Select * from tb_aluno where id_aluno = " + _id;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Nome = dr.GetString(1);
                    Email = dr.GetString(4);
                    Cpf = dr.GetString(2);
                    Sexo = dr.GetString(3);
                    Telefone = dr.GetString(5);
                    DataCadastro = Convert.ToDateTime(dr.GetValue(6));

                }


            }
            public List<Aluno> ListarTodos()
            {

                List<Aluno> ListaAluno = new List<Aluno>();
                var comm = Banco.Abrir();
                comm.CommandText = "Select * from tb_aluno ";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ListaAluno.Add(new Aluno(dr.GetInt32(0),
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
