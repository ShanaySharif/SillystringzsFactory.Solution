using System.Collections.Generic;

namespace Engineer.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        public string EngineerName { get; set; }
        // public string  License { get; set; }
        public int MachineId { get; set; }

        public List<EngineerMachine> JoinEntities { get; }
    }
}