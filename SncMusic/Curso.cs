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
                comm.CommandText = "selec @@identity";
                id = Convert.ToInt32(comm.ExecuteScalar());
                Banco.Fechar();

            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public bool Alterar()
        {
            return true;
        }

        public void ConsultarPorId(int id)
        {

        }
        public List <Curso> ConsultarPorNome(string caracteres) 
        {
            List<Curso> lista = new List<Curso>();
            return lista;


        }
        public bool AssociarProfessor(int _id_curso, int _id_professor)
        {
            return true;
        }
        public List<Professor> ConsultarAssociacao(int _id_curso)
        {
            List<Professor> lista = new List<Professor>();
            return lista;
            
        }



    }
}
