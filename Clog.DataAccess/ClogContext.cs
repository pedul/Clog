using Clog.Data.SampleData;
using Clog.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clog.Data
{
	public class ClogContext : IdentityDbContext<User>
	{
		public DbSet<Log> Logs { get; set; }
		public DbSet<QuestionAnswer> QuestionAnswerLogs { get; set; }
		public DbSet<Definition> DefinitionLogs { get; set; }
		public DbSet<CheckItOut> CheckItOut { get; set; }
		public DbSet<Trick> Tricks { get; set; }
		public DbSet<ClogPost> Clogs { get; set; }
		public DbSet<Tag> Tags { get; set; }

		static ClogContext()
		{
			Database.SetInitializer(new ClogDataInitializer());
		}

		//public ClogContext() : base("Clog") { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			modelBuilder.Entity<QuestionAnswer>().ToTable("QuestionAnswer");
			modelBuilder.Entity<Definition>().ToTable("Definition");
			modelBuilder.Entity<Trick>().ToTable("Trick");
			modelBuilder.Entity<CheckItOut>().ToTable("CheckItOut");
			modelBuilder.Entity<ClogPost>().ToTable("ClogPost");

			base.OnModelCreating(modelBuilder);
		}
	}
}
