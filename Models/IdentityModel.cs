using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IMS_New.Models
{
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Slots> Slots { get; set; }
        public DbSet<Interview> Interview { get; set; }
        public DbSet<SlotException> SlotException { get; set; }
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {            
        }
        public static ApplicationDbContext Create => new ApplicationDbContext();
    }
}