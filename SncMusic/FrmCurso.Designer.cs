﻿namespace SncMusic
{
    partial class FrmCurso
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblCursos = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(92, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(75, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(38, 93);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(72, 13);
            this.lblCargaHoraria.TabIndex = 2;
            this.lblCargaHoraria.Text = "Carga Horária";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor R$";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(140, 86);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(75, 20);
            this.txtCargaHoraria.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(140, 115);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(140, 156);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProfessor);
            this.groupBox1.Controls.Add(this.btnAssociar);
            this.groupBox1.Controls.Add(this.lblProfessor);
            this.groupBox1.Controls.Add(this.lblCursos);
            this.groupBox1.Controls.Add(this.cmbCurso);
            this.groupBox1.Location = new System.Drawing.Point(41, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 164);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associar Professor";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(179, 73);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(137, 21);
            this.cmbProfessor.TabIndex = 20;
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
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(176, 47);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(51, 13);
            this.lblProfessor.TabIndex = 18;
            this.lblProfessor.Text = "Professor";
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(12, 47);
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
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(141, 34);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(74, 20);
            this.txtID.TabIndex = 32;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "FrmCurso";
            this.Text = "FrmCursos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.TextBox txtID;
    }
}
