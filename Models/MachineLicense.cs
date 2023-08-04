using System.Collections.Generic;


namespace Factory.Models
{
  public class MachineLicense
  {
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public  Engineer Engineer { get; set; }
    public  Machine EngMachine  { get; set; } //code doctor entity/navigation property 
    // public List<MachineLicense> JoinEntities { get;}
  }
}