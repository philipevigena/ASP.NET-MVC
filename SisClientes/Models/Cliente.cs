using SisClientes.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SisClientes.Models
{
    public class Cliente
    {
        [Required]
        [StringLength(50,ErrorMessage = "Limite de 50 caracteres")]
        public string Nome { get; set; }
        
        [Required]
        public string CPF { get; set; }

        [Required(ErrorMessageResourceType = typeof(ValidationsMessages),
    ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Url]
        public string Site { get; set; }

        public string CEP { get; set; }

        public int Sexo { get; set; }
    }
}