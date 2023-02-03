using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Keyless]
public partial class UsersViewForMap
{
    public string? PostalCode { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Country { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    [Column("User_ID")]
    public int UserId { get; set; }
}
