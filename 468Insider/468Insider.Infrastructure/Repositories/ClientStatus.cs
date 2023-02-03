using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

[Table("Client_Status")]
public partial class ClientStatus
{
    [Key]
    [Column("Client_Status_ID")]
    public int ClientStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("ClientStatus")]
    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
