using System.ComponentModel.DataAnnotations;

namespace Moment33API.Models
{
    public class Music
    {

		public int Id { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string? Artist { get; set; }
		[Required]
		public int Length { get; set; }

		[Required]
		public string? Genre { get; set; }
		public bool Favorite { get; set; } = false;
		public DateTime DateRegistered { get; set; } = DateTime.Now;

    }
}
