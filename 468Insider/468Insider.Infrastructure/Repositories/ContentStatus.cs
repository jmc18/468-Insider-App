using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Content_Status")]
public partial class ContentStatus
{
    [Key]
    [Column("Content_Status_ID")]
    public int ContentStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("ContentStatus")]
    public virtual ICollection<Content> Contents { get; } = new List<Content>();
}
