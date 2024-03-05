using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jose_Polanco_P2_Ap1.Shared.Models
{
    public class VehiculosDetalle
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [ForeignKey("VehiculoId")]
        public int VehiculoId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [ForeignKey("AccesorioId")]
        public int AccesorioId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public double Valor { get; set; }


    }
}
