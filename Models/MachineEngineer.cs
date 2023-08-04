using System.Collections.Generic;


namespace Factory.Models
{
  public class MachineEngineer
  {
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public  Engineer Engineer { get; set; }
    public  Machine Machine  { get; set; } //code doctor entity/navigation property 
    public List<MachineEngineer> JoinEntities { get;}
  }
}