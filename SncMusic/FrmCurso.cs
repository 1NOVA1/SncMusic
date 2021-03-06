﻿using System;
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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Nome = txtNome.Text;
            curso.CargaHoraria =Convert.ToInt32(txtCargaHoraria.Text);
            curso.Valor = Convert.ToDouble(txtValor.Text);
            curso.Inserir();
            if (curso.Id > 0)
            {
                txtID.Text = curso.Id.ToString();
                MessageBox.Show("Curso cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Fala ao cadastrar curso!");
            }


        }

        private void cmbCurso_DropDown(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            var dr = curso.ListarTodos();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome_curso";
            cmbCurso.ValueMember = "id_curso";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

    }
    }

