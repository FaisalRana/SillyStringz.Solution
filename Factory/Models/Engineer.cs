using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }

    public string EngineerName { get; set; }

    public string EngineerType { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}