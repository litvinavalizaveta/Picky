using System.ComponentModel.DataAnnotations.Schema;

namespace Picky.Domain.Models
{
	public class PictureOnBoard
	{
        public string PictureId { get; set; } = null!;
        public string BoardId { get; set; } = null!;

    }
}

