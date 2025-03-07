namespace Conn_Banco.Exercicio.Connection;
using System.Data;

public class Conexao
{
    private static readonly string conn = "Host=localhost;Database=ExercicioDapper;Username=postgres;Password=root";

    public static IDbConnection GetConnection()
    {
        return new Npgsql.NpgsqlConnection(conn);
    }
    
}