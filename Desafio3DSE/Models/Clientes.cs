using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio3DSE.Models
{
    public class Clientes
    {
        [Key]
        public int id { get; set; }

        [StringLength(100), Display(Name ="Nombre")]
        public string NombreCl { get; set; }

        [StringLength(100), Display(Name ="Apellido")]
        public string ApellidoCl { get; set; }

        [StringLength(100), EmailAddress(ErrorMessage ="El correo no cumple con el formato correcto"), Display(Name ="Correo")]
        public string CorreoCl { get; set; }
    }
}