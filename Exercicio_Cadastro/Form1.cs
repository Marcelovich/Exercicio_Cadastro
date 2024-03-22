using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstCadastro.View = View.Details;
            lstCadastro.LabelEdit = true;
            lstCadastro.AllowColumnReorder = true;
            lstCadastro.FullRowSelect = true;
            lstCadastro.GridLines = true;

            ColumnHeader Nome = new ColumnHeader();
            Nome.Text = "Nome";
            Nome.Width = 220;

            ColumnHeader Endereco = new ColumnHeader();
            Endereco.Text = "Endereco";
            Endereco.Width = 220;

            ColumnHeader dataNasc = new ColumnHeader();
            dataNasc.Text = "Nascimento";
            dataNasc.Width = 100;

            ColumnHeader Sexo = new ColumnHeader();
            Sexo.Text = "Sexo";
            Sexo.Width = 100;

            ColumnHeader Formacao = new ColumnHeader();
            Formacao.Text = "Formacao";
            Formacao.Width = 120;

            ColumnHeader Ingles = new ColumnHeader();
            Ingles.Text = "Ingles";
            Ingles.Width = 60;

            ColumnHeader Informatica = new ColumnHeader();
            Informatica.Text = "Informatica";
            Informatica.Width = 100;

            ColumnHeader Experiencia = new ColumnHeader();
            Experiencia.Text = "Experiencia";
            Experiencia.Width = 100;

            ColumnHeader cnh = new ColumnHeader();
            cnh.Text = "CNH";
            cnh.Width = 50;

            ColumnHeader pcd = new ColumnHeader();
            pcd.Text = "PCD";
            pcd.Width = 50;

            lstCadastro.Columns.Add(Nome);
            lstCadastro.Columns.Add(Endereco);
            lstCadastro.Columns.Add(dataNasc);
            lstCadastro.Columns.Add(Sexo);
            lstCadastro.Columns.Add(Formacao);
            lstCadastro.Columns.Add(Ingles);
            lstCadastro.Columns.Add(Informatica);
            lstCadastro.Columns.Add(Experiencia);
            lstCadastro.Columns.Add(cnh);
            lstCadastro.Columns.Add(pcd);
        }

        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = "";
            string endereco = "";
            DateTime dataNasc;
            string sexo = ""; 
            string formacao = "";
            string ingles = "";
            string informatica = "";
            string experiencia = "";
            string cnh = "";
            string pcd = "";



            nome = txtNome.Text;
            endereco = txtEndereco.Text;


            //Escolher sexo
            // Verifica se o dataNasc eh valido e armazena no dataNasc
             if (!DateTime.TryParseExact(mTxtDataNasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNasc))
             {
                MessageBox.Show("Data de nascimento inválida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
             }

            if (rbtnMasculino.Checked)
            {
                sexo = "Masculino";
            }
            else if (rbtnFeminino.Checked)
            {
                sexo = "Feminino";
            }
            else
            {
                MessageBox.Show("Escolha um sexo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Escolher ensino
            if (rbtnFundamental.Checked)
            {
                formacao = "Fundamental";

            }
            else if (rbtnMedio.Checked)
            {
                formacao = "Ensino Medio";

            }
            else if (rbtnSuperior.Checked)
            {
                formacao = "Ensino Superior";
            }
            else
            {
                MessageBox.Show("Escolha uma Formacao!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //Escolher informacoes adicionais
            if (chkIngles.Checked)
            {
                ingles = "Sim";
            }
            else
            {
                ingles = "Nao";
            }

            if (chkInformatica.Checked)
            {
                informatica = "Sim";
            }
            else
            {
                informatica = "Nao";
            }

            if (chkExperiencia.Checked)
            {
                experiencia = "Sim";
            }
            else
            {
                experiencia = "Nao";
            }

            if (chkCNH.Checked)
            {
                cnh = "Sim";
            }
            else
            {
                cnh = "Nao";
            }

            if (chkPCD.Checked)
            {
                pcd = "Sim";
            }
            else
            {
                pcd = "Nao";
            }


            ListViewItem item = new ListViewItem(nome);
            item.SubItems.Add(endereco);
            item.SubItems.Add(dataNasc.ToString("dd/MM/yyyy")); 
            item.SubItems.Add(sexo);
            item.SubItems.Add(formacao);
            item.SubItems.Add(ingles);
            item.SubItems.Add(informatica);
            item.SubItems.Add(experiencia);
            item.SubItems.Add(cnh);
            item.SubItems.Add(pcd);
            lstCadastro.Items.Add(item);
            lstCadastro.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            lstCadastro.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);

            for (int i = 0; i < lstCadastro.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lstCadastro.Items[i].BackColor = Color.White;
                }
                else
                {
                    lstCadastro.Items[i].BackColor = Color.LightGray;
                }
            }



            txtNome.Text = "";
            txtEndereco.Text = "";
            mTxtDataNasc.Text = "";

            txtNome.Focus();
            foreach (Control selecionado in grbSexo.Controls)
            {
                if (selecionado is RadioButton)
                {
                    ((RadioButton)selecionado).Checked = false;
                }
            }

            foreach (Control selecionado in grbFormacao.Controls)
            {
                if (selecionado is RadioButton)
                {
                    ((RadioButton)selecionado).Checked = false;
                }
            }

            foreach (Control selecionado in grbInformacoes.Controls)
            {
                if (selecionado is CheckBox)
                {
                    ((CheckBox)selecionado).Checked = false;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNome.Text = "";
            txtEndereco.Text = "";
            mTxtDataNasc.Text = "";

            
            foreach (Control selecionado in grbSexo.Controls)
            {
                if (selecionado is RadioButton)
                {
                    ((RadioButton)selecionado).Checked = false;
                }
            }

            foreach (Control selecionado in grbFormacao.Controls)
            {
                if (selecionado is RadioButton)
                {
                    ((RadioButton)selecionado).Checked = false;
                }
            }

            foreach (Control selecionado in grbInformacoes.Controls)
            {
                if (selecionado is CheckBox)
                {
                    ((CheckBox)selecionado).Checked = false;
                }
            }
        }
    }
}
