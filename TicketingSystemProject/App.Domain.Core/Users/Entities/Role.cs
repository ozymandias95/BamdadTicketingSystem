namespace App.Domain.Core.Users.Entities;

public class Role
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<User> Users { get; set; }
}
