using System.Collections.Generic;


namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
     public string MachineName { get; set; }
     public string ManufactureDate { get; set; }
    public int EngineerId { get; set; }
    // public  Engineer Engineer { get; set; } //code doctor entity/navigation property 
    public List<EngineerMachine> JoinEntities { get;}
  }
}