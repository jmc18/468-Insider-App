using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Country
{
    [Key]
    [Column("id")]
    [StringLength(2)]
    public string Id { get; set; } = null!;

    [Column("name")]
    [StringLength(64)]
    public string Name { get; set; } = null!;
}
