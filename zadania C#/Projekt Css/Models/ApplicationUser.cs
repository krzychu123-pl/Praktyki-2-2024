using Microsoft.AspNetCore.Identity;
namespace Tutorial.Models;

public class ApplicationUser : IdentityUser
{
    public ICollection<Order>? Orders { get; set; }
}
