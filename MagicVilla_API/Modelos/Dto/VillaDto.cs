using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.MinValue;
        public string Detalle { get; set; } = string.Empty;
        [Required]
        public double Tarifa { get; set; } = double.MinValue;
        public int Ocupantes { get; set; } = int.MinValue;
        public int MetrosCuadrados { get; set; } = int.MinValue;
        public string ImageUrl { get; set; } = string.Empty;
        public string Amenidad { get; set; } = string.Empty;
        public DateTime FechaActualizacion { get; set; } = DateTime.MinValue;
    }
}
