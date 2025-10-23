using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShoes.Database.Entidades
{
    public enum PorteEnum
    {
        Nenhum = 0,
        Pequeno,
        Medio,
        Grande
    }

    public enum SexoEnum
    {
        Nenhum = 0,
        Macho,
        Femea
    }

    public enum StatusAdocaoEnum
    {
        Nenhum = 0,
        Disponivel,
        EmProcesso,
        Adotado,
        Pausado
    }

    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public PorteEnum Porte { get; set; }
        public string Raca { get; set; } = string.Empty;
        public SexoEnum Sexo { get; set; }
        public bool Castrado { get; set; }
        public bool Vacinado { get; set; }
        public string Temperamento { get; set; } = string.Empty;
        public string ObservacoesMedicas { get; set; } = string.Empty;
        public StatusAdocaoEnum StatusAdocao { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Animal> GetAll()
        {
            try
            {
                using (var conn = new MySqlConnection(Database.Connection.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = @"SELECT id_animal,
                                    nome, idade_estimada,
                                    porte, raca, sexo,
                                    castrado, vacinado, temperamento,
                                    observacoes_medicas, status_adocao, data_cadastro FROM animais";

                    var cmd = new MySqlCommand(query, conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var animais = new List<Animal>();
                        while (reader.Read())
                        {
                            var animal = new Animal()
                            {
                                Id = reader.GetInt32("id_animal"),
                                Nome = reader.GetString("nome"),
                                Idade = reader.GetInt32("idade_estimada"),
                                Porte = (PorteEnum)reader.GetInt32("porte"),
                                Raca = reader.GetString("raca"),
                                Sexo = (SexoEnum)reader.GetInt32("sexo"),
                                Castrado = reader.GetBoolean("castrado"),
                                Vacinado = reader.GetBoolean("vacinado"),
                                Temperamento = reader.GetString("temperamento"),
                                ObservacoesMedicas = reader.GetString("observacoes_medicas"),
                                StatusAdocao = (StatusAdocaoEnum)reader.GetInt32("status_adocao"),
                                DataCadastro = reader.GetDateTime("data_cadastro")
                            };

                            animais.Add(animal);
                        }

                        return animais;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao buscar animais na base de dados. Mensagem: {e.Message}");
            }

            return new List<Animal>();
        }
    }
}
