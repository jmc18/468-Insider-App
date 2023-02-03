using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Content")]
public partial class Content
{
    [Key]
    [Column("Content_ID")]
    public int ContentId { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("Content_Status_ID")]
    public int ContentStatusId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column("HTML_Content")]
    [Unicode(false)]
    public string HtmlContent { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Updated { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Contents")]
    public virtual Client Client { get; set; } = null!;

    [ForeignKey("ContentStatusId")]
    [InverseProperty("Contents")]
    public virtual ContentStatus ContentStatus { get; set; } = null!;
}
