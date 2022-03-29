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

        public void InserirPassageiro(Voo voo)
        {

            connection.Close();
            connection.Open();
            SqlCommand sql = new SqlCommand("inserir_endereco", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("id", SqlDbType.Int).Value = voo.Passageiro.Endereco.ID;
            sql.Parameters.AddWithValue("pais", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Pais;
            sql.Parameters.AddWithValue("cep", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Cep;
            sql.Parameters.AddWithValue("cidade", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Cidade;
            sql.Parameters.AddWithValue("estado", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Estado;
            sql.Parameters.AddWithValue("logradouro", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Logradouro;
            sql.Parameters.AddWithValue("bairro", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Bairro;
            sql.Parameters.AddWithValue("complemento", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Complemento;
            sql.Parameters.AddWithValue("numero", SqlDbType.NVarChar).Value = voo.Passageiro.Endereco.Numero;
            sql.ExecuteNonQuery();
            connection.Close();

            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_passageiro", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@cpf", SqlDbType.NVarChar).Value = voo.Passageiro.CPF;
            sql_cmnd.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = voo.Passageiro.Nome;
            sql_cmnd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = voo.Passageiro.Email ;
            sql_cmnd.Parameters.AddWithValue("@telefone", SqlDbType.NVarChar).Value = voo.Passageiro.Telefone;
            sql_cmnd.Parameters.AddWithValue("@data_nascimento", SqlDbType.DateTime).Value = voo.Passageiro.DataNasc;
            sql_cmnd.Parameters.AddWithValue("@endereco", SqlDbType.Int).Value = voo.Passageiro.Endereco.ID;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }

        public void InserirAeronave(Voo voo)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_aeronave", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = voo.Aeronave.ID;
            sql_cmnd.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = voo.Aeronave.Nome;
            sql_cmnd.Parameters.AddWithValue("@capacidade", SqlDbType.Int).Value = voo.Aeronave.Capacidade;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }

        /*public void InserirEndereco(Endereco endereco)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_endereco", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
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
        }*/

        public void InserirAeroportoOrigem(Voo voo)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql = new SqlCommand("inserir_endereco", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("id", SqlDbType.Int).Value = voo.Origem.Endereco.ID;
            sql.Parameters.AddWithValue("pais", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Pais;
            sql.Parameters.AddWithValue("cep", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Cep;
            sql.Parameters.AddWithValue("cidade", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Cidade;
            sql.Parameters.AddWithValue("estado", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Estado;
            sql.Parameters.AddWithValue("logradouro", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Logradouro;
            sql.Parameters.AddWithValue("bairro", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Bairro;
            sql.Parameters.AddWithValue("complemento", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Complemento;
            sql.Parameters.AddWithValue("numero", SqlDbType.NVarChar).Value = voo.Origem.Endereco.Numero;
            sql.ExecuteNonQuery();
            connection.Close();

            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_aeroporto", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@sigla", SqlDbType.NVarChar).Value = voo.Origem.Sigla;
            sql_cmnd.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = voo.Origem.Nome;
            sql_cmnd.Parameters.AddWithValue("@endereco", SqlDbType.Int).Value = voo.Origem.Endereco.ID;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }

        public void InserirAeroportoDestino(Voo voo)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql = new SqlCommand("inserir_endereco", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("id", SqlDbType.Int).Value = voo.Destino.Endereco.ID;
            sql.Parameters.AddWithValue("pais", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Pais;
            sql.Parameters.AddWithValue("cep", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Cep;
            sql.Parameters.AddWithValue("cidade", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Cidade;
            sql.Parameters.AddWithValue("estado", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Estado;
            sql.Parameters.AddWithValue("logradouro", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Logradouro;
            sql.Parameters.AddWithValue("bairro", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Bairro;
            sql.Parameters.AddWithValue("complemento", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Complemento;
            sql.Parameters.AddWithValue("numero", SqlDbType.NVarChar).Value = voo.Destino.Endereco.Numero;
            sql.ExecuteNonQuery();
            connection.Close();

            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("inserir_aeroporto", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@sigla", SqlDbType.NVarChar).Value = voo.Destino.Sigla;
            sql_cmnd.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = voo.Destino.Nome;
            sql_cmnd.Parameters.AddWithValue("@endereco", SqlDbType.Int).Value = voo.Destino.Endereco.ID;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }

        public void InserirVoo(Voo voo)
        {
            connection.Close();
            connection.Open();
            SqlCommand sql_cmnd = new SqlCommand("insert_voo", connection);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = voo.ID;
            sql_cmnd.Parameters.AddWithValue("@origem", SqlDbType.NVarChar).Value = voo.Origem.Sigla;
            sql_cmnd.Parameters.AddWithValue("@destino", SqlDbType.NVarChar).Value = voo.Destino.Sigla;
            sql_cmnd.Parameters.AddWithValue("@aeronave", SqlDbType.NVarChar).Value = voo.Aeronave.ID;
            sql_cmnd.Parameters.AddWithValue("@horario_embarque", SqlDbType.NVarChar).Value = voo.HorarioEmbarque;
            sql_cmnd.Parameters.AddWithValue("@horario_desembarque", SqlDbType.NVarChar).Value = voo.HorarioDesembarque;
            sql_cmnd.Parameters.AddWithValue("@passageiro", SqlDbType.DateTime).Value = voo.Passageiro.CPF;
            sql_cmnd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
