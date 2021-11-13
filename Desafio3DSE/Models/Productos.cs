using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio3DSE.Models
{
    public class Productos
    {
        [Key]
        public int id { get; set; }

        [StringLength(200), Display(Name ="Nombre")]
        public string NombreProd { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$"), Display(Name ="Precio")]
        [Range(0, 9999999999999999.99)]
        public decimal PrecioProd { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number"), Display(Name ="Stock")]
        public int CantidadProd { get; set; }
    }
}