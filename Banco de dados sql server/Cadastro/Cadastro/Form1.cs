using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stringConexao = @"Provider=SQLOLEDB.1;Password=39150689;Persist Security Info=True;User ID=SA;Initial Catalog=CADASTRO;Data Source=STI\SQLEXPRESS";
        OleDbConnection conexao;
        OleDbCommand comando;
            string comandBanco;
        private void btnInserir_Click(object sender, EventArgs e)
        {
            conexao = new OleDbConnection(stringConexao);
            comandBanco = "INSERIR_CLIENTES";
                comando = new OleDbCommand(comandBanco, conexao);
                comando.CommandType = CommandType.StoredProcedure;
                
            //    //comando.Parameters.Add(new OleDbParameter ("@NOME", txtNome.Text));
            //    //comando.Parameters.Add(new OleDbParameter("@TELEFONE", txtTelefone.Text));
            //    //comando.Parameters.Add(new OleDbParameter("@EMAIL", txtEmail.Text));
            //    comando.Parameters.Add("@NOME", OleDbType.VarChar).Value = txtNome.Text;
            //    comando.Parameters.Add("@TELEFONE", OleDbType.VarChar).Value = txtTelefone.Text;
            //    comando.Parameters.Add("@EMAIL", OleDbType.VarChar).Value = txtEmail.Text;
                
            //    conexao.Open();
            //    try
            //    {
            //    comando.ExecuteNonQuery();
            //    MessageBox.Show("Inserido com sucesso");
            //}
            //catch
            //{
            //    MessageBox.Show("falha na conexão do banco de dados");
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            //comando.Parameters.Clear();


                //OleDbParameter parCodigo = new OleDbParameter("CODIGO", OleDbType.Integer);
                //parCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.AddWithValue("Nome", txtNome.Text);
                comando.Parameters.AddWithValue("TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("INSERIDO COM SUCESSO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            conexao = new OleDbConnection(stringConexao);
            comandBanco = "ALTERAR_CLIENTES";
            comando = new OleDbCommand(comandBanco, conexao);
            comando.CommandText = comandBanco;

            comando.Parameters.AddWithValue("CODIGO", txtCodigo.Text);
            comando.Parameters.AddWithValue("NOME", txtNome.Text);
            comando.Parameters.AddWithValue("TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("EMAIL", txtEmail.Text);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            conexao = new OleDbConnection(stringConexao);            
            OleDbDataAdapter selecao = new OleDbDataAdapter("",conexao);
            DataTable TblCliente = new DataTable();
            comandBanco = "SELECIONAR_CLIENTES";
            comandBanco = "SELECT * FROM CLIENTES WHERE CODIGO= " + txtCodigo.Text;
            selecao.SelectCommand.CommandText = comandBanco;
            selecao.Fill(TblCliente);

            if (TblCliente.Rows.Count >= 1)
            {
                txtNome.Text = TblCliente.Rows[0]["NOME"].ToString();
                txtTelefone.Text = TblCliente.Rows[0]["TELEFONE"].ToString();
                txtEmail.Text=TblCliente.Rows[0]["EMAIL"].ToString();
            }
             else
                MessageBox.Show("Registro não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            try
            {
                conexao.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
