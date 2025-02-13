using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Campeonato")]
    public class Campeonato
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Campeonato"), StringLength(100)]
        public required string Nombre { get; set; }

        [Column("Año")]
        public int Año { get; set; }
        
        [Column("IdSeleccion")]
        public int IdSeleccion { get; set; }

        public Pais PaisOrganizador { get; set; }
    }
}