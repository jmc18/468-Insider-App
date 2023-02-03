using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _468Insider.Infrastructure.Repositories;

public partial class Admin468InsiderDbContext : DbContext
{
    public Admin468InsiderDbContext()
    {
    }

    public Admin468InsiderDbContext(DbContextOptions<Admin468InsiderDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountType> AccountTypes { get; set; }

    public virtual DbSet<AppUsed> AppUseds { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientStatus> ClientStatuses { get; set; }

    public virtual DbSet<Content> Contents { get; set; }

    public virtual DbSet<ContentStatus> ContentStatuses { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CountryInfo> CountryInfos { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<GiftCertificate> GiftCertificates { get; set; }

    public virtual DbSet<LimitedAccount> LimitedAccounts { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationStatus> LocationStatuses { get; set; }

    public virtual DbSet<LocationType> LocationTypes { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<ParentChildRelationship> ParentChildRelationships { get; set; }

    public virtual DbSet<PointsEarned> PointsEarneds { get; set; }

    public virtual DbSet<PointsEarnedStatus> PointsEarnedStatuses { get; set; }

    public virtual DbSet<PointsRedeemed> PointsRedeemeds { get; set; }

    public virtual DbSet<PointsRedeemedStatus> PointsRedeemedStatuses { get; set; }

    public virtual DbSet<PostalCode> PostalCodes { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPaymentProfile> UserPaymentProfiles { get; set; }

    public virtual DbSet<UserStatus> UserStatuses { get; set; }

    public virtual DbSet<UserSubscription> UserSubscriptions { get; set; }

    public virtual DbSet<UsersForPostalCode> UsersForPostalCodes { get; set; }

    public virtual DbSet<UsersViewForMap> UsersViewForMaps { get; set; }

    public virtual DbSet<WebsiteMirror> WebsiteMirrors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:468InsiderDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Accounts__B19E45C9D0F6046E");

            entity.HasOne(d => d.AccountType).WithMany(p => p.Accounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accounts_Account_Types");

            entity.HasOne(d => d.Client).WithMany(p => p.Accounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accounts_Clients");
        });

        modelBuilder.Entity<AccountType>(entity =>
        {
            entity.HasKey(e => e.AccountTypeId).HasName("PK__Account___223F1E4B9FAC2223");

            entity.Property(e => e.AccountTypeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<AppUsed>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.AppUseds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_App_Used_Clients");

            entity.HasOne(d => d.User).WithMany(p => p.AppUseds).HasConstraintName("FK_App_Used_Users");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.Categories).HasConstraintName("FK_Categories_Clients");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK_Table_1");

            entity.HasOne(d => d.ClientStatus).WithMany(p => p.Clients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clients_Client_Status");
        });

        modelBuilder.Entity<Content>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.Contents).HasConstraintName("FK_Content_Clients");

            entity.HasOne(d => d.ContentStatus).WithMany(p => p.Contents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Content_Content_Status");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Countrie__3213E83F82064C15");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_App_Tracking");

            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<GiftCertificate>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locations_Clients");

            entity.HasOne(d => d.LocationStatus).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locations_Location_Status");

            entity.HasOne(d => d.LocationTypeNavigation).WithMany(p => p.Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locations_Location_Type");

            entity.HasMany(d => d.Categories).WithMany(p => p.Locations)
                .UsingEntity<Dictionary<string, object>>(
                    "LocationCategory",
                    r => r.HasOne<Category>().WithMany()
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Location_Category_Categories"),
                    l => l.HasOne<Location>().WithMany()
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_Location_Category_Locations"),
                    j =>
                    {
                        j.HasKey("LocationId", "CategoryId");
                        j.ToTable("Location_Category");
                    });
        });

        modelBuilder.Entity<LocationType>(entity =>
        {
            entity.HasKey(e => e.LocationTypeId).HasName("PK__Location__8132631E17173949");
        });

        modelBuilder.Entity<ParentChildRelationship>(entity =>
        {
            entity.HasOne(d => d.ChildLocation).WithMany(p => p.ParentChildRelationshipChildLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Parent_Child_Relationships_Locations1");

            entity.HasOne(d => d.ParentLocation).WithMany(p => p.ParentChildRelationshipParentLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Parent_Child_Relationships_Locations");
        });

        modelBuilder.Entity<PointsEarned>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.PointsEarneds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Earned_Clients1");

            entity.HasOne(d => d.Location).WithMany(p => p.PointsEarneds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Earned_Locations");

            entity.HasOne(d => d.PointsEarnedStatus).WithMany(p => p.PointsEarneds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Earned_Points_Earned_Status");

            entity.HasOne(d => d.User).WithMany(p => p.PointsEarneds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Earned_Users");
        });

        modelBuilder.Entity<PointsRedeemed>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.PointsRedeemeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Redeemed_Clients");

            entity.HasOne(d => d.Location).WithMany(p => p.PointsRedeemeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Redeemed_Locations");

            entity.HasOne(d => d.PointsRedeemedStatus).WithMany(p => p.PointsRedeemeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Redeemed_Points_Redeemed_Status");

            entity.HasOne(d => d.User).WithMany(p => p.PointsRedeemeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Points_Redeemed_Users");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.Property(e => e.Code).IsFixedLength();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Client).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Clients");

            entity.HasOne(d => d.UserStatus).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_User_Status");
        });

        modelBuilder.Entity<UserPaymentProfile>(entity =>
        {
            entity.Property(e => e.FailedPaymentCount).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<UsersForPostalCode>(entity =>
        {
            entity.ToView("UsersForPostalCode");

            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UsersViewForMap>(entity =>
        {
            entity.ToView("UsersViewForMap");

            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
