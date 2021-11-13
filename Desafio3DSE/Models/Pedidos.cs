using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio3DSE.Models
{
    public class Pedidos
    {
        [Key]
        public int id { get; set; }

        public string NombreCl { get; set; }

        public string NombreProd { get; set; }

        [Required, Range(0, int.MaxValue, ErrorMessage = "Por favor ingrese una cantidad valida")]
        public int CantidadPedida { get; set; }

        public string PrecioProd { get; set; }

        public virtual Clientes Clientes { get; set; }

        public virtual Productos Productos { get; set; }
    }
}