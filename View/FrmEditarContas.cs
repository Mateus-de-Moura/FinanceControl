
using LOGIN.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contas.Apresentacao
{
    public partial class FrmEditarContas : Form
    {
        public FrmEditarContas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginDao cad = new LoginDao();
            int id = int.Parse(txbId.Text);
            string descricao = txbDesc.Text;
            decimal valor = decimal.Parse(tcbVal.Text);
            string vencimento = txbVenc.Text;
            string situacao = cbmSitu.Text;
            if (situacao != "Selecione")
            {
                cad.EditarConta(id, descricao, valor, vencimento, situacao);
                MessageBox.Show(cad.mensagem);
                this.Close();
            }
            else {
                MessageBox.Show("Informe a situação Atual da Conta");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoginDao c = new LoginDao();
                int id = int.Parse(txbId.Text);
                c.DeletarConta(id);
                MessageBox.Show("Registro excluído com sucesso", "Sucesso");
                this.Close();

            }
            else
            {
                this.Close();
            }
        }
    }
}
