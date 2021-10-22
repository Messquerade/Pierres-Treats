using System.Collections.Generic;

namespace PierresShop.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set;}
    public string Name { get; set;}
    public string Ingredients { get; set;}
    public bool GlutenFree { get; set;}
    public bool Vegan { get; set; }
    public virtual ApplicationUser User { get; set;}
    public virtual ICollection<FlavorTreat> JoinEntities { get; set;}
  }
}