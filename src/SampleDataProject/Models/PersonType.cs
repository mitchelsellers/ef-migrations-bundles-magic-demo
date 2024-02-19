using System.ComponentModel.DataAnnotations;

namespace SampleDataProject.Models;

public class PersonType
{
    public int PersonTypeId { get; set; }
    [StringLength(500)]
    public string PersonTypeDescription { get; set; }

    public ICollection<Person> Persons { get; set; }
}
