using System;
using Microsoft.EntityFrameworkCore;
using Picky.Domain.Models;

namespace Picky.Application.Interfaces
{
	public struct IPickyDbContext : IDbContext
	{
		DbSet<Picture> Pictures { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}

