using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Picky.Persistence.EntityTypeConfigurations
{
	public class PickyConfiguration : IEntityTypeConfiguration<Picture>
	{
		public PickyConfiguration()
		{
			public void Configure(EntityTypeBuilder<Picture> builder)
			{

			}
		}
	}
}

