using System.ComponentModel.DataAnnotations.Schema;
namespace exemplo1.EntityFramework;


[Table("usuario")]
public class Usuario
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;
    
    [Column("email")]
    public string Email { get; set; }
    
    
}