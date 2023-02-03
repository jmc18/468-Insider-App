using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Event
{
    [Key]
    public int EventId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    public int ClientId { get; set; }

    public int UserId { get; set; }

    public int LocationId { get; set; }

    [StringLength(20)]
    public string AppVersion { get; set; } = null!;

    [StringLength(100)]
    public string Description { get; set; } = null!;
}
