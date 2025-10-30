using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShoes.Database.Entidades
{
    public class Animal
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Porte { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public bool Castrado { get; set; }
        public bool Vacinado { get; set; }
        public string Temperamento { get; set; }
        public string ObservacoesMedicas { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Método utilizado para buscar todos os animais na base de dados. Utiliza a tabela ANIMAIS.
        /// </summary>
        /// <returns>Lista com os animais do banco</returns>
        public static List<Animal> GetAll()
        {
            var result = new List<Animal>();

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT ID_ANIMAL, 
                                    NOME, IDADE_ESTIMADA, PORTE,
                                    RACA, SEXO, CASTRADO, VACINADO, TEMPERAMENTO, 
                                    OBSERVACOES_MEDICAS, STATUS_ADOCAO, DATA_CADASTRO 
                                    FROM ANIMAIS;";

                    var cmd = new MySqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var animal = new Animal();

                            //animal.Id = reader.GetInt32("ID_ANIMAL");
                            animal.Id = reader.GetInt32(0);
                            animal.Nome = reader.GetString(1);
                            animal.Idade = reader.GetInt32(2);
                            animal.Porte = reader.GetString(3);
                            animal.Raca = reader.GetString(4);
                            animal.Sexo = reader.GetString(5);
                            animal.Castrado = reader.GetInt32(6) > 0;
                            animal.Vacinado = reader.GetInt32(7) > 0;
                            animal.Temperamento = reader.GetString(8);
                            animal.ObservacoesMedicas = reader.GetString(9);
                            animal.Status = reader.GetString(10);
                            animal.DataCadastro = reader.GetDateTime(11);

                            result.Add(animal);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
            }

            return result;
        }

        public static Animal Get(int id)
        {
            Animal result = null;

            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @"SELECT ID_ANIMAL, 
                                    NOME, IDADE_ESTIMADA, PORTE,
                                    RACA, SEXO, CASTRADO, VACINADO, TEMPERAMENTO, 
                                    OBSERVACOES_MEDICAS, STATUS_ADOCAO, DATA_CADASTRO 
                                    FROM ANIMAIS WHERE ID_ANIMAL = @ID_ANIMAL;";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_ANIMAL", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new Animal();

                            result.Id = reader.GetInt32(0);
                            result.Nome = reader.GetString(1);
                            result.Idade = reader.GetInt32(2);
                            result.Porte = reader.GetString(3);
                            result.Raca = reader.GetString(4);
                            result.Sexo = reader.GetString(5);
                            result.Castrado = reader.GetInt32(6) > 0;
                            result.Vacinado = reader.GetInt32(7) > 0;
                            result.Temperamento = reader.GetString(8);
                            result.ObservacoesMedicas = reader.GetString(9);
                            result.Status = reader.GetString(10);
                            result.DataCadastro = reader.GetDateTime(11);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
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
                        query = @"UPDATE ANIMAIS SET NOME = @NOME, IDADE_ESTIMADA = @IDADE_ESTIMADA, PORTE = @PORTE, 
                                RACA = @RACA, SEXO = @SEXO, CASTRADO = @CASTRADO, VACINADO = @VACINADO, TEMPERAMENTO = @TEMPERAMENTO,
                                OBSERVACOES_MEDICAS = @OBSERVACOES_MEDICAS, STATUS_ADOCAO = @STATUS_ADOCAO
                                WHERE ID_ANIMAL = @ID_ANIMAL";
                    }
                    else
                    {
                        query = @"INSERT INTO ANIMAIS (
                                NOME, IDADE_ESTIMADA, PORTE, RACA, SEXO, CASTRADO, VACINADO, TEMPERAMENTO,
                                OBSERVACOES_MEDICAS, STATUS_ADOCAO, DATA_CADASTRO)
                                VALUES (@NOME, @IDADE_ESTIMADA, @PORTE, @RACA, @SEXO, @CASTRADO, @VACINADO, @TEMPERAMENTO,
                                @OBSERVACOES_MEDICAS, @STATUS_ADOCAO, NOW())";
                    }


                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_ANIMAL", Id);
                    cmd.Parameters.AddWithValue("@NOME", Nome);
                    cmd.Parameters.AddWithValue("@IDADE_ESTIMADA", Idade);
                    cmd.Parameters.AddWithValue("@PORTE", Porte);
                    cmd.Parameters.AddWithValue("@RACA", Raca);
                    cmd.Parameters.AddWithValue("@SEXO", Sexo);
                    cmd.Parameters.AddWithValue("@CASTRADO", Castrado);
                    cmd.Parameters.AddWithValue("@VACINADO", Vacinado);
                    cmd.Parameters.AddWithValue("@TEMPERAMENTO", Temperamento);
                    cmd.Parameters.AddWithValue("@OBSERVACOES_MEDICAS", ObservacoesMedicas);
                    cmd.Parameters.AddWithValue("@STATUS_ADOCAO", Status);

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
                throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
            }
        }

        public void Delete()
        {
            try
            {
                using (var conn = new MySqlConnection(Connection.CONNECTION_STRING))
                {
                    conn.Open();
                    string query = @$"DELETE FROM ANIMAIS WHERE ID_ANIMAL = @ID_ANIMAL";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_ANIMAL", Id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {error.Message}");
            }
        }
    }
}
