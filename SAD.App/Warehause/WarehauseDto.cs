using SAD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace SAD.App.Warehause
{ //AutoMapper. -model do formularza
    public class WarehauseDto
    {      
        public string Hardnes { get; set; } = default!;      
        public int Width { get; set; } =default!;      
        public int Height { get; set; } = default!;    
        public int Thicness { get; set; } =default!;    
        public string? PalletRackName { get; set; } = default!;
        public string? PalletRackPosition { get; set; } = default!;
        public string? Description { get; set; }
        public string? SEOName { get; set; }
    //    public string Name { get; private set; } = default!;

    //    public void CreateName() => Name = Hardnes + Width + Height + Thicness + PalletRackName + PalletRackPosition;
    }
}
