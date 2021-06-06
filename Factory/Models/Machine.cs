using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineMachine>();
    }

    public int MachineId { get; set; }

    public string MachineName { get; set; }

    public virtual ICollection<MachineMachine> JoinEntities { get; set; }
  }
}