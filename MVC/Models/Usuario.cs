using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova8.Models
{
	public class Usuario
	{
		[Key]
		public string EmailID { get; set; }
		public string Nome { get; set; }
		public string Password { get; set; }

		public virtual  ICollection<ContatoUsuario> NomeContatoID { get; set; }

	}
}