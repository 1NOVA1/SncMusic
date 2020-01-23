using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SncMusic
{
    public class Curso
    {
        //Atributos
        private int id;
        private string nome;
        private int cargaHoraria;
        private double valor;

        //Propriedades
        public int Id { get => id; set => id = value; } //Encapsulamento
        public string Nome { get => nome; set => nome = value; }
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public double Valor { get => valor; set => valor = value; }

        //Métodos Construtores (new Curso))
        public Curso()
        {
            Valor = 0.0;
        }

        public Curso(int id, string nome, int cargaHoraria, double valor)
        {
            this.id = id;
            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.Valor = valor;
        }
        public Curso(string nome, int cargaHoraria, double valor)
        {
            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.Valor = valor;
        }
        public Curso(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        //Métodos da Classe
        public void Inserir()
        {

            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "Insert into tb_curso values(0,@nome, @carga_horaria, @valor)";
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                comm.Parameters.Add("@carga_horaria", MySqlDbType.Int32).Value = cargaHoraria;
                comm.Parameters.Add("@valor", MySqlDbType.Decimal).Value = valor;
                comm.ExecuteNonQuery();
                comm.CommandText = "select @@identity";
                id = Convert.ToInt32(comm.ExecuteScalar());
                Banco.Fechar();

            }
            catch (Exception)
            {
                throw;
            }
           
        }
        public bool Alterar(Curso curso)
        {
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "update tb_curso set nome_curso = @nome," +
                    " carga_horaria_curso = @carga" +
                    ", valor_curso = @valor where id_curso = @id";
                comm.Parameters.Add("id", MySqlDbType.Int32).Value = curso.id;
                comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = curso.nome;
                comm.Parameters.Add("@carga", MySqlDbType.Int32).Value = curso.cargaHoraria;
                comm.Parameters.Add("@valor", MySqlDbType.Decimal).Value = curso.valor;
                comm.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ConsultarPorId(int _id)
        {
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = ("select * from tb_curso where id = @id =") + _id;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nome = dr.GetString(1);
                    CargaHoraria = dr.GetInt32(2);
                    Valor = Convert.ToDouble(dr.GetDecimal(3));
                }

            }


            catch (Exception)
            {


            }

        }
        public List <Curso> ConsultarPorNome(string caracteres) 
        {

            List<Curso> lista = new List<Curso>();
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_curso where nome_curso like '%@carac%'";
                comm.Parameters.Add("@carac", MySqlDbType.VarChar).Value = caracteres;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Curso(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetDouble(3)));

                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }


        }
        public bool AssociarProfessor(int _id_curso, int _id_professor)
        {
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = ("insert into professor_curso values(@prof, @curso, default)");
                comm.Parameters.Add("@prof", MySqlDbType.Int32).Value = _id_professor;
                comm.Parameters.Add("@curso", MySqlDbType.Int32).Value = _id_curso;
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {  
                return true;
            }
            
        }
        public List<Professor> ConsultarAssociacao(int _id_curso)
        {
            List<Professor> lista = new List<Professor>();
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_professor_curso";
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
            
        }





    }
}
