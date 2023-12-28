using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemStoreOriginal.Shared.Models
{
    public class ManufacturedItem
    {
        public int? Id { get; set; }
        public string? Name { get; set;}
        public string? Description { get; set; }
        public float Weight { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int Format { get; set; }
        public string Category { get; set; }
        public DateTime ManufacturedDate { get; set; }

    }
}
