using CampeonatosFIFA.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

[Table("GrupoPais")]
public class GrupoPais
{
    [Column("IdGrupo")]
    public int IdGrupo { get; set; }
    public Grupo Grupo { get; set; }

    [Column("IdPais")]
    public int IdPais { get; set; }
    public Pais Pais { get; set; }
}