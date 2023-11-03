using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UserMembershipApplication.Models;
namespace UserMembershipApplication.Data;

// Microsoft.EntityFrameworkCore and UserMembershipApplication.Data were created


public class ApplicationDbContext:DbContext
{
    // Here we override default configuration values
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        // Configure our ApplicationDbContext to use a Sqlite Database of our specification
        builder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}UserMemberShipDb.db");
        // This code below will catch the Idenity scaffolding error when interoping with CRUD operations
        base.OnConfiguring(builder);
    }

    // Set the User table into the database
    public DbSet<User> Users { get; set; }
}