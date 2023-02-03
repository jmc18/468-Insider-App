using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class State
{
    [Key]
    public int Id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string CountryCode { get; set; } = null!;
}
