using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Pais"), StringLength(100)]
        public required string Nombre { get; set; }

        [Column("Entidad"), StringLength(100)]
        public required string Entidad { get; set; }

        [Column("Bandera")]
        public byte[]? Bandera { get; set; }

        [Column("LogoEntidad")]
        public byte[]? LogoEntidad { get; set; }
    }
}