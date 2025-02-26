namespace exemplo1.EntityFramework;

public class Executar
{
    static void Main(string[] args)
    {
        Crud crud = new Crud();
        // crud.ListarUsuarios();
        // crud.InserirUsuario(24, "Ciclano", "ciclano@gmail.com");
        // crud.ListarUsuarios();
        
        crud.AlterarUsuario(24, "Ciclano mudado", "ciclano@email.com");
        crud.ListarUsuarios();
        
        
        
    }
}