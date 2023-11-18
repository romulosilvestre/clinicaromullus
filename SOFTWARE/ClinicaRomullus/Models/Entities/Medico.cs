using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaRomullus.Models.Entities
{
  public class Medico
  {
    public int Id { get; set; }
    public string? CRM { get; set; } 
    public string Nome { get; set; } = string.Empty;   

  }

}
