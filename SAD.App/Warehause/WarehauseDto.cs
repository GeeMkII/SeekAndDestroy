using System.ComponentModel.DataAnnotations;

namespace SAD.App.Warehause
{ //AutoMapper. -model do formularza
    public class WarehauseDto
    {
        [Required]
        [StringLength(5, MinimumLength = 4, ErrorMessage = "4 or 5 char like S355 or HB450")]
        public string Hardnes { get; set; } = default!;
        [Range (600,12050, ErrorMessage = "{1} - {2})")]
        public int Width { get; set; } =default!;
        [Required]
        [Range(100, 2550, ErrorMessage = "{1} - {2}")]
        public int Height { get; set; } = default!;
        [Required]
        [Range(0.9, 50, ErrorMessage = "{1} - {2}")]
        public int Thicness { get; set; } =default!;
        [Required]
        public string? PalletRackName { get; set; } = default!;
        [Required]        
        public string? PalletRackPosition { get; set; } = default!;
        public string? Description { get; set; }
        public string? SEOName { get; set; }
        public string Name { get; private set; } = default!;

  
    }
}
