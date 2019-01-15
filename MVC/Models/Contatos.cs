using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaProd.Models
{
    public class Contatos
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}