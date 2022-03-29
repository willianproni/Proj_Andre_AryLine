using System;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class ReadBd
    {
        public static string datasource = @"DESKTOP-KGQAT74";
        public static string database = "bd_andre_airline";
        public static string username = "sa";
        public static string password = "246810";

        static string connString = @"Data Source=" + datasource + ";Initial Catalog="
                      + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

        SqlConnection connection = new SqlConnection(connString);

        public void InserirPassageiro(Passageiro passageiro)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_passageiro", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@cpf", SqlDbType.NVarChar).Value = passageiro.CPF;
            sql_cmnd.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = passageiro.Nome;
            sql_cmnd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = passageiro.Email;
            sql_cmnd.Parameters.AddWithValue("@telefone", SqlDbType.NVarChar).Value = passageiro.Telefone;
            sql_cmnd.Parameters.AddWithValue("@data_nascimento", SqlDbType.DateTime).Value = passageiro.DataNasc;
            sql_cmnd.Parameters.AddWithValue("@endereco", SqlDbType.Int).Value = passageiro.Endereco;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }

        public void InserirAeronave(Aeronave aeronave)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_aeronave", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = aeronave.ID;
            sql_cmnd.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = aeronave.Nome;
            sql_cmnd.Parameters.AddWithValue("@capacidade", SqlDbType.Int).Value = aeronave.Capacidade;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }

        public void InserirEndereco(Endereco endereco)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_endereco", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = endereco.ID;
            sql_cmnd.Parameters.AddWithValue("@pais", SqlDbType.NVarChar).Value = endereco.Pais;
            sql_cmnd.Parameters.AddWithValue("@cep", SqlDbType.NVarChar).Value = endereco.Cep;
            sql_cmnd.Parameters.AddWithValue("@cidade", SqlDbType.NVarChar).Value = endereco.Cidade;
            sql_cmnd.Parameters.AddWithValue("@estado", SqlDbType.NVarChar).Value = endereco.Estado;
            sql_cmnd.Parameters.AddWithValue("@logradouro", SqlDbType.NVarChar).Value = endereco.Logradouro;
            sql_cmnd.Parameters.AddWithValue("@bairro", SqlDbType.NVarChar).Value = endereco.Bairro;
            sql_cmnd.Parameters.AddWithValue("@complemento", SqlDbType.NVarChar).Value = endereco.Bairro;
            sql_cmnd.Parameters.AddWithValue("@numero", SqlDbType.NVarChar).Value = endereco.Numero;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }

        public void InserirAeroporto(Aeroporto aeroporto)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_aeroporto", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@sigla", SqlDbType.NVarChar).Value = aeroporto.Sigla;
            sql_cmnd.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = aeroporto.Nome;
            sql_cmnd.Parameters.AddWithValue("@endereco", SqlDbType.Int).Value = aeroporto.Endereco;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
