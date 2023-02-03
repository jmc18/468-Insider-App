using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Notification
{
    [Key]
    public int Id { get; set; }

    public int ClientId { get; set; }

    [StringLength(50)]
    public string Headline { get; set; } = null!;

    [StringLength(200)]
    public string Text { get; set; } = null!;

    public int LocationId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SendDate { get; set; }

    [StringLength(255)]
    public string? Response { get; set; }
}
