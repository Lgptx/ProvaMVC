using Prova8.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Prova8.DAL
{
	public class EFContext : DbContext
	{
		public EFContext() : base("BdProva8") { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Usuario> Usuario { get; set; }
		public DbSet<ContatoUsuario> ContatoUsuario { get; set; }

	}
}