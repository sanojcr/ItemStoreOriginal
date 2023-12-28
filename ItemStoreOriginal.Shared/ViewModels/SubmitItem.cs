using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemStoreOriginal.Shared.ViewModels
{
    public class SubmitItem
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name must be less than 50 characters.")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(10, 200)]
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public bool IsActive { get; set; }
        public int Format { get; set; }
        public string Category { get; set; }
        public DateOnly ManufacturedDate { get; set; }
    }

    public class Emp
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
