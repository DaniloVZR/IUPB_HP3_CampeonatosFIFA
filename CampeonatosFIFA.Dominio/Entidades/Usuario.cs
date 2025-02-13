using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Usuario")]
public class Usuario
{
    [Column("Id")]
    public int Id { get; set; }

    [Column("Usuario"), StringLength(100)]
    public required string NombreUsuario { get; set; }

    [Column("Clave"), StringLength(50)]
    public string? Clave { get; set; }

    [Column("Nombre"), StringLength(100)]
    public required string Nombre { get; set; }

    [Column("Foto")]
    public byte[]? Foto { get; set; }
}