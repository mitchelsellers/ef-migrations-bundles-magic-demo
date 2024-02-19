using System.ComponentModel.DataAnnotations;

namespace SimpleEntityFrameworkWeb.Models;

public class PersonType
{
    public int PersonTypeId { get; set; }
    [StringLength(500)]
    public string PersonTypeDescription { get; set; }

    public ICollection<Person> Persons { get; set; }
}
