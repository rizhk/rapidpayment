using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    // ... other properties

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}