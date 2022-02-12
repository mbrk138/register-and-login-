
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persis
{
    public class DateBassDbContext : IdentityDbContext<User>
    {
        public DateBassDbContext(DbContextOptions<DateBassDbContext> options) : base(options)
        {
            
        }

    }
}
