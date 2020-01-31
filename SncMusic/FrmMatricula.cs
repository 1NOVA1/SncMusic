using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SncMusic
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            matricula.Situacao = txtSituação.Text;
            matricula.Horario = txtHorario.Text;
            matricula.DiaSemana = txtDiaSemana.Text;
            matricula.ValorCurso = Convert.ToDouble(txtValorCurso.Text);
            matricula.Inserir();
            if (matricula.Id > 0)
            {
                txtMatriculaId.Text = matricula.Id.ToString();
                MessageBox.Show("Matricula feita com sucesso!");
            }
            else
            {

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void cmbAluno_DropDown(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            var dr = matricula.ListarTodos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbAluno.DataSource = dt;
            cmbAluno.DisplayMember = "nome_aluno";
            cmbAluno.ValueMember = "id_aluno";
        }

        private void cmbCurso_DropDown(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            var dr = matricula.ListarTodos2();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome_curso";
            cmbCurso.ValueMember = "id_curso";

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idcurso = cmbCurso.SelectedValue.ToString();
            if (idcurso != string.Empty)
            {
                Matricula matricula = new Matricula();
                matricula.ConsultarPorId(Convert.ToInt32(idcurso));
                cmbCurso.Text = matricula.IdCurso.ToString();
                txtValorCurso.Text = matricula.Nome;
            }
        }
    }
}

