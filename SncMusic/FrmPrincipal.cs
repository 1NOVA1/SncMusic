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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno frmaluno = new FrmAluno();
            frmaluno.MdiParent = this;
            frmaluno.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfessor frmprofessor = new FrmProfessor();
            frmprofessor.MdiParent = this;
            frmprofessor.Show();

        }

        private void novoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
