using Contas;
using LOGIN.Dao;
using System;
using System.Windows.Forms;


namespace LOGIN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblSenha.PasswordChar ='*';

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginDao log = new LoginDao();                       
            if (log.ConsultarUsuario(LblUsuario.Text, lblSenha.Text)) 
            {
                LblMessage.Text = "";
                FrmPrincipal frm = new FrmPrincipal();
                this.Hide();
                if (frm.ShowDialog(this) != DialogResult.OK) 
                {
                    this.Close();
                }
            }         
            else 
            {
                LblMessage.Text = "Usuario ou senha incorretos";
            }
        }
        private void PictureSenha_Click(object sender, EventArgs e)
        {
            if (lblSenha.PasswordChar == '\0')
            {
                pictureBox4.BringToFront();
                lblSenha.PasswordChar = '*';
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (lblSenha.PasswordChar == '*')
            {
                PictureSenha.BringToFront();
                lblSenha.PasswordChar = '\0';
            }
        }
    }
}
