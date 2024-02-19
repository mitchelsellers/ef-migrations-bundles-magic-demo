using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace SimpleEntityFrameworkWeb.Models;

public class Person
{
    public int PersonId { get; set; }

    [Required]
    [StringLength(500)]
    public string Name { get; set; }

    [Required]
    [StringLength(500)]
    [EmailAddress]
    public string EmailAddress { get; set; }

    public int PersonTypeId { get; set; }

    public PersonType PersonType { get; set; }
}

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("CrazyTable");
        builder.HasIndex(p => p.EmailAddress).IsUnique();
    }
}
