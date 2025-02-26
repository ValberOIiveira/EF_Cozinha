using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;

namespace exemplo1.EntityFramework;

public class Crud
{
    public void InserirUsuario(int id, string nome, string email)
    {
        using (var db = new Ligacao())
        {
            db.Usuarios.Add(new Usuario() { Id = id, Nome = nome, Email = email });
            db.SaveChanges();
        }
    }

    public void ListarUsuarios()
    {
        
        using (var db = new Ligacao())
        {
            var usuarios = db.Usuarios.ToList();
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"id: {usuario.Id}, nome: {usuario.Nome}, email: {usuario.Email}");
            }
        }
    }

    public void AlterarUsuario(int id, string nome, string email)
    {
        using (var db = new Ligacao())
        {
            var usuario = db.Usuarios.Find(id);
            if (usuario != null)
            {
                usuario.Nome = nome;
                db.SaveChanges();
                Console.WriteLine("Usuario alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuario não encontrado!");   
            }
        }
    }
}