using CampeonatosFIFA.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Encuentro")]
public class Encuentro
{
    [Column("Id")]
    public int Id { get; set; }

    [Column("IdPais1")]
    public int IdPais1 { get; set; }
    public Pais Pais1 { get; set; }

    [Column("IdPais2")]
    public int IdPais2 { get; set; }
    public Pais Pais2 { get; set; }

    [Column("IdFase")]
    public int IdFase { get; set; }
    public Fase Fase { get; set; }

    [Column("IdCampeonato")]
    public int IdCampeonato { get; set; }
    public Campeonato Campeonato { get; set; }

    [Column("IdEstadio")]
    public int IdEstadio { get; set; }
    public Estadio Estadio { get; set; }

    [Column("Fecha")]
    public DateTime? Fecha { get; set; }

    [Column("Goles1")]
    public int? Goles1 { get; set; }

    [Column("Goles2")]
    public int? Goles2 { get; set; }
}
