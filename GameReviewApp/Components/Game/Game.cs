using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReviewApp.Components.Game
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType (DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public float? Rating { get; set; }
        public int reviewCount { get; set; }
        public string? ImagePath { get; set; }
    }
}
