using Microondas_Digital.DAL.Data.Interfaces;
using Microondas_Digital.DAL.Models;
using System.Data.SqlClient;

namespace Microondas_Digital.DAL.Data.Repositories;

public class AcessoDadosRepository : IAcessoDadosRepository
{
    private string _connectionString;

    public AcessoDadosRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<ProgramaPersonalizado> GetAll()
    {
        List<ProgramaPersonalizado> lista = new List<ProgramaPersonalizado>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProgramasPersonalizados", connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var programaPersonalizado = new ProgramaPersonalizado
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    Alimento = reader.GetString(reader.GetOrdinal("Alimento")),
                    Tempo = reader.GetInt32(reader.GetOrdinal("Tempo")),
                    Potencia = reader.GetInt32(reader.GetOrdinal("Potencia")),
                    Instrucoes = reader.GetString(reader.GetOrdinal("Instrucoes")),
                    CaractereAquecimento = char.Parse(reader.GetString(reader.GetOrdinal("CaractereAquecimento"))),
                };

                lista.Add(programaPersonalizado);
            }

            return lista;
        }
    }

    public ProgramaPersonalizado? GetById(long id)
    {
        ProgramaPersonalizado? programaPersonalizado = null;

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string query = @"SELECT * FROM ProgramasPersonalizados WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        programaPersonalizado = new ProgramaPersonalizado
                        {
                            Id = reader.GetInt64(reader.GetOrdinal("Id")),
                            Nome = reader.GetString(reader.GetOrdinal("Nome")),
                            Alimento = reader.GetString(reader.GetOrdinal("Alimento")),
                            Tempo = reader.GetInt32(reader.GetOrdinal("Tempo")),
                            Potencia = reader.GetInt32(reader.GetOrdinal("Potencia")),
                            Instrucoes = reader.GetString(reader.GetOrdinal("Instrucoes")),
                            CaractereAquecimento = char.Parse(reader.GetString(reader.GetOrdinal("CaractereAquecimento"))),
                        };
                    }
                }
            }
        }

        return programaPersonalizado;
    }

    public bool Create(ProgramaPersonalizado programaPersonalizado)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "INSERT INTO ProgramasPersonalizados" +
                            "(Nome, Alimento, Tempo, Potencia, Instrucoes, CaractereAquecimento)" +
                            "VALUES (@Nome, @Alimento, @Tempo, @Potencia, @Instrucoes, @CaractereAquecimento)";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Nome", programaPersonalizado.Nome);
                cmd.Parameters.AddWithValue("@Alimento", programaPersonalizado.Alimento);
                cmd.Parameters.AddWithValue("@Tempo", programaPersonalizado.Tempo);
                cmd.Parameters.AddWithValue("@Potencia", programaPersonalizado.Potencia);
                cmd.Parameters.AddWithValue("@Instrucoes", programaPersonalizado.Instrucoes);
                cmd.Parameters.AddWithValue("@CaractereAquecimento", programaPersonalizado.CaractereAquecimento);

                int rowsAfetadas = cmd.ExecuteNonQuery();

                return rowsAfetadas > 0;
            }
        }
    }

    public bool Update(ProgramaPersonalizado programaPersonalizado)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = "UPDATE ProgramasPersonalizados " +
                            "SET " +
                            "Nome = @Nome," +
                            "Alimento = @Alimento," +
                            "Tempo = @Tempo," +
                            "Potencia = @Potencia," +
                            "Instrucoes = @Instrucoes, " +
                            "CaractereAquecimento = @CaractereAquecimento " +
                            "WHERE Id = @Id ";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Id", programaPersonalizado.Id);
                cmd.Parameters.AddWithValue("@Nome", programaPersonalizado.Nome);
                cmd.Parameters.AddWithValue("@Alimento", programaPersonalizado.Alimento);
                cmd.Parameters.AddWithValue("@Tempo", programaPersonalizado.Tempo);
                cmd.Parameters.AddWithValue("@Potencia", programaPersonalizado.Potencia);
                cmd.Parameters.AddWithValue("@Instrucoes", programaPersonalizado.Instrucoes);
                cmd.Parameters.AddWithValue("@CaractereAquecimento", programaPersonalizado.CaractereAquecimento);

                int rowsAfetadas = cmd.ExecuteNonQuery();

                return rowsAfetadas > 0;
            }
        }
    }

    public bool Delete(long id)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = @"DELETE FROM ProgramasPersonalizados WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsAfetadas = cmd.ExecuteNonQuery();

                return rowsAfetadas > 0;
            }
        }
    }
}

