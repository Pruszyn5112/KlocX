<<<<<<< HEAD
﻿using KlocX.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
=======
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
>>>>>>> 563ed6674bb4ecfc4f37308cfac903aa2282c984
using Microsoft.EntityFrameworkCore;

namespace KlocX.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< HEAD
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Comment> Comments { get; set; }
     }
=======
    }
>>>>>>> 563ed6674bb4ecfc4f37308cfac903aa2282c984
}
