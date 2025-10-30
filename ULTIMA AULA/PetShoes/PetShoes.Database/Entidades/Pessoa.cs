using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PetShoes.Database.Entidades
{
    public class Pessoa
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string TipoUsuario { get; set; }

        /// <summary>
        /// Método utilizado para buscar todos os animais na base de dados. Utiliza a tabela ANIMAIS.
        /// </summary>
        /// <returns>Lista com os animais do banco</returns>
        public static List<Pessoa> GetAll()
        {
            var result = new List<Pessoa>();

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT id_pessoa, 
                                    nome, cpf, data_nascimento,
                                    email, telefone, endereco, tipo_usuario
                                    FROM PESSOAS;";

                    var cmd = new MySqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pessoa = new Pessoa();

                            //animal.Id = reader.GetInt32("ID_ANIMAL");
                            pessoa.Id = reader.GetInt32(0);
                            pessoa.Nome = reader.GetString(1);
                            pessoa.CPF = reader.GetString(2);
                            pessoa.DataNascimento = reader.GetDateTime(3);
                            pessoa.Email = reader.GetString(4);
                            pessoa.Telefone = reader.GetString(5);
                            pessoa.Endereco = reader.GetString(6);
                            pessoa.TipoUsuario = reader.GetString(7);

                            result.Add(pessoa);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoas na base de dados. Mensagem: {error.Message}");
            }

            return result;
        }

        public static Pessoa Get(int id)
        {
            Pessoa result = null;

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT id_pessoa, 
                                    nome, cpf, data_nascimento,
                                    email, telefone, endereco, tipo_usuario
                                    FROM PESSOAS WHERE id_pessoa = @id_pessoa;";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_pessoa", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Pessoa();

                            result.Id = reader.GetInt32(0);
                            result.Nome = reader.GetString(1);
                            result.CPF = reader.GetString(2);
                            result.DataNascimento = reader.GetDateTime(3);
                            result.Email = reader.GetString(4);
                            result.Telefone = reader.GetString(5);
                            result.Endereco = reader.GetString(6);
                            result.TipoUsuario = reader.GetString(7);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoas na base de dados. Mensagem: {error.Message}");
            }

            return result;
        }

        public void Save()
        {
            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = string.Empty;
                    if (Id.HasValue)
                    {
                        query = @"UPDATE pessoas SET NOME = @NOME, cpf = @cpf, data_nascimento = @data_nascimento, 
                                email = @email, telefone = @telefone, endereco = @endereco, tipo_usuario = @tipo_usuario
                                WHERE @id_pessoa = @id_pessoa";
                    }
                    else
                    {
                        query = @"INSERT INTO pessoas (
                                NOME, cpf, data_nascimento, email, telefone, endereco, tipo_usuario)
                                VALUES (@NOME, @cpf, @data_nascimento, @email, @telefone, @endereco, @tipo_usuario)";
                    }


                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_pessoa", Id);
                    cmd.Parameters.AddWithValue("@NOME", Nome);
                    cmd.Parameters.AddWithValue("@cpf", CPF);
                    cmd.Parameters.AddWithValue("@data_nascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@telefone", Telefone);
                    cmd.Parameters.AddWithValue("@endereco", Endereco);
                    cmd.Parameters.AddWithValue("@tipo_usuario", TipoUsuario);

                    cmd.ExecuteNonQuery();

                    if (!Id.HasValue)
                    {
                        var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                        Id = Convert.ToInt32(idCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoas na base de dados. Mensagem: {error.Message}");
            }
        }

        public void Delete()
        {
            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @$"DELETE FROM pessoas WHERE id_pessoa = @id_pessoa";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_pessoa", Id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar pessoas na base de dados. Mensagem: {error.Message}");
            }
        }
    }
}
