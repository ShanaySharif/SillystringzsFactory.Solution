using System.Collections.Generic;


namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public int Id { get; set; }
    public  Engineer Engineer { get; set; } //code doctor entity/navigation property 
    public List<MachineLicense> JoinEntities { get;}
  }
}