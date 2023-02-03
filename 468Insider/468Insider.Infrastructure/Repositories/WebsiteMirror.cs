using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Keyless]
[Table("WebsiteMirror")]
public partial class WebsiteMirror
{
    [Column("Client_Id")]
    public int? ClientId { get; set; }

    [Unicode(false)]
    public string? PrimaryColor { get; set; }

    [Unicode(false)]
    public string? ShortDescription { get; set; }

    [Unicode(false)]
    public string? IosStoreLink { get; set; }

    [Unicode(false)]
    public string? AndroidStoreLink { get; set; }

    [Unicode(false)]
    public string? HighlightTextColor { get; set; }

    [Unicode(false)]
    public string? IconColor { get; set; }

    public int? MapZoomLevel { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? MapLatitude { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? MapLongitude { get; set; }
}
