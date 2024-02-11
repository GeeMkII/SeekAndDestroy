using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SAD.Domain.Entities
{
    public class Warehause
    {
        public int Id { get; set; } = default!;
        public string Hardnes { get; set; } = default!;
        public int Width { get; set; } = default!;
        public int Height { get; set; } = default!;
        public int Thicness { get; set; } = default!;
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public PalletRack PalletRack { get; set; } = default!;
        public string? Description { get; set; }
        public string SEOName { get; private set; } = default!;
        public void SeoName() => SEOName = Hardnes.ToLower().Replace(" ", "_")+"_"+PalletRack.Name.ToLower().Replace(" ", "_")+"_"+PalletRack.Position.ToLower().Replace(" ", "_");
    }
}
