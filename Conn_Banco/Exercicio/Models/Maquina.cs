namespace Conn_Banco.Exercicio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Maquina")]
public class Maquina
{
    [Key]
    [Column("ID_Maquina")]
    public int ID_Maquina { get; set; }

    [Column("Tipo")]
    public string Tipo { get; set; }

    [Column("Velocidade")]
    public int Velocidade { get; set; }

    [Column("Harddisk")]
    public int Harddisk { get; set; }

    [Column("Placa_Rede")]
    public int Placa_Rede { get; set; }

    [Column("Memoria_Ram")]
    public int Memoria_Ram { get; set; }

    [ForeignKey("Fk_Usuario")]
    [Column("Fk_Usuario")]
    public int Fk_Usuario { get; set; }
}