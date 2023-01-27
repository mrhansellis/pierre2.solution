using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Field cannot be empty!")]
    public string TreatName { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}