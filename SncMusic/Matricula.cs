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
    public class Matricula
    {
        public int Id { get; set; }
        public string Situacao { get; set; }
        public string Horario { get; set; }
        public string DiaSemana { get; set; }
        public double ValorCurso { get; set; }

        public Matricula()
        {
            ValorCurso = 0.0;
        }

        public Matricula(int _id, string _situacao, string _horario, string _diasemana, double _valorcurso)
        {
            Id = _id;
            Situacao = _situacao;
            Horario = _horario;
            DiaSemana = _diasemana;
            ValorCurso = _valorcurso;

        }
        public void Inserir()
        {
            MySqlCommand comm = Banco.Abrir();
            comm.CommandText = "insert into tb_matricula values (0,@situacao,@horario,@diasemana,@valorcurso)";
            comm.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = Situacao;
            comm.Parameters.Add("@horario", MySqlDbType.VarChar).Value = Horario;
            comm.Parameters.Add("@diasemana", MySqlDbType.VarChar).Value = DiaSemana;
            comm.Parameters.Add("@valorcurso", MySqlDbType.Decimal).Value = ValorCurso;
            comm.ExecuteNonQuery();
            comm.CommandText = "select @@identity";
            Id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();
        }
        public MySqlDataReader ListarTodos()
        {
            MySqlDataReader dr;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_aluno";
                dr = comm.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {

                return dr = null;
            }

        }
        public MySqlDataReader ListarTodos2()
        {
            MySqlDataReader dr;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandText = "select * from tb_curso";
                dr = comm.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {

                return dr = null;
            }




        }
    }
}

    
