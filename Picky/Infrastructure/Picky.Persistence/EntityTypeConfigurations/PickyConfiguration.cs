using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Picky.Domain.Models;

namespace Picky.Persistence.EntityTypeConfigurations
{
	public class PickyConfiguration : IEntityTypeConfiguration<Picture>
	{
        public void Configure(EntityTypeBuilder<Picture> builder)
        {

        }
	}
}

