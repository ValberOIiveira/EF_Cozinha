// using Npgsql;
// using System;
//
// namespace exemplo1
// {
//     public class Executar
//     {
//         public void Conectar()
//         {
//             string conexao = "Host=localhost;Database=Aula1;Username=postgres;Password=root";
//
//             using (NpgsqlConnection con = new NpgsqlConnection(conexao))
//             {
//                 try
//                 {
//                     con.Open();
//                     Console.WriteLine("Conexão aberta com Postgres");
//
//                     string tabela = "cargo"; 
//                     
//                     string query = $"DELETE FROM {tabela} WHERE id = 1";
//
//                     using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
//                     {
//                         cmd.ExecuteNonQuery();
//                         Console.WriteLine("Registro deletado com sucesso");
//                     }
//                 }
//                 catch (NpgsqlException ex)
//                 {
//                     Console.WriteLine("Erro: " + ex.Message);
//                 }
//             }
//         }
//
//         public static void Main(string[] args)
//         {
//             var executar = new Executar();
//             executar.Conectar(); 
//         }
//     }
// }