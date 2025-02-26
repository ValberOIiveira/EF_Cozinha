// namespace exemplo1;
// using Npgsql;
// using System.Diagnostics;
//
// public class Crud
// {
//     static void Main(string[] args)
//     {
//         
//         var crud = new Crud();
//         Stopwatch sw = new Stopwatch();
//
//         
//         sw.Start();
//         crud.InserirUsuario(23, "Fulano", "fulano@email.com");
//         sw.Stop();
//         Console.WriteLine($"Tempo de inserção: {sw.Elapsed}");
//
//        
//         sw.Reset();  
//         sw.Start();
//         crud.LerUsuario();
//         sw.Stop();
//         Console.WriteLine($"Tempo de leitura: {sw.Elapsed}");
//
//       
//         sw.Reset();  
//         sw.Start();
//         crud.AtualizarUsuario(23, "Fulano Atualizado");
//         sw.Stop();
//         Console.WriteLine($"Tempo de atualização: {sw.Elapsed}");
//
//        
//         sw.Reset();  
//         sw.Start();
//         crud.DeletarUsuario(23);
//         sw.Stop();
//         Console.WriteLine($"Tempo de exclusão: {sw.Elapsed}");
//         
//     }
//
//     string conexao = "Host=localhost;Database=Aula1;Username=postgres;Password=root";
//
//     void InserirUsuario(int id, string nome, string email)
//     {
//         string query = "INSERT INTO usuario (id, nome, email) VALUES(@id, @nome, @email)";
//
//         using (NpgsqlConnection con = new NpgsqlConnection(conexao))
//         {
//             con.Open();
//             Console.WriteLine("Conexão aberta com o banco");
//
//             using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
//             {
//                 // Adicionando os parâmetros corretamente
//                 cmd.Parameters.AddWithValue("@id", id);
//                 cmd.Parameters.AddWithValue("@nome", nome);
//                 cmd.Parameters.AddWithValue("@email", email);
//
//                 // Executando a query
//                 cmd.ExecuteNonQuery();
//             }
//         }
//     }
//
//     void LerUsuario()
//     {
//         string query = "SELECT * FROM usuario";
//
//         using (NpgsqlConnection con = new NpgsqlConnection(conexao))
//         {
//             con.Open();
//             Console.WriteLine("Consultando Usuario");
//
//             using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
//             {
//                 using (NpgsqlDataReader reader = cmd.ExecuteReader())
//                 {
//                     while (reader.Read())
//                     {
//                         int id = reader.GetInt32(reader.GetOrdinal("id"));
//                         string nome = reader.GetString(reader.GetOrdinal("nome"));
//
//                         Console.WriteLine($"Id: {id}, Nome: {nome}");
//                     }
//                 }
//             }
//         }
//     }
//
//     void AtualizarUsuario(int id, string nome)
//     {
//         string query = "UPDATE usuario SET nome = @nome WHERE id = @id";
//
//         using (NpgsqlConnection con = new NpgsqlConnection(conexao))
//         {
//             con.Open();
//             Console.WriteLine("Atualizando Usuario");
//
//             using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
//             {
//                 // Adicionando os parâmetros antes de executar a query
//                 cmd.Parameters.AddWithValue("@id", id);
//                 cmd.Parameters.AddWithValue("@nome", nome);
//
//                 cmd.ExecuteNonQuery();
//             }
//         }
//     }
//
//     void DeletarUsuario(int id)
//     {
//         string query = "DELETE FROM usuario WHERE id = @id";
//
//         using (NpgsqlConnection con = new NpgsqlConnection(conexao))
//         {
//             con.Open();
//             using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
//             {
//                 cmd.Parameters.AddWithValue("@id", id);
//                 cmd.ExecuteNonQuery();
//             }
//         }
//     }
// }
