using Contas.Entites;
using Dapper;
using LOGIN.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace LOGIN.Dao
{
    class LoginDao
    {
        string conexao = @"Data Source=DESKTOP-GPICHSB\SQLEXPRESS;Initial Catalog=DB_CONTAS;Integrated Security=True";
        public string mensagem = "";

        public bool ConsultarUsuario(string usu,  string psw) 
        {
            var con = new SqlConnection(conexao);
            
            bool retorno = false;
            try
            {
                 con.Open();
                string query = $"select * from usuario where usuario = '{usu}' and senha ='{psw}'";
                var usuario = con.Query(query);
                if(usuario.Count() > 0) 
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                con.Close();
            }

            return retorno;             
        }     
        public void Cadastrar(CadConta Cad)
        {
            SqlConnection con = new SqlConnection(conexao);
            try
            {
                var cmd = "INSERT INTO TB_CONTAS(descricao,Valor,Vencimento,Situacao)values(@descricao,@Valor,@Vencimento,@Situacao)";
                con.Open();
                SqlCommand coman = new SqlCommand(cmd, con);
                coman.Parameters.AddWithValue("@descricao", Cad.Descricao);
                coman.Parameters.AddWithValue("@Valor", Cad.Valor);
                coman.Parameters.AddWithValue("@Vencimento", Cad.Vencimeto);
                coman.Parameters.AddWithValue("@Situacao", Cad.situacao);
                coman.ExecuteNonQuery();
                mensagem = "Cadastrado  com Sucesso";
                con.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void DeletarConta(int id)
        {
            SqlConnection con = new SqlConnection(conexao);
            try
            {
                var cmd = "delete from TB_CONTAS where ID = @ID";
                con.Open();
                SqlCommand coman = new SqlCommand(cmd, con);
                coman.Parameters.AddWithValue("@ID", id);
                coman.ExecuteNonQuery();
                con.Close();
                mensagem = "Conta excluida";
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public void EditarConta(int id, string descricao, decimal valor, string vencimento, string situacao)
        {
            SqlConnection conn = new SqlConnection(conexao);
            try
            {
                var edit = "UPDATE TB_CONTAS SET descricao = @descricao,Valor= @valor,Vencimento = @vencimento,Situacao = @situacao  WHERE Id = @id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(edit, conn);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@Valor", valor);
                cmd.Parameters.AddWithValue("@Vencimento", vencimento);
                cmd.Parameters.AddWithValue("@Situacao", situacao);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                mensagem = "Registro alterado com sucesso";
            }
            catch (SqlException e)
            {

                mensagem = "erro" + e;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable CarregaGrid(int Mes)
        {

            string Comando = "";
            if (Mes == DateTime.Now.Month)
            {
                Comando = "select * from TB_CONTAS where MONTH(Vencimento) = MONTH(GETDATE()) and year(Vencimento) =  DATEPART(year,getdate())";
            }
            else
            {
                Comando = $"select* from TB_CONTAS where MONTH(Vencimento) = {Mes} and year(Vencimento) =  DATEPART(year,getdate())";
            }
            var con = new SqlConnection(conexao);
            con.Open();
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = Comando;
                da = new SqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable CarregaGridExcluir(string query)
        {
            string comando = $"select * from TB_CONTAS where Descricao like '{ query}%'";
            var con = new SqlConnection(conexao);
            con.Open();
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = comando;
                    da = new SqlDataAdapter(cmd.CommandText, con);
                    da.Fill(dt);
                    return dt;
                }

            }
            catch (System.Exception)
            {

                throw;
            }

        }


    }
}

