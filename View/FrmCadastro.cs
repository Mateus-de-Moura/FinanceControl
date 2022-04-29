using Contas.Entites;
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
    public partial class FrmCadastro : Form
    {
        LoginDao cadastrar = new LoginDao();
        public FrmCadastro()
        {
            InitializeComponent();
        }       

        private void pictureBox2_Click(object sender, EventArgs e)
        {  
                CadConta cad = new CadConta();            
                cad.Descricao = TxbDescri.Text;
                cad.Valor = decimal.Parse(txbValor.Text);
                cad.Vencimeto = DateTime.Parse(txbVenc.Text);
                cad.situacao = cbmSitu.Text;
            if (TxbDescri.Text != null && txbValor.Text != null && txbVenc.Text != null && cbmSitu.Text != null)
            {
                if (cbmSitu.Text != "Selecione")
                {
                    cadastrar.Cadastrar(cad);
                    MessageBox.Show(cadastrar.mensagem);
                    this.Close();
                }
            }
            else 
            {
                MessageBox.Show("Preencha todos os Campos");
            
            }

        }
    }
}
