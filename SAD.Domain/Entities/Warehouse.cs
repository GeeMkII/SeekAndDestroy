using System.ComponentModel.DataAnnotations;

namespace SAD.Domain.Entities
{
    public class Warehouse
    {
        public int Id { get; set; } = default!;
        [Required]
        public string Hardness { get; set; } = default!;
        public int Width { get; set; } = default!;
        public int Height { get; set; } = default!;
        public int Thickness { get; set; } = default!;
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public PalletRack PalletRack { get; set; } = default!;
        public string? Description { get; set; }
        public string SEOName { get; private set; } = default!;
        public void SeoName() => SEOName = Hardness.ToLower().Replace(" ", "_");
    }
}
