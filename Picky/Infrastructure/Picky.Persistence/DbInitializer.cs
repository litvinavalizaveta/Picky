using System;
namespace Picky.Persistence
{
	public class DbInitializer
	{
		public static void Initialize(PickyDbContext context)
		{
			context.Database.EnsureCreated();
		}
	}
}

