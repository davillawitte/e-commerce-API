using System;
using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions <StoreContext> options) : base (options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}