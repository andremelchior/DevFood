using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PessoaFuncionario;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class Dao
    {
        Pessoa P = new Pessoa();
        Pessoa user = new Pessoa();

        public string sql;
        public MySqlConnection mConn;

        public Dao()
        {
            string server = "localhost";
            string database = "devfood";
            string uid = "root";

            this.mConn = new MySqlConnection($"server={server};database={database};uid={uid};password=''");

            try
            {
                mConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool login(Pessoa P)
        {
            string sql = "SELECT * FROM Funcionario WHERE cpf =" + "\'" + P.Cpf +
                "\'" + " AND senha =" + "\'" + P.Senha + "\'"; //consulta e trás dados

            MySqlCommand cmd = new MySqlCommand(this.sql, this.mConn); //responsavel pelas execuções de querys, passando para o construtor o comando + conexão
            MySqlDataReader rdr = cmd.ExecuteReader(); //lê os dados do banco
            rdr.Read(); //lê uma linha da consulta

            if (rdr.HasRows) //verifica se há linhas retornadas (se o registro existe no banco)
            {
                //compara os valores e verifica se realmente é igual com o banco
                //se o usuario e senha digitado for igual ao que está no banco
                if (rdr["cpf"].ToString().Equals(P.Cpf) &&
                   rdr["senha"].ToString().Equals(P.Senha))
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
    }
}
