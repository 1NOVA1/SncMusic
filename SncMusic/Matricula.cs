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

        public  Matricula(int _id, string _situacao, string _horario, string _diasemana, double _valorcurso)
        {
            Id = _id;
            Situacao = _situacao;
            Horario = _horario;
            DiaSemana = _diasemana;
            ValorCurso = _valorcurso;         
        }



    }


}

    
