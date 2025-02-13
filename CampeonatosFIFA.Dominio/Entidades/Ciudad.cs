using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CampeonatosFIFA.Dominio.Entidades;

[Table("Ciudad")]
public class Ciudad
{
    [Column("Id")]
    public int Id { get; set; }

    [Column("Ciudad"), StringLength(100)]
    public required string Nombre { get; set; }

    [Column("IdPais")]
    public int IdPais { get; set; }
    public Pais Pais { get; set; }
}