namespace SncMusic
{
    partial class FrmMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSituação = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.txtValorCurso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblCursos = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMatriculaId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "MatriculaID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSituação
            // 
            this.txtSituação.Location = new System.Drawing.Point(98, 52);
            this.txtSituação.Name = "txtSituação";
            this.txtSituação.Size = new System.Drawing.Size(121, 20);
            this.txtSituação.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Situação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dia Semana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor Curso";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(98, 78);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(121, 20);
            this.txtHorario.TabIndex = 18;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(98, 104);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(121, 20);
            this.txtDiaSemana.TabIndex = 19;
            // 
            // txtValorCurso
            // 
            this.txtValorCurso.Location = new System.Drawing.Point(98, 130);
            this.txtValorCurso.Name = "txtValorCurso";
            this.txtValorCurso.Size = new System.Drawing.Size(121, 20);
            this.txtValorCurso.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAluno);
            this.groupBox1.Controls.Add(this.btnAssociar);
            this.groupBox1.Controls.Add(this.lblAluno);
            this.groupBox1.Controls.Add(this.lblCursos);
            this.groupBox1.Controls.Add(this.cmbCurso);
            this.groupBox1.Location = new System.Drawing.Point(30, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 164);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associar Aluno";
            // 
            // cmbAluno
            // 
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Location = new System.Drawing.Point(179, 73);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(137, 21);
            this.cmbAluno.TabIndex = 20;
            this.cmbAluno.DropDown += new System.EventHandler(this.cmbAluno_DropDown);
            // 
            // btnAssociar
            // 
            this.btnAssociar.Location = new System.Drawing.Point(338, 71);
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.Size = new System.Drawing.Size(75, 23);
            this.btnAssociar.TabIndex = 19;
            this.btnAssociar.Text = "Associar";
            this.btnAssociar.UseVisualStyleBackColor = true;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(176, 47);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(34, 13);
            this.lblAluno.TabIndex = 18;
            this.lblAluno.Text = "Aluno";
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(13, 47);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(39, 13);
            this.lblCursos.TabIndex = 17;
            this.lblCursos.Text = "Cursos";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(15, 73);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(137, 21);
            this.cmbCurso.TabIndex = 14;
            this.cmbCurso.DropDown += new System.EventHandler(this.cmbCurso_DropDown);
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatriculaId
            // 
            this.txtMatriculaId.Enabled = false;
            this.txtMatriculaId.Location = new System.Drawing.Point(98, 26);
            this.txtMatriculaId.Name = "txtMatriculaId";
            this.txtMatriculaId.ReadOnly = true;
            this.txtMatriculaId.Size = new System.Drawing.Size(74, 20);
            this.txtMatriculaId.TabIndex = 34;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(178, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(115, 168);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 36;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMatriculaId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorCurso);
            this.Controls.Add(this.txtDiaSemana);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSituação);
            this.Controls.Add(this.lblID);
            this.Name = "FrmMatricula";
            this.Text = "FrmMatricula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSituação;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.TextBox txtValorCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMatriculaId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultar;
    }
}