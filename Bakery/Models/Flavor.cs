using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Field cannot be empty!")]
    public string FlavorName { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}