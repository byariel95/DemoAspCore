using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAspCore.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required (ErrorMessage ="Campo Requerido")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="El Campo Debe Tener De 3 a 60 Caracteres")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage = "La Descripcion No Debe Ser Extensa")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
    }
}
