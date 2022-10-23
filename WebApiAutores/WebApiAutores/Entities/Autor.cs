﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiAutores.Validators;

namespace WebApiAutores.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:5, ErrorMessage = "El campo {0} no debe de tener más de {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string? Nombre { get; set; }
        [Range(18, 120)]
        [NotMapped]
        public int Edad { get; set; }
        [CreditCard]
        [NotMapped]
        public string? TarjetaDeCredito { get; set; }
        [Url]
        [NotMapped]
        public string? URL { get; set; }
        public List <Libro>? Libros { get; set; }
    }
}
