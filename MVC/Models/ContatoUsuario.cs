using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prova8.Models
{
	public class ContatoUsuario
	{
		[Key]
		public string NomeContatoID { get; set; }
		public string EmailContato { get; set; }
		public string TelefoneContato { get; set; }
		public string EmailID { get; set; }

		[ForeignKey("EmailID")]
		public virtual Usuario Email { get; set; }
	}
}