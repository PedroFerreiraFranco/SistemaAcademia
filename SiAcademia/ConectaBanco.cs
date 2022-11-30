using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace SiAcademia
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=academia");
        public String mensagem;
        public DataTable ListaPlanos()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("proc_listaPlanos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_planos

        public DataTable listaClientes()
        {
            MySqlCommand cmd = new MySqlCommand("proc_listaClientes", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_clientes

        public bool insereClientes(Clientes c)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereClientes", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nomeCliente", c.Nome);
            cmd.Parameters.AddWithValue("cpfCliente", c.Cpf);
            cmd.Parameters.AddWithValue("dataNascimentoCliente", c.DataNascimento);
            cmd.Parameters.AddWithValue("telCliente", c.Telefone);
            cmd.Parameters.AddWithValue("emailCliente", c.Email);
            cmd.Parameters.AddWithValue("enderecoCliente", c.Endereco);
            cmd.Parameters.AddWithValue("cidadeCliente", c.Cidade);
            cmd.Parameters.AddWithValue("codigoPlano", c.Plano);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereClientes 

        public bool inserePlanos(Planos p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_inserePlanos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tipoPlanoCliente", p.NomePlano);
            cmd.Parameters.AddWithValue("dataInicioPlano", p.DataInicio);
            cmd.Parameters.AddWithValue("dataFimPlano", p.DataFim);
            cmd.Parameters.AddWithValue("valorPlano", p.Valor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereBanda

        public bool alteraCliente(Clientes c, int idcliente)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraClientes", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigoClientes", idcliente);
            cmd.Parameters.AddWithValue("nomeCliente", c.Nome);
            cmd.Parameters.AddWithValue("cpfCliente", c.Cpf);
            cmd.Parameters.AddWithValue("dataNascimentoCliente", c.DataNascimento);
            cmd.Parameters.AddWithValue("telCliente", c.Telefone);
            cmd.Parameters.AddWithValue("emailCliente", c.Email);
            cmd.Parameters.AddWithValue("enderecoCliente", c.Endereco);
            cmd.Parameters.AddWithValue("cidadeCliente", c.Cidade);
            cmd.Parameters.AddWithValue("codigoPlano", c.Plano);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim alteraCliente

        public bool deletaCliente(int idcliente)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deleteClientes", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigoClientes", idcliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaCliente


    }

}
