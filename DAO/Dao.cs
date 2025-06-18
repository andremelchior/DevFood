using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PessoaFuncionario;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
    public class Dao
    {
        Pessoa user = new Funcionario();

        public string sql;
        public MySqlConnection mConn;

        public Dao()
        {
            string server = "localhost";
            string port = "3307";
            string database = "devfood";
            string uid = "root";

            this.mConn = new MySqlConnection($"server={server};port={port};database={database};uid={uid};password=''");

            try
            {
                mConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool login(Funcionario F)
        {
            this.sql = "SELECT * FROM Funcionario WHERE cpf =" + "\'" + F.Cpf +
                "\'" + " AND senha =" + "\'" + F.Senha + "\'"; //consulta e trás dados

            MySqlCommand cmd = new MySqlCommand(this.sql, this.mConn); //responsavel pelas execuções de querys, passando para o construtor o comando + conexão
            MySqlDataReader rdr = cmd.ExecuteReader(); //lê os dados do banco
            rdr.Read(); //lê uma linha da consulta

            if (rdr.HasRows) //verifica se há linhas retornadas (se o registro existe no banco)
            {
                //compara os valores e verifica se realmente é igual com o banco
                //se o usuario e senha digitado for igual ao que está no banco
                if (rdr["cpf"].ToString().Equals(F.Cpf) &&
                   rdr["senha"].ToString().Equals(F.Senha))
                {
                    rdr.Close(); //fechar conexão
                }
                return true;
            }
            else
            {
                rdr.Close();
                return false;
            }
        }

        public string username(Funcionario F)
        {
            try
            {
                if (F.Cpf == null || F.Cpf == "")
                {
                    throw new Exception("CPF não pode ser nulo ou vazio.");
                }
                else
                {
                    this.sql = $"SELECT nome FROM Funcionario WHERE cpf = @cpf";
                    MySqlCommand cmd = new MySqlCommand(this.sql, this.mConn);

                    cmd.Parameters.AddWithValue("@cpf", F.Cpf);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();

                    string nome = rdr["nome"].ToString();

                    rdr.Close();
                    return nome;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter o nome de usuário: " + ex.Message);
                return null;
            }
            finally
            {
                mConn.Close();
            }

        }

        public void updateUsuario()
        {
            try
            { //trocar o sql para cada caso especifico (
              //insert, delete, update)
                String sql = "UPDATE funcionario SET nome = @nome, " +
                    "email = @email, " + "senha = @senha " + "WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@nome", user.Nome);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@senha", user.Senha);

                var linhas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            //fim updateUsuario
        }

        public string pegarCategoria(int id)
        {
            try
            {
                if (mConn.State != ConnectionState.Open)
                {
                    mConn.Open();
                }

                this.sql = $"SELECT tipo_categoria FROM Categoria WHERE cod_categoria = @id";
                MySqlCommand cmd = new MySqlCommand(this.sql, this.mConn);

                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                string nomeCategoria = rdr["tipo_categoria"].ToString();
                rdr.Close();

                return nomeCategoria;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! não foi possível obter a categoria. \n\n" + ex.Message);
                return null;
            }
            finally
            {
                mConn.Close();
            }
        }

        public bool cadastrarPrato(string id, string nome, string desc, string categoria, string preco)
        {
            try
            {
                if (mConn.State != ConnectionState.Open)
                {
                    mConn.Open();
                }

                this.sql = "INSERT INTO Prato (cod_prato, nome, descricao, cod_categoria, preco) " +
                           "VALUES (@id, @nome, @descricao, (SELECT cod_categoria FROM Categoria WHERE tipo_categoria = @categoria), @preco)";
                MySqlCommand cmd = new MySqlCommand(this.sql, mConn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", desc);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@preco", preco);
                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! não foi possivel cadastrar o prato. \n\n" + ex.Message);
                return false;
            }
            finally
            {
                mConn.Close();
            }
        }

        public bool cadastrarPrato(string nome, string desc, string categoria, string preco)
        {
            try
            {
                if (mConn.State != ConnectionState.Open)
                {
                    mConn.Open();
                }

                this.sql = "INSERT INTO Prato (cod_prato, nome, descricao, cod_categoria, preco) " +
                           "VALUES (default, @nome, @descricao, (SELECT cod_categoria FROM Categoria WHERE tipo_categoria = @categoria), @preco)";
                MySqlCommand cmd = new MySqlCommand(this.sql, mConn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", desc);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@preco", preco);
                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! não foi possivel cadastrar o prato. \n\n" + ex.Message);
                return false;
            }
            finally
            {
                mConn.Close();
            }
        }

        public string pegarPrato(int id)
        {
            try
            {
                if (mConn.State != ConnectionState.Open)
                {
                    mConn.Open();
                }
                this.sql = $"SELECT nome FROM Prato WHERE cod_prato = @id";
                MySqlCommand cmd = new MySqlCommand(this.sql, this.mConn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                string nomePrato = rdr["nome"].ToString();
                rdr.Close();
                return nomePrato;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! não foi possível obter o prato. \n\n" + ex.Message);
                return null;
            }
            finally
            {
                mConn.Close();
            }
        }

        public bool cadastrarPedido(string numeroPedido, string numeroMesa, string taxa, string item, string quantidade, string codFuncionario)
        {
            try
            {
                if (mConn.State != ConnectionState.Open)
                {
                    mConn.Open();
                }
                this.sql = "INSERT INTO Pedido (cod_pedido, cod_mesa, cod_funcionario, taxa_servico, taxa_couvert, subtotal, total) " +
                           "VALUES (@cod_pedido, @cod_mesa, @cod_funcionario, @taxa, null, (SELECT preco FROM Prato WHERE nome = @item) * @quantidade, ((SELECT preco FROM Prato WHERE nome = @item) * @quantidade) * (1 + @taxa / 100)";
                MySqlCommand cmd = new MySqlCommand(this.sql, mConn);
                cmd.Parameters.AddWithValue("@cod_pedido", numeroPedido);
                cmd.Parameters.AddWithValue("@cod_mesa", numeroMesa);
                cmd.Parameters.AddWithValue("@taxa", taxa);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Parameters.AddWithValue("@cod_funcionario", codFuncionario);
                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! não foi possivel cadastrar o pedido. \n\n" + ex.Message);
                return false;
            }
            finally
            {
                mConn.Close();
            }
        }

        public bool cadastrarFuncionario(string nome, string email, string cargo, string cpf, string senha)
        {
            try
            {
                if (mConn.State != ConnectionState.Open)
                {
                    mConn.Open();
                }
                this.sql = "INSERT INTO Funcionario (nome, email, cargo, cpf, senha) " +
                           "VALUES (@nome, @email, @cargo, @cpf, @senha)";
                MySqlCommand cmd = new MySqlCommand(this.sql, mConn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);
                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! não foi possivel cadastrar o funcionario. \n\n" + ex.Message);
                return false;
            }
            finally
            {
                mConn.Close();
            }
        }

        public bool verificarPratos()
        {
            try
            {
                if (mConn.State != ConnectionState.Open)
                {
                    mConn.Open();
                }

                this.sql = $"SELECT count(*) FROM Prato";
                MySqlCommand cmd = new MySqlCommand(this.sql, this.mConn);

                int linhas = cmd.ExecuteNonQuery();
                return linhas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! não foi possível verificar o prato. \n\n" + ex.Message);
                return false;
            }
            finally
            {
                mConn.Close();
            }
        }
    }
}
