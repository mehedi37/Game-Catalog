using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Catalog.Models
{
    public class Games
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public required string Name { get; set; }

        public required string CoverPic { get; set; }

        public string Description { get; set; } = string.Empty;

        public required string Publisher { get; set; }

        public required string Genre { get; set; }

        public required string DeveloperTeam { get; set; }

        public required DateOnly ReleaseDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public required float Price { get; set; }

    }
}
