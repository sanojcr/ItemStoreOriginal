using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ItemStoreOriginal.Shared.Models;

[Table("Item")]
public partial class Item
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Weight { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Price { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ManufacturedDate { get; set; }

    public int? Format { get; set; }

    [StringLength(50)]
    public string? Category { get; set; }
}
