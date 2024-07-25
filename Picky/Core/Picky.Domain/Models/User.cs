using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Picky.Domain.Models
{
	[Table("Users")]
	public class User
	{
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        //public ICollection<Picture> OrderDetails { get; set; } = null!;
    }
}

