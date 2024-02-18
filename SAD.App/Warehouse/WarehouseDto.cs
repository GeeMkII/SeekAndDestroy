// Ignore Spelling: Dto App Seo

using SAD.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SAD.App.Warehouse
{ //AutoMapper. -model do formularza
    public class WarehouseDto
    {
        public void SeoName() => SEOName = palletRackName+ "_" + palletRackPosition;
        // [Required]
        [StringLength(5, MinimumLength = 4, ErrorMessage = "4 or 5 char like S355 or HB450")]
                public string Hardness { get; set; } = default!;
        [Range (600,12050, ErrorMessage = "{1} - {2})")]
                public int Width { get; set; } =default!;
       // [Required]
        [Range(100, 2550, ErrorMessage = "{1} - {2}")]
                public int Height { get; set; } = default!;
      //  [Required]
        [Range(0.9, 50, ErrorMessage = "{1} - {2}")]
                public int Thickness { get; set; } = default!;
        //  [Required]
        private string? palletRackName;
                public string? PalletRackName 
                { 
                    get { return palletRackName; }
                    set
                    {
                        palletRackName = value.ToLower().Replace(" ", "_");
                SeoName();
                    }
                }
       // [Required]
        private string? palletRackPosition;
                public string? PalletRackPosition
                {
                    get { return palletRackPosition; }
                    set
                    {
                        palletRackPosition = value.ToLower().Replace(" ","_");
                        
                        SeoName();
                    }
                }
                public string? Description { get; set; }
                    public string? SEOName { get; set; }
               
    }
    
}
