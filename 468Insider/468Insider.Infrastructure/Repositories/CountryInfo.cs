using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Keyless]
[Table("CountryInfo")]
public partial class CountryInfo
{
    [StringLength(2)]
    [Unicode(false)]
    public string? CountryCode { get; set; }

    [Column(TypeName = "decimal(18, 8)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(18, 8)")]
    public decimal? Longitude { get; set; }

    [StringLength(44)]
    [Unicode(false)]
    public string? Name { get; set; }
}
