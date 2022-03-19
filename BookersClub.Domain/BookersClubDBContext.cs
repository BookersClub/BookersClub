using BookersClub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace BookersClub.Domain
{
    public class BookersClubDBContext : DbContext
    {
        public BookersClubDBContext(DbContextOptions<BookersClubDBContext> options) : base(options)
        { 
        
        }

        public DbSet<User> User { get; set; }
    }
}
