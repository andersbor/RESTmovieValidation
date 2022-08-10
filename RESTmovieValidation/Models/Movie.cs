using System.ComponentModel.DataAnnotations;

namespace RESTmovieValidation.Models
{
    // https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/mvc/models/validation/samples/6.x/ValidationSample/Models/Movie.cs
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;

        //[ClassicMovie(1960)]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = null!;

        [Range(0, 999.99)]
        public decimal Price { get; set; }

        //public Genre Genre { get; set; }

        public bool Preorder { get; set; }

        override
        public string ToString() { return Id + " " + Title + " " + Price; }
    }
}
