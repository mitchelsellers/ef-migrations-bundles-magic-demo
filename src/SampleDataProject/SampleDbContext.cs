using Microsoft.EntityFrameworkCore;
using SampleDataProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataProject;

public class SampleDbContext : DbContext
{
    public SampleDbContext(DbContextOptions<SampleDbContext> options)
       : base(options)
    {
        //For Migrations
        //dotnet ef --startup-project ../MultiEntityFrameworkWeb migrations add Initial

        //Script changes
        //dotnet ef --startup-project ../MultiEntityFrameworkWeb migrations script -i --output FullScript.sql
        //Apply changes
        //dotnet ef --startup-project ../MultiEntityFrameworkWeb database update
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonType> PersonTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //Handle any default items
        base.OnModelCreating(builder);

        //Load custom configurations
        builder.ApplyConfigurationsFromAssembly(typeof(SampleDbContext).Assembly);
    }
}
