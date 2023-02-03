using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Category
{
    [Key]
    [Column("Category_ID")]
    public int CategoryId { get; set; }

    [Column("Client_ID")]
    public int ClientId { get; set; }

    [Column("Category_Name")]
    [StringLength(100)]
    [Unicode(false)]
    public string CategoryName { get; set; } = null!;

    [ForeignKey("ClientId")]
    [InverseProperty("Categories")]
    public virtual Client Client { get; set; } = null!;

    [ForeignKey("CategoryId")]
    [InverseProperty("Categories")]
    public virtual ICollection<Location> Locations { get; } = new List<Location>();
}
