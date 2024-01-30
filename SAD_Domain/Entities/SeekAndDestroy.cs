using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD_Domain.Entities
{
    public class SeekAndDestroy
    {
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public SAD_Domain.Entities.ContactDetails Contact { get; set; } = default!;
        public string SEOName { get; private set; } = default!;
        public void SeoName() => SEOName = Name.ToLower().Replace(" ","_");
    }   
}
