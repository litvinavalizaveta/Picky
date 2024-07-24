using Microsoft.EntityFrameworkCore;
using Picky.Domain.Models;

namespace Picky.Application.Interfaces
{
	public interface IPickyDbContext
	{
		DbSet<Picture> Pictures { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}

