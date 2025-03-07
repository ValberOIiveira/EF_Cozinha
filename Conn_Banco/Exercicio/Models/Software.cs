namespace Conn_Banco.Exercicio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Software")]
public class Software
{
    [Key]
    [Column("ID_Software")]
    public int ID_Software { get; set; }

    [Column("Produto")]
    public string Produto { get; set; }

    [Column("Harddisk")]
    public int Harddisk { get; set; }

    [Column("Memoria_Ram")]
    public int Memoria_Ram { get; set; }

    [ForeignKey("Fk_Maquina")]
    [Column("Fk_Maquina")]
    public int Fk_Maquina { get; set; }
}