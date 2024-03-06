using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jose_Polanco_P2_Ap1.Shared.Models
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public double Costo { get; set; }

        public double Gastos { get; set; }
        [ForeignKey("VehiculoId")]
        public ICollection<VehiculosDetalle> VehiculosDetalle { get; set; } = new List<VehiculosDetalle>();

    }
}
