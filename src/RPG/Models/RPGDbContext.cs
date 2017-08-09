using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace RPG.Models
{
    public class RPGDbContext : IdentityDbContext<ApplicationUser>
    {
        public RPGDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}