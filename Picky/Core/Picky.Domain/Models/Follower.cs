using System.ComponentModel.DataAnnotations.Schema;

namespace Picky.Domain.Models
{
    [Table("Followers")]
	public class Follower
	{
        public string FollowingUserId { get; set; } = null!;
        public string FollowerUserId { get; set; } = null!;

    }
}

