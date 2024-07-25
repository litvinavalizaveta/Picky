using System.ComponentModel.DataAnnotations.Schema;

namespace Picky.Domain.Models
{
    [Table("Boards")]
    public class Board
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string OwnerId { get; set; } = null!;
    }
}

