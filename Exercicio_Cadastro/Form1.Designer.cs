namespace Exercicio_Cadastro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.grbFormacao = new System.Windows.Forms.GroupBox();
            this.rbtnSuperior = new System.Windows.Forms.RadioButton();
            this.rbtnFundamental = new System.Windows.Forms.RadioButton();
            this.rbtnMedio = new System.Windows.Forms.RadioButton();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.chkPCD = new System.Windows.Forms.CheckBox();
            this.chkCNH = new System.Windows.Forms.CheckBox();
            this.chkExperiencia = new System.Windows.Forms.CheckBox();
            this.chkInformatica = new System.Windows.Forms.CheckBox();
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.lstCadastro = new System.Windows.Forms.ListView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mTxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.grbSexo.SuspendLayout();
            this.grbFormacao.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNome.Location = new System.Drawing.Point(38, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblEndereco.Location = new System.Drawing.Point(38, 76);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(88, 18);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereco: ";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNascimento.Location = new System.Drawing.Point(38, 118);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(165, 18);
            this.lblNascimento.TabIndex = 0;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rbtnMasculino);
            this.grbSexo.Controls.Add(this.rbtnFeminino);
            this.grbSexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.grbSexo.Location = new System.Drawing.Point(26, 148);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(243, 66);
            this.grbSexo.TabIndex = 4;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rbtnMasculino.Location = new System.Drawing.Point(15, 28);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(102, 22);
            this.rbtnMasculino.TabIndex = 5;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rbtnFeminino.Location = new System.Drawing.Point(125, 28);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(93, 22);
            this.rbtnFeminino.TabIndex = 6;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // grbFormacao
            // 
            this.grbFormacao.Controls.Add(this.rbtnSuperior);
            this.grbFormacao.Controls.Add(this.rbtnFundamental);
            this.grbFormacao.Controls.Add(this.rbtnMedio);
            this.grbFormacao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.grbFormacao.Location = new System.Drawing.Point(26, 239);
            this.grbFormacao.Name = "grbFormacao";
            this.grbFormacao.Size = new System.Drawing.Size(243, 116);
            this.grbFormacao.TabIndex = 7;
            this.grbFormacao.TabStop = false;
            this.grbFormacao.Text = "Formacao";
            // 
            // rbtnSuperior
            // 
            this.rbtnSuperior.AutoSize = true;
            this.rbtnSuperior.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rbtnSuperior.Location = new System.Drawing.Point(15, 83);
            this.rbtnSuperior.Name = "rbtnSuperior";
            this.rbtnSuperior.Size = new System.Drawing.Size(135, 22);
            this.rbtnSuperior.TabIndex = 10;
            this.rbtnSuperior.TabStop = true;
            this.rbtnSuperior.Text = "Ensino Superior";
            this.rbtnSuperior.UseVisualStyleBackColor = true;
            // 
            // rbtnFundamental
            // 
            this.rbtnFundamental.AutoSize = true;
            this.rbtnFundamental.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rbtnFundamental.Location = new System.Drawing.Point(15, 23);
            this.rbtnFundamental.Name = "rbtnFundamental";
            this.rbtnFundamental.Size = new System.Drawing.Size(122, 22);
            this.rbtnFundamental.TabIndex = 8;
            this.rbtnFundamental.TabStop = true;
            this.rbtnFundamental.Text = "Fundamental";
            this.rbtnFundamental.UseVisualStyleBackColor = true;
            // 
            // rbtnMedio
            // 
            this.rbtnMedio.AutoSize = true;
            this.rbtnMedio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rbtnMedio.Location = new System.Drawing.Point(15, 53);
            this.rbtnMedio.Name = "rbtnMedio";
            this.rbtnMedio.Size = new System.Drawing.Size(125, 22);
            this.rbtnMedio.TabIndex = 9;
            this.rbtnMedio.TabStop = true;
            this.rbtnMedio.Text = "Ensino Medio";
            this.rbtnMedio.UseVisualStyleBackColor = true;
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.chkPCD);
            this.grbInformacoes.Controls.Add(this.chkCNH);
            this.grbInformacoes.Controls.Add(this.chkExperiencia);
            this.grbInformacoes.Controls.Add(this.chkInformatica);
            this.grbInformacoes.Controls.Add(this.chkIngles);
            this.grbInformacoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.grbInformacoes.Location = new System.Drawing.Point(26, 381);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(243, 196);
            this.grbInformacoes.TabIndex = 11;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informacoes Adicionais";
            // 
            // chkPCD
            // 
            this.chkPCD.AutoSize = true;
            this.chkPCD.Location = new System.Drawing.Point(15, 155);
            this.chkPCD.Name = "chkPCD";
            this.chkPCD.Size = new System.Drawing.Size(207, 22);
            this.chkPCD.TabIndex = 16;
            this.chkPCD.Text = "Pessoa com deficiência";
            this.chkPCD.UseVisualStyleBackColor = true;
            // 
            // chkCNH
            // 
            this.chkCNH.AutoSize = true;
            this.chkCNH.Location = new System.Drawing.Point(15, 125);
            this.chkCNH.Name = "chkCNH";
            this.chkCNH.Size = new System.Drawing.Size(203, 22);
            this.chkCNH.TabIndex = 15;
            this.chkCNH.Text = "Carteira de Habilitacao";
            this.chkCNH.UseVisualStyleBackColor = true;
            // 
            // chkExperiencia
            // 
            this.chkExperiencia.AutoSize = true;
            this.chkExperiencia.Location = new System.Drawing.Point(15, 95);
            this.chkExperiencia.Name = "chkExperiencia";
            this.chkExperiencia.Size = new System.Drawing.Size(202, 22);
            this.chkExperiencia.TabIndex = 14;
            this.chkExperiencia.Text = "Experiencia Profissional";
            this.chkExperiencia.UseVisualStyleBackColor = true;
            // 
            // chkInformatica
            // 
            this.chkInformatica.AutoSize = true;
            this.chkInformatica.Location = new System.Drawing.Point(15, 65);
            this.chkInformatica.Name = "chkInformatica";
            this.chkInformatica.Size = new System.Drawing.Size(183, 22);
            this.chkInformatica.TabIndex = 13;
            this.chkInformatica.Text = "Curso de Informatica";
            this.chkInformatica.UseVisualStyleBackColor = true;
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(15, 35);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(139, 22);
            this.chkIngles.TabIndex = 12;
            this.chkIngles.Text = "Curso de Ingles";
            this.chkIngles.UseVisualStyleBackColor = true;
            // 
            // lstCadastro
            // 
            this.lstCadastro.BackColor = System.Drawing.Color.White;
            this.lstCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCadastro.ForeColor = System.Drawing.Color.Black;
            this.lstCadastro.HideSelection = false;
            this.lstCadastro.Location = new System.Drawing.Point(289, 148);
            this.lstCadastro.Name = "lstCadastro";
            this.lstCadastro.Size = new System.Drawing.Size(887, 429);
            this.lstCadastro.TabIndex = 0;
            this.lstCadastro.UseCompatibleStateImageBehavior = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnCadastrar.Location = new System.Drawing.Point(474, 112);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 25);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnLimpar.Location = new System.Drawing.Point(625, 112);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 25);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtNome.Location = new System.Drawing.Point(101, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(659, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtEndereco.Location = new System.Drawing.Point(132, 73);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(628, 26);
            this.txtEndereco.TabIndex = 2;
            // 
            // mTxtDataNasc
            // 
            this.mTxtDataNasc.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.mTxtDataNasc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.mTxtDataNasc.Location = new System.Drawing.Point(210, 110);
            this.mTxtDataNasc.Mask = "00/00/0000";
            this.mTxtDataNasc.Name = "mTxtDataNasc";
            this.mTxtDataNasc.Size = new System.Drawing.Size(100, 26);
            this.mTxtDataNasc.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Silver;
            this.btnFechar.Location = new System.Drawing.Point(1194, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 10);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 10);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(764, 10);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 10);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1210, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 600);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 600);
            this.panel5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(625, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(595, 10);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(449, 590);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(764, 10);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(827, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(290, 85);
            this.panel9.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(10, 8);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(70, 70);
            this.panel10.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 600);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.mTxtDataNasc);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lstCadastro);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.grbFormacao);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.grbFormacao.ResumeLayout(false);
            this.grbFormacao.PerformLayout();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.GroupBox grbFormacao;
        private System.Windows.Forms.RadioButton rbtnSuperior;
        private System.Windows.Forms.RadioButton rbtnFundamental;
        private System.Windows.Forms.RadioButton rbtnMedio;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.CheckBox chkPCD;
        private System.Windows.Forms.CheckBox chkCNH;
        private System.Windows.Forms.CheckBox chkExperiencia;
        private System.Windows.Forms.CheckBox chkInformatica;
        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.ListView lstCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mTxtDataNasc;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

