using CampeonatosFIFA.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Grupo")]
public class Grupo
{
    [Column("Id")]
    public int Id { get; set; }

    [Column("Grupo"), StringLength(5)]
    public required string Nombre { get; set; }

    [Column("IdCampeonato")]
    public int IdCampeonato { get; set; }
    public Campeonato Campeonato { get; set; }
}