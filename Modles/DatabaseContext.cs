using Microsoft.EntityFrameworkCore;

namespace Modles
{
	public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
	{
		public DatabaseContext() : base()
		{
			Database.EnsureCreated();
		}

		public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }

		protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString =
				"Server=.;Database=WindowsForm;MultipleActiveResultSets=true;User ID=sa;Password=123;TrustServerCertificate=true;";
			
			optionsBuilder.UseSqlServer(connectionString: connectionString);
		}
	}
}