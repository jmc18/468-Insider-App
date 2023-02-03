using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Keyless]
public partial class PostalCode
{
    [StringLength(2)]
    [Unicode(false)]
    public string? CountryCode { get; set; }

    [Column("PostalCode")]
    [StringLength(5)]
    [Unicode(false)]
    public string? PostalCode1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Location { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? StateProvince { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? StateProvinceCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column(TypeName = "decimal(18, 8)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(18, 8)")]
    public decimal? Longitude { get; set; }
}
